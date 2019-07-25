namespace USB_CAN_READER
{
    partial class CAN_Reader_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_devtype = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_Time1 = new System.Windows.Forms.TextBox();
            this.textBox_AccMask = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_Mode = new System.Windows.Forms.ComboBox();
            this.comboBox_Filter = new System.Windows.Forms.ComboBox();
            this.textBox_Time0 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_AccCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_CANIndex = new System.Windows.Forms.ComboBox();
            this.comboBox_DevIndex = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.button_StartCAN = new System.Windows.Forms.Button();
            this.button_StopCAN = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_FrameFormat = new System.Windows.Forms.ComboBox();
            this.comboBox_FrameType = new System.Windows.Forms.ComboBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Data = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox_Info = new System.Windows.Forms.ListBox();
            this.timer_rec = new System.Windows.Forms.Timer(this.components);
            this.button_Clear = new System.Windows.Forms.Button();
            this.Group_Car_Status_Indicator = new System.Windows.Forms.GroupBox();
            this.Status_RearTirePressure = new System.Windows.Forms.RadioButton();
            this.Status_FrontTirePressure = new System.Windows.Forms.RadioButton();
            this.Status_Maintenance = new System.Windows.Forms.RadioButton();
            this.Status_WaterTemp = new System.Windows.Forms.RadioButton();
            this.Status_ABS = new System.Windows.Forms.RadioButton();
            this.Status_Fuel = new System.Windows.Forms.RadioButton();
            this.Status_EngineOil = new System.Windows.Forms.RadioButton();
            this.Status_OnOff = new System.Windows.Forms.RadioButton();
            this.Value_AveSpeed = new System.Windows.Forms.TextBox();
            this.Value_FuelConsumption = new System.Windows.Forms.TextBox();
            this.Label_AveSpeed = new System.Windows.Forms.Label();
            this.Label_FuelConsumption = new System.Windows.Forms.Label();
            this.Value_MaxSpeed = new System.Windows.Forms.TextBox();
            this.Label_MaxSpeed = new System.Windows.Forms.Label();
            this.Value_EngineRPM = new System.Windows.Forms.TextBox();
            this.Value_TotalMileage = new System.Windows.Forms.TextBox();
            this.Label_EngineRPM = new System.Windows.Forms.Label();
            this.Label_TotalMileage = new System.Windows.Forms.Label();
            this.Value_Speed = new System.Windows.Forms.TextBox();
            this.Label_Speed = new System.Windows.Forms.Label();
            this.Group_ABS_Error_Code = new System.Windows.Forms.GroupBox();
            this.ABS_0x5025 = new System.Windows.Forms.RadioButton();
            this.ABS_0x5044 = new System.Windows.Forms.RadioButton();
            this.ABS_0x5052 = new System.Windows.Forms.RadioButton();
            this.ABS_0x5042 = new System.Windows.Forms.RadioButton();
            this.ABS_0x5053 = new System.Windows.Forms.RadioButton();
            this.ABS_0x5045 = new System.Windows.Forms.RadioButton();
            this.ABS_0x5014 = new System.Windows.Forms.RadioButton();
            this.ABS_0x5043 = new System.Windows.Forms.RadioButton();
            this.ABS_0x5018 = new System.Windows.Forms.RadioButton();
            this.ABS_0x5035 = new System.Windows.Forms.RadioButton();
            this.ABS_0x5013 = new System.Windows.Forms.RadioButton();
            this.ABS_0x5017 = new System.Windows.Forms.RadioButton();
            this.ABS_0x5019 = new System.Windows.Forms.RadioButton();
            this.ABS_0x5055 = new System.Windows.Forms.RadioButton();
            this.Group_OBD_Error_Code = new System.Windows.Forms.GroupBox();
            this.OBD_U0486 = new System.Windows.Forms.RadioButton();
            this.OBD_U0426 = new System.Windows.Forms.RadioButton();
            this.OBD_U0122 = new System.Windows.Forms.RadioButton();
            this.OBD_U0121 = new System.Windows.Forms.RadioButton();
            this.OBD_U0002 = new System.Windows.Forms.RadioButton();
            this.OBD_U0140 = new System.Windows.Forms.RadioButton();
            this.OBD_U0001 = new System.Windows.Forms.RadioButton();
            this.OBD_U0128 = new System.Windows.Forms.RadioButton();
            this.OBD_P2600 = new System.Windows.Forms.RadioButton();
            this.OBD_P2158 = new System.Windows.Forms.RadioButton();
            this.OBD_P1800 = new System.Windows.Forms.RadioButton();
            this.OBD_P1607 = new System.Windows.Forms.RadioButton();
            this.OBD_P1536 = new System.Windows.Forms.RadioButton();
            this.OBD_P1310 = new System.Windows.Forms.RadioButton();
            this.OBD_P0620_PIN31 = new System.Windows.Forms.RadioButton();
            this.OBD_P1300 = new System.Windows.Forms.RadioButton();
            this.OBD_P0620_PIN2 = new System.Windows.Forms.RadioButton();
            this.OBD_P0A0F = new System.Windows.Forms.RadioButton();
            this.OBD_P0606 = new System.Windows.Forms.RadioButton();
            this.OBD_P0655 = new System.Windows.Forms.RadioButton();
            this.OBD_P0605 = new System.Windows.Forms.RadioButton();
            this.OBD_P0650 = new System.Windows.Forms.RadioButton();
            this.OBD_P0604 = new System.Windows.Forms.RadioButton();
            this.OBD_P0601 = new System.Windows.Forms.RadioButton();
            this.OBD_P0560 = new System.Windows.Forms.RadioButton();
            this.OBD_P0512 = new System.Windows.Forms.RadioButton();
            this.OBD_P0500 = new System.Windows.Forms.RadioButton();
            this.OBD_P0480 = new System.Windows.Forms.RadioButton();
            this.OBD_P0410 = new System.Windows.Forms.RadioButton();
            this.OBD_P0505 = new System.Windows.Forms.RadioButton();
            this.OBD_P0352 = new System.Windows.Forms.RadioButton();
            this.OBD_P0501 = new System.Windows.Forms.RadioButton();
            this.OBD_P0351 = new System.Windows.Forms.RadioButton();
            this.OBD_P0336 = new System.Windows.Forms.RadioButton();
            this.OBD_P0335 = new System.Windows.Forms.RadioButton();
            this.OBD_P0230 = new System.Windows.Forms.RadioButton();
            this.OBD_P0217 = new System.Windows.Forms.RadioButton();
            this.OBD_P0202 = new System.Windows.Forms.RadioButton();
            this.OBD_P0130 = new System.Windows.Forms.RadioButton();
            this.OBD_P0201 = new System.Windows.Forms.RadioButton();
            this.OBD_P0120 = new System.Windows.Forms.RadioButton();
            this.OBD_P0155 = new System.Windows.Forms.RadioButton();
            this.OBD_P0115 = new System.Windows.Forms.RadioButton();
            this.OBD_P0150 = new System.Windows.Forms.RadioButton();
            this.OBD_P0110 = new System.Windows.Forms.RadioButton();
            this.OBD_P0135 = new System.Windows.Forms.RadioButton();
            this.OBD_P0105 = new System.Windows.Forms.RadioButton();
            this.OBD_C0085 = new System.Windows.Forms.RadioButton();
            this.OBD_C0083 = new System.Windows.Forms.RadioButton();
            this.OBD_P0503 = new System.Windows.Forms.RadioButton();
            this.Value_Battery = new System.Windows.Forms.TextBox();
            this.Label_Battery = new System.Windows.Forms.Label();
            this.Value_RoomTemp = new System.Windows.Forms.TextBox();
            this.Value_Fuel = new System.Windows.Forms.TextBox();
            this.Label_RoomTemp = new System.Windows.Forms.Label();
            this.Label_Fuel = new System.Windows.Forms.Label();
            this.Value_WaterTemp = new System.Windows.Forms.TextBox();
            this.Label_WaterTemp = new System.Windows.Forms.Label();
            this.Group_Driving_Status = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textbox_Connection_Message = new System.Windows.Forms.TextBox();
            this.Value_FuelConsumption_02 = new System.Windows.Forms.TextBox();
            this.Label_FuelConsumption_02 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Group_Car_Status_Indicator.SuspendLayout();
            this.Group_ABS_Error_Code.SuspendLayout();
            this.Group_OBD_Error_Code.SuspendLayout();
            this.Group_Driving_Status.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_devtype);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.comboBox_CANIndex);
            this.groupBox1.Controls.Add(this.comboBox_DevIndex);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(626, 172);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设备参数";
            // 
            // comboBox_devtype
            // 
            this.comboBox_devtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_devtype.FormattingEnabled = true;
            this.comboBox_devtype.Items.AddRange(new object[] {
            "3",
            "4"});
            this.comboBox_devtype.Location = new System.Drawing.Point(68, 24);
            this.comboBox_devtype.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_devtype.MaxDropDownItems = 15;
            this.comboBox_devtype.Name = "comboBox_devtype";
            this.comboBox_devtype.Size = new System.Drawing.Size(160, 28);
            this.comboBox_devtype.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 29);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "类型:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_Time1);
            this.groupBox2.Controls.Add(this.textBox_AccMask);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBox_Mode);
            this.groupBox2.Controls.Add(this.comboBox_Filter);
            this.groupBox2.Controls.Add(this.textBox_Time0);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_AccCode);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 62);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(605, 96);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "初始化CAN参数";
            // 
            // textBox_Time1
            // 
            this.textBox_Time1.Location = new System.Drawing.Point(298, 58);
            this.textBox_Time1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Time1.Name = "textBox_Time1";
            this.textBox_Time1.Size = new System.Drawing.Size(36, 31);
            this.textBox_Time1.TabIndex = 1;
            // 
            // textBox_AccMask
            // 
            this.textBox_AccMask.Location = new System.Drawing.Point(103, 55);
            this.textBox_AccMask.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_AccMask.Name = "textBox_AccMask";
            this.textBox_AccMask.Size = new System.Drawing.Size(92, 31);
            this.textBox_AccMask.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "定时器1:0x";
            // 
            // comboBox_Mode
            // 
            this.comboBox_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Mode.FormattingEnabled = true;
            this.comboBox_Mode.Items.AddRange(new object[] {
            "正常",
            "只听",
            "自测"});
            this.comboBox_Mode.Location = new System.Drawing.Point(442, 59);
            this.comboBox_Mode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Mode.Name = "comboBox_Mode";
            this.comboBox_Mode.Size = new System.Drawing.Size(92, 28);
            this.comboBox_Mode.TabIndex = 1;
            // 
            // comboBox_Filter
            // 
            this.comboBox_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Filter.FormattingEnabled = true;
            this.comboBox_Filter.Items.AddRange(new object[] {
            "接收全部类型",
            "只接收标准帧",
            "只接收扩展帧"});
            this.comboBox_Filter.Location = new System.Drawing.Point(442, 28);
            this.comboBox_Filter.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Filter.Name = "comboBox_Filter";
            this.comboBox_Filter.Size = new System.Drawing.Size(92, 28);
            this.comboBox_Filter.TabIndex = 1;
            // 
            // textBox_Time0
            // 
            this.textBox_Time0.Location = new System.Drawing.Point(298, 24);
            this.textBox_Time0.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Time0.Name = "textBox_Time0";
            this.textBox_Time0.Size = new System.Drawing.Size(36, 31);
            this.textBox_Time0.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "模式:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "滤波方式:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "屏蔽码:0x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "定时器0:0x";
            // 
            // textBox_AccCode
            // 
            this.textBox_AccCode.Location = new System.Drawing.Point(103, 24);
            this.textBox_AccCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_AccCode.Name = "textBox_AccCode";
            this.textBox_AccCode.Size = new System.Drawing.Size(92, 31);
            this.textBox_AccCode.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "验收码:0x";
            // 
            // comboBox_CANIndex
            // 
            this.comboBox_CANIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CANIndex.FormattingEnabled = true;
            this.comboBox_CANIndex.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboBox_CANIndex.Location = new System.Drawing.Point(557, 26);
            this.comboBox_CANIndex.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_CANIndex.Name = "comboBox_CANIndex";
            this.comboBox_CANIndex.Size = new System.Drawing.Size(61, 28);
            this.comboBox_CANIndex.TabIndex = 1;
            // 
            // comboBox_DevIndex
            // 
            this.comboBox_DevIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DevIndex.FormattingEnabled = true;
            this.comboBox_DevIndex.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBox_DevIndex.Location = new System.Drawing.Point(355, 28);
            this.comboBox_DevIndex.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_DevIndex.Name = "comboBox_DevIndex";
            this.comboBox_DevIndex.Size = new System.Drawing.Size(53, 28);
            this.comboBox_DevIndex.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "第几路CAN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "索引号:";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonConnect.Location = new System.Drawing.Point(659, 10);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(130, 31);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // button_StartCAN
            // 
            this.button_StartCAN.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_StartCAN.Location = new System.Drawing.Point(665, 100);
            this.button_StartCAN.Margin = new System.Windows.Forms.Padding(4);
            this.button_StartCAN.Name = "button_StartCAN";
            this.button_StartCAN.Size = new System.Drawing.Size(100, 29);
            this.button_StartCAN.TabIndex = 5;
            this.button_StartCAN.Text = "Start CAN";
            this.button_StartCAN.UseVisualStyleBackColor = true;
            this.button_StartCAN.Click += new System.EventHandler(this.button_StartCAN_Click);
            // 
            // button_StopCAN
            // 
            this.button_StopCAN.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_StopCAN.Location = new System.Drawing.Point(665, 172);
            this.button_StopCAN.Margin = new System.Windows.Forms.Padding(4);
            this.button_StopCAN.Name = "button_StopCAN";
            this.button_StopCAN.Size = new System.Drawing.Size(100, 29);
            this.button_StopCAN.TabIndex = 5;
            this.button_StopCAN.Text = "Stop CAN";
            this.button_StopCAN.UseVisualStyleBackColor = true;
            this.button_StopCAN.Click += new System.EventHandler(this.button_StopCAN_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox_FrameFormat);
            this.groupBox3.Controls.Add(this.comboBox_FrameType);
            this.groupBox3.Controls.Add(this.button_Send);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox_Data);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBox_ID);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(20, 205);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(626, 101);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送数据帧";
            // 
            // comboBox_FrameFormat
            // 
            this.comboBox_FrameFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_FrameFormat.FormattingEnabled = true;
            this.comboBox_FrameFormat.Items.AddRange(new object[] {
            "数据帧",
            "远程帧"});
            this.comboBox_FrameFormat.Location = new System.Drawing.Point(261, 24);
            this.comboBox_FrameFormat.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_FrameFormat.Name = "comboBox_FrameFormat";
            this.comboBox_FrameFormat.Size = new System.Drawing.Size(92, 28);
            this.comboBox_FrameFormat.TabIndex = 1;
            // 
            // comboBox_FrameType
            // 
            this.comboBox_FrameType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_FrameType.FormattingEnabled = true;
            this.comboBox_FrameType.Items.AddRange(new object[] {
            "标准帧",
            "扩展帧"});
            this.comboBox_FrameType.Location = new System.Drawing.Point(92, 25);
            this.comboBox_FrameType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_FrameType.Name = "comboBox_FrameType";
            this.comboBox_FrameType.Size = new System.Drawing.Size(92, 28);
            this.comboBox_FrameType.TabIndex = 1;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(519, 62);
            this.button_Send.Margin = new System.Windows.Forms.Padding(4);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(100, 29);
            this.button_Send.TabIndex = 5;
            this.button_Send.Text = "发送";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(196, 29);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "帧格式:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "帧类型:";
            // 
            // textBox_Data
            // 
            this.textBox_Data.Location = new System.Drawing.Point(75, 60);
            this.textBox_Data.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Data.Name = "textBox_Data";
            this.textBox_Data.Size = new System.Drawing.Size(333, 31);
            this.textBox_Data.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 68);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "数据:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(519, 24);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(100, 31);
            this.textBox_ID.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(363, 30);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "帧ID:0x";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox_Info);
            this.groupBox4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(12, 49);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(786, 160);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Message";
            // 
            // listBox_Info
            // 
            this.listBox_Info.FormattingEnabled = true;
            this.listBox_Info.ItemHeight = 20;
            this.listBox_Info.Location = new System.Drawing.Point(13, 25);
            this.listBox_Info.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_Info.Name = "listBox_Info";
            this.listBox_Info.Size = new System.Drawing.Size(758, 124);
            this.listBox_Info.TabIndex = 0;
            // 
            // timer_rec
            // 
            this.timer_rec.Tick += new System.EventHandler(this.timer_rec_Tick);
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Clear.Location = new System.Drawing.Point(665, 240);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(100, 29);
            this.button_Clear.TabIndex = 8;
            this.button_Clear.Text = "Clear List";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Group_Car_Status_Indicator
            // 
            this.Group_Car_Status_Indicator.Controls.Add(this.Status_RearTirePressure);
            this.Group_Car_Status_Indicator.Controls.Add(this.Status_FrontTirePressure);
            this.Group_Car_Status_Indicator.Controls.Add(this.Status_Maintenance);
            this.Group_Car_Status_Indicator.Controls.Add(this.Status_WaterTemp);
            this.Group_Car_Status_Indicator.Controls.Add(this.Status_ABS);
            this.Group_Car_Status_Indicator.Controls.Add(this.Status_Fuel);
            this.Group_Car_Status_Indicator.Controls.Add(this.Status_EngineOil);
            this.Group_Car_Status_Indicator.Controls.Add(this.Status_OnOff);
            this.Group_Car_Status_Indicator.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Group_Car_Status_Indicator.Location = new System.Drawing.Point(12, 216);
            this.Group_Car_Status_Indicator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Group_Car_Status_Indicator.Name = "Group_Car_Status_Indicator";
            this.Group_Car_Status_Indicator.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Group_Car_Status_Indicator.Size = new System.Drawing.Size(222, 261);
            this.Group_Car_Status_Indicator.TabIndex = 9;
            this.Group_Car_Status_Indicator.TabStop = false;
            this.Group_Car_Status_Indicator.Text = "Car Status Indicator";
            // 
            // Status_RearTirePressure
            // 
            this.Status_RearTirePressure.AutoCheck = false;
            this.Status_RearTirePressure.AutoSize = true;
            this.Status_RearTirePressure.Location = new System.Drawing.Point(13, 211);
            this.Status_RearTirePressure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Status_RearTirePressure.Name = "Status_RearTirePressure";
            this.Status_RearTirePressure.Size = new System.Drawing.Size(190, 24);
            this.Status_RearTirePressure.TabIndex = 7;
            this.Status_RearTirePressure.TabStop = true;
            this.Status_RearTirePressure.Text = "後輪胎胎壓指示燈";
            this.Status_RearTirePressure.UseVisualStyleBackColor = true;
            // 
            // Status_FrontTirePressure
            // 
            this.Status_FrontTirePressure.AutoCheck = false;
            this.Status_FrontTirePressure.AutoSize = true;
            this.Status_FrontTirePressure.Location = new System.Drawing.Point(13, 186);
            this.Status_FrontTirePressure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Status_FrontTirePressure.Name = "Status_FrontTirePressure";
            this.Status_FrontTirePressure.Size = new System.Drawing.Size(190, 24);
            this.Status_FrontTirePressure.TabIndex = 6;
            this.Status_FrontTirePressure.TabStop = true;
            this.Status_FrontTirePressure.Text = "前輪胎胎壓指示燈";
            this.Status_FrontTirePressure.UseVisualStyleBackColor = true;
            // 
            // Status_Maintenance
            // 
            this.Status_Maintenance.AutoCheck = false;
            this.Status_Maintenance.AutoSize = true;
            this.Status_Maintenance.Location = new System.Drawing.Point(13, 161);
            this.Status_Maintenance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Status_Maintenance.Name = "Status_Maintenance";
            this.Status_Maintenance.Size = new System.Drawing.Size(170, 24);
            this.Status_Maintenance.TabIndex = 5;
            this.Status_Maintenance.TabStop = true;
            this.Status_Maintenance.Text = "保養提示指示燈";
            this.Status_Maintenance.UseVisualStyleBackColor = true;
            // 
            // Status_WaterTemp
            // 
            this.Status_WaterTemp.AutoCheck = false;
            this.Status_WaterTemp.AutoSize = true;
            this.Status_WaterTemp.Location = new System.Drawing.Point(13, 136);
            this.Status_WaterTemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Status_WaterTemp.Name = "Status_WaterTemp";
            this.Status_WaterTemp.Size = new System.Drawing.Size(90, 24);
            this.Status_WaterTemp.TabIndex = 4;
            this.Status_WaterTemp.TabStop = true;
            this.Status_WaterTemp.Text = "水溫燈";
            this.Status_WaterTemp.UseVisualStyleBackColor = true;
            // 
            // Status_ABS
            // 
            this.Status_ABS.AutoCheck = false;
            this.Status_ABS.AutoSize = true;
            this.Status_ABS.Location = new System.Drawing.Point(13, 111);
            this.Status_ABS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Status_ABS.Name = "Status_ABS";
            this.Status_ABS.Size = new System.Drawing.Size(127, 24);
            this.Status_ABS.TabIndex = 3;
            this.Status_ABS.TabStop = true;
            this.Status_ABS.Text = "ABS故障燈";
            this.Status_ABS.UseVisualStyleBackColor = true;
            // 
            // Status_Fuel
            // 
            this.Status_Fuel.AutoCheck = false;
            this.Status_Fuel.AutoSize = true;
            this.Status_Fuel.Location = new System.Drawing.Point(13, 86);
            this.Status_Fuel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Status_Fuel.Name = "Status_Fuel";
            this.Status_Fuel.Size = new System.Drawing.Size(90, 24);
            this.Status_Fuel.TabIndex = 2;
            this.Status_Fuel.TabStop = true;
            this.Status_Fuel.Text = "燃油燈";
            this.Status_Fuel.UseVisualStyleBackColor = true;
            // 
            // Status_EngineOil
            // 
            this.Status_EngineOil.AutoCheck = false;
            this.Status_EngineOil.AutoSize = true;
            this.Status_EngineOil.Location = new System.Drawing.Point(13, 60);
            this.Status_EngineOil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Status_EngineOil.Name = "Status_EngineOil";
            this.Status_EngineOil.Size = new System.Drawing.Size(170, 24);
            this.Status_EngineOil.TabIndex = 1;
            this.Status_EngineOil.TabStop = true;
            this.Status_EngineOil.Text = "機油壓力指示燈";
            this.Status_EngineOil.UseVisualStyleBackColor = true;
            // 
            // Status_OnOff
            // 
            this.Status_OnOff.AutoCheck = false;
            this.Status_OnOff.AutoSize = true;
            this.Status_OnOff.BackColor = System.Drawing.SystemColors.Control;
            this.Status_OnOff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Status_OnOff.Location = new System.Drawing.Point(13, 33);
            this.Status_OnOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Status_OnOff.Name = "Status_OnOff";
            this.Status_OnOff.Size = new System.Drawing.Size(130, 24);
            this.Status_OnOff.TabIndex = 0;
            this.Status_OnOff.TabStop = true;
            this.Status_OnOff.Text = "開機指示燈";
            this.Status_OnOff.UseVisualStyleBackColor = false;
            // 
            // Value_AveSpeed
            // 
            this.Value_AveSpeed.Location = new System.Drawing.Point(450, 99);
            this.Value_AveSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Value_AveSpeed.Name = "Value_AveSpeed";
            this.Value_AveSpeed.ReadOnly = true;
            this.Value_AveSpeed.Size = new System.Drawing.Size(93, 31);
            this.Value_AveSpeed.TabIndex = 19;
            this.Value_AveSpeed.Text = "No Data";
            this.Value_AveSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value_FuelConsumption
            // 
            this.Value_FuelConsumption.Location = new System.Drawing.Point(134, 98);
            this.Value_FuelConsumption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Value_FuelConsumption.Name = "Value_FuelConsumption";
            this.Value_FuelConsumption.ReadOnly = true;
            this.Value_FuelConsumption.Size = new System.Drawing.Size(147, 31);
            this.Value_FuelConsumption.TabIndex = 13;
            this.Value_FuelConsumption.Text = "No Data";
            this.Value_FuelConsumption.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_AveSpeed
            // 
            this.Label_AveSpeed.AutoSize = true;
            this.Label_AveSpeed.Location = new System.Drawing.Point(314, 102);
            this.Label_AveSpeed.Name = "Label_AveSpeed";
            this.Label_AveSpeed.Size = new System.Drawing.Size(120, 20);
            this.Label_AveSpeed.TabIndex = 18;
            this.Label_AveSpeed.Text = "Average Speed";
            // 
            // Label_FuelConsumption
            // 
            this.Label_FuelConsumption.AutoSize = true;
            this.Label_FuelConsumption.Location = new System.Drawing.Point(6, 102);
            this.Label_FuelConsumption.Name = "Label_FuelConsumption";
            this.Label_FuelConsumption.Size = new System.Drawing.Size(108, 20);
            this.Label_FuelConsumption.TabIndex = 12;
            this.Label_FuelConsumption.Text = "Consumption";
            // 
            // Value_MaxSpeed
            // 
            this.Value_MaxSpeed.Location = new System.Drawing.Point(450, 61);
            this.Value_MaxSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Value_MaxSpeed.Name = "Value_MaxSpeed";
            this.Value_MaxSpeed.ReadOnly = true;
            this.Value_MaxSpeed.Size = new System.Drawing.Size(93, 31);
            this.Value_MaxSpeed.TabIndex = 17;
            this.Value_MaxSpeed.Text = "No Data";
            this.Value_MaxSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_MaxSpeed
            // 
            this.Label_MaxSpeed.AutoSize = true;
            this.Label_MaxSpeed.Location = new System.Drawing.Point(314, 64);
            this.Label_MaxSpeed.Name = "Label_MaxSpeed";
            this.Label_MaxSpeed.Size = new System.Drawing.Size(92, 20);
            this.Label_MaxSpeed.TabIndex = 16;
            this.Label_MaxSpeed.Text = "Max Speed";
            // 
            // Value_EngineRPM
            // 
            this.Value_EngineRPM.Location = new System.Drawing.Point(134, 60);
            this.Value_EngineRPM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Value_EngineRPM.Name = "Value_EngineRPM";
            this.Value_EngineRPM.ReadOnly = true;
            this.Value_EngineRPM.Size = new System.Drawing.Size(147, 31);
            this.Value_EngineRPM.TabIndex = 11;
            this.Value_EngineRPM.Text = "No Data";
            this.Value_EngineRPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value_TotalMileage
            // 
            this.Value_TotalMileage.Location = new System.Drawing.Point(450, 23);
            this.Value_TotalMileage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Value_TotalMileage.Name = "Value_TotalMileage";
            this.Value_TotalMileage.ReadOnly = true;
            this.Value_TotalMileage.Size = new System.Drawing.Size(93, 31);
            this.Value_TotalMileage.TabIndex = 15;
            this.Value_TotalMileage.Text = "No Data";
            this.Value_TotalMileage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_EngineRPM
            // 
            this.Label_EngineRPM.AutoSize = true;
            this.Label_EngineRPM.Location = new System.Drawing.Point(6, 62);
            this.Label_EngineRPM.Name = "Label_EngineRPM";
            this.Label_EngineRPM.Size = new System.Drawing.Size(65, 20);
            this.Label_EngineRPM.TabIndex = 10;
            this.Label_EngineRPM.Text = "Engine ";
            // 
            // Label_TotalMileage
            // 
            this.Label_TotalMileage.AutoSize = true;
            this.Label_TotalMileage.Location = new System.Drawing.Point(314, 28);
            this.Label_TotalMileage.Name = "Label_TotalMileage";
            this.Label_TotalMileage.Size = new System.Drawing.Size(69, 20);
            this.Label_TotalMileage.TabIndex = 14;
            this.Label_TotalMileage.Text = "Mileage";
            // 
            // Value_Speed
            // 
            this.Value_Speed.Location = new System.Drawing.Point(134, 22);
            this.Value_Speed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Value_Speed.Name = "Value_Speed";
            this.Value_Speed.ReadOnly = true;
            this.Value_Speed.Size = new System.Drawing.Size(147, 31);
            this.Value_Speed.TabIndex = 9;
            this.Value_Speed.Text = "No Data";
            this.Value_Speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_Speed
            // 
            this.Label_Speed.AutoSize = true;
            this.Label_Speed.BackColor = System.Drawing.SystemColors.Control;
            this.Label_Speed.Location = new System.Drawing.Point(6, 26);
            this.Label_Speed.Name = "Label_Speed";
            this.Label_Speed.Size = new System.Drawing.Size(58, 20);
            this.Label_Speed.TabIndex = 8;
            this.Label_Speed.Text = "Speed ";
            // 
            // Group_ABS_Error_Code
            // 
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5025);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5044);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5052);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5042);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5053);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5045);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5014);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5043);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5018);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5035);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5013);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5017);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5019);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5055);
            this.Group_ABS_Error_Code.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Group_ABS_Error_Code.Location = new System.Drawing.Point(831, 15);
            this.Group_ABS_Error_Code.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Group_ABS_Error_Code.Name = "Group_ABS_Error_Code";
            this.Group_ABS_Error_Code.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Group_ABS_Error_Code.Size = new System.Drawing.Size(125, 378);
            this.Group_ABS_Error_Code.TabIndex = 10;
            this.Group_ABS_Error_Code.TabStop = false;
            this.Group_ABS_Error_Code.Text = "ABS Status";
            // 
            // ABS_0x5025
            // 
            this.ABS_0x5025.AutoCheck = false;
            this.ABS_0x5025.AutoSize = true;
            this.ABS_0x5025.Location = new System.Drawing.Point(13, 350);
            this.ABS_0x5025.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ABS_0x5025.Name = "ABS_0x5025";
            this.ABS_0x5025.Size = new System.Drawing.Size(84, 24);
            this.ABS_0x5025.TabIndex = 16;
            this.ABS_0x5025.TabStop = true;
            this.ABS_0x5025.Text = "0x5025";
            this.ABS_0x5025.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5044
            // 
            this.ABS_0x5044.AutoCheck = false;
            this.ABS_0x5044.AutoSize = true;
            this.ABS_0x5044.Location = new System.Drawing.Point(13, 325);
            this.ABS_0x5044.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ABS_0x5044.Name = "ABS_0x5044";
            this.ABS_0x5044.Size = new System.Drawing.Size(84, 24);
            this.ABS_0x5044.TabIndex = 15;
            this.ABS_0x5044.TabStop = true;
            this.ABS_0x5044.Text = "0x5044";
            this.ABS_0x5044.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5052
            // 
            this.ABS_0x5052.AutoCheck = false;
            this.ABS_0x5052.AutoSize = true;
            this.ABS_0x5052.Location = new System.Drawing.Point(13, 200);
            this.ABS_0x5052.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ABS_0x5052.Name = "ABS_0x5052";
            this.ABS_0x5052.Size = new System.Drawing.Size(84, 24);
            this.ABS_0x5052.TabIndex = 7;
            this.ABS_0x5052.TabStop = true;
            this.ABS_0x5052.Text = "0x5052";
            this.ABS_0x5052.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5042
            // 
            this.ABS_0x5042.AutoCheck = false;
            this.ABS_0x5042.AutoSize = true;
            this.ABS_0x5042.Location = new System.Drawing.Point(13, 300);
            this.ABS_0x5042.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ABS_0x5042.Name = "ABS_0x5042";
            this.ABS_0x5042.Size = new System.Drawing.Size(84, 24);
            this.ABS_0x5042.TabIndex = 14;
            this.ABS_0x5042.TabStop = true;
            this.ABS_0x5042.Text = "0x5042";
            this.ABS_0x5042.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5053
            // 
            this.ABS_0x5053.AutoCheck = false;
            this.ABS_0x5053.AutoSize = true;
            this.ABS_0x5053.Location = new System.Drawing.Point(13, 175);
            this.ABS_0x5053.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ABS_0x5053.Name = "ABS_0x5053";
            this.ABS_0x5053.Size = new System.Drawing.Size(84, 24);
            this.ABS_0x5053.TabIndex = 6;
            this.ABS_0x5053.TabStop = true;
            this.ABS_0x5053.Text = "0x5053";
            this.ABS_0x5053.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5045
            // 
            this.ABS_0x5045.AutoCheck = false;
            this.ABS_0x5045.AutoSize = true;
            this.ABS_0x5045.Location = new System.Drawing.Point(13, 275);
            this.ABS_0x5045.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ABS_0x5045.Name = "ABS_0x5045";
            this.ABS_0x5045.Size = new System.Drawing.Size(84, 24);
            this.ABS_0x5045.TabIndex = 13;
            this.ABS_0x5045.TabStop = true;
            this.ABS_0x5045.Text = "0x5045";
            this.ABS_0x5045.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5014
            // 
            this.ABS_0x5014.AutoCheck = false;
            this.ABS_0x5014.AutoSize = true;
            this.ABS_0x5014.Location = new System.Drawing.Point(13, 150);
            this.ABS_0x5014.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ABS_0x5014.Name = "ABS_0x5014";
            this.ABS_0x5014.Size = new System.Drawing.Size(84, 24);
            this.ABS_0x5014.TabIndex = 5;
            this.ABS_0x5014.TabStop = true;
            this.ABS_0x5014.Text = "0x5014";
            this.ABS_0x5014.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5043
            // 
            this.ABS_0x5043.AutoCheck = false;
            this.ABS_0x5043.AutoSize = true;
            this.ABS_0x5043.Location = new System.Drawing.Point(13, 250);
            this.ABS_0x5043.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ABS_0x5043.Name = "ABS_0x5043";
            this.ABS_0x5043.Size = new System.Drawing.Size(84, 24);
            this.ABS_0x5043.TabIndex = 12;
            this.ABS_0x5043.TabStop = true;
            this.ABS_0x5043.Text = "0x5043";
            this.ABS_0x5043.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5018
            // 
            this.ABS_0x5018.AutoCheck = false;
            this.ABS_0x5018.AutoSize = true;
            this.ABS_0x5018.Location = new System.Drawing.Point(13, 125);
            this.ABS_0x5018.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ABS_0x5018.Name = "ABS_0x5018";
            this.ABS_0x5018.Size = new System.Drawing.Size(84, 24);
            this.ABS_0x5018.TabIndex = 4;
            this.ABS_0x5018.TabStop = true;
            this.ABS_0x5018.Text = "0x5018";
            this.ABS_0x5018.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5035
            // 
            this.ABS_0x5035.AutoCheck = false;
            this.ABS_0x5035.AutoSize = true;
            this.ABS_0x5035.Location = new System.Drawing.Point(13, 225);
            this.ABS_0x5035.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ABS_0x5035.Name = "ABS_0x5035";
            this.ABS_0x5035.Size = new System.Drawing.Size(84, 24);
            this.ABS_0x5035.TabIndex = 11;
            this.ABS_0x5035.TabStop = true;
            this.ABS_0x5035.Text = "0x5035";
            this.ABS_0x5035.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5013
            // 
            this.ABS_0x5013.AutoCheck = false;
            this.ABS_0x5013.AutoSize = true;
            this.ABS_0x5013.Location = new System.Drawing.Point(13, 100);
            this.ABS_0x5013.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ABS_0x5013.Name = "ABS_0x5013";
            this.ABS_0x5013.Size = new System.Drawing.Size(84, 24);
            this.ABS_0x5013.TabIndex = 3;
            this.ABS_0x5013.TabStop = true;
            this.ABS_0x5013.Text = "0x5013";
            this.ABS_0x5013.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5017
            // 
            this.ABS_0x5017.AutoCheck = false;
            this.ABS_0x5017.AutoSize = true;
            this.ABS_0x5017.Location = new System.Drawing.Point(13, 75);
            this.ABS_0x5017.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ABS_0x5017.Name = "ABS_0x5017";
            this.ABS_0x5017.Size = new System.Drawing.Size(84, 24);
            this.ABS_0x5017.TabIndex = 2;
            this.ABS_0x5017.TabStop = true;
            this.ABS_0x5017.Text = "0x5017";
            this.ABS_0x5017.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5019
            // 
            this.ABS_0x5019.AutoCheck = false;
            this.ABS_0x5019.AutoSize = true;
            this.ABS_0x5019.Location = new System.Drawing.Point(13, 49);
            this.ABS_0x5019.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ABS_0x5019.Name = "ABS_0x5019";
            this.ABS_0x5019.Size = new System.Drawing.Size(84, 24);
            this.ABS_0x5019.TabIndex = 1;
            this.ABS_0x5019.TabStop = true;
            this.ABS_0x5019.Text = "0x5019";
            this.ABS_0x5019.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5055
            // 
            this.ABS_0x5055.AutoCheck = false;
            this.ABS_0x5055.AutoSize = true;
            this.ABS_0x5055.Location = new System.Drawing.Point(13, 24);
            this.ABS_0x5055.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ABS_0x5055.Name = "ABS_0x5055";
            this.ABS_0x5055.Size = new System.Drawing.Size(84, 24);
            this.ABS_0x5055.TabIndex = 0;
            this.ABS_0x5055.TabStop = true;
            this.ABS_0x5055.Text = "0x5055";
            this.ABS_0x5055.UseVisualStyleBackColor = true;
            // 
            // Group_OBD_Error_Code
            // 
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_U0486);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_U0426);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_U0122);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_U0121);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_U0002);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_U0140);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_U0001);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_U0128);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P2600);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P2158);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P1800);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P1607);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P1536);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P1310);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0620_PIN31);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P1300);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0620_PIN2);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0A0F);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0606);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0655);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0605);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0650);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0604);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0601);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0560);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0512);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0500);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0480);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0410);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0505);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0352);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0501);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0351);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0336);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0335);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0230);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0217);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0202);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0130);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0201);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0120);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0155);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0115);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0150);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0110);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0135);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0105);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_C0085);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_C0083);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0503);
            this.Group_OBD_Error_Code.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Group_OBD_Error_Code.Location = new System.Drawing.Point(961, 15);
            this.Group_OBD_Error_Code.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Group_OBD_Error_Code.Name = "Group_OBD_Error_Code";
            this.Group_OBD_Error_Code.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Group_OBD_Error_Code.Size = new System.Drawing.Size(309, 685);
            this.Group_OBD_Error_Code.TabIndex = 11;
            this.Group_OBD_Error_Code.TabStop = false;
            this.Group_OBD_Error_Code.Text = "OBD Status";
            // 
            // OBD_U0486
            // 
            this.OBD_U0486.AutoCheck = false;
            this.OBD_U0486.AutoSize = true;
            this.OBD_U0486.Location = new System.Drawing.Point(220, 49);
            this.OBD_U0486.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_U0486.Name = "OBD_U0486";
            this.OBD_U0486.Size = new System.Drawing.Size(80, 24);
            this.OBD_U0486.TabIndex = 52;
            this.OBD_U0486.TabStop = true;
            this.OBD_U0486.Text = "U0486";
            this.OBD_U0486.UseVisualStyleBackColor = true;
            // 
            // OBD_U0426
            // 
            this.OBD_U0426.AutoCheck = false;
            this.OBD_U0426.AutoSize = true;
            this.OBD_U0426.Location = new System.Drawing.Point(220, 24);
            this.OBD_U0426.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_U0426.Name = "OBD_U0426";
            this.OBD_U0426.Size = new System.Drawing.Size(80, 24);
            this.OBD_U0426.TabIndex = 51;
            this.OBD_U0426.TabStop = true;
            this.OBD_U0426.Text = "U0426";
            this.OBD_U0426.UseVisualStyleBackColor = true;
            // 
            // OBD_U0122
            // 
            this.OBD_U0122.AutoCheck = false;
            this.OBD_U0122.AutoSize = true;
            this.OBD_U0122.Location = new System.Drawing.Point(113, 551);
            this.OBD_U0122.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_U0122.Name = "OBD_U0122";
            this.OBD_U0122.Size = new System.Drawing.Size(80, 24);
            this.OBD_U0122.TabIndex = 48;
            this.OBD_U0122.TabStop = true;
            this.OBD_U0122.Text = "U0122";
            this.OBD_U0122.UseVisualStyleBackColor = true;
            // 
            // OBD_U0121
            // 
            this.OBD_U0121.AutoCheck = false;
            this.OBD_U0121.AutoSize = true;
            this.OBD_U0121.Location = new System.Drawing.Point(113, 526);
            this.OBD_U0121.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_U0121.Name = "OBD_U0121";
            this.OBD_U0121.Size = new System.Drawing.Size(80, 24);
            this.OBD_U0121.TabIndex = 47;
            this.OBD_U0121.TabStop = true;
            this.OBD_U0121.Text = "U0121";
            this.OBD_U0121.UseVisualStyleBackColor = true;
            // 
            // OBD_U0002
            // 
            this.OBD_U0002.AutoCheck = false;
            this.OBD_U0002.AutoSize = true;
            this.OBD_U0002.Location = new System.Drawing.Point(113, 501);
            this.OBD_U0002.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_U0002.Name = "OBD_U0002";
            this.OBD_U0002.Size = new System.Drawing.Size(80, 24);
            this.OBD_U0002.TabIndex = 46;
            this.OBD_U0002.TabStop = true;
            this.OBD_U0002.Text = "U0002";
            this.OBD_U0002.UseVisualStyleBackColor = true;
            // 
            // OBD_U0140
            // 
            this.OBD_U0140.AutoCheck = false;
            this.OBD_U0140.AutoSize = true;
            this.OBD_U0140.Location = new System.Drawing.Point(113, 601);
            this.OBD_U0140.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_U0140.Name = "OBD_U0140";
            this.OBD_U0140.Size = new System.Drawing.Size(80, 24);
            this.OBD_U0140.TabIndex = 50;
            this.OBD_U0140.TabStop = true;
            this.OBD_U0140.Text = "U0140";
            this.OBD_U0140.UseVisualStyleBackColor = true;
            // 
            // OBD_U0001
            // 
            this.OBD_U0001.AutoCheck = false;
            this.OBD_U0001.AutoSize = true;
            this.OBD_U0001.Location = new System.Drawing.Point(113, 476);
            this.OBD_U0001.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_U0001.Name = "OBD_U0001";
            this.OBD_U0001.Size = new System.Drawing.Size(80, 24);
            this.OBD_U0001.TabIndex = 45;
            this.OBD_U0001.TabStop = true;
            this.OBD_U0001.Text = "U0001";
            this.OBD_U0001.UseVisualStyleBackColor = true;
            // 
            // OBD_U0128
            // 
            this.OBD_U0128.AutoCheck = false;
            this.OBD_U0128.AutoSize = true;
            this.OBD_U0128.Location = new System.Drawing.Point(113, 576);
            this.OBD_U0128.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_U0128.Name = "OBD_U0128";
            this.OBD_U0128.Size = new System.Drawing.Size(80, 24);
            this.OBD_U0128.TabIndex = 49;
            this.OBD_U0128.TabStop = true;
            this.OBD_U0128.Text = "U0128";
            this.OBD_U0128.UseVisualStyleBackColor = true;
            // 
            // OBD_P2600
            // 
            this.OBD_P2600.AutoCheck = false;
            this.OBD_P2600.AutoSize = true;
            this.OBD_P2600.Location = new System.Drawing.Point(113, 451);
            this.OBD_P2600.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P2600.Name = "OBD_P2600";
            this.OBD_P2600.Size = new System.Drawing.Size(76, 24);
            this.OBD_P2600.TabIndex = 44;
            this.OBD_P2600.TabStop = true;
            this.OBD_P2600.Text = "P2600";
            this.OBD_P2600.UseVisualStyleBackColor = true;
            // 
            // OBD_P2158
            // 
            this.OBD_P2158.AutoCheck = false;
            this.OBD_P2158.AutoSize = true;
            this.OBD_P2158.Location = new System.Drawing.Point(113, 426);
            this.OBD_P2158.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P2158.Name = "OBD_P2158";
            this.OBD_P2158.Size = new System.Drawing.Size(76, 24);
            this.OBD_P2158.TabIndex = 43;
            this.OBD_P2158.TabStop = true;
            this.OBD_P2158.Text = "P2158";
            this.OBD_P2158.UseVisualStyleBackColor = true;
            // 
            // OBD_P1800
            // 
            this.OBD_P1800.AutoCheck = false;
            this.OBD_P1800.AutoSize = true;
            this.OBD_P1800.Location = new System.Drawing.Point(113, 400);
            this.OBD_P1800.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P1800.Name = "OBD_P1800";
            this.OBD_P1800.Size = new System.Drawing.Size(76, 24);
            this.OBD_P1800.TabIndex = 42;
            this.OBD_P1800.TabStop = true;
            this.OBD_P1800.Text = "P1800";
            this.OBD_P1800.UseVisualStyleBackColor = true;
            // 
            // OBD_P1607
            // 
            this.OBD_P1607.AutoCheck = false;
            this.OBD_P1607.AutoSize = true;
            this.OBD_P1607.Location = new System.Drawing.Point(113, 375);
            this.OBD_P1607.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P1607.Name = "OBD_P1607";
            this.OBD_P1607.Size = new System.Drawing.Size(76, 24);
            this.OBD_P1607.TabIndex = 41;
            this.OBD_P1607.TabStop = true;
            this.OBD_P1607.Text = "P1607";
            this.OBD_P1607.UseVisualStyleBackColor = true;
            // 
            // OBD_P1536
            // 
            this.OBD_P1536.AutoCheck = false;
            this.OBD_P1536.AutoSize = true;
            this.OBD_P1536.Location = new System.Drawing.Point(113, 350);
            this.OBD_P1536.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P1536.Name = "OBD_P1536";
            this.OBD_P1536.Size = new System.Drawing.Size(76, 24);
            this.OBD_P1536.TabIndex = 40;
            this.OBD_P1536.TabStop = true;
            this.OBD_P1536.Text = "P1536";
            this.OBD_P1536.UseVisualStyleBackColor = true;
            // 
            // OBD_P1310
            // 
            this.OBD_P1310.AutoCheck = false;
            this.OBD_P1310.AutoSize = true;
            this.OBD_P1310.Location = new System.Drawing.Point(113, 325);
            this.OBD_P1310.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P1310.Name = "OBD_P1310";
            this.OBD_P1310.Size = new System.Drawing.Size(76, 24);
            this.OBD_P1310.TabIndex = 39;
            this.OBD_P1310.TabStop = true;
            this.OBD_P1310.Text = "P1310";
            this.OBD_P1310.UseVisualStyleBackColor = true;
            // 
            // OBD_P0620_PIN31
            // 
            this.OBD_P0620_PIN31.AutoCheck = false;
            this.OBD_P0620_PIN31.AutoSize = true;
            this.OBD_P0620_PIN31.Location = new System.Drawing.Point(113, 200);
            this.OBD_P0620_PIN31.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0620_PIN31.Name = "OBD_P0620_PIN31";
            this.OBD_P0620_PIN31.Size = new System.Drawing.Size(133, 24);
            this.OBD_P0620_PIN31.TabIndex = 34;
            this.OBD_P0620_PIN31.TabStop = true;
            this.OBD_P0620_PIN31.Text = "P0620_PIN31";
            this.OBD_P0620_PIN31.UseVisualStyleBackColor = true;
            // 
            // OBD_P1300
            // 
            this.OBD_P1300.AutoCheck = false;
            this.OBD_P1300.AutoSize = true;
            this.OBD_P1300.Location = new System.Drawing.Point(113, 300);
            this.OBD_P1300.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P1300.Name = "OBD_P1300";
            this.OBD_P1300.Size = new System.Drawing.Size(76, 24);
            this.OBD_P1300.TabIndex = 38;
            this.OBD_P1300.TabStop = true;
            this.OBD_P1300.Text = "P1300";
            this.OBD_P1300.UseVisualStyleBackColor = true;
            // 
            // OBD_P0620_PIN2
            // 
            this.OBD_P0620_PIN2.AutoCheck = false;
            this.OBD_P0620_PIN2.AutoSize = true;
            this.OBD_P0620_PIN2.Location = new System.Drawing.Point(113, 175);
            this.OBD_P0620_PIN2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0620_PIN2.Name = "OBD_P0620_PIN2";
            this.OBD_P0620_PIN2.Size = new System.Drawing.Size(124, 24);
            this.OBD_P0620_PIN2.TabIndex = 33;
            this.OBD_P0620_PIN2.TabStop = true;
            this.OBD_P0620_PIN2.Text = "P0620_PIN2";
            this.OBD_P0620_PIN2.UseVisualStyleBackColor = true;
            // 
            // OBD_P0A0F
            // 
            this.OBD_P0A0F.AutoCheck = false;
            this.OBD_P0A0F.AutoSize = true;
            this.OBD_P0A0F.Location = new System.Drawing.Point(113, 275);
            this.OBD_P0A0F.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0A0F.Name = "OBD_P0A0F";
            this.OBD_P0A0F.Size = new System.Drawing.Size(82, 24);
            this.OBD_P0A0F.TabIndex = 37;
            this.OBD_P0A0F.TabStop = true;
            this.OBD_P0A0F.Text = "P0A0F";
            this.OBD_P0A0F.UseVisualStyleBackColor = true;
            // 
            // OBD_P0606
            // 
            this.OBD_P0606.AutoCheck = false;
            this.OBD_P0606.AutoSize = true;
            this.OBD_P0606.Location = new System.Drawing.Point(113, 150);
            this.OBD_P0606.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0606.Name = "OBD_P0606";
            this.OBD_P0606.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0606.TabIndex = 32;
            this.OBD_P0606.TabStop = true;
            this.OBD_P0606.Text = "P0606";
            this.OBD_P0606.UseVisualStyleBackColor = true;
            // 
            // OBD_P0655
            // 
            this.OBD_P0655.AutoCheck = false;
            this.OBD_P0655.AutoSize = true;
            this.OBD_P0655.Location = new System.Drawing.Point(113, 250);
            this.OBD_P0655.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0655.Name = "OBD_P0655";
            this.OBD_P0655.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0655.TabIndex = 36;
            this.OBD_P0655.TabStop = true;
            this.OBD_P0655.Text = "P0655";
            this.OBD_P0655.UseVisualStyleBackColor = true;
            // 
            // OBD_P0605
            // 
            this.OBD_P0605.AutoCheck = false;
            this.OBD_P0605.AutoSize = true;
            this.OBD_P0605.Location = new System.Drawing.Point(113, 125);
            this.OBD_P0605.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0605.Name = "OBD_P0605";
            this.OBD_P0605.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0605.TabIndex = 31;
            this.OBD_P0605.TabStop = true;
            this.OBD_P0605.Text = "P0605";
            this.OBD_P0605.UseVisualStyleBackColor = true;
            // 
            // OBD_P0650
            // 
            this.OBD_P0650.AutoCheck = false;
            this.OBD_P0650.AutoSize = true;
            this.OBD_P0650.Location = new System.Drawing.Point(113, 225);
            this.OBD_P0650.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0650.Name = "OBD_P0650";
            this.OBD_P0650.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0650.TabIndex = 35;
            this.OBD_P0650.TabStop = true;
            this.OBD_P0650.Text = "P0650";
            this.OBD_P0650.UseVisualStyleBackColor = true;
            // 
            // OBD_P0604
            // 
            this.OBD_P0604.AutoCheck = false;
            this.OBD_P0604.AutoSize = true;
            this.OBD_P0604.Location = new System.Drawing.Point(113, 100);
            this.OBD_P0604.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0604.Name = "OBD_P0604";
            this.OBD_P0604.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0604.TabIndex = 30;
            this.OBD_P0604.TabStop = true;
            this.OBD_P0604.Text = "P0604";
            this.OBD_P0604.UseVisualStyleBackColor = true;
            // 
            // OBD_P0601
            // 
            this.OBD_P0601.AutoCheck = false;
            this.OBD_P0601.AutoSize = true;
            this.OBD_P0601.Location = new System.Drawing.Point(113, 75);
            this.OBD_P0601.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0601.Name = "OBD_P0601";
            this.OBD_P0601.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0601.TabIndex = 29;
            this.OBD_P0601.TabStop = true;
            this.OBD_P0601.Text = "P0601";
            this.OBD_P0601.UseVisualStyleBackColor = true;
            // 
            // OBD_P0560
            // 
            this.OBD_P0560.AutoCheck = false;
            this.OBD_P0560.AutoSize = true;
            this.OBD_P0560.Location = new System.Drawing.Point(113, 49);
            this.OBD_P0560.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0560.Name = "OBD_P0560";
            this.OBD_P0560.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0560.TabIndex = 28;
            this.OBD_P0560.TabStop = true;
            this.OBD_P0560.Text = "P0560";
            this.OBD_P0560.UseVisualStyleBackColor = true;
            // 
            // OBD_P0512
            // 
            this.OBD_P0512.AutoCheck = false;
            this.OBD_P0512.AutoSize = true;
            this.OBD_P0512.Location = new System.Drawing.Point(113, 24);
            this.OBD_P0512.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0512.Name = "OBD_P0512";
            this.OBD_P0512.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0512.TabIndex = 27;
            this.OBD_P0512.TabStop = true;
            this.OBD_P0512.Text = "P0512";
            this.OBD_P0512.UseVisualStyleBackColor = true;
            // 
            // OBD_P0500
            // 
            this.OBD_P0500.AutoCheck = false;
            this.OBD_P0500.AutoSize = true;
            this.OBD_P0500.Location = new System.Drawing.Point(13, 551);
            this.OBD_P0500.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0500.Name = "OBD_P0500";
            this.OBD_P0500.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0500.TabIndex = 24;
            this.OBD_P0500.TabStop = true;
            this.OBD_P0500.Text = "P0500";
            this.OBD_P0500.UseVisualStyleBackColor = true;
            // 
            // OBD_P0480
            // 
            this.OBD_P0480.AutoCheck = false;
            this.OBD_P0480.AutoSize = true;
            this.OBD_P0480.Location = new System.Drawing.Point(13, 526);
            this.OBD_P0480.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0480.Name = "OBD_P0480";
            this.OBD_P0480.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0480.TabIndex = 23;
            this.OBD_P0480.TabStop = true;
            this.OBD_P0480.Text = "P0480";
            this.OBD_P0480.UseVisualStyleBackColor = true;
            // 
            // OBD_P0410
            // 
            this.OBD_P0410.AutoCheck = false;
            this.OBD_P0410.AutoSize = true;
            this.OBD_P0410.Location = new System.Drawing.Point(13, 501);
            this.OBD_P0410.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0410.Name = "OBD_P0410";
            this.OBD_P0410.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0410.TabIndex = 22;
            this.OBD_P0410.TabStop = true;
            this.OBD_P0410.Text = "P0410";
            this.OBD_P0410.UseVisualStyleBackColor = true;
            // 
            // OBD_P0505
            // 
            this.OBD_P0505.AutoCheck = false;
            this.OBD_P0505.AutoSize = true;
            this.OBD_P0505.Location = new System.Drawing.Point(13, 601);
            this.OBD_P0505.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0505.Name = "OBD_P0505";
            this.OBD_P0505.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0505.TabIndex = 26;
            this.OBD_P0505.TabStop = true;
            this.OBD_P0505.Text = "P0505";
            this.OBD_P0505.UseVisualStyleBackColor = true;
            // 
            // OBD_P0352
            // 
            this.OBD_P0352.AutoCheck = false;
            this.OBD_P0352.AutoSize = true;
            this.OBD_P0352.Location = new System.Drawing.Point(13, 476);
            this.OBD_P0352.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0352.Name = "OBD_P0352";
            this.OBD_P0352.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0352.TabIndex = 21;
            this.OBD_P0352.TabStop = true;
            this.OBD_P0352.Text = "P0352";
            this.OBD_P0352.UseVisualStyleBackColor = true;
            // 
            // OBD_P0501
            // 
            this.OBD_P0501.AutoCheck = false;
            this.OBD_P0501.AutoSize = true;
            this.OBD_P0501.Location = new System.Drawing.Point(13, 576);
            this.OBD_P0501.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0501.Name = "OBD_P0501";
            this.OBD_P0501.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0501.TabIndex = 25;
            this.OBD_P0501.TabStop = true;
            this.OBD_P0501.Text = "P0501";
            this.OBD_P0501.UseVisualStyleBackColor = true;
            // 
            // OBD_P0351
            // 
            this.OBD_P0351.AutoCheck = false;
            this.OBD_P0351.AutoSize = true;
            this.OBD_P0351.Location = new System.Drawing.Point(13, 451);
            this.OBD_P0351.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0351.Name = "OBD_P0351";
            this.OBD_P0351.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0351.TabIndex = 20;
            this.OBD_P0351.TabStop = true;
            this.OBD_P0351.Text = "P0351";
            this.OBD_P0351.UseVisualStyleBackColor = true;
            // 
            // OBD_P0336
            // 
            this.OBD_P0336.AutoCheck = false;
            this.OBD_P0336.AutoSize = true;
            this.OBD_P0336.Location = new System.Drawing.Point(13, 426);
            this.OBD_P0336.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0336.Name = "OBD_P0336";
            this.OBD_P0336.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0336.TabIndex = 19;
            this.OBD_P0336.TabStop = true;
            this.OBD_P0336.Text = "P0336";
            this.OBD_P0336.UseVisualStyleBackColor = true;
            // 
            // OBD_P0335
            // 
            this.OBD_P0335.AutoCheck = false;
            this.OBD_P0335.AutoSize = true;
            this.OBD_P0335.Location = new System.Drawing.Point(13, 400);
            this.OBD_P0335.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0335.Name = "OBD_P0335";
            this.OBD_P0335.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0335.TabIndex = 18;
            this.OBD_P0335.TabStop = true;
            this.OBD_P0335.Text = "P0335";
            this.OBD_P0335.UseVisualStyleBackColor = true;
            // 
            // OBD_P0230
            // 
            this.OBD_P0230.AutoCheck = false;
            this.OBD_P0230.AutoSize = true;
            this.OBD_P0230.Location = new System.Drawing.Point(13, 375);
            this.OBD_P0230.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0230.Name = "OBD_P0230";
            this.OBD_P0230.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0230.TabIndex = 17;
            this.OBD_P0230.TabStop = true;
            this.OBD_P0230.Text = "P0230";
            this.OBD_P0230.UseVisualStyleBackColor = true;
            // 
            // OBD_P0217
            // 
            this.OBD_P0217.AutoCheck = false;
            this.OBD_P0217.AutoSize = true;
            this.OBD_P0217.Location = new System.Drawing.Point(13, 350);
            this.OBD_P0217.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0217.Name = "OBD_P0217";
            this.OBD_P0217.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0217.TabIndex = 16;
            this.OBD_P0217.TabStop = true;
            this.OBD_P0217.Text = "P0217";
            this.OBD_P0217.UseVisualStyleBackColor = true;
            // 
            // OBD_P0202
            // 
            this.OBD_P0202.AutoCheck = false;
            this.OBD_P0202.AutoSize = true;
            this.OBD_P0202.Location = new System.Drawing.Point(13, 325);
            this.OBD_P0202.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0202.Name = "OBD_P0202";
            this.OBD_P0202.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0202.TabIndex = 15;
            this.OBD_P0202.TabStop = true;
            this.OBD_P0202.Text = "P0202";
            this.OBD_P0202.UseVisualStyleBackColor = true;
            // 
            // OBD_P0130
            // 
            this.OBD_P0130.AutoCheck = false;
            this.OBD_P0130.AutoSize = true;
            this.OBD_P0130.Location = new System.Drawing.Point(13, 200);
            this.OBD_P0130.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0130.Name = "OBD_P0130";
            this.OBD_P0130.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0130.TabIndex = 7;
            this.OBD_P0130.TabStop = true;
            this.OBD_P0130.Text = "P0130";
            this.OBD_P0130.UseVisualStyleBackColor = true;
            // 
            // OBD_P0201
            // 
            this.OBD_P0201.AutoCheck = false;
            this.OBD_P0201.AutoSize = true;
            this.OBD_P0201.Location = new System.Drawing.Point(13, 300);
            this.OBD_P0201.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0201.Name = "OBD_P0201";
            this.OBD_P0201.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0201.TabIndex = 14;
            this.OBD_P0201.TabStop = true;
            this.OBD_P0201.Text = "P0201";
            this.OBD_P0201.UseVisualStyleBackColor = true;
            // 
            // OBD_P0120
            // 
            this.OBD_P0120.AutoCheck = false;
            this.OBD_P0120.AutoSize = true;
            this.OBD_P0120.Location = new System.Drawing.Point(13, 175);
            this.OBD_P0120.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0120.Name = "OBD_P0120";
            this.OBD_P0120.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0120.TabIndex = 6;
            this.OBD_P0120.TabStop = true;
            this.OBD_P0120.Text = "P0120";
            this.OBD_P0120.UseVisualStyleBackColor = true;
            // 
            // OBD_P0155
            // 
            this.OBD_P0155.AutoCheck = false;
            this.OBD_P0155.AutoSize = true;
            this.OBD_P0155.Location = new System.Drawing.Point(13, 275);
            this.OBD_P0155.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0155.Name = "OBD_P0155";
            this.OBD_P0155.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0155.TabIndex = 13;
            this.OBD_P0155.TabStop = true;
            this.OBD_P0155.Text = "P0155";
            this.OBD_P0155.UseVisualStyleBackColor = true;
            // 
            // OBD_P0115
            // 
            this.OBD_P0115.AutoCheck = false;
            this.OBD_P0115.AutoSize = true;
            this.OBD_P0115.Location = new System.Drawing.Point(13, 150);
            this.OBD_P0115.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0115.Name = "OBD_P0115";
            this.OBD_P0115.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0115.TabIndex = 5;
            this.OBD_P0115.TabStop = true;
            this.OBD_P0115.Text = "P0115";
            this.OBD_P0115.UseVisualStyleBackColor = true;
            // 
            // OBD_P0150
            // 
            this.OBD_P0150.AutoCheck = false;
            this.OBD_P0150.AutoSize = true;
            this.OBD_P0150.Location = new System.Drawing.Point(13, 250);
            this.OBD_P0150.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0150.Name = "OBD_P0150";
            this.OBD_P0150.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0150.TabIndex = 12;
            this.OBD_P0150.TabStop = true;
            this.OBD_P0150.Text = "P0150";
            this.OBD_P0150.UseVisualStyleBackColor = true;
            // 
            // OBD_P0110
            // 
            this.OBD_P0110.AutoCheck = false;
            this.OBD_P0110.AutoSize = true;
            this.OBD_P0110.Location = new System.Drawing.Point(13, 125);
            this.OBD_P0110.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0110.Name = "OBD_P0110";
            this.OBD_P0110.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0110.TabIndex = 4;
            this.OBD_P0110.TabStop = true;
            this.OBD_P0110.Text = "P0110";
            this.OBD_P0110.UseVisualStyleBackColor = true;
            // 
            // OBD_P0135
            // 
            this.OBD_P0135.AutoCheck = false;
            this.OBD_P0135.AutoSize = true;
            this.OBD_P0135.Location = new System.Drawing.Point(13, 225);
            this.OBD_P0135.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0135.Name = "OBD_P0135";
            this.OBD_P0135.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0135.TabIndex = 11;
            this.OBD_P0135.TabStop = true;
            this.OBD_P0135.Text = "P0135";
            this.OBD_P0135.UseVisualStyleBackColor = true;
            // 
            // OBD_P0105
            // 
            this.OBD_P0105.AutoCheck = false;
            this.OBD_P0105.AutoSize = true;
            this.OBD_P0105.Location = new System.Drawing.Point(13, 100);
            this.OBD_P0105.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0105.Name = "OBD_P0105";
            this.OBD_P0105.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0105.TabIndex = 3;
            this.OBD_P0105.TabStop = true;
            this.OBD_P0105.Text = "P0105";
            this.OBD_P0105.UseVisualStyleBackColor = true;
            // 
            // OBD_C0085
            // 
            this.OBD_C0085.AutoCheck = false;
            this.OBD_C0085.AutoSize = true;
            this.OBD_C0085.Location = new System.Drawing.Point(13, 75);
            this.OBD_C0085.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_C0085.Name = "OBD_C0085";
            this.OBD_C0085.Size = new System.Drawing.Size(79, 24);
            this.OBD_C0085.TabIndex = 2;
            this.OBD_C0085.TabStop = true;
            this.OBD_C0085.Text = "C0085";
            this.OBD_C0085.UseVisualStyleBackColor = true;
            // 
            // OBD_C0083
            // 
            this.OBD_C0083.AutoCheck = false;
            this.OBD_C0083.AutoSize = true;
            this.OBD_C0083.Location = new System.Drawing.Point(13, 49);
            this.OBD_C0083.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_C0083.Name = "OBD_C0083";
            this.OBD_C0083.Size = new System.Drawing.Size(79, 24);
            this.OBD_C0083.TabIndex = 1;
            this.OBD_C0083.TabStop = true;
            this.OBD_C0083.Text = "C0083";
            this.OBD_C0083.UseVisualStyleBackColor = true;
            // 
            // OBD_P0503
            // 
            this.OBD_P0503.AutoCheck = false;
            this.OBD_P0503.AutoSize = true;
            this.OBD_P0503.Location = new System.Drawing.Point(13, 24);
            this.OBD_P0503.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OBD_P0503.Name = "OBD_P0503";
            this.OBD_P0503.Size = new System.Drawing.Size(76, 24);
            this.OBD_P0503.TabIndex = 0;
            this.OBD_P0503.TabStop = true;
            this.OBD_P0503.Text = "P0503";
            this.OBD_P0503.UseVisualStyleBackColor = true;
            // 
            // Value_Battery
            // 
            this.Value_Battery.Location = new System.Drawing.Point(450, 213);
            this.Value_Battery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Value_Battery.Name = "Value_Battery";
            this.Value_Battery.ReadOnly = true;
            this.Value_Battery.Size = new System.Drawing.Size(93, 31);
            this.Value_Battery.TabIndex = 27;
            this.Value_Battery.Text = "No Data";
            this.Value_Battery.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_Battery
            // 
            this.Label_Battery.AutoSize = true;
            this.Label_Battery.Location = new System.Drawing.Point(314, 217);
            this.Label_Battery.Name = "Label_Battery";
            this.Label_Battery.Size = new System.Drawing.Size(63, 20);
            this.Label_Battery.TabIndex = 26;
            this.Label_Battery.Text = "Battery";
            // 
            // Value_RoomTemp
            // 
            this.Value_RoomTemp.Location = new System.Drawing.Point(134, 212);
            this.Value_RoomTemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Value_RoomTemp.Name = "Value_RoomTemp";
            this.Value_RoomTemp.ReadOnly = true;
            this.Value_RoomTemp.Size = new System.Drawing.Size(147, 31);
            this.Value_RoomTemp.TabIndex = 23;
            this.Value_RoomTemp.Text = "No Data";
            this.Value_RoomTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value_Fuel
            // 
            this.Value_Fuel.Location = new System.Drawing.Point(450, 176);
            this.Value_Fuel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Value_Fuel.Name = "Value_Fuel";
            this.Value_Fuel.ReadOnly = true;
            this.Value_Fuel.Size = new System.Drawing.Size(93, 31);
            this.Value_Fuel.TabIndex = 25;
            this.Value_Fuel.Text = "No Data";
            this.Value_Fuel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_RoomTemp
            // 
            this.Label_RoomTemp.AutoSize = true;
            this.Label_RoomTemp.Location = new System.Drawing.Point(6, 215);
            this.Label_RoomTemp.Name = "Label_RoomTemp";
            this.Label_RoomTemp.Size = new System.Drawing.Size(102, 20);
            this.Label_RoomTemp.TabIndex = 22;
            this.Label_RoomTemp.Text = "Temperature";
            // 
            // Label_Fuel
            // 
            this.Label_Fuel.AutoSize = true;
            this.Label_Fuel.Location = new System.Drawing.Point(314, 180);
            this.Label_Fuel.Name = "Label_Fuel";
            this.Label_Fuel.Size = new System.Drawing.Size(41, 20);
            this.Label_Fuel.TabIndex = 24;
            this.Label_Fuel.Text = "Fuel";
            // 
            // Value_WaterTemp
            // 
            this.Value_WaterTemp.Location = new System.Drawing.Point(134, 175);
            this.Value_WaterTemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Value_WaterTemp.Name = "Value_WaterTemp";
            this.Value_WaterTemp.ReadOnly = true;
            this.Value_WaterTemp.Size = new System.Drawing.Size(147, 31);
            this.Value_WaterTemp.TabIndex = 21;
            this.Value_WaterTemp.Text = "No Data";
            this.Value_WaterTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_WaterTemp
            // 
            this.Label_WaterTemp.AutoSize = true;
            this.Label_WaterTemp.Location = new System.Drawing.Point(6, 180);
            this.Label_WaterTemp.Name = "Label_WaterTemp";
            this.Label_WaterTemp.Size = new System.Drawing.Size(102, 20);
            this.Label_WaterTemp.TabIndex = 20;
            this.Label_WaterTemp.Text = "Water Temp";
            // 
            // Group_Driving_Status
            // 
            this.Group_Driving_Status.Controls.Add(this.Label_FuelConsumption_02);
            this.Group_Driving_Status.Controls.Add(this.Value_FuelConsumption_02);
            this.Group_Driving_Status.Controls.Add(this.Value_Battery);
            this.Group_Driving_Status.Controls.Add(this.Label_Battery);
            this.Group_Driving_Status.Controls.Add(this.Value_RoomTemp);
            this.Group_Driving_Status.Controls.Add(this.Value_Fuel);
            this.Group_Driving_Status.Controls.Add(this.Label_RoomTemp);
            this.Group_Driving_Status.Controls.Add(this.Label_Fuel);
            this.Group_Driving_Status.Controls.Add(this.Value_WaterTemp);
            this.Group_Driving_Status.Controls.Add(this.Label_WaterTemp);
            this.Group_Driving_Status.Controls.Add(this.Value_AveSpeed);
            this.Group_Driving_Status.Controls.Add(this.Value_FuelConsumption);
            this.Group_Driving_Status.Controls.Add(this.Label_AveSpeed);
            this.Group_Driving_Status.Controls.Add(this.Label_FuelConsumption);
            this.Group_Driving_Status.Controls.Add(this.Value_MaxSpeed);
            this.Group_Driving_Status.Controls.Add(this.Label_MaxSpeed);
            this.Group_Driving_Status.Controls.Add(this.Value_EngineRPM);
            this.Group_Driving_Status.Controls.Add(this.Value_TotalMileage);
            this.Group_Driving_Status.Controls.Add(this.Label_EngineRPM);
            this.Group_Driving_Status.Controls.Add(this.Label_TotalMileage);
            this.Group_Driving_Status.Controls.Add(this.Value_Speed);
            this.Group_Driving_Status.Controls.Add(this.Label_Speed);
            this.Group_Driving_Status.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Group_Driving_Status.Location = new System.Drawing.Point(240, 216);
            this.Group_Driving_Status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Group_Driving_Status.Name = "Group_Driving_Status";
            this.Group_Driving_Status.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Group_Driving_Status.Size = new System.Drawing.Size(558, 261);
            this.Group_Driving_Status.TabIndex = 12;
            this.Group_Driving_Status.TabStop = false;
            this.Group_Driving_Status.Text = "Driving Status";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Controls.Add(this.button_StartCAN);
            this.groupBox5.Controls.Add(this.button_StopCAN);
            this.groupBox5.Controls.Add(this.button_Clear);
            this.groupBox5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox5.Location = new System.Drawing.Point(1290, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(789, 312);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "GroupBox_CAN_Parameter";
            // 
            // textbox_Connection_Message
            // 
            this.textbox_Connection_Message.Font = new System.Drawing.Font("新細明體", 12F);
            this.textbox_Connection_Message.Location = new System.Drawing.Point(12, 12);
            this.textbox_Connection_Message.Name = "textbox_Connection_Message";
            this.textbox_Connection_Message.ReadOnly = true;
            this.textbox_Connection_Message.Size = new System.Drawing.Size(611, 31);
            this.textbox_Connection_Message.TabIndex = 14;
            this.textbox_Connection_Message.Text = "Please click [Connect] button to start";
            // 
            // Value_FuelConsumption_02
            // 
            this.Value_FuelConsumption_02.Location = new System.Drawing.Point(134, 136);
            this.Value_FuelConsumption_02.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Value_FuelConsumption_02.Name = "Value_FuelConsumption_02";
            this.Value_FuelConsumption_02.ReadOnly = true;
            this.Value_FuelConsumption_02.Size = new System.Drawing.Size(147, 31);
            this.Value_FuelConsumption_02.TabIndex = 28;
            this.Value_FuelConsumption_02.Text = "No Data";
            this.Value_FuelConsumption_02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_FuelConsumption_02
            // 
            this.Label_FuelConsumption_02.AutoSize = true;
            this.Label_FuelConsumption_02.Location = new System.Drawing.Point(6, 140);
            this.Label_FuelConsumption_02.Name = "Label_FuelConsumption_02";
            this.Label_FuelConsumption_02.Size = new System.Drawing.Size(108, 20);
            this.Label_FuelConsumption_02.TabIndex = 29;
            this.Label_FuelConsumption_02.Text = "Consumption";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 483);
            this.Controls.Add(this.textbox_Connection_Message);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Group_Driving_Status);
            this.Controls.Add(this.Group_OBD_Error_Code);
            this.Controls.Add(this.Group_ABS_Error_Code);
            this.Controls.Add(this.Group_Car_Status_Indicator);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.buttonConnect);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "USB CAN Tool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.Group_Car_Status_Indicator.ResumeLayout(false);
            this.Group_Car_Status_Indicator.PerformLayout();
            this.Group_ABS_Error_Code.ResumeLayout(false);
            this.Group_ABS_Error_Code.PerformLayout();
            this.Group_OBD_Error_Code.ResumeLayout(false);
            this.Group_OBD_Error_Code.PerformLayout();
            this.Group_Driving_Status.ResumeLayout(false);
            this.Group_Driving_Status.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBox_CANIndex;
        private System.Windows.Forms.ComboBox comboBox_DevIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Time1;
        private System.Windows.Forms.TextBox textBox_AccMask;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Time0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_AccCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Mode;
        private System.Windows.Forms.ComboBox comboBox_Filter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_StartCAN;
        private System.Windows.Forms.Button button_StopCAN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox_FrameFormat;
        private System.Windows.Forms.ComboBox comboBox_FrameType;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Data;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox_Info;
        private System.Windows.Forms.Timer timer_rec;
        private System.Windows.Forms.ComboBox comboBox_devtype;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.GroupBox Group_Car_Status_Indicator;
        private System.Windows.Forms.RadioButton Status_RearTirePressure;
        private System.Windows.Forms.RadioButton Status_FrontTirePressure;
        private System.Windows.Forms.RadioButton Status_Maintenance;
        private System.Windows.Forms.RadioButton Status_WaterTemp;
        private System.Windows.Forms.RadioButton Status_ABS;
        private System.Windows.Forms.RadioButton Status_Fuel;
        private System.Windows.Forms.RadioButton Status_EngineOil;
        private System.Windows.Forms.RadioButton Status_OnOff;
        private System.Windows.Forms.TextBox Value_FuelConsumption;
        private System.Windows.Forms.Label Label_FuelConsumption;
        private System.Windows.Forms.TextBox Value_EngineRPM;
        private System.Windows.Forms.Label Label_EngineRPM;
        private System.Windows.Forms.TextBox Value_Speed;
        private System.Windows.Forms.Label Label_Speed;
        private System.Windows.Forms.TextBox Value_AveSpeed;
        private System.Windows.Forms.Label Label_AveSpeed;
        private System.Windows.Forms.TextBox Value_MaxSpeed;
        private System.Windows.Forms.Label Label_MaxSpeed;
        private System.Windows.Forms.TextBox Value_TotalMileage;
        private System.Windows.Forms.Label Label_TotalMileage;
        private System.Windows.Forms.GroupBox Group_ABS_Error_Code;
        private System.Windows.Forms.RadioButton ABS_0x5052;
        private System.Windows.Forms.RadioButton ABS_0x5053;
        private System.Windows.Forms.RadioButton ABS_0x5014;
        private System.Windows.Forms.RadioButton ABS_0x5018;
        private System.Windows.Forms.RadioButton ABS_0x5013;
        private System.Windows.Forms.RadioButton ABS_0x5017;
        private System.Windows.Forms.RadioButton ABS_0x5019;
        private System.Windows.Forms.RadioButton ABS_0x5055;
        private System.Windows.Forms.RadioButton ABS_0x5025;
        private System.Windows.Forms.RadioButton ABS_0x5044;
        private System.Windows.Forms.RadioButton ABS_0x5042;
        private System.Windows.Forms.RadioButton ABS_0x5045;
        private System.Windows.Forms.RadioButton ABS_0x5043;
        private System.Windows.Forms.RadioButton ABS_0x5035;
        private System.Windows.Forms.GroupBox Group_OBD_Error_Code;
        private System.Windows.Forms.RadioButton OBD_P0217;
        private System.Windows.Forms.RadioButton OBD_P0202;
        private System.Windows.Forms.RadioButton OBD_P0130;
        private System.Windows.Forms.RadioButton OBD_P0201;
        private System.Windows.Forms.RadioButton OBD_P0120;
        private System.Windows.Forms.RadioButton OBD_P0155;
        private System.Windows.Forms.RadioButton OBD_P0115;
        private System.Windows.Forms.RadioButton OBD_P0150;
        private System.Windows.Forms.RadioButton OBD_P0110;
        private System.Windows.Forms.RadioButton OBD_P0135;
        private System.Windows.Forms.RadioButton OBD_P0105;
        private System.Windows.Forms.RadioButton OBD_C0085;
        private System.Windows.Forms.RadioButton OBD_C0083;
        private System.Windows.Forms.RadioButton OBD_P0503;
        private System.Windows.Forms.RadioButton OBD_P0500;
        private System.Windows.Forms.RadioButton OBD_P0480;
        private System.Windows.Forms.RadioButton OBD_P0410;
        private System.Windows.Forms.RadioButton OBD_P0505;
        private System.Windows.Forms.RadioButton OBD_P0352;
        private System.Windows.Forms.RadioButton OBD_P0501;
        private System.Windows.Forms.RadioButton OBD_P0351;
        private System.Windows.Forms.RadioButton OBD_P0336;
        private System.Windows.Forms.RadioButton OBD_P0335;
        private System.Windows.Forms.RadioButton OBD_P0230;
        private System.Windows.Forms.RadioButton OBD_U0486;
        private System.Windows.Forms.RadioButton OBD_U0426;
        private System.Windows.Forms.RadioButton OBD_U0122;
        private System.Windows.Forms.RadioButton OBD_U0121;
        private System.Windows.Forms.RadioButton OBD_U0002;
        private System.Windows.Forms.RadioButton OBD_U0140;
        private System.Windows.Forms.RadioButton OBD_U0001;
        private System.Windows.Forms.RadioButton OBD_U0128;
        private System.Windows.Forms.RadioButton OBD_P2600;
        private System.Windows.Forms.RadioButton OBD_P2158;
        private System.Windows.Forms.RadioButton OBD_P1800;
        private System.Windows.Forms.RadioButton OBD_P1607;
        private System.Windows.Forms.RadioButton OBD_P1536;
        private System.Windows.Forms.RadioButton OBD_P1310;
        private System.Windows.Forms.RadioButton OBD_P0620_PIN31;
        private System.Windows.Forms.RadioButton OBD_P1300;
        private System.Windows.Forms.RadioButton OBD_P0620_PIN2;
        private System.Windows.Forms.RadioButton OBD_P0A0F;
        private System.Windows.Forms.RadioButton OBD_P0606;
        private System.Windows.Forms.RadioButton OBD_P0655;
        private System.Windows.Forms.RadioButton OBD_P0605;
        private System.Windows.Forms.RadioButton OBD_P0650;
        private System.Windows.Forms.RadioButton OBD_P0604;
        private System.Windows.Forms.RadioButton OBD_P0601;
        private System.Windows.Forms.RadioButton OBD_P0560;
        private System.Windows.Forms.RadioButton OBD_P0512;
        private System.Windows.Forms.TextBox Value_Battery;
        private System.Windows.Forms.Label Label_Battery;
        private System.Windows.Forms.TextBox Value_RoomTemp;
        private System.Windows.Forms.TextBox Value_Fuel;
        private System.Windows.Forms.Label Label_RoomTemp;
        private System.Windows.Forms.Label Label_Fuel;
        private System.Windows.Forms.TextBox Value_WaterTemp;
        private System.Windows.Forms.Label Label_WaterTemp;
        private System.Windows.Forms.GroupBox Group_Driving_Status;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textbox_Connection_Message;
        private System.Windows.Forms.TextBox Value_FuelConsumption_02;
        private System.Windows.Forms.Label Label_FuelConsumption_02;
    }
}

