using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace USB_CAN_READER
{
    public partial class CAN_Reader_Form : Form
    {
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
        [DllImport("controlcan.dll")]
        static extern UInt32 VCI_ConnectDevice(UInt32 DevType, UInt32 DevIndex);
        [DllImport("controlcan.dll")]
        static extern UInt32 VCI_UsbDeviceReset(UInt32 DevType, UInt32 DevIndex, UInt32 Reserved);
        [DllImport("controlcan.dll")]
        static extern UInt32 VCI_FindUsbDevice(ref VCI_BOARD_INFO1 pInfo);

        const int DEV_USBCAN = 3;
        const int DEV_USBCAN2 = 4;

        static UInt32 m_devtype = DEV_USBCAN2;

        UInt32 m_bOpen = 0;
        UInt32 m_devind = 0;
        UInt32 m_canind = 0;

        VCI_CAN_OBJ[] m_recobj = new VCI_CAN_OBJ[1000];

        UInt32[] m_arrdevtype = new UInt32[20];


       // private bool First_Run = true;
        private byte Previous_Car_Indicator = 0;
        private uint Previous_Speed = 0;
        private uint Previous_RPM = 0;
        private uint Previous_Consumption = 0;
        private uint Previous_WaterTemp = 0;
        private int  Previous_Final_Room_temp = 0;
        private uint Previous_Fuel = 0;
        private uint Previous_Battery;
        private uint Previous_Mileage;
        private uint Previous_MaxSpeed = 0;
        private uint Previous_AveSpeed = 0;

        public CAN_Reader_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup default CAN parameter for connection

            comboBox_DevIndex.SelectedIndex = 0;
            comboBox_CANIndex.SelectedIndex = 1;
            textBox_AccCode.Text = "80000000";
            textBox_AccMask.Text = "FFFFFFFF";
            textBox_Time0.Text = "00";
            textBox_Time1.Text = "1C";
            comboBox_Filter.SelectedIndex = 0;               
            comboBox_Mode.SelectedIndex = 0;                 
            comboBox_FrameFormat.SelectedIndex = 0;
            comboBox_FrameType.SelectedIndex = 0;
            textBox_ID.Text = "00000001";
            textBox_Data.Text = "00 00 00 00 00 00 00 00 ";

            // For Debug purpose
            Int32 curindex = 0;
            comboBox_devtype.Items.Clear();

            curindex = comboBox_devtype.Items.Add("DEV_USBCAN");
            m_arrdevtype[curindex] =  DEV_USBCAN;

            curindex = comboBox_devtype.Items.Add("DEV_USBCAN2");
            m_arrdevtype[curindex] = DEV_USBCAN2 ;

            comboBox_devtype.SelectedIndex = 1;
            comboBox_devtype.MaxDropDownItems = comboBox_devtype.Items.Count;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (m_bOpen==1)
            {
                textbox_Connection_Message.Text = "Please click[Connect] button to start";
                VCI_CloseDevice(m_devtype, m_devind);
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (m_bOpen==1)
            {
                VCI_ResetCAN(m_devtype, m_devind, m_canind);
                VCI_CloseDevice(m_devtype, m_devind);
                m_bOpen = 0;
            }
            else
            {
                uint status;

                m_devtype = m_arrdevtype[comboBox_devtype.SelectedIndex];

                m_devind=(UInt32)comboBox_DevIndex.SelectedIndex;
                m_canind = (UInt32)comboBox_CANIndex.SelectedIndex;
                status = VCI_OpenDevice(m_devtype, m_devind, 0);
                if ( status != 1)
                {
                    textbox_Connection_Message.Text = "USB-CAN connection failed. Please check your setup and try again.";
                    return;
                }

                m_bOpen = 1;
                VCI_INIT_CONFIG config=new VCI_INIT_CONFIG();
                config.AccCode=System.Convert.ToUInt32("0x" + textBox_AccCode.Text,16);
                config.AccMask = System.Convert.ToUInt32("0x" + textBox_AccMask.Text, 16);
                config.Timing0 = System.Convert.ToByte("0x" + textBox_Time0.Text, 16);
                config.Timing1 = System.Convert.ToByte("0x" + textBox_Time1.Text, 16);
                config.Filter = (Byte)(comboBox_Filter.SelectedIndex+1);
                config.Mode = (Byte)comboBox_Mode.SelectedIndex;
                status = VCI_InitCAN(m_devtype, m_devind, m_canind, ref config);
                if (status != 1)
                {
                    VCI_CloseDevice(m_devtype, m_devind);
                    textbox_Connection_Message.Text = "USB-CAN connection failed. Please check your setup and try again.";
                    return;
                }

                status = VCI_StartCAN(m_devtype, m_devind, m_canind);
                if (status != 1)
                {
                    VCI_CloseDevice(m_devtype, m_devind);
                    textbox_Connection_Message.Text = "USB-CAN connection failed. Please check your setup and try again.";
                    return;
                }

            }
            buttonConnect.Text = m_bOpen==1?"Disconnect":"Connect";
            textbox_Connection_Message.Text = m_bOpen == 1 ? "Please click [Disonnect] button to stop." :"Please click [Connect] button to start.";
            timer_rec.Enabled = m_bOpen==1?true:false;
        }


        private bool FirstRun_Car_Indicator = true;
        private bool FirstRun_Speed = true;
        private bool FirstRun_RPM = true;
        private bool FirstRun_Consumption = true;
        private bool FirstRun_WaterTemp = true;
        private bool FirstRun_Room_Temp = true;
        private bool FirstRun_Fuel = true;
        private bool FirstRun_Battery = true;
        private bool FirstRun_Mileage = true;
        private bool FirstRun_MaxSpeed = true;
        private bool FirstRun_AveSpeed = true;

        private Color BGHighLightColor = System.Drawing.SystemColors.ActiveCaption;
        private Color BGNormalColor = System.Drawing.SystemColors.Control;
        private Color BGOutOfRange = System.Drawing.Color.Maroon;

        private const byte MASK_Status_OnOff = 0x01;
        private const byte MASK_Status_EngineOil = 0x02;
        private const byte MASK_Status_Fuel = 0x04;
        private const byte MASK_Status_ABS = 0x08;
        private const byte MASK_Status_WaterTemp = 0x10;
        private const byte MASK_Status_Maintenance = 0x20;
        private const byte MASK_Status_FrontTirePressure = 0x40;
        private const byte MASK_Status_RearTirePressure = 0x80;

        private Color UpdateItemColor(ref bool FirstRunBit, ref byte Previous, byte Current)
        {
            Color ret_color;

            if (FirstRunBit == true)
            {
                ret_color = BGHighLightColor;
                FirstRunBit = false;
            }
            else
            {
                ret_color = (Previous != Current) ? BGHighLightColor : BGNormalColor;
            }
            Previous = Current;
            return ret_color;
        }

        private Color UpdateItemColor(ref bool FirstRunBit, ref uint Previous, uint Current)
        {
            Color ret_color;

            if (FirstRunBit == true)
            {
                ret_color = BGHighLightColor;
                FirstRunBit = false;
            }
            else
            {
                ret_color = (Previous != Current) ? BGHighLightColor : BGNormalColor;
            }
            Previous = Current;
            return ret_color;
        }

        private Color UpdateItemColor(ref bool FirstRunBit, ref int Previous, int Current)
        {
            Color ret_color;

            if (FirstRunBit == true)
            {
                ret_color = BGHighLightColor;
                FirstRunBit = false;
            }
            else
            {
                ret_color = (Previous != Current) ? BGHighLightColor : BGNormalColor;
            }
            Previous = Current;
            return ret_color;
        }

        private void CAN_Update_DashBoard(uint ID, uint DLC, byte[] DATA)
        {
            switch (ID)
            {
                case 0x1:       // CMD_A
                    if (DLC == 1)
                    {
                        Byte status = DATA[0];

                        Status_OnOff.Checked = ((status & MASK_Status_OnOff) != 0) ? true : false;
                        Status_EngineOil.Checked = ((status & MASK_Status_EngineOil) != 0) ? true : false;
                        Status_Fuel.Checked = ((status & MASK_Status_Fuel) != 0) ? true : false;
                        Status_ABS.Checked = ((status & MASK_Status_ABS) != 0) ? true : false;
                        Status_WaterTemp.Checked = ((status & MASK_Status_WaterTemp) != 0) ? true : false;
                        Status_Maintenance.Checked = ((status & MASK_Status_Maintenance) != 0) ? true : false;
                        Status_FrontTirePressure.Checked = ((status & MASK_Status_FrontTirePressure) != 0) ? true : false;
                        Status_RearTirePressure.Checked = ((status & MASK_Status_RearTirePressure) != 0) ? true : false;

                        if (FirstRun_Car_Indicator == true)
                        {
                            Status_OnOff.BackColor = BGHighLightColor;
                            Status_EngineOil.BackColor = BGHighLightColor;
                            Status_Fuel.BackColor = BGHighLightColor;
                            Status_ABS.BackColor = BGHighLightColor;
                            Status_WaterTemp.BackColor = BGHighLightColor;
                            Status_Maintenance.BackColor = BGHighLightColor;
                            Status_FrontTirePressure.BackColor = BGHighLightColor;
                            Status_RearTirePressure.BackColor = BGHighLightColor;
                            FirstRun_Car_Indicator = false;
                        }
                        else
                        {
                            // if changed, bit_a ^ bit_b != 0
                            Status_OnOff.BackColor = (((Previous_Car_Indicator ^ status) & MASK_Status_OnOff) != 0)?BGHighLightColor:BGNormalColor;
                            Status_EngineOil.BackColor = (((Previous_Car_Indicator ^ status) & MASK_Status_EngineOil) != 0) ? BGHighLightColor : BGNormalColor;
                            Status_Fuel.BackColor = (((Previous_Car_Indicator ^ status) & MASK_Status_Fuel) != 0) ? BGHighLightColor : BGNormalColor;
                            Status_ABS.BackColor = (((Previous_Car_Indicator ^ status) & MASK_Status_ABS) != 0) ? BGHighLightColor : BGNormalColor;
                            Status_WaterTemp.BackColor = (((Previous_Car_Indicator ^ status) & MASK_Status_WaterTemp) != 0) ? BGHighLightColor : BGNormalColor;
                            Status_Maintenance.BackColor = (((Previous_Car_Indicator ^ status) & MASK_Status_Maintenance) != 0) ? BGHighLightColor : BGNormalColor;
                            Status_FrontTirePressure.BackColor = (((Previous_Car_Indicator ^ status) & MASK_Status_FrontTirePressure) != 0) ? BGHighLightColor : BGNormalColor;
                            Status_RearTirePressure.BackColor = (((Previous_Car_Indicator ^ status) & MASK_Status_RearTirePressure) != 0) ? BGHighLightColor : BGNormalColor;
                        }
                        Previous_Car_Indicator = status;
                    }
                    else
                    {
                        // Error DLC
                    }
                    break;

                case 0x2:       // CMD_B
                    if (DLC == 5)
                    {
                        // Speed
                        uint Speed = DATA[0];
                        if (Speed <= 180)  // 180?
                        {
                            Value_Speed.Text = Speed.ToString() + " km/h";
                            Label_Speed.BackColor = UpdateItemColor(ref FirstRun_Speed, ref Previous_Speed, Speed);
                        }
                        else
                        {
                            // Always warning if out of range
                            Value_Speed.Text = Speed.ToString() + " km/h";
                            FirstRun_Speed = false;
                            Label_Speed.BackColor = BGOutOfRange;
                            Previous_Speed = Speed;
                        }

                        // RPM
                        uint RPM = DATA[1];
                        RPM = RPM * 256 + DATA[2];
                        Value_EngineRPM.Text = RPM.ToString() + " RPM";
                        Label_EngineRPM.BackColor = UpdateItemColor(ref FirstRun_RPM, ref Previous_RPM, RPM);

                        // Consumption
                        uint Consumption = DATA[3];
                        Consumption = Consumption * 256 + DATA[4];
                        if ((Consumption == 0xfffe) || (Speed < 9))
                        {
                            Value_FuelConsumption.Text = "--.-km/L";
                            Value_FuelConsumption_02.Text = "--.-L/100km";
                        }
                        else
                        {
                            float f_Consumption = ((float)Consumption) / 10;
                            Value_FuelConsumption.Text = f_Consumption.ToString() + " km/L";
                            if(Consumption > 0)
                            {
                                uint temp = 100000 / Consumption;
                                Value_FuelConsumption_02.Text = (((float)temp)/100).ToString() + " L/100km";
                            }
                        }
                        Label_FuelConsumption_02.BackColor = Label_FuelConsumption.BackColor = UpdateItemColor(ref FirstRun_Consumption, ref Previous_Consumption, Consumption);
                    }
                    else
                    {
                        // Error DLC
                    }
                    break;

                case 0x3:       // CMD_C
                    if (DLC == 5)
                    {
                        // Water Temp
                        uint WaterTemp = DATA[0];
                        if (WaterTemp <= 8)
                        {
                            Value_WaterTemp.Text = WaterTemp.ToString();
                        }
                        else
                        {
                            // Out of range
                        }
                        Label_WaterTemp.BackColor = UpdateItemColor(ref FirstRun_WaterTemp, ref Previous_WaterTemp, WaterTemp);

                        // Room Temperature
                        uint Temp_Sign_Value = DATA[1];
                        uint Room_Temp = DATA[2];
                        int Final_Room_temp;

                        if ((DATA[1] == 0xFF) && (DATA[2] == 0xFE))
                        {
                            Value_RoomTemp.Text = "-- C";
                        }
                        if (Temp_Sign_Value == 0)
                        {
                            Value_RoomTemp.Text = "+" + Room_Temp.ToString() + " C";
                            Final_Room_temp = (int)Room_Temp;
                            Label_RoomTemp.BackColor = UpdateItemColor(ref FirstRun_Room_Temp, ref Previous_Final_Room_temp, Final_Room_temp);
                        }
                        else if (Temp_Sign_Value == 1)
                        {
                            Value_RoomTemp.Text = "-" + Room_Temp.ToString() + " C";
                            Final_Room_temp = -((int)Room_Temp);
                            Label_RoomTemp.BackColor = UpdateItemColor(ref FirstRun_Room_Temp, ref Previous_Final_Room_temp, Final_Room_temp);
                        }
                        else
                        {
                            // Error data of Temp_Sign
                            FirstRun_Room_Temp = false;
                            Label_RoomTemp.BackColor = BGOutOfRange;
                            Previous_Final_Room_temp = 32767;
                        }

                        // Fuel
                        uint Fuel = DATA[3];
                        if (Fuel <= 160)
                        {
                            float f_Fuel;
                            f_Fuel = ((float)Fuel) / 10;
                            Value_Fuel.Text = f_Fuel.ToString() + "L";
                            Label_Fuel.BackColor = UpdateItemColor(ref FirstRun_Fuel, ref Previous_Fuel, Fuel);
                        }
                        else
                        {
                            // Error data of Fuel
                            float f_Fuel;
                            f_Fuel = ((float)Fuel) / 10;
                            Value_Fuel.Text = f_Fuel.ToString() + "L";
                            FirstRun_Fuel = false;
                            Label_Fuel.BackColor = BGOutOfRange;
                            Previous_Fuel = Fuel;
                        }

                        // Battery
                        uint Battery = DATA[4];
                        float f_Battery;
                        f_Battery = ((float)Battery) / 10;
                        Value_Battery.Text = f_Battery.ToString() + "V";
                        Label_Battery.BackColor = UpdateItemColor(ref FirstRun_Battery, ref Previous_Battery, Battery);
                    }
                    else
                    {
                        // Error DLC
                    }
                    break;

                case 0x4:       // CMD_D
                    if (DLC == 5)
                    {
                        // Mileage
                        uint Mileage = (((uint)DATA[0]) * 0x10000) + (((uint)DATA[1]) * 0x100) + DATA[2];
                        Value_TotalMileage.Text = Mileage.ToString() + " km";
                        Label_TotalMileage.BackColor = UpdateItemColor(ref FirstRun_Mileage, ref Previous_Mileage, Mileage);

                        // Max Speed
                        uint MaxSpeed = DATA[3];
                        Value_MaxSpeed.Text = ((MaxSpeed != 0xff) ? (MaxSpeed.ToString()) : ("--")) + " km/h";
                        Label_MaxSpeed.BackColor = UpdateItemColor(ref FirstRun_MaxSpeed, ref Previous_MaxSpeed, MaxSpeed);

                        // Average Speed
                        uint AveSpeed = DATA[4];
                        AveSpeed = DATA[4];
                        Value_AveSpeed.Text = ((AveSpeed != 0xff) ? (AveSpeed.ToString()) : ("--")) + " km/h";
                        Label_AveSpeed.BackColor = UpdateItemColor(ref FirstRun_AveSpeed, ref Previous_AveSpeed, AveSpeed);
                    }
                    else
                    {
                        // Error DLC
                    }
                    break;

                case 0x5:       // CMD_E
                    if (DLC == 2)
                    {
                        Byte status = DATA[0];
                        ABS_0x5055.Checked = ((status & 0x01) != 0) ? true : false;
                        ABS_0x5019.Checked = ((status & 0x02) != 0) ? true : false;
                        ABS_0x5017.Checked = ((status & 0x04) != 0) ? true : false;
                        ABS_0x5013.Checked = ((status & 0x08) != 0) ? true : false;
                        ABS_0x5018.Checked = ((status & 0x10) != 0) ? true : false;
                        ABS_0x5014.Checked = ((status & 0x20) != 0) ? true : false;
                        ABS_0x5053.Checked = ((status & 0x40) != 0) ? true : false;
                        ABS_0x5052.Checked = ((status & 0x80) != 0) ? true : false;
                        status = DATA[1];
                        ABS_0x5035.Checked = ((status & 0x01) != 0) ? true : false;
                        ABS_0x5043.Checked = ((status & 0x02) != 0) ? true : false;
                        ABS_0x5045.Checked = ((status & 0x04) != 0) ? true : false;
                        ABS_0x5042.Checked = ((status & 0x08) != 0) ? true : false;
                        ABS_0x5044.Checked = ((status & 0x10) != 0) ? true : false;
                        ABS_0x5025.Checked = ((status & 0x20) != 0) ? true : false;
                    }
                    else
                    {
                        // Error DLC
                    }
                    break;

                case 0x6:       // CMD_F
                    if (DLC == 7)
                    {
                        Byte status = DATA[0];
                        OBD_P0503.Checked = ((status & 0x01) != 0) ? true : false;
                        OBD_C0083.Checked = ((status & 0x02) != 0) ? true : false;
                        OBD_C0085.Checked = ((status & 0x04) != 0) ? true : false;
                        OBD_P0105.Checked = ((status & 0x08) != 0) ? true : false;
                        OBD_P0110.Checked = ((status & 0x10) != 0) ? true : false;
                        OBD_P0115.Checked = ((status & 0x20) != 0) ? true : false;
                        OBD_P0120.Checked = ((status & 0x40) != 0) ? true : false;
                        OBD_P0130.Checked = ((status & 0x80) != 0) ? true : false;
                        status = DATA[1];
                        OBD_P0135.Checked = ((status & 0x01) != 0) ? true : false;
                        OBD_P0150.Checked = ((status & 0x02) != 0) ? true : false;
                        OBD_P0155.Checked = ((status & 0x04) != 0) ? true : false;
                        OBD_P0201.Checked = ((status & 0x08) != 0) ? true : false;
                        OBD_P0202.Checked = ((status & 0x10) != 0) ? true : false;
                        OBD_P0217.Checked = ((status & 0x20) != 0) ? true : false;
                        OBD_P0230.Checked = ((status & 0x20) != 0) ? true : false;
                        OBD_P0335.Checked = ((status & 0x20) != 0) ? true : false;
                        status = DATA[2];
                        OBD_P0336.Checked = ((status & 0x01) != 0) ? true : false;
                        OBD_P0351.Checked = ((status & 0x02) != 0) ? true : false;
                        OBD_P0352.Checked = ((status & 0x04) != 0) ? true : false;
                        OBD_P0410.Checked = ((status & 0x08) != 0) ? true : false;
                        OBD_P0480.Checked = ((status & 0x10) != 0) ? true : false;
                        OBD_P0500.Checked = ((status & 0x20) != 0) ? true : false;
                        OBD_P0501.Checked = ((status & 0x20) != 0) ? true : false;
                        OBD_P0505.Checked = ((status & 0x20) != 0) ? true : false;
                        status = DATA[3];
                        OBD_P0512.Checked = ((status & 0x01) != 0) ? true : false;
                        OBD_P0560.Checked = ((status & 0x02) != 0) ? true : false;
                        OBD_P0601.Checked = ((status & 0x04) != 0) ? true : false;
                        OBD_P0604.Checked = ((status & 0x08) != 0) ? true : false;
                        OBD_P0605.Checked = ((status & 0x10) != 0) ? true : false;
                        OBD_P0606.Checked = ((status & 0x20) != 0) ? true : false;
                        OBD_P0620_PIN2.Checked = ((status & 0x20) != 0) ? true : false;
                        OBD_P0620_PIN31.Checked = ((status & 0x20) != 0) ? true : false;
                        status = DATA[4];
                        OBD_P0650.Checked = ((status & 0x01) != 0) ? true : false;
                        OBD_P0655.Checked = ((status & 0x02) != 0) ? true : false;
                        OBD_P0A0F.Checked = ((status & 0x04) != 0) ? true : false;
                        OBD_P1300.Checked = ((status & 0x08) != 0) ? true : false;
                        OBD_P1310.Checked = ((status & 0x10) != 0) ? true : false;
                        OBD_P1536.Checked = ((status & 0x20) != 0) ? true : false;
                        OBD_P1607.Checked = ((status & 0x20) != 0) ? true : false;
                        OBD_P1800.Checked = ((status & 0x20) != 0) ? true : false;
                        status = DATA[5];
                        OBD_P2158.Checked = ((status & 0x01) != 0) ? true : false;
                        OBD_P2600.Checked = ((status & 0x02) != 0) ? true : false;
                        OBD_U0001.Checked = ((status & 0x04) != 0) ? true : false;
                        OBD_U0002.Checked = ((status & 0x08) != 0) ? true : false;
                        OBD_U0121.Checked = ((status & 0x10) != 0) ? true : false;
                        OBD_U0122.Checked = ((status & 0x20) != 0) ? true : false;
                        OBD_U0128.Checked = ((status & 0x20) != 0) ? true : false;
                        OBD_U0140.Checked = ((status & 0x20) != 0) ? true : false;
                        status = DATA[6];
                        OBD_U0426.Checked = ((status & 0x01) != 0) ? true : false;
                        OBD_U0486.Checked = ((status & 0x02) != 0) ? true : false;
                    }
                    else
                    {
                        // Error DLC
                    }
                    break;
                default:
                    break;
            }

        }

        unsafe private void timer_rec_Tick(object sender, EventArgs e)
        {
            UInt32 res = new UInt32();

            res = VCI_Receive(m_devtype, m_devind, m_canind, ref m_recobj[0],1000, 100);

            uint ID=0, DLC=0;
            const int DATA_LEN = 8;
            byte[] DATA = new byte[DATA_LEN];

            String str;
            for (UInt32 i = 0; i < res; i++)
            {
                str = "";
                if (m_recobj[i].ExternFlag == 0)
                {
                    str += "Base-format ";
                }
                else
                {
                    str += "Extended-format ";
                }
                if (m_recobj[i].RemoteFlag == 0)
                {
                    str += "data-frame ";
                }
                else
                {
                    str += "remote-frame ";
                }

                str += " ID:0x" + System.Convert.ToString(m_recobj[i].ID, 16) +" ";
                ID = m_recobj[i].ID;

                if (m_recobj[i].RemoteFlag == 0)
                {
                    byte len = (byte)(m_recobj[i].DataLen % 9);
                    DLC = len;

                    str += "Data:";

                    fixed (VCI_CAN_OBJ* m_recobj1 = &m_recobj[i])
                    {
                        byte j = 0;
                        while ((j<len)&&(j<DATA_LEN))
                        {
                            DATA[j] = m_recobj1->Data[j];
                            str += " " + System.Convert.ToString(DATA[j], 16);
                            j++;
                        }
                    }

                    CAN_Update_DashBoard(ID, DLC, DATA);
                }
                listBox_Info.Items.Add(str);
                listBox_Info.SelectedIndex = listBox_Info.Items.Count - 1;

            }
        }

        private void button_StartCAN_Click(object sender, EventArgs e)
        {
            uint status;

            if (m_bOpen == 0)
                return;
            status = VCI_StartCAN(m_devtype, m_devind, m_canind);
        }

        private void button_StopCAN_Click(object sender, EventArgs e)
        {
            if (m_bOpen == 0)
                return;
            VCI_ResetCAN(m_devtype, m_devind, m_canind);
        }

        unsafe private void button_Send_Click(object sender, EventArgs e)
        {
            if(m_bOpen==0)
                return;

            VCI_CAN_OBJ sendobj = new VCI_CAN_OBJ();
            //sendobj.Init();
            sendobj.RemoteFlag = (byte)comboBox_FrameFormat.SelectedIndex;
            sendobj.ExternFlag = (byte)comboBox_FrameType.SelectedIndex;
            sendobj.ID = System.Convert.ToUInt32("0x"+textBox_ID.Text,16);
            int len = (textBox_Data.Text.Length+1) / 3;
            sendobj.DataLen =System.Convert.ToByte(len);
            String strdata = textBox_Data.Text;
            int i=-1;
            if(i++<len-1)
                sendobj.Data[0]=System.Convert.ToByte("0x" +strdata.Substring(i * 3, 2),16);
            if (i++ < len - 1)
                sendobj.Data[1]=System.Convert.ToByte("0x" +strdata.Substring(i * 3, 2),16);
            if (i++ < len - 1)
                sendobj.Data[2]=System.Convert.ToByte("0x" +strdata.Substring(i * 3, 2),16);
            if (i++ < len - 1)
                sendobj.Data[3]=System.Convert.ToByte("0x" +strdata.Substring(i * 3, 2),16);
            if (i++ < len - 1)
                sendobj.Data[4]=System.Convert.ToByte("0x" +strdata.Substring(i * 3, 2),16);
            if (i++ < len - 1)
                sendobj.Data[5]=System.Convert.ToByte("0x" +strdata.Substring(i * 3, 2),16);
            if (i++ < len - 1)
                sendobj.Data[6]=System.Convert.ToByte("0x" +strdata.Substring(i * 3, 2),16);
            if (i++ < len - 1)
                sendobj.Data[7] = System.Convert.ToByte("0x" + strdata.Substring(i * 3, 2), 16);

            if(VCI_Transmit(m_devtype,m_devind,m_canind,ref sendobj,1)==0)
            {
                MessageBox.Show("Fail to send", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            listBox_Info.Items.Clear();
        }

    }
}