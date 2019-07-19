using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

/*------------兼容ZLG的数据类型---------------------------------*/

//1.ZLGCAN系列接口卡信息的数据类型。
public struct VCI_BOARD_INFO
{
    public UInt16 hw_Version;
    public UInt16 fw_Version;
    public UInt16 dr_Version;
    public UInt16 in_Version;
    public UInt16 irq_Num;
    public byte can_Num;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)] public byte[] str_Serial_Num;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
    public byte[] str_hw_Type;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] Reserved;
}

/////////////////////////////////////////////////////
//2.定义CAN信息帧的数据类型。
unsafe public struct VCI_CAN_OBJ  //使用不安全代码
{
    public uint ID;
    public uint TimeStamp;        //时间标识
    public byte TimeFlag;         //是否使用时间标识
    public byte SendType;         //发送标志。保留，未用
    public byte RemoteFlag;       //是否是远程帧
    public byte ExternFlag;       //是否是扩展帧
    public byte DataLen;          //数据长度
    public fixed byte Data[8];    //数据
    public fixed byte Reserved[3];//保留位

}

//3.定义初始化CAN的数据类型
public struct VCI_INIT_CONFIG
{
    public UInt32 AccCode;
    public UInt32 AccMask;
    public UInt32 Reserved;
    public byte Filter;   //0或1接收所有帧。2标准帧滤波，3是扩展帧滤波。
    public byte Timing0;  //波特率参数，具体配置，请查看二次开发库函数说明书。
    public byte Timing1;
    public byte Mode;     //模式，0表示正常模式，1表示只听模式,2自测模式
}

/*------------其他数据结构描述---------------------------------*/
//4.USB-CAN总线适配器板卡信息的数据类型1，该类型为VCI_FindUsbDevice函数的返回参数。
public struct VCI_BOARD_INFO1
{
    public UInt16 hw_Version;
    public UInt16 fw_Version;
    public UInt16 dr_Version;
    public UInt16 in_Version;
    public UInt16 irq_Num;
    public byte can_Num;
    public byte Reserved;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public byte[] str_Serial_Num;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public byte[] str_hw_Type;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public byte[] str_Usb_Serial;
}

/*------------数据结构描述完成---------------------------------*/

public struct CHGDESIPANDPORT
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
    public byte[] szpwd;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public byte[] szdesip;
    public Int32 desport;

    public void Init()
    {
        szpwd = new byte[10];
        szdesip = new byte[20];
    }
}

namespace WindowsApplication1
{
    public class CAN_Reader 
    {
        const int DEV_USBCAN = 3;
        const int DEV_USBCAN2 = 4;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="DeviceType"></param>
        /// <param name="DeviceInd"></param>
        /// <param name="Reserved"></param>
        /// <returns></returns>
        /*------------兼容ZLG的函数描述---------------------------------*/
        [DllImport("controlcan.dll")]
        static extern UInt32 VCI_OpenDevice(UInt32 DeviceType, UInt32 DeviceInd, UInt32 Reserved);
        [DllImport("controlcan.dll")]
        static extern UInt32 VCI_CloseDevice(UInt32 DeviceType, UInt32 DeviceInd);
        [DllImport("controlcan.dll")]
        static extern UInt32 VCI_InitCAN(UInt32 DeviceType, UInt32 DeviceInd, UInt32 CANInd, ref VCI_INIT_CONFIG pInitConfig);

        [DllImport("controlcan.dll")]
        static extern UInt32 VCI_ReadBoardInfo(UInt32 DeviceType, UInt32 DeviceInd, ref VCI_BOARD_INFO pInfo);

        [DllImport("controlcan.dll")]
        static extern UInt32 VCI_GetReceiveNum(UInt32 DeviceType, UInt32 DeviceInd, UInt32 CANInd);
        [DllImport("controlcan.dll")]
        static extern UInt32 VCI_ClearBuffer(UInt32 DeviceType, UInt32 DeviceInd, UInt32 CANInd);

        [DllImport("controlcan.dll")]
        static extern UInt32 VCI_StartCAN(UInt32 DeviceType, UInt32 DeviceInd, UInt32 CANInd);
        [DllImport("controlcan.dll")]
        static extern UInt32 VCI_ResetCAN(UInt32 DeviceType, UInt32 DeviceInd, UInt32 CANInd);

        [DllImport("controlcan.dll")]
        static extern UInt32 VCI_Transmit(UInt32 DeviceType, UInt32 DeviceInd, UInt32 CANInd, ref VCI_CAN_OBJ pSend, UInt32 Len);

        [DllImport("controlcan.dll")]
        static extern UInt32 VCI_Receive(UInt32 DeviceType, UInt32 DeviceInd, UInt32 CANInd, ref VCI_CAN_OBJ pReceive, UInt32 Len, Int32 WaitTime);

        /*------------其他函数描述---------------------------------*/

        [DllImport("controlcan.dll")]
        static extern UInt32 VCI_ConnectDevice(UInt32 DevType, UInt32 DevIndex);
        [DllImport("controlcan.dll")]
        static extern UInt32 VCI_UsbDeviceReset(UInt32 DevType, UInt32 DevIndex, UInt32 Reserved);
        [DllImport("controlcan.dll")]
        static extern UInt32 VCI_FindUsbDevice(ref VCI_BOARD_INFO1 pInfo);
        /*------------函数描述结束---------------------------------*/

        static UInt32 m_devtype = 4;//USBCAN2

        UInt32 m_bOpen = 0;
        UInt32 m_devind = 0;
        UInt32 m_canind = 0;

        VCI_CAN_OBJ[] m_recobj = new VCI_CAN_OBJ[1000];

        UInt32[] m_arrdevtype = new UInt32[20];

        // COPY - end


        //
        // Function for external use
        //
        public CAN_Reader() { }
        ~CAN_Reader() { }

        UInt32 default_devtype = DEV_USBCAN2;
        UInt32 default_devint = 0;
        UInt32 default_canind = 1;
        uint default_AccCode = 0x80000000;
        uint default_AccMask = 0xffffffff;
        byte default_Timing0 = 0x00;
        byte default_Timing1 = 0x1C;
        byte default_Filter = 0x01;
        byte default_Mode = 0x00;

        public void Connect()
        {
            if (m_bOpen == 0)
            {
                m_devtype = default_devtype;

                m_devind = default_devint;
                m_canind = default_canind;
                if (VCI_OpenDevice(m_devtype, m_devind, 0) == 0)
                {
                    MessageBox.Show("USB-CAN Adaptor connection fail", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                m_bOpen = 1;
                VCI_INIT_CONFIG config = new VCI_INIT_CONFIG();
                config.AccCode = default_AccCode;
                config.AccMask = default_AccMask;
                config.Timing0 = default_Timing0;
                config.Timing1 = default_Timing1;
                config.Filter = default_Filter;
                config.Mode = default_Mode;
                VCI_InitCAN(m_devtype, m_devind, m_canind, ref config);
            }
            //buttonConnect.Text = m_bOpen == 1 ? "断开" : "连接";
            //timer_rec.Enabled = m_bOpen == 1 ? true : false;

        }

        public UInt32 ReceiveData()
        {
            UInt32 res;

            res = VCI_Receive(m_devtype, m_devind, m_canind, ref m_recobj[0], 1000, 100);
            return res;
        }

        unsafe public void GetOneCommand(UInt32 index, out String str, out uint ID, out uint DLC, out byte[] DATA)
        {
            ID = 0;
            DLC = 0;
            const int DATA_LEN = 8;
            DATA = new byte[DATA_LEN];

            str = "接收到数据: ";
            str += "  帧ID:0x" + System.Convert.ToString(m_recobj[index].ID, 16);
            str += "  帧格式:";
            if (m_recobj[index].RemoteFlag == 0)
                str += "数据帧 ";
            else
                str += "远程帧 ";
            if (m_recobj[index].ExternFlag == 0)
                str += "标准帧 ";
            else
                str += "扩展帧 ";

            ID = m_recobj[index].ID;

            if (m_recobj[index].RemoteFlag == 0)
            {
                byte len = (byte)(m_recobj[index].DataLen % 9);
                DLC = len;

                str += "数据: ";

                fixed (VCI_CAN_OBJ* m_recobj1 = &m_recobj[index])
                {
                    byte j = 0;
                    while ((j < len) && (j < DATA_LEN))
                    {
                        DATA[j] = m_recobj1->Data[j];
                        str += " " + System.Convert.ToString(DATA[j], 16);
                        j++;
                    }
                }
            }
        }

        //unsafe public void ReceiveDataAndUpdate()
        //{
        //    UInt32 res;

        //    res = VCI_Receive(m_devtype, m_devind, m_canind, ref m_recobj[0], 1000, 100);

        //    uint ID = 0, DLC = 0;
        //    const int DATA_LEN = 8;
        //    byte[] DATA = new byte[DATA_LEN];

        //    String str = "";
        //    for (UInt32 i = 0; i < res; i++)
        //    {
        //        GetOneCommand(i, out str, out ID, out DLC, out DATA[]);
        //        //CAN_Update_DashBoard(ID, DLC, DATA);
        //    }
        //    // listBox_Info.Items.Add(str);
        //    // listBox_Info.SelectedIndex = listBox_Info.Items.Count - 1;
        //}

        public void Disconnect()
        {
            if (m_bOpen == 1)
            {
                VCI_CloseDevice(m_devtype, m_devind);
                m_bOpen = 0;
            }
        }

        public void StartCAN()
        {
            if (m_bOpen == 0)
                return;
            VCI_StartCAN(m_devtype, m_devind, m_canind);
        }

        public void StopCAN()
        {
            if (m_bOpen == 0)
                return;
            VCI_ResetCAN(m_devtype, m_devind, m_canind);
        }

    }
}