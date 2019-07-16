namespace WindowsApplication1
{
    partial class Form1
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Status_OnOff = new System.Windows.Forms.RadioButton();
            this.Status_EngineOil = new System.Windows.Forms.RadioButton();
            this.Status_Fuel = new System.Windows.Forms.RadioButton();
            this.Status_ABS = new System.Windows.Forms.RadioButton();
            this.Status_WaterTemp = new System.Windows.Forms.RadioButton();
            this.Status_Maintenance = new System.Windows.Forms.RadioButton();
            this.Status_FrontTirePressure = new System.Windows.Forms.RadioButton();
            this.Status_RearTirePressure = new System.Windows.Forms.RadioButton();
            this.Label_Speed = new System.Windows.Forms.Label();
            this.Value_Speed = new System.Windows.Forms.TextBox();
            this.Value_EngineRPM = new System.Windows.Forms.TextBox();
            this.Label_EngineRPM = new System.Windows.Forms.Label();
            this.Value_FuelConsumption = new System.Windows.Forms.TextBox();
            this.Label_FuelConsumption = new System.Windows.Forms.Label();
            this.Value_AveSpeed = new System.Windows.Forms.TextBox();
            this.Label_AveSpeed = new System.Windows.Forms.Label();
            this.Value_MaxSpeed = new System.Windows.Forms.TextBox();
            this.Label_MaxSpeed = new System.Windows.Forms.Label();
            this.Value_TotalMileage = new System.Windows.Forms.TextBox();
            this.Label_TotalMileage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(567, 172);
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
            this.comboBox_devtype.Size = new System.Drawing.Size(160, 23);
            this.comboBox_devtype.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 29);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 15);
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
            this.groupBox2.Size = new System.Drawing.Size(540, 96);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "初始化CAN参数";
            // 
            // textBox_Time1
            // 
            this.textBox_Time1.Location = new System.Drawing.Point(291, 58);
            this.textBox_Time1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Time1.Name = "textBox_Time1";
            this.textBox_Time1.Size = new System.Drawing.Size(36, 25);
            this.textBox_Time1.TabIndex = 1;
            // 
            // textBox_AccMask
            // 
            this.textBox_AccMask.Location = new System.Drawing.Point(99, 58);
            this.textBox_AccMask.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_AccMask.Name = "textBox_AccMask";
            this.textBox_AccMask.Size = new System.Drawing.Size(92, 25);
            this.textBox_AccMask.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
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
            this.comboBox_Mode.Location = new System.Drawing.Point(423, 60);
            this.comboBox_Mode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Mode.Name = "comboBox_Mode";
            this.comboBox_Mode.Size = new System.Drawing.Size(92, 23);
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
            this.comboBox_Filter.Location = new System.Drawing.Point(423, 26);
            this.comboBox_Filter.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Filter.Name = "comboBox_Filter";
            this.comboBox_Filter.Size = new System.Drawing.Size(92, 23);
            this.comboBox_Filter.TabIndex = 1;
            // 
            // textBox_Time0
            // 
            this.textBox_Time0.Location = new System.Drawing.Point(291, 24);
            this.textBox_Time0.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Time0.Name = "textBox_Time0";
            this.textBox_Time0.Size = new System.Drawing.Size(36, 25);
            this.textBox_Time0.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "模式:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "滤波方式:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "屏蔽码:0x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "定时器0:0x";
            // 
            // textBox_AccCode
            // 
            this.textBox_AccCode.Location = new System.Drawing.Point(99, 24);
            this.textBox_AccCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_AccCode.Name = "textBox_AccCode";
            this.textBox_AccCode.Size = new System.Drawing.Size(92, 25);
            this.textBox_AccCode.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
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
            this.comboBox_CANIndex.Location = new System.Drawing.Point(491, 29);
            this.comboBox_CANIndex.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_CANIndex.Name = "comboBox_CANIndex";
            this.comboBox_CANIndex.Size = new System.Drawing.Size(61, 23);
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
            this.comboBox_DevIndex.Location = new System.Drawing.Point(317, 29);
            this.comboBox_DevIndex.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_DevIndex.Name = "comboBox_DevIndex";
            this.comboBox_DevIndex.Size = new System.Drawing.Size(53, 23);
            this.comboBox_DevIndex.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "第几路CAN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "索引号:";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(603, 49);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(100, 29);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "连接";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // button_StartCAN
            // 
            this.button_StartCAN.Location = new System.Drawing.Point(603, 109);
            this.button_StartCAN.Margin = new System.Windows.Forms.Padding(4);
            this.button_StartCAN.Name = "button_StartCAN";
            this.button_StartCAN.Size = new System.Drawing.Size(100, 29);
            this.button_StartCAN.TabIndex = 5;
            this.button_StartCAN.Text = "启动CAN";
            this.button_StartCAN.UseVisualStyleBackColor = true;
            this.button_StartCAN.Click += new System.EventHandler(this.button_StartCAN_Click);
            // 
            // button_StopCAN
            // 
            this.button_StopCAN.Location = new System.Drawing.Point(603, 181);
            this.button_StopCAN.Margin = new System.Windows.Forms.Padding(4);
            this.button_StopCAN.Name = "button_StopCAN";
            this.button_StopCAN.Size = new System.Drawing.Size(100, 29);
            this.button_StopCAN.TabIndex = 5;
            this.button_StopCAN.Text = "复位CAN";
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
            this.groupBox3.Location = new System.Drawing.Point(16, 195);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(567, 101);
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
            this.comboBox_FrameFormat.Size = new System.Drawing.Size(92, 23);
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
            this.comboBox_FrameType.Size = new System.Drawing.Size(92, 23);
            this.comboBox_FrameType.TabIndex = 1;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(433, 59);
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
            this.label11.Size = new System.Drawing.Size(56, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "帧格式:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "帧类型:";
            // 
            // textBox_Data
            // 
            this.textBox_Data.Location = new System.Drawing.Point(75, 60);
            this.textBox_Data.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Data.Name = "textBox_Data";
            this.textBox_Data.Size = new System.Drawing.Size(333, 25);
            this.textBox_Data.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 68);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "数据:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(429, 22);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(92, 25);
            this.textBox_ID.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(363, 30);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "帧ID:0x";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox_Info);
            this.groupBox4.Location = new System.Drawing.Point(16, 304);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(707, 160);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "信息";
            // 
            // listBox_Info
            // 
            this.listBox_Info.FormattingEnabled = true;
            this.listBox_Info.ItemHeight = 15;
            this.listBox_Info.Location = new System.Drawing.Point(13, 25);
            this.listBox_Info.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_Info.Name = "listBox_Info";
            this.listBox_Info.Size = new System.Drawing.Size(679, 124);
            this.listBox_Info.TabIndex = 0;
            // 
            // timer_rec
            // 
            this.timer_rec.Tick += new System.EventHandler(this.timer_rec_Tick);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(603, 249);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(100, 29);
            this.button_Clear.TabIndex = 8;
            this.button_Clear.Text = "清空列表";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Value_AveSpeed);
            this.groupBox5.Controls.Add(this.Value_FuelConsumption);
            this.groupBox5.Controls.Add(this.Label_AveSpeed);
            this.groupBox5.Controls.Add(this.Label_FuelConsumption);
            this.groupBox5.Controls.Add(this.Value_MaxSpeed);
            this.groupBox5.Controls.Add(this.Label_MaxSpeed);
            this.groupBox5.Controls.Add(this.Value_EngineRPM);
            this.groupBox5.Controls.Add(this.Value_TotalMileage);
            this.groupBox5.Controls.Add(this.Label_EngineRPM);
            this.groupBox5.Controls.Add(this.Label_TotalMileage);
            this.groupBox5.Controls.Add(this.Value_Speed);
            this.groupBox5.Controls.Add(this.Label_Speed);
            this.groupBox5.Controls.Add(this.Status_RearTirePressure);
            this.groupBox5.Controls.Add(this.Status_FrontTirePressure);
            this.groupBox5.Controls.Add(this.Status_Maintenance);
            this.groupBox5.Controls.Add(this.Status_WaterTemp);
            this.groupBox5.Controls.Add(this.Status_ABS);
            this.groupBox5.Controls.Add(this.Status_Fuel);
            this.groupBox5.Controls.Add(this.Status_EngineOil);
            this.groupBox5.Controls.Add(this.Status_OnOff);
            this.groupBox5.Location = new System.Drawing.Point(16, 471);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(707, 230);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CAN Data Visualizer";
            // 
            // Status_OnOff
            // 
            this.Status_OnOff.AutoCheck = false;
            this.Status_OnOff.AutoSize = true;
            this.Status_OnOff.Location = new System.Drawing.Point(13, 24);
            this.Status_OnOff.Name = "Status_OnOff";
            this.Status_OnOff.Size = new System.Drawing.Size(103, 19);
            this.Status_OnOff.TabIndex = 0;
            this.Status_OnOff.TabStop = true;
            this.Status_OnOff.Text = "開機指示燈";
            this.Status_OnOff.UseVisualStyleBackColor = true;
            // 
            // Status_EngineOil
            // 
            this.Status_EngineOil.AutoCheck = false;
            this.Status_EngineOil.AutoSize = true;
            this.Status_EngineOil.Location = new System.Drawing.Point(13, 49);
            this.Status_EngineOil.Name = "Status_EngineOil";
            this.Status_EngineOil.Size = new System.Drawing.Size(133, 19);
            this.Status_EngineOil.TabIndex = 1;
            this.Status_EngineOil.TabStop = true;
            this.Status_EngineOil.Text = "機油壓力指示燈";
            this.Status_EngineOil.UseVisualStyleBackColor = true;
            // 
            // Status_Fuel
            // 
            this.Status_Fuel.AutoCheck = false;
            this.Status_Fuel.AutoSize = true;
            this.Status_Fuel.Location = new System.Drawing.Point(13, 75);
            this.Status_Fuel.Name = "Status_Fuel";
            this.Status_Fuel.Size = new System.Drawing.Size(73, 19);
            this.Status_Fuel.TabIndex = 2;
            this.Status_Fuel.TabStop = true;
            this.Status_Fuel.Text = "燃油燈";
            this.Status_Fuel.UseVisualStyleBackColor = true;
            // 
            // Status_ABS
            // 
            this.Status_ABS.AutoCheck = false;
            this.Status_ABS.AutoSize = true;
            this.Status_ABS.Location = new System.Drawing.Point(13, 100);
            this.Status_ABS.Name = "Status_ABS";
            this.Status_ABS.Size = new System.Drawing.Size(100, 19);
            this.Status_ABS.TabIndex = 3;
            this.Status_ABS.TabStop = true;
            this.Status_ABS.Text = "ABS故障燈";
            this.Status_ABS.UseVisualStyleBackColor = true;
            // 
            // Status_WaterTemp
            // 
            this.Status_WaterTemp.AutoCheck = false;
            this.Status_WaterTemp.AutoSize = true;
            this.Status_WaterTemp.Location = new System.Drawing.Point(13, 125);
            this.Status_WaterTemp.Name = "Status_WaterTemp";
            this.Status_WaterTemp.Size = new System.Drawing.Size(73, 19);
            this.Status_WaterTemp.TabIndex = 4;
            this.Status_WaterTemp.TabStop = true;
            this.Status_WaterTemp.Text = "水溫燈";
            this.Status_WaterTemp.UseVisualStyleBackColor = true;
            // 
            // Status_Maintenance
            // 
            this.Status_Maintenance.AutoCheck = false;
            this.Status_Maintenance.AutoSize = true;
            this.Status_Maintenance.Location = new System.Drawing.Point(13, 150);
            this.Status_Maintenance.Name = "Status_Maintenance";
            this.Status_Maintenance.Size = new System.Drawing.Size(133, 19);
            this.Status_Maintenance.TabIndex = 5;
            this.Status_Maintenance.TabStop = true;
            this.Status_Maintenance.Text = "保養提示指示燈";
            this.Status_Maintenance.UseVisualStyleBackColor = true;
            // 
            // Status_FrontTirePressure
            // 
            this.Status_FrontTirePressure.AutoCheck = false;
            this.Status_FrontTirePressure.AutoSize = true;
            this.Status_FrontTirePressure.Location = new System.Drawing.Point(13, 175);
            this.Status_FrontTirePressure.Name = "Status_FrontTirePressure";
            this.Status_FrontTirePressure.Size = new System.Drawing.Size(148, 19);
            this.Status_FrontTirePressure.TabIndex = 6;
            this.Status_FrontTirePressure.TabStop = true;
            this.Status_FrontTirePressure.Text = "前輪胎胎壓指示燈";
            this.Status_FrontTirePressure.UseVisualStyleBackColor = true;
            // 
            // Status_RearTirePressure
            // 
            this.Status_RearTirePressure.AutoCheck = false;
            this.Status_RearTirePressure.AutoSize = true;
            this.Status_RearTirePressure.Location = new System.Drawing.Point(13, 200);
            this.Status_RearTirePressure.Name = "Status_RearTirePressure";
            this.Status_RearTirePressure.Size = new System.Drawing.Size(148, 19);
            this.Status_RearTirePressure.TabIndex = 7;
            this.Status_RearTirePressure.TabStop = true;
            this.Status_RearTirePressure.Text = "後輪胎胎壓指示燈";
            this.Status_RearTirePressure.UseVisualStyleBackColor = true;
            // 
            // Label_Speed
            // 
            this.Label_Speed.AutoSize = true;
            this.Label_Speed.Location = new System.Drawing.Point(168, 26);
            this.Label_Speed.Name = "Label_Speed";
            this.Label_Speed.Size = new System.Drawing.Size(84, 15);
            this.Label_Speed.TabIndex = 8;
            this.Label_Speed.Text = "Speed (km/h)";
            // 
            // Value_Speed
            // 
            this.Value_Speed.Location = new System.Drawing.Point(298, 23);
            this.Value_Speed.Name = "Value_Speed";
            this.Value_Speed.ReadOnly = true;
            this.Value_Speed.Size = new System.Drawing.Size(93, 25);
            this.Value_Speed.TabIndex = 9;
            this.Value_Speed.Text = "0";
            this.Value_Speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value_EngineRPM
            // 
            this.Value_EngineRPM.Location = new System.Drawing.Point(298, 60);
            this.Value_EngineRPM.Name = "Value_EngineRPM";
            this.Value_EngineRPM.ReadOnly = true;
            this.Value_EngineRPM.Size = new System.Drawing.Size(93, 25);
            this.Value_EngineRPM.TabIndex = 11;
            this.Value_EngineRPM.Text = "0";
            this.Value_EngineRPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_EngineRPM
            // 
            this.Label_EngineRPM.AutoSize = true;
            this.Label_EngineRPM.Location = new System.Drawing.Point(168, 63);
            this.Label_EngineRPM.Name = "Label_EngineRPM";
            this.Label_EngineRPM.Size = new System.Drawing.Size(90, 15);
            this.Label_EngineRPM.TabIndex = 10;
            this.Label_EngineRPM.Text = "Engine - RPM";
            // 
            // Value_FuelConsumption
            // 
            this.Value_FuelConsumption.Location = new System.Drawing.Point(298, 97);
            this.Value_FuelConsumption.Name = "Value_FuelConsumption";
            this.Value_FuelConsumption.ReadOnly = true;
            this.Value_FuelConsumption.Size = new System.Drawing.Size(93, 25);
            this.Value_FuelConsumption.TabIndex = 13;
            this.Value_FuelConsumption.Text = "0";
            this.Value_FuelConsumption.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_FuelConsumption
            // 
            this.Label_FuelConsumption.AutoSize = true;
            this.Label_FuelConsumption.Location = new System.Drawing.Point(168, 100);
            this.Label_FuelConsumption.Name = "Label_FuelConsumption";
            this.Label_FuelConsumption.Size = new System.Drawing.Size(117, 15);
            this.Label_FuelConsumption.TabIndex = 12;
            this.Label_FuelConsumption.Text = "Consumption km/L";
            // 
            // Value_AveSpeed
            // 
            this.Value_AveSpeed.Location = new System.Drawing.Point(557, 97);
            this.Value_AveSpeed.Name = "Value_AveSpeed";
            this.Value_AveSpeed.ReadOnly = true;
            this.Value_AveSpeed.Size = new System.Drawing.Size(93, 25);
            this.Value_AveSpeed.TabIndex = 19;
            this.Value_AveSpeed.Text = "0";
            this.Value_AveSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_AveSpeed
            // 
            this.Label_AveSpeed.AutoSize = true;
            this.Label_AveSpeed.Location = new System.Drawing.Point(427, 100);
            this.Label_AveSpeed.Name = "Label_AveSpeed";
            this.Label_AveSpeed.Size = new System.Drawing.Size(92, 15);
            this.Label_AveSpeed.TabIndex = 18;
            this.Label_AveSpeed.Text = "Average Speed";
            // 
            // Value_MaxSpeed
            // 
            this.Value_MaxSpeed.Location = new System.Drawing.Point(557, 60);
            this.Value_MaxSpeed.Name = "Value_MaxSpeed";
            this.Value_MaxSpeed.ReadOnly = true;
            this.Value_MaxSpeed.Size = new System.Drawing.Size(93, 25);
            this.Value_MaxSpeed.TabIndex = 17;
            this.Value_MaxSpeed.Text = "0";
            this.Value_MaxSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_MaxSpeed
            // 
            this.Label_MaxSpeed.AutoSize = true;
            this.Label_MaxSpeed.Location = new System.Drawing.Point(427, 63);
            this.Label_MaxSpeed.Name = "Label_MaxSpeed";
            this.Label_MaxSpeed.Size = new System.Drawing.Size(71, 15);
            this.Label_MaxSpeed.TabIndex = 16;
            this.Label_MaxSpeed.Text = "Max Speed";
            // 
            // Value_TotalMileage
            // 
            this.Value_TotalMileage.Location = new System.Drawing.Point(557, 23);
            this.Value_TotalMileage.Name = "Value_TotalMileage";
            this.Value_TotalMileage.ReadOnly = true;
            this.Value_TotalMileage.Size = new System.Drawing.Size(93, 25);
            this.Value_TotalMileage.TabIndex = 15;
            this.Value_TotalMileage.Text = "0";
            this.Value_TotalMileage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_TotalMileage
            // 
            this.Label_TotalMileage.AutoSize = true;
            this.Label_TotalMileage.Location = new System.Drawing.Point(427, 26);
            this.Label_TotalMileage.Name = "Label_TotalMileage";
            this.Label_TotalMileage.Size = new System.Drawing.Size(47, 15);
            this.Label_TotalMileage.TabIndex = 14;
            this.Label_TotalMileage.Text = "Milage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 708);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_StopCAN);
            this.Controls.Add(this.button_StartCAN);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "USB CAN Demo(创芯光电科技有限公司)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox5;
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
    }
}

