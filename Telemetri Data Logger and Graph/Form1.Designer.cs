namespace Telemetri_Data_Logger_and_Graph
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PictureBoxConnectionStatue = new System.Windows.Forms.PictureBox();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.ButtonDisconnect = new System.Windows.Forms.Button();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ComboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxPort = new System.Windows.Forms.ComboBox();
            this.ButtonScanPort = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.modbus_master_clock = new System.Windows.Forms.Timer(this.components);
            this.BMS_Voltage1_Label = new System.Windows.Forms.Label();
            this.BMS_Voltage2_Label = new System.Windows.Forms.Label();
            this.BMS_Voltage3_Label = new System.Windows.Forms.Label();
            this.BMS_Voltage4_Label = new System.Windows.Forms.Label();
            this.BMS_Voltage5_Label = new System.Windows.Forms.Label();
            this.BMS_Voltage6_Label = new System.Windows.Forms.Label();
            this.BMS_Voltage7_Label = new System.Windows.Forms.Label();
            this.BMS_Voltage8_Label = new System.Windows.Forms.Label();
            this.BMS_Voltage9_Label = new System.Windows.Forms.Label();
            this.BMS_Voltage10_Label = new System.Windows.Forms.Label();
            this.BMS_Voltage11_Label = new System.Windows.Forms.Label();
            this.BMS_Voltage12_Label = new System.Windows.Forms.Label();
            this.BMS_Voltage13_Label = new System.Windows.Forms.Label();
            this.BMS_Voltage14_Label = new System.Windows.Forms.Label();
            this.BMS_Voltage15_Label = new System.Windows.Forms.Label();
            this.BMS_Voltage16_Label = new System.Windows.Forms.Label();
            this.BMS_Voltage17_Label = new System.Windows.Forms.Label();
            this.BMS_Voltage18_Label = new System.Windows.Forms.Label();
            this.BMS_Voltage19_Label = new System.Windows.Forms.Label();
            this.BMS_Voltage20_Label = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BMS_Voltage21_Label = new System.Windows.Forms.Label();
            this.BMS_Voltage22_Label = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.BMS_Voltage23_Label = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.BMS_Voltage24_Label = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.BMS_Voltage25_Label = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.BMS_Voltage26_Label = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.BMS_Voltage27_Label = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.BMS_Voltage28_Label = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.BMS_Voltage29_Label = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.BMS_Voltage30_Label = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.BMS_Voltage31_Label = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.BMS_Voltage32_Label = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BattTemp30_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Data_Time_Label = new System.Windows.Forms.Label();
            this.BattTemp29_Label = new System.Windows.Forms.Label();
            this.BattTemp28_Label = new System.Windows.Forms.Label();
            this.BattTemp27_Label = new System.Windows.Forms.Label();
            this.BattTemp26_Label = new System.Windows.Forms.Label();
            this.BattTemp25_Label = new System.Windows.Forms.Label();
            this.BattTemp18_Label = new System.Windows.Forms.Label();
            this.BattTemp20_Label = new System.Windows.Forms.Label();
            this.BattTemp16_Label = new System.Windows.Forms.Label();
            this.BattTemp24_Label = new System.Windows.Forms.Label();
            this.BattTemp15_Label = new System.Windows.Forms.Label();
            this.BattTemp19_Label = new System.Windows.Forms.Label();
            this.BattTemp17_Label = new System.Windows.Forms.Label();
            this.BattTemp23_Label = new System.Windows.Forms.Label();
            this.BattTemp13_Label = new System.Windows.Forms.Label();
            this.BattTemp21_Label = new System.Windows.Forms.Label();
            this.BattTemp14_Label = new System.Windows.Forms.Label();
            this.BattTemp22_Label = new System.Windows.Forms.Label();
            this.BattTemp6_Label = new System.Windows.Forms.Label();
            this.BattTemp8_Label = new System.Windows.Forms.Label();
            this.BattTemp4_Label = new System.Windows.Forms.Label();
            this.BattTemp12_Label = new System.Windows.Forms.Label();
            this.BattTemp3_Label = new System.Windows.Forms.Label();
            this.BattTemp7_Label = new System.Windows.Forms.Label();
            this.BattTemp5_Label = new System.Windows.Forms.Label();
            this.BattTemp11_Label = new System.Windows.Forms.Label();
            this.BattTemp1_Label = new System.Windows.Forms.Label();
            this.BattTemp9_Label = new System.Windows.Forms.Label();
            this.BattTemp2_Label = new System.Windows.Forms.Label();
            this.BattTemp10_Label = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Speed_Label = new System.Windows.Forms.Label();
            this.PVEnergy_Label = new System.Windows.Forms.Label();
            this.BattVoltage_Label = new System.Windows.Forms.Label();
            this.CabinTemp_Label = new System.Windows.Forms.Label();
            this.PVCurrent_Label = new System.Windows.Forms.Label();
            this.BattEnergy_Label = new System.Windows.Forms.Label();
            this.BattCurrent_Label = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Motor_Current_Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.GPS_Height_Label = new System.Windows.Forms.Label();
            this.GPS_Speed_Label = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.Longitude_Label = new System.Windows.Forms.Label();
            this.Latitude_Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.AccelZ_Label = new System.Windows.Forms.Label();
            this.AccelX_Label = new System.Windows.Forms.Label();
            this.AccelY_Label = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.GyroZ_Label = new System.Windows.Forms.Label();
            this.GyroX_Label = new System.Windows.Forms.Label();
            this.GyroY_Label = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.Roll_Label = new System.Windows.Forms.Label();
            this.Yaw_Label = new System.Windows.Forms.Label();
            this.Pitch_Label = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.Roll = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.PV_T1_Label = new System.Windows.Forms.Label();
            this.PV_T2_Label = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.Motor_T3_Label = new System.Windows.Forms.Label();
            this.Motor_T1_Label = new System.Windows.Forms.Label();
            this.Motor_T2_Label = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.MPPT_T2_Label = new System.Windows.Forms.Label();
            this.Pilot_Uyari_Label = new System.Windows.Forms.Label();
            this.MPPT_T1_Label = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graph_clock = new System.Windows.Forms.Timer(this.components);
            this.Button1Minute = new System.Windows.Forms.Button();
            this.Button30Seccond = new System.Windows.Forms.Button();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxConnectionStatue)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PictureBoxConnectionStatue);
            this.groupBox1.Controls.Add(this.LabelStatus);
            this.groupBox1.Controls.Add(this.ButtonDisconnect);
            this.groupBox1.Controls.Add(this.ButtonConnect);
            this.groupBox1.Controls.Add(this.ComboBoxBaudRate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ComboBoxPort);
            this.groupBox1.Controls.Add(this.ButtonScanPort);
            this.groupBox1.Location = new System.Drawing.Point(700, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // PictureBoxConnectionStatue
            // 
            this.PictureBoxConnectionStatue.Image = global::Telemetri_Data_Logger_and_Graph.Properties.Resources.red;
            this.PictureBoxConnectionStatue.Location = new System.Drawing.Point(431, 1);
            this.PictureBoxConnectionStatue.Name = "PictureBoxConnectionStatue";
            this.PictureBoxConnectionStatue.Size = new System.Drawing.Size(13, 13);
            this.PictureBoxConnectionStatue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxConnectionStatue.TabIndex = 1;
            this.PictureBoxConnectionStatue.TabStop = false;
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Location = new System.Drawing.Point(323, 1);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(109, 13);
            this.LabelStatus.TabIndex = 1;
            this.LabelStatus.Text = "Status: Disconnected";
            // 
            // ButtonDisconnect
            // 
            this.ButtonDisconnect.Location = new System.Drawing.Point(251, 71);
            this.ButtonDisconnect.Name = "ButtonDisconnect";
            this.ButtonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.ButtonDisconnect.TabIndex = 5;
            this.ButtonDisconnect.Text = "Disconnect";
            this.ButtonDisconnect.UseVisualStyleBackColor = true;
            this.ButtonDisconnect.Click += new System.EventHandler(this.ButtonDisconnect_Click);
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(166, 71);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(75, 23);
            this.ButtonConnect.TabIndex = 4;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ComboBoxBaudRate
            // 
            this.ComboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxBaudRate.FormattingEnabled = true;
            this.ComboBoxBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.ComboBoxBaudRate.Location = new System.Drawing.Point(310, 38);
            this.ComboBoxBaudRate.Name = "ComboBoxBaudRate";
            this.ComboBoxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxBaudRate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Baud Rate: ";
            // 
            // ComboBoxPort
            // 
            this.ComboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPort.FormattingEnabled = true;
            this.ComboBoxPort.Location = new System.Drawing.Point(113, 38);
            this.ComboBoxPort.Name = "ComboBoxPort";
            this.ComboBoxPort.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxPort.TabIndex = 1;
            // 
            // ButtonScanPort
            // 
            this.ButtonScanPort.Location = new System.Drawing.Point(32, 36);
            this.ButtonScanPort.Name = "ButtonScanPort";
            this.ButtonScanPort.Size = new System.Drawing.Size(75, 23);
            this.ButtonScanPort.TabIndex = 0;
            this.ButtonScanPort.Text = "Scan Port";
            this.ButtonScanPort.UseVisualStyleBackColor = true;
            this.ButtonScanPort.Click += new System.EventHandler(this.ButtonScanPort_Click);
            // 
            // modbus_master_clock
            // 
            this.modbus_master_clock.Enabled = true;
            this.modbus_master_clock.Interval = 1;
            this.modbus_master_clock.Tick += new System.EventHandler(this.modbus_master_clock_Tick);
            // 
            // BMS_Voltage1_Label
            // 
            this.BMS_Voltage1_Label.AutoSize = true;
            this.BMS_Voltage1_Label.Location = new System.Drawing.Point(78, 21);
            this.BMS_Voltage1_Label.Name = "BMS_Voltage1_Label";
            this.BMS_Voltage1_Label.Size = new System.Drawing.Size(35, 13);
            this.BMS_Voltage1_Label.TabIndex = 6;
            this.BMS_Voltage1_Label.Text = "label6";
            // 
            // BMS_Voltage2_Label
            // 
            this.BMS_Voltage2_Label.AutoSize = true;
            this.BMS_Voltage2_Label.Location = new System.Drawing.Point(78, 40);
            this.BMS_Voltage2_Label.Name = "BMS_Voltage2_Label";
            this.BMS_Voltage2_Label.Size = new System.Drawing.Size(35, 13);
            this.BMS_Voltage2_Label.TabIndex = 7;
            this.BMS_Voltage2_Label.Text = "label7";
            // 
            // BMS_Voltage3_Label
            // 
            this.BMS_Voltage3_Label.AutoSize = true;
            this.BMS_Voltage3_Label.Location = new System.Drawing.Point(78, 60);
            this.BMS_Voltage3_Label.Name = "BMS_Voltage3_Label";
            this.BMS_Voltage3_Label.Size = new System.Drawing.Size(35, 13);
            this.BMS_Voltage3_Label.TabIndex = 8;
            this.BMS_Voltage3_Label.Text = "label8";
            // 
            // BMS_Voltage4_Label
            // 
            this.BMS_Voltage4_Label.AutoSize = true;
            this.BMS_Voltage4_Label.Location = new System.Drawing.Point(78, 83);
            this.BMS_Voltage4_Label.Name = "BMS_Voltage4_Label";
            this.BMS_Voltage4_Label.Size = new System.Drawing.Size(35, 13);
            this.BMS_Voltage4_Label.TabIndex = 9;
            this.BMS_Voltage4_Label.Text = "label9";
            // 
            // BMS_Voltage5_Label
            // 
            this.BMS_Voltage5_Label.AutoSize = true;
            this.BMS_Voltage5_Label.Location = new System.Drawing.Point(78, 105);
            this.BMS_Voltage5_Label.Name = "BMS_Voltage5_Label";
            this.BMS_Voltage5_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage5_Label.TabIndex = 10;
            this.BMS_Voltage5_Label.Text = "label10";
            // 
            // BMS_Voltage6_Label
            // 
            this.BMS_Voltage6_Label.AutoSize = true;
            this.BMS_Voltage6_Label.Location = new System.Drawing.Point(78, 127);
            this.BMS_Voltage6_Label.Name = "BMS_Voltage6_Label";
            this.BMS_Voltage6_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage6_Label.TabIndex = 11;
            this.BMS_Voltage6_Label.Text = "label11";
            // 
            // BMS_Voltage7_Label
            // 
            this.BMS_Voltage7_Label.AutoSize = true;
            this.BMS_Voltage7_Label.Location = new System.Drawing.Point(78, 149);
            this.BMS_Voltage7_Label.Name = "BMS_Voltage7_Label";
            this.BMS_Voltage7_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage7_Label.TabIndex = 12;
            this.BMS_Voltage7_Label.Text = "label12";
            // 
            // BMS_Voltage8_Label
            // 
            this.BMS_Voltage8_Label.AutoSize = true;
            this.BMS_Voltage8_Label.Location = new System.Drawing.Point(78, 171);
            this.BMS_Voltage8_Label.Name = "BMS_Voltage8_Label";
            this.BMS_Voltage8_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage8_Label.TabIndex = 13;
            this.BMS_Voltage8_Label.Text = "label13";
            // 
            // BMS_Voltage9_Label
            // 
            this.BMS_Voltage9_Label.AutoSize = true;
            this.BMS_Voltage9_Label.Location = new System.Drawing.Point(78, 195);
            this.BMS_Voltage9_Label.Name = "BMS_Voltage9_Label";
            this.BMS_Voltage9_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage9_Label.TabIndex = 14;
            this.BMS_Voltage9_Label.Text = "label14";
            // 
            // BMS_Voltage10_Label
            // 
            this.BMS_Voltage10_Label.AutoSize = true;
            this.BMS_Voltage10_Label.Location = new System.Drawing.Point(78, 217);
            this.BMS_Voltage10_Label.Name = "BMS_Voltage10_Label";
            this.BMS_Voltage10_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage10_Label.TabIndex = 15;
            this.BMS_Voltage10_Label.Text = "label15";
            // 
            // BMS_Voltage11_Label
            // 
            this.BMS_Voltage11_Label.AutoSize = true;
            this.BMS_Voltage11_Label.Location = new System.Drawing.Point(78, 239);
            this.BMS_Voltage11_Label.Name = "BMS_Voltage11_Label";
            this.BMS_Voltage11_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage11_Label.TabIndex = 16;
            this.BMS_Voltage11_Label.Text = "label16";
            // 
            // BMS_Voltage12_Label
            // 
            this.BMS_Voltage12_Label.AutoSize = true;
            this.BMS_Voltage12_Label.Location = new System.Drawing.Point(78, 262);
            this.BMS_Voltage12_Label.Name = "BMS_Voltage12_Label";
            this.BMS_Voltage12_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage12_Label.TabIndex = 17;
            this.BMS_Voltage12_Label.Text = "label17";
            // 
            // BMS_Voltage13_Label
            // 
            this.BMS_Voltage13_Label.AutoSize = true;
            this.BMS_Voltage13_Label.Location = new System.Drawing.Point(78, 287);
            this.BMS_Voltage13_Label.Name = "BMS_Voltage13_Label";
            this.BMS_Voltage13_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage13_Label.TabIndex = 18;
            this.BMS_Voltage13_Label.Text = "label18";
            // 
            // BMS_Voltage14_Label
            // 
            this.BMS_Voltage14_Label.AutoSize = true;
            this.BMS_Voltage14_Label.Location = new System.Drawing.Point(78, 311);
            this.BMS_Voltage14_Label.Name = "BMS_Voltage14_Label";
            this.BMS_Voltage14_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage14_Label.TabIndex = 19;
            this.BMS_Voltage14_Label.Text = "label19";
            // 
            // BMS_Voltage15_Label
            // 
            this.BMS_Voltage15_Label.AutoSize = true;
            this.BMS_Voltage15_Label.Location = new System.Drawing.Point(78, 334);
            this.BMS_Voltage15_Label.Name = "BMS_Voltage15_Label";
            this.BMS_Voltage15_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage15_Label.TabIndex = 20;
            this.BMS_Voltage15_Label.Text = "label20";
            // 
            // BMS_Voltage16_Label
            // 
            this.BMS_Voltage16_Label.AutoSize = true;
            this.BMS_Voltage16_Label.Location = new System.Drawing.Point(78, 360);
            this.BMS_Voltage16_Label.Name = "BMS_Voltage16_Label";
            this.BMS_Voltage16_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage16_Label.TabIndex = 21;
            this.BMS_Voltage16_Label.Text = "label21";
            // 
            // BMS_Voltage17_Label
            // 
            this.BMS_Voltage17_Label.AutoSize = true;
            this.BMS_Voltage17_Label.Location = new System.Drawing.Point(78, 382);
            this.BMS_Voltage17_Label.Name = "BMS_Voltage17_Label";
            this.BMS_Voltage17_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage17_Label.TabIndex = 22;
            this.BMS_Voltage17_Label.Text = "label22";
            // 
            // BMS_Voltage18_Label
            // 
            this.BMS_Voltage18_Label.AutoSize = true;
            this.BMS_Voltage18_Label.Location = new System.Drawing.Point(78, 405);
            this.BMS_Voltage18_Label.Name = "BMS_Voltage18_Label";
            this.BMS_Voltage18_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage18_Label.TabIndex = 23;
            this.BMS_Voltage18_Label.Text = "label23";
            // 
            // BMS_Voltage19_Label
            // 
            this.BMS_Voltage19_Label.AutoSize = true;
            this.BMS_Voltage19_Label.Location = new System.Drawing.Point(78, 428);
            this.BMS_Voltage19_Label.Name = "BMS_Voltage19_Label";
            this.BMS_Voltage19_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage19_Label.TabIndex = 24;
            this.BMS_Voltage19_Label.Text = "label24";
            // 
            // BMS_Voltage20_Label
            // 
            this.BMS_Voltage20_Label.AutoSize = true;
            this.BMS_Voltage20_Label.Location = new System.Drawing.Point(78, 448);
            this.BMS_Voltage20_Label.Name = "BMS_Voltage20_Label";
            this.BMS_Voltage20_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage20_Label.TabIndex = 25;
            this.BMS_Voltage20_Label.Text = "label25";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BMS_Voltage21_Label);
            this.groupBox4.Controls.Add(this.BMS_Voltage22_Label);
            this.groupBox4.Controls.Add(this.label45);
            this.groupBox4.Controls.Add(this.BMS_Voltage23_Label);
            this.groupBox4.Controls.Add(this.label46);
            this.groupBox4.Controls.Add(this.BMS_Voltage24_Label);
            this.groupBox4.Controls.Add(this.label47);
            this.groupBox4.Controls.Add(this.BMS_Voltage3_Label);
            this.groupBox4.Controls.Add(this.BMS_Voltage12_Label);
            this.groupBox4.Controls.Add(this.label48);
            this.groupBox4.Controls.Add(this.BMS_Voltage13_Label);
            this.groupBox4.Controls.Add(this.BMS_Voltage25_Label);
            this.groupBox4.Controls.Add(this.BMS_Voltage11_Label);
            this.groupBox4.Controls.Add(this.BMS_Voltage14_Label);
            this.groupBox4.Controls.Add(this.BMS_Voltage10_Label);
            this.groupBox4.Controls.Add(this.BMS_Voltage15_Label);
            this.groupBox4.Controls.Add(this.label50);
            this.groupBox4.Controls.Add(this.BMS_Voltage9_Label);
            this.groupBox4.Controls.Add(this.BMS_Voltage26_Label);
            this.groupBox4.Controls.Add(this.BMS_Voltage16_Label);
            this.groupBox4.Controls.Add(this.BMS_Voltage8_Label);
            this.groupBox4.Controls.Add(this.BMS_Voltage17_Label);
            this.groupBox4.Controls.Add(this.label52);
            this.groupBox4.Controls.Add(this.BMS_Voltage7_Label);
            this.groupBox4.Controls.Add(this.BMS_Voltage27_Label);
            this.groupBox4.Controls.Add(this.BMS_Voltage18_Label);
            this.groupBox4.Controls.Add(this.BMS_Voltage6_Label);
            this.groupBox4.Controls.Add(this.BMS_Voltage19_Label);
            this.groupBox4.Controls.Add(this.label54);
            this.groupBox4.Controls.Add(this.BMS_Voltage5_Label);
            this.groupBox4.Controls.Add(this.BMS_Voltage28_Label);
            this.groupBox4.Controls.Add(this.BMS_Voltage20_Label);
            this.groupBox4.Controls.Add(this.BMS_Voltage4_Label);
            this.groupBox4.Controls.Add(this.BMS_Voltage2_Label);
            this.groupBox4.Controls.Add(this.label56);
            this.groupBox4.Controls.Add(this.BMS_Voltage1_Label);
            this.groupBox4.Controls.Add(this.BMS_Voltage29_Label);
            this.groupBox4.Controls.Add(this.label58);
            this.groupBox4.Controls.Add(this.BMS_Voltage30_Label);
            this.groupBox4.Controls.Add(this.label60);
            this.groupBox4.Controls.Add(this.BMS_Voltage31_Label);
            this.groupBox4.Controls.Add(this.label62);
            this.groupBox4.Controls.Add(this.BMS_Voltage32_Label);
            this.groupBox4.Controls.Add(this.label64);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Controls.Add(this.label35);
            this.groupBox4.Controls.Add(this.label36);
            this.groupBox4.Controls.Add(this.label37);
            this.groupBox4.Controls.Add(this.label38);
            this.groupBox4.Controls.Add(this.label39);
            this.groupBox4.Controls.Add(this.label40);
            this.groupBox4.Controls.Add(this.label41);
            this.groupBox4.Controls.Add(this.label42);
            this.groupBox4.Controls.Add(this.label43);
            this.groupBox4.Controls.Add(this.label44);
            this.groupBox4.Location = new System.Drawing.Point(38, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(305, 475);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Battery Voltages";
            // 
            // BMS_Voltage21_Label
            // 
            this.BMS_Voltage21_Label.AutoSize = true;
            this.BMS_Voltage21_Label.Location = new System.Drawing.Point(231, 16);
            this.BMS_Voltage21_Label.Name = "BMS_Voltage21_Label";
            this.BMS_Voltage21_Label.Size = new System.Drawing.Size(35, 13);
            this.BMS_Voltage21_Label.TabIndex = 27;
            this.BMS_Voltage21_Label.Text = "label6";
            // 
            // BMS_Voltage22_Label
            // 
            this.BMS_Voltage22_Label.AutoSize = true;
            this.BMS_Voltage22_Label.Location = new System.Drawing.Point(231, 35);
            this.BMS_Voltage22_Label.Name = "BMS_Voltage22_Label";
            this.BMS_Voltage22_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage22_Label.TabIndex = 28;
            this.BMS_Voltage22_Label.Text = "label66";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(153, 16);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(58, 13);
            this.label45.TabIndex = 46;
            this.label45.Text = "Voltage 21";
            // 
            // BMS_Voltage23_Label
            // 
            this.BMS_Voltage23_Label.AutoSize = true;
            this.BMS_Voltage23_Label.Location = new System.Drawing.Point(231, 55);
            this.BMS_Voltage23_Label.Name = "BMS_Voltage23_Label";
            this.BMS_Voltage23_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage23_Label.TabIndex = 29;
            this.BMS_Voltage23_Label.Text = "label67";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(153, 35);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(58, 13);
            this.label46.TabIndex = 47;
            this.label46.Text = "Voltage 22";
            // 
            // BMS_Voltage24_Label
            // 
            this.BMS_Voltage24_Label.AutoSize = true;
            this.BMS_Voltage24_Label.Location = new System.Drawing.Point(231, 78);
            this.BMS_Voltage24_Label.Name = "BMS_Voltage24_Label";
            this.BMS_Voltage24_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage24_Label.TabIndex = 30;
            this.BMS_Voltage24_Label.Text = "label68";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(153, 55);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(58, 13);
            this.label47.TabIndex = 48;
            this.label47.Text = "Voltage 23";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(153, 78);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(58, 13);
            this.label48.TabIndex = 49;
            this.label48.Text = "Voltage 24";
            // 
            // BMS_Voltage25_Label
            // 
            this.BMS_Voltage25_Label.AutoSize = true;
            this.BMS_Voltage25_Label.Location = new System.Drawing.Point(231, 100);
            this.BMS_Voltage25_Label.Name = "BMS_Voltage25_Label";
            this.BMS_Voltage25_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage25_Label.TabIndex = 31;
            this.BMS_Voltage25_Label.Text = "label70";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(153, 100);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(58, 13);
            this.label50.TabIndex = 50;
            this.label50.Text = "Voltage 25";
            // 
            // BMS_Voltage26_Label
            // 
            this.BMS_Voltage26_Label.AutoSize = true;
            this.BMS_Voltage26_Label.Location = new System.Drawing.Point(231, 122);
            this.BMS_Voltage26_Label.Name = "BMS_Voltage26_Label";
            this.BMS_Voltage26_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage26_Label.TabIndex = 32;
            this.BMS_Voltage26_Label.Text = "label72";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(153, 122);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(58, 13);
            this.label52.TabIndex = 51;
            this.label52.Text = "Voltage 26";
            // 
            // BMS_Voltage27_Label
            // 
            this.BMS_Voltage27_Label.AutoSize = true;
            this.BMS_Voltage27_Label.Location = new System.Drawing.Point(231, 144);
            this.BMS_Voltage27_Label.Name = "BMS_Voltage27_Label";
            this.BMS_Voltage27_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage27_Label.TabIndex = 33;
            this.BMS_Voltage27_Label.Text = "label74";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(153, 144);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(58, 13);
            this.label54.TabIndex = 52;
            this.label54.Text = "Voltage 27";
            // 
            // BMS_Voltage28_Label
            // 
            this.BMS_Voltage28_Label.AutoSize = true;
            this.BMS_Voltage28_Label.Location = new System.Drawing.Point(231, 168);
            this.BMS_Voltage28_Label.Name = "BMS_Voltage28_Label";
            this.BMS_Voltage28_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage28_Label.TabIndex = 34;
            this.BMS_Voltage28_Label.Text = "label76";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(153, 168);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(58, 13);
            this.label56.TabIndex = 53;
            this.label56.Text = "Voltage 28";
            // 
            // BMS_Voltage29_Label
            // 
            this.BMS_Voltage29_Label.AutoSize = true;
            this.BMS_Voltage29_Label.Location = new System.Drawing.Point(231, 190);
            this.BMS_Voltage29_Label.Name = "BMS_Voltage29_Label";
            this.BMS_Voltage29_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage29_Label.TabIndex = 35;
            this.BMS_Voltage29_Label.Text = "label78";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(153, 190);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(58, 13);
            this.label58.TabIndex = 54;
            this.label58.Text = "Voltage 29";
            // 
            // BMS_Voltage30_Label
            // 
            this.BMS_Voltage30_Label.AutoSize = true;
            this.BMS_Voltage30_Label.Location = new System.Drawing.Point(231, 212);
            this.BMS_Voltage30_Label.Name = "BMS_Voltage30_Label";
            this.BMS_Voltage30_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage30_Label.TabIndex = 36;
            this.BMS_Voltage30_Label.Text = "label80";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(153, 212);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(58, 13);
            this.label60.TabIndex = 55;
            this.label60.Text = "Voltage 30";
            // 
            // BMS_Voltage31_Label
            // 
            this.BMS_Voltage31_Label.AutoSize = true;
            this.BMS_Voltage31_Label.Location = new System.Drawing.Point(231, 234);
            this.BMS_Voltage31_Label.Name = "BMS_Voltage31_Label";
            this.BMS_Voltage31_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage31_Label.TabIndex = 37;
            this.BMS_Voltage31_Label.Text = "label82";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(153, 234);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(58, 13);
            this.label62.TabIndex = 56;
            this.label62.Text = "Voltage 31";
            // 
            // BMS_Voltage32_Label
            // 
            this.BMS_Voltage32_Label.AutoSize = true;
            this.BMS_Voltage32_Label.Location = new System.Drawing.Point(231, 257);
            this.BMS_Voltage32_Label.Name = "BMS_Voltage32_Label";
            this.BMS_Voltage32_Label.Size = new System.Drawing.Size(41, 13);
            this.BMS_Voltage32_Label.TabIndex = 38;
            this.BMS_Voltage32_Label.Text = "label84";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(153, 257);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(58, 13);
            this.label64.TabIndex = 57;
            this.label64.Text = "Voltage 32";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Voltage 1";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 40);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(52, 13);
            this.label26.TabIndex = 27;
            this.label26.Text = "Voltage 2";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 60);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(52, 13);
            this.label27.TabIndex = 28;
            this.label27.Text = "Voltage 3";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 83);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(52, 13);
            this.label28.TabIndex = 29;
            this.label28.Text = "Voltage 4";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 448);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(58, 13);
            this.label29.TabIndex = 45;
            this.label29.Text = "Voltage 20";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 105);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(52, 13);
            this.label30.TabIndex = 30;
            this.label30.Text = "Voltage 5";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 428);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(58, 13);
            this.label31.TabIndex = 44;
            this.label31.Text = "Voltage 19";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 127);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(52, 13);
            this.label32.TabIndex = 31;
            this.label32.Text = "Voltage 6";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 405);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(58, 13);
            this.label33.TabIndex = 43;
            this.label33.Text = "Voltage 18";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 149);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(52, 13);
            this.label34.TabIndex = 32;
            this.label34.Text = "Voltage 7";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 382);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(58, 13);
            this.label35.TabIndex = 42;
            this.label35.Text = "Voltage 17";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 171);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(52, 13);
            this.label36.TabIndex = 33;
            this.label36.Text = "Voltage 8";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(6, 360);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(58, 13);
            this.label37.TabIndex = 41;
            this.label37.Text = "Voltage 16";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(6, 195);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(52, 13);
            this.label38.TabIndex = 34;
            this.label38.Text = "Voltage 9";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(6, 334);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(58, 13);
            this.label39.TabIndex = 40;
            this.label39.Text = "Voltage 15";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(6, 217);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(58, 13);
            this.label40.TabIndex = 35;
            this.label40.Text = "Voltage 10";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(6, 311);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(58, 13);
            this.label41.TabIndex = 39;
            this.label41.Text = "Voltage 14";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(6, 239);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(58, 13);
            this.label42.TabIndex = 36;
            this.label42.Text = "Voltage 11";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(6, 287);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(58, 13);
            this.label43.TabIndex = 38;
            this.label43.Text = "Voltage 13";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(6, 262);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(58, 13);
            this.label44.TabIndex = 37;
            this.label44.Text = "Voltage 12";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BattTemp30_Label);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.Data_Time_Label);
            this.groupBox5.Controls.Add(this.BattTemp29_Label);
            this.groupBox5.Controls.Add(this.BattTemp28_Label);
            this.groupBox5.Controls.Add(this.BattTemp27_Label);
            this.groupBox5.Controls.Add(this.BattTemp26_Label);
            this.groupBox5.Controls.Add(this.BattTemp25_Label);
            this.groupBox5.Controls.Add(this.BattTemp18_Label);
            this.groupBox5.Controls.Add(this.BattTemp20_Label);
            this.groupBox5.Controls.Add(this.BattTemp16_Label);
            this.groupBox5.Controls.Add(this.BattTemp24_Label);
            this.groupBox5.Controls.Add(this.BattTemp15_Label);
            this.groupBox5.Controls.Add(this.BattTemp19_Label);
            this.groupBox5.Controls.Add(this.BattTemp17_Label);
            this.groupBox5.Controls.Add(this.BattTemp23_Label);
            this.groupBox5.Controls.Add(this.BattTemp13_Label);
            this.groupBox5.Controls.Add(this.BattTemp21_Label);
            this.groupBox5.Controls.Add(this.BattTemp14_Label);
            this.groupBox5.Controls.Add(this.BattTemp22_Label);
            this.groupBox5.Controls.Add(this.BattTemp6_Label);
            this.groupBox5.Controls.Add(this.BattTemp8_Label);
            this.groupBox5.Controls.Add(this.BattTemp4_Label);
            this.groupBox5.Controls.Add(this.BattTemp12_Label);
            this.groupBox5.Controls.Add(this.BattTemp3_Label);
            this.groupBox5.Controls.Add(this.BattTemp7_Label);
            this.groupBox5.Controls.Add(this.BattTemp5_Label);
            this.groupBox5.Controls.Add(this.BattTemp11_Label);
            this.groupBox5.Controls.Add(this.BattTemp1_Label);
            this.groupBox5.Controls.Add(this.BattTemp9_Label);
            this.groupBox5.Controls.Add(this.BattTemp2_Label);
            this.groupBox5.Controls.Add(this.BattTemp10_Label);
            this.groupBox5.Controls.Add(this.label67);
            this.groupBox5.Controls.Add(this.label66);
            this.groupBox5.Controls.Add(this.label65);
            this.groupBox5.Controls.Add(this.label63);
            this.groupBox5.Controls.Add(this.label61);
            this.groupBox5.Controls.Add(this.label59);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.label49);
            this.groupBox5.Controls.Add(this.label51);
            this.groupBox5.Controls.Add(this.label53);
            this.groupBox5.Controls.Add(this.label55);
            this.groupBox5.Controls.Add(this.label57);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Location = new System.Drawing.Point(362, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(153, 468);
            this.groupBox5.TabIndex = 52;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Battery Temperatures";
            // 
            // BattTemp30_Label
            // 
            this.BattTemp30_Label.AutoSize = true;
            this.BattTemp30_Label.Location = new System.Drawing.Point(50, 421);
            this.BattTemp30_Label.Name = "BattTemp30_Label";
            this.BattTemp30_Label.Size = new System.Drawing.Size(26, 13);
            this.BattTemp30_Label.TabIndex = 98;
            this.BattTemp30_Label.Text = "T30";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 132;
            this.label3.Text = "Data Time:";
            // 
            // Data_Time_Label
            // 
            this.Data_Time_Label.AutoSize = true;
            this.Data_Time_Label.Location = new System.Drawing.Point(60, 451);
            this.Data_Time_Label.Name = "Data_Time_Label";
            this.Data_Time_Label.Size = new System.Drawing.Size(35, 13);
            this.Data_Time_Label.TabIndex = 131;
            this.Data_Time_Label.Text = "label3";
            // 
            // BattTemp29_Label
            // 
            this.BattTemp29_Label.AutoSize = true;
            this.BattTemp29_Label.Location = new System.Drawing.Point(50, 408);
            this.BattTemp29_Label.Name = "BattTemp29_Label";
            this.BattTemp29_Label.Size = new System.Drawing.Size(26, 13);
            this.BattTemp29_Label.TabIndex = 97;
            this.BattTemp29_Label.Text = "T29";
            // 
            // BattTemp28_Label
            // 
            this.BattTemp28_Label.AutoSize = true;
            this.BattTemp28_Label.Location = new System.Drawing.Point(50, 396);
            this.BattTemp28_Label.Name = "BattTemp28_Label";
            this.BattTemp28_Label.Size = new System.Drawing.Size(26, 13);
            this.BattTemp28_Label.TabIndex = 96;
            this.BattTemp28_Label.Text = "T28";
            // 
            // BattTemp27_Label
            // 
            this.BattTemp27_Label.AutoSize = true;
            this.BattTemp27_Label.Location = new System.Drawing.Point(50, 383);
            this.BattTemp27_Label.Name = "BattTemp27_Label";
            this.BattTemp27_Label.Size = new System.Drawing.Size(26, 13);
            this.BattTemp27_Label.TabIndex = 95;
            this.BattTemp27_Label.Text = "T27";
            // 
            // BattTemp26_Label
            // 
            this.BattTemp26_Label.AutoSize = true;
            this.BattTemp26_Label.Location = new System.Drawing.Point(50, 370);
            this.BattTemp26_Label.Name = "BattTemp26_Label";
            this.BattTemp26_Label.Size = new System.Drawing.Size(26, 13);
            this.BattTemp26_Label.TabIndex = 94;
            this.BattTemp26_Label.Text = "T26";
            // 
            // BattTemp25_Label
            // 
            this.BattTemp25_Label.AutoSize = true;
            this.BattTemp25_Label.Location = new System.Drawing.Point(50, 357);
            this.BattTemp25_Label.Name = "BattTemp25_Label";
            this.BattTemp25_Label.Size = new System.Drawing.Size(26, 13);
            this.BattTemp25_Label.TabIndex = 93;
            this.BattTemp25_Label.Text = "T25";
            // 
            // BattTemp18_Label
            // 
            this.BattTemp18_Label.AutoSize = true;
            this.BattTemp18_Label.Location = new System.Drawing.Point(50, 263);
            this.BattTemp18_Label.Name = "BattTemp18_Label";
            this.BattTemp18_Label.Size = new System.Drawing.Size(26, 13);
            this.BattTemp18_Label.TabIndex = 86;
            this.BattTemp18_Label.Text = "T18";
            // 
            // BattTemp20_Label
            // 
            this.BattTemp20_Label.AutoSize = true;
            this.BattTemp20_Label.Location = new System.Drawing.Point(50, 289);
            this.BattTemp20_Label.Name = "BattTemp20_Label";
            this.BattTemp20_Label.Size = new System.Drawing.Size(26, 13);
            this.BattTemp20_Label.TabIndex = 88;
            this.BattTemp20_Label.Text = "T20";
            // 
            // BattTemp16_Label
            // 
            this.BattTemp16_Label.AutoSize = true;
            this.BattTemp16_Label.Location = new System.Drawing.Point(50, 234);
            this.BattTemp16_Label.Name = "BattTemp16_Label";
            this.BattTemp16_Label.Size = new System.Drawing.Size(26, 13);
            this.BattTemp16_Label.TabIndex = 84;
            this.BattTemp16_Label.Text = "T16";
            // 
            // BattTemp24_Label
            // 
            this.BattTemp24_Label.AutoSize = true;
            this.BattTemp24_Label.Location = new System.Drawing.Point(50, 344);
            this.BattTemp24_Label.Name = "BattTemp24_Label";
            this.BattTemp24_Label.Size = new System.Drawing.Size(26, 13);
            this.BattTemp24_Label.TabIndex = 92;
            this.BattTemp24_Label.Text = "T24";
            // 
            // BattTemp15_Label
            // 
            this.BattTemp15_Label.AutoSize = true;
            this.BattTemp15_Label.Location = new System.Drawing.Point(50, 221);
            this.BattTemp15_Label.Name = "BattTemp15_Label";
            this.BattTemp15_Label.Size = new System.Drawing.Size(26, 13);
            this.BattTemp15_Label.TabIndex = 83;
            this.BattTemp15_Label.Text = "T15";
            // 
            // BattTemp19_Label
            // 
            this.BattTemp19_Label.AutoSize = true;
            this.BattTemp19_Label.Location = new System.Drawing.Point(50, 276);
            this.BattTemp19_Label.Name = "BattTemp19_Label";
            this.BattTemp19_Label.Size = new System.Drawing.Size(26, 13);
            this.BattTemp19_Label.TabIndex = 87;
            this.BattTemp19_Label.Text = "T19";
            // 
            // BattTemp17_Label
            // 
            this.BattTemp17_Label.AutoSize = true;
            this.BattTemp17_Label.Location = new System.Drawing.Point(50, 249);
            this.BattTemp17_Label.Name = "BattTemp17_Label";
            this.BattTemp17_Label.Size = new System.Drawing.Size(26, 13);
            this.BattTemp17_Label.TabIndex = 85;
            this.BattTemp17_Label.Text = "T17";
            // 
            // BattTemp23_Label
            // 
            this.BattTemp23_Label.AutoSize = true;
            this.BattTemp23_Label.Location = new System.Drawing.Point(50, 329);
            this.BattTemp23_Label.Name = "BattTemp23_Label";
            this.BattTemp23_Label.Size = new System.Drawing.Size(26, 13);
            this.BattTemp23_Label.TabIndex = 91;
            this.BattTemp23_Label.Text = "T23";
            // 
            // BattTemp13_Label
            // 
            this.BattTemp13_Label.AutoSize = true;
            this.BattTemp13_Label.Location = new System.Drawing.Point(50, 193);
            this.BattTemp13_Label.Name = "BattTemp13_Label";
            this.BattTemp13_Label.Size = new System.Drawing.Size(26, 13);
            this.BattTemp13_Label.TabIndex = 81;
            this.BattTemp13_Label.Text = "T13";
            // 
            // BattTemp21_Label
            // 
            this.BattTemp21_Label.AutoSize = true;
            this.BattTemp21_Label.Location = new System.Drawing.Point(50, 302);
            this.BattTemp21_Label.Name = "BattTemp21_Label";
            this.BattTemp21_Label.Size = new System.Drawing.Size(26, 13);
            this.BattTemp21_Label.TabIndex = 89;
            this.BattTemp21_Label.Text = "T21";
            // 
            // BattTemp14_Label
            // 
            this.BattTemp14_Label.AutoSize = true;
            this.BattTemp14_Label.Location = new System.Drawing.Point(50, 207);
            this.BattTemp14_Label.Name = "BattTemp14_Label";
            this.BattTemp14_Label.Size = new System.Drawing.Size(26, 13);
            this.BattTemp14_Label.TabIndex = 82;
            this.BattTemp14_Label.Text = "T14";
            // 
            // BattTemp22_Label
            // 
            this.BattTemp22_Label.AutoSize = true;
            this.BattTemp22_Label.Location = new System.Drawing.Point(50, 316);
            this.BattTemp22_Label.Name = "BattTemp22_Label";
            this.BattTemp22_Label.Size = new System.Drawing.Size(26, 13);
            this.BattTemp22_Label.TabIndex = 90;
            this.BattTemp22_Label.Text = "T22";
            // 
            // BattTemp6_Label
            // 
            this.BattTemp6_Label.AutoSize = true;
            this.BattTemp6_Label.Location = new System.Drawing.Point(50, 98);
            this.BattTemp6_Label.Name = "BattTemp6_Label";
            this.BattTemp6_Label.Size = new System.Drawing.Size(20, 13);
            this.BattTemp6_Label.TabIndex = 74;
            this.BattTemp6_Label.Text = "T6";
            // 
            // BattTemp8_Label
            // 
            this.BattTemp8_Label.AutoSize = true;
            this.BattTemp8_Label.Location = new System.Drawing.Point(50, 126);
            this.BattTemp8_Label.Name = "BattTemp8_Label";
            this.BattTemp8_Label.Size = new System.Drawing.Size(20, 13);
            this.BattTemp8_Label.TabIndex = 76;
            this.BattTemp8_Label.Text = "T8";
            // 
            // BattTemp4_Label
            // 
            this.BattTemp4_Label.AutoSize = true;
            this.BattTemp4_Label.Location = new System.Drawing.Point(50, 72);
            this.BattTemp4_Label.Name = "BattTemp4_Label";
            this.BattTemp4_Label.Size = new System.Drawing.Size(20, 13);
            this.BattTemp4_Label.TabIndex = 72;
            this.BattTemp4_Label.Text = "T4";
            // 
            // BattTemp12_Label
            // 
            this.BattTemp12_Label.AutoSize = true;
            this.BattTemp12_Label.Location = new System.Drawing.Point(50, 179);
            this.BattTemp12_Label.Name = "BattTemp12_Label";
            this.BattTemp12_Label.Size = new System.Drawing.Size(26, 13);
            this.BattTemp12_Label.TabIndex = 80;
            this.BattTemp12_Label.Text = "T12";
            // 
            // BattTemp3_Label
            // 
            this.BattTemp3_Label.AutoSize = true;
            this.BattTemp3_Label.Location = new System.Drawing.Point(50, 59);
            this.BattTemp3_Label.Name = "BattTemp3_Label";
            this.BattTemp3_Label.Size = new System.Drawing.Size(20, 13);
            this.BattTemp3_Label.TabIndex = 71;
            this.BattTemp3_Label.Text = "T3";
            // 
            // BattTemp7_Label
            // 
            this.BattTemp7_Label.AutoSize = true;
            this.BattTemp7_Label.Location = new System.Drawing.Point(50, 113);
            this.BattTemp7_Label.Name = "BattTemp7_Label";
            this.BattTemp7_Label.Size = new System.Drawing.Size(20, 13);
            this.BattTemp7_Label.TabIndex = 75;
            this.BattTemp7_Label.Text = "T7";
            // 
            // BattTemp5_Label
            // 
            this.BattTemp5_Label.AutoSize = true;
            this.BattTemp5_Label.Location = new System.Drawing.Point(50, 85);
            this.BattTemp5_Label.Name = "BattTemp5_Label";
            this.BattTemp5_Label.Size = new System.Drawing.Size(20, 13);
            this.BattTemp5_Label.TabIndex = 73;
            this.BattTemp5_Label.Text = "T5";
            // 
            // BattTemp11_Label
            // 
            this.BattTemp11_Label.AutoSize = true;
            this.BattTemp11_Label.Location = new System.Drawing.Point(50, 165);
            this.BattTemp11_Label.Name = "BattTemp11_Label";
            this.BattTemp11_Label.Size = new System.Drawing.Size(26, 13);
            this.BattTemp11_Label.TabIndex = 79;
            this.BattTemp11_Label.Text = "T11";
            // 
            // BattTemp1_Label
            // 
            this.BattTemp1_Label.AutoSize = true;
            this.BattTemp1_Label.Location = new System.Drawing.Point(50, 33);
            this.BattTemp1_Label.Name = "BattTemp1_Label";
            this.BattTemp1_Label.Size = new System.Drawing.Size(20, 13);
            this.BattTemp1_Label.TabIndex = 69;
            this.BattTemp1_Label.Text = "T1";
            // 
            // BattTemp9_Label
            // 
            this.BattTemp9_Label.AutoSize = true;
            this.BattTemp9_Label.Location = new System.Drawing.Point(50, 139);
            this.BattTemp9_Label.Name = "BattTemp9_Label";
            this.BattTemp9_Label.Size = new System.Drawing.Size(20, 13);
            this.BattTemp9_Label.TabIndex = 77;
            this.BattTemp9_Label.Text = "T9";
            // 
            // BattTemp2_Label
            // 
            this.BattTemp2_Label.AutoSize = true;
            this.BattTemp2_Label.Location = new System.Drawing.Point(50, 46);
            this.BattTemp2_Label.Name = "BattTemp2_Label";
            this.BattTemp2_Label.Size = new System.Drawing.Size(20, 13);
            this.BattTemp2_Label.TabIndex = 70;
            this.BattTemp2_Label.Text = "T2";
            // 
            // BattTemp10_Label
            // 
            this.BattTemp10_Label.AutoSize = true;
            this.BattTemp10_Label.Location = new System.Drawing.Point(50, 152);
            this.BattTemp10_Label.Name = "BattTemp10_Label";
            this.BattTemp10_Label.Size = new System.Drawing.Size(26, 13);
            this.BattTemp10_Label.TabIndex = 78;
            this.BattTemp10_Label.Text = "T10";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(6, 421);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(26, 13);
            this.label67.TabIndex = 68;
            this.label67.Text = "T30";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(6, 408);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(26, 13);
            this.label66.TabIndex = 67;
            this.label66.Text = "T29";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(6, 396);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(26, 13);
            this.label65.TabIndex = 66;
            this.label65.Text = "T28";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(6, 383);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(26, 13);
            this.label63.TabIndex = 65;
            this.label63.Text = "T27";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(6, 370);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(26, 13);
            this.label61.TabIndex = 64;
            this.label61.Text = "T26";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(6, 357);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(26, 13);
            this.label59.TabIndex = 63;
            this.label59.Text = "T25";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 263);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 13);
            this.label19.TabIndex = 56;
            this.label19.Text = "T18";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 289);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 13);
            this.label20.TabIndex = 58;
            this.label20.Text = "T20";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 234);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(26, 13);
            this.label21.TabIndex = 54;
            this.label21.Text = "T16";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 344);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(26, 13);
            this.label22.TabIndex = 62;
            this.label22.Text = "T24";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 221);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(26, 13);
            this.label23.TabIndex = 53;
            this.label23.Text = "T15";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 276);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(26, 13);
            this.label24.TabIndex = 57;
            this.label24.Text = "T19";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 249);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(26, 13);
            this.label25.TabIndex = 55;
            this.label25.Text = "T17";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(6, 329);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(26, 13);
            this.label49.TabIndex = 61;
            this.label49.Text = "T23";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(6, 193);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(26, 13);
            this.label51.TabIndex = 51;
            this.label51.Text = "T13";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(6, 302);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(26, 13);
            this.label53.TabIndex = 59;
            this.label53.Text = "T21";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(6, 207);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(26, 13);
            this.label55.TabIndex = 52;
            this.label55.Text = "T14";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(6, 316);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(26, 13);
            this.label57.TabIndex = 60;
            this.label57.Text = "T22";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "T6";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "T8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "T4";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 50;
            this.label14.Text = "T12";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "T3";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "T7";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "T5";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 165);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "T11";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "T1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 139);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 13);
            this.label17.TabIndex = 47;
            this.label17.Text = "T9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "T2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 152);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 13);
            this.label18.TabIndex = 48;
            this.label18.Text = "T10";
            // 
            // Speed_Label
            // 
            this.Speed_Label.AutoSize = true;
            this.Speed_Label.Location = new System.Drawing.Point(99, 83);
            this.Speed_Label.Name = "Speed_Label";
            this.Speed_Label.Size = new System.Drawing.Size(20, 13);
            this.Speed_Label.TabIndex = 112;
            this.Speed_Label.Text = "T6";
            // 
            // PVEnergy_Label
            // 
            this.PVEnergy_Label.AutoSize = true;
            this.PVEnergy_Label.Location = new System.Drawing.Point(99, 57);
            this.PVEnergy_Label.Name = "PVEnergy_Label";
            this.PVEnergy_Label.Size = new System.Drawing.Size(20, 13);
            this.PVEnergy_Label.TabIndex = 110;
            this.PVEnergy_Label.Text = "T4";
            // 
            // BattVoltage_Label
            // 
            this.BattVoltage_Label.AutoSize = true;
            this.BattVoltage_Label.Location = new System.Drawing.Point(99, 44);
            this.BattVoltage_Label.Name = "BattVoltage_Label";
            this.BattVoltage_Label.Size = new System.Drawing.Size(20, 13);
            this.BattVoltage_Label.TabIndex = 109;
            this.BattVoltage_Label.Text = "T3";
            // 
            // CabinTemp_Label
            // 
            this.CabinTemp_Label.AutoSize = true;
            this.CabinTemp_Label.Location = new System.Drawing.Point(99, 98);
            this.CabinTemp_Label.Name = "CabinTemp_Label";
            this.CabinTemp_Label.Size = new System.Drawing.Size(20, 13);
            this.CabinTemp_Label.TabIndex = 113;
            this.CabinTemp_Label.Text = "T7";
            // 
            // PVCurrent_Label
            // 
            this.PVCurrent_Label.AutoSize = true;
            this.PVCurrent_Label.Location = new System.Drawing.Point(99, 70);
            this.PVCurrent_Label.Name = "PVCurrent_Label";
            this.PVCurrent_Label.Size = new System.Drawing.Size(20, 13);
            this.PVCurrent_Label.TabIndex = 111;
            this.PVCurrent_Label.Text = "T5";
            // 
            // BattEnergy_Label
            // 
            this.BattEnergy_Label.AutoSize = true;
            this.BattEnergy_Label.Location = new System.Drawing.Point(99, 18);
            this.BattEnergy_Label.Name = "BattEnergy_Label";
            this.BattEnergy_Label.Size = new System.Drawing.Size(20, 13);
            this.BattEnergy_Label.TabIndex = 107;
            this.BattEnergy_Label.Text = "T1";
            // 
            // BattCurrent_Label
            // 
            this.BattCurrent_Label.AutoSize = true;
            this.BattCurrent_Label.Location = new System.Drawing.Point(99, 31);
            this.BattCurrent_Label.Name = "BattCurrent_Label";
            this.BattCurrent_Label.Size = new System.Drawing.Size(20, 13);
            this.BattCurrent_Label.TabIndex = 108;
            this.BattCurrent_Label.Text = "T2";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(15, 83);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(38, 13);
            this.label76.TabIndex = 104;
            this.label76.Text = "Speed";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(15, 57);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(57, 13);
            this.label78.TabIndex = 102;
            this.label78.Text = "PV Energy";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(15, 44);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(79, 13);
            this.label79.TabIndex = 101;
            this.label79.Text = "Battery Voltage";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(15, 98);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(61, 13);
            this.label80.TabIndex = 105;
            this.label80.Text = "CabinTemp";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(15, 70);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(58, 13);
            this.label81.TabIndex = 103;
            this.label81.Text = "PV Current";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(15, 18);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(76, 13);
            this.label82.TabIndex = 99;
            this.label82.Text = "Battery Energy";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(15, 31);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(77, 13);
            this.label83.TabIndex = 100;
            this.label83.Text = "Battery Current";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Motor_Current_Label);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.Speed_Label);
            this.groupBox6.Controls.Add(this.PVEnergy_Label);
            this.groupBox6.Controls.Add(this.BattVoltage_Label);
            this.groupBox6.Controls.Add(this.CabinTemp_Label);
            this.groupBox6.Controls.Add(this.PVCurrent_Label);
            this.groupBox6.Controls.Add(this.BattEnergy_Label);
            this.groupBox6.Controls.Add(this.BattCurrent_Label);
            this.groupBox6.Controls.Add(this.label76);
            this.groupBox6.Controls.Add(this.label82);
            this.groupBox6.Controls.Add(this.label83);
            this.groupBox6.Controls.Add(this.label78);
            this.groupBox6.Controls.Add(this.label81);
            this.groupBox6.Controls.Add(this.label79);
            this.groupBox6.Controls.Add(this.label80);
            this.groupBox6.Location = new System.Drawing.Point(531, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(163, 131);
            this.groupBox6.TabIndex = 115;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // Motor_Current_Label
            // 
            this.Motor_Current_Label.AutoSize = true;
            this.Motor_Current_Label.Location = new System.Drawing.Point(99, 110);
            this.Motor_Current_Label.Name = "Motor_Current_Label";
            this.Motor_Current_Label.Size = new System.Drawing.Size(20, 13);
            this.Motor_Current_Label.TabIndex = 116;
            this.Motor_Current_Label.Text = "T8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 115;
            this.label4.Text = "Motor Current";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.GPS_Height_Label);
            this.groupBox7.Controls.Add(this.GPS_Speed_Label);
            this.groupBox7.Controls.Add(this.label72);
            this.groupBox7.Controls.Add(this.label73);
            this.groupBox7.Controls.Add(this.Longitude_Label);
            this.groupBox7.Controls.Add(this.Latitude_Label);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.label71);
            this.groupBox7.Controls.Add(this.AccelZ_Label);
            this.groupBox7.Controls.Add(this.AccelX_Label);
            this.groupBox7.Controls.Add(this.AccelY_Label);
            this.groupBox7.Controls.Add(this.label74);
            this.groupBox7.Controls.Add(this.label75);
            this.groupBox7.Controls.Add(this.label84);
            this.groupBox7.Controls.Add(this.GyroZ_Label);
            this.groupBox7.Controls.Add(this.GyroX_Label);
            this.groupBox7.Controls.Add(this.GyroY_Label);
            this.groupBox7.Controls.Add(this.label68);
            this.groupBox7.Controls.Add(this.label69);
            this.groupBox7.Controls.Add(this.label70);
            this.groupBox7.Controls.Add(this.Roll_Label);
            this.groupBox7.Controls.Add(this.Yaw_Label);
            this.groupBox7.Controls.Add(this.Pitch_Label);
            this.groupBox7.Controls.Add(this.label85);
            this.groupBox7.Controls.Add(this.label87);
            this.groupBox7.Controls.Add(this.Roll);
            this.groupBox7.Location = new System.Drawing.Point(531, 155);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(163, 192);
            this.groupBox7.TabIndex = 116;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "groupBox7";
            // 
            // GPS_Height_Label
            // 
            this.GPS_Height_Label.AutoSize = true;
            this.GPS_Height_Label.Location = new System.Drawing.Point(99, 177);
            this.GPS_Height_Label.Name = "GPS_Height_Label";
            this.GPS_Height_Label.Size = new System.Drawing.Size(20, 13);
            this.GPS_Height_Label.TabIndex = 129;
            this.GPS_Height_Label.Text = "T3";
            // 
            // GPS_Speed_Label
            // 
            this.GPS_Speed_Label.AutoSize = true;
            this.GPS_Speed_Label.Location = new System.Drawing.Point(99, 164);
            this.GPS_Speed_Label.Name = "GPS_Speed_Label";
            this.GPS_Speed_Label.Size = new System.Drawing.Size(20, 13);
            this.GPS_Speed_Label.TabIndex = 128;
            this.GPS_Speed_Label.Text = "T2";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(15, 164);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(47, 13);
            this.label72.TabIndex = 126;
            this.label72.Text = "GPS Hız";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(15, 177);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(78, 13);
            this.label73.TabIndex = 127;
            this.label73.Text = "GPS Yükseklik";
            // 
            // Longitude_Label
            // 
            this.Longitude_Label.AutoSize = true;
            this.Longitude_Label.Location = new System.Drawing.Point(99, 151);
            this.Longitude_Label.Name = "Longitude_Label";
            this.Longitude_Label.Size = new System.Drawing.Size(20, 13);
            this.Longitude_Label.TabIndex = 125;
            this.Longitude_Label.Text = "T3";
            // 
            // Latitude_Label
            // 
            this.Latitude_Label.AutoSize = true;
            this.Latitude_Label.Location = new System.Drawing.Point(99, 138);
            this.Latitude_Label.Name = "Latitude_Label";
            this.Latitude_Label.Size = new System.Drawing.Size(20, 13);
            this.Latitude_Label.TabIndex = 124;
            this.Latitude_Label.Text = "T2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 122;
            this.label5.Text = "Enlem";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(15, 151);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(41, 13);
            this.label71.TabIndex = 123;
            this.label71.Text = "Boylam";
            // 
            // AccelZ_Label
            // 
            this.AccelZ_Label.AutoSize = true;
            this.AccelZ_Label.Location = new System.Drawing.Point(99, 124);
            this.AccelZ_Label.Name = "AccelZ_Label";
            this.AccelZ_Label.Size = new System.Drawing.Size(20, 13);
            this.AccelZ_Label.TabIndex = 121;
            this.AccelZ_Label.Text = "T3";
            // 
            // AccelX_Label
            // 
            this.AccelX_Label.AutoSize = true;
            this.AccelX_Label.Location = new System.Drawing.Point(99, 98);
            this.AccelX_Label.Name = "AccelX_Label";
            this.AccelX_Label.Size = new System.Drawing.Size(20, 13);
            this.AccelX_Label.TabIndex = 119;
            this.AccelX_Label.Text = "T1";
            // 
            // AccelY_Label
            // 
            this.AccelY_Label.AutoSize = true;
            this.AccelY_Label.Location = new System.Drawing.Point(99, 111);
            this.AccelY_Label.Name = "AccelY_Label";
            this.AccelY_Label.Size = new System.Drawing.Size(20, 13);
            this.AccelY_Label.TabIndex = 120;
            this.AccelY_Label.Text = "T2";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(15, 98);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(47, 13);
            this.label74.TabIndex = 116;
            this.label74.Text = "Accel. X";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(15, 111);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(47, 13);
            this.label75.TabIndex = 117;
            this.label75.Text = "Accel. Y";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(15, 124);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(47, 13);
            this.label84.TabIndex = 118;
            this.label84.Text = "Accel. Z";
            // 
            // GyroZ_Label
            // 
            this.GyroZ_Label.AutoSize = true;
            this.GyroZ_Label.Location = new System.Drawing.Point(99, 83);
            this.GyroZ_Label.Name = "GyroZ_Label";
            this.GyroZ_Label.Size = new System.Drawing.Size(20, 13);
            this.GyroZ_Label.TabIndex = 115;
            this.GyroZ_Label.Text = "T3";
            // 
            // GyroX_Label
            // 
            this.GyroX_Label.AutoSize = true;
            this.GyroX_Label.Location = new System.Drawing.Point(99, 57);
            this.GyroX_Label.Name = "GyroX_Label";
            this.GyroX_Label.Size = new System.Drawing.Size(20, 13);
            this.GyroX_Label.TabIndex = 113;
            this.GyroX_Label.Text = "T1";
            // 
            // GyroY_Label
            // 
            this.GyroY_Label.AutoSize = true;
            this.GyroY_Label.Location = new System.Drawing.Point(99, 70);
            this.GyroY_Label.Name = "GyroY_Label";
            this.GyroY_Label.Size = new System.Drawing.Size(20, 13);
            this.GyroY_Label.TabIndex = 114;
            this.GyroY_Label.Text = "T2";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(15, 57);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(39, 13);
            this.label68.TabIndex = 110;
            this.label68.Text = "Gyro X";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(15, 70);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(39, 13);
            this.label69.TabIndex = 111;
            this.label69.Text = "Gyro Y";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(15, 83);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(39, 13);
            this.label70.TabIndex = 112;
            this.label70.Text = "Gyro Z";
            // 
            // Roll_Label
            // 
            this.Roll_Label.AutoSize = true;
            this.Roll_Label.Location = new System.Drawing.Point(99, 44);
            this.Roll_Label.Name = "Roll_Label";
            this.Roll_Label.Size = new System.Drawing.Size(20, 13);
            this.Roll_Label.TabIndex = 109;
            this.Roll_Label.Text = "T3";
            // 
            // Yaw_Label
            // 
            this.Yaw_Label.AutoSize = true;
            this.Yaw_Label.Location = new System.Drawing.Point(99, 18);
            this.Yaw_Label.Name = "Yaw_Label";
            this.Yaw_Label.Size = new System.Drawing.Size(20, 13);
            this.Yaw_Label.TabIndex = 107;
            this.Yaw_Label.Text = "T1";
            // 
            // Pitch_Label
            // 
            this.Pitch_Label.AutoSize = true;
            this.Pitch_Label.Location = new System.Drawing.Point(99, 31);
            this.Pitch_Label.Name = "Pitch_Label";
            this.Pitch_Label.Size = new System.Drawing.Size(20, 13);
            this.Pitch_Label.TabIndex = 108;
            this.Pitch_Label.Text = "T2";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(15, 18);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(28, 13);
            this.label85.TabIndex = 99;
            this.label85.Text = "Yaw";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(15, 31);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(31, 13);
            this.label87.TabIndex = 100;
            this.label87.Text = "Pitch";
            // 
            // Roll
            // 
            this.Roll.AutoSize = true;
            this.Roll.Location = new System.Drawing.Point(15, 44);
            this.Roll.Name = "Roll";
            this.Roll.Size = new System.Drawing.Size(25, 13);
            this.Roll.TabIndex = 101;
            this.Roll.Text = "Roll";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(700, 141);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(463, 204);
            this.chart1.TabIndex = 117;
            this.chart1.Text = "chart1";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.PV_T1_Label);
            this.groupBox8.Controls.Add(this.PV_T2_Label);
            this.groupBox8.Controls.Add(this.label98);
            this.groupBox8.Controls.Add(this.label99);
            this.groupBox8.Controls.Add(this.Motor_T3_Label);
            this.groupBox8.Controls.Add(this.Motor_T1_Label);
            this.groupBox8.Controls.Add(this.Motor_T2_Label);
            this.groupBox8.Controls.Add(this.label104);
            this.groupBox8.Controls.Add(this.label105);
            this.groupBox8.Controls.Add(this.label106);
            this.groupBox8.Controls.Add(this.MPPT_T2_Label);
            this.groupBox8.Controls.Add(this.Pilot_Uyari_Label);
            this.groupBox8.Controls.Add(this.MPPT_T1_Label);
            this.groupBox8.Controls.Add(this.label110);
            this.groupBox8.Controls.Add(this.label111);
            this.groupBox8.Controls.Add(this.label112);
            this.groupBox8.Location = new System.Drawing.Point(531, 351);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(163, 132);
            this.groupBox8.TabIndex = 130;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "groupBox8";
            // 
            // PV_T1_Label
            // 
            this.PV_T1_Label.AutoSize = true;
            this.PV_T1_Label.Location = new System.Drawing.Point(99, 98);
            this.PV_T1_Label.Name = "PV_T1_Label";
            this.PV_T1_Label.Size = new System.Drawing.Size(20, 13);
            this.PV_T1_Label.TabIndex = 119;
            this.PV_T1_Label.Text = "T1";
            // 
            // PV_T2_Label
            // 
            this.PV_T2_Label.AutoSize = true;
            this.PV_T2_Label.Location = new System.Drawing.Point(99, 111);
            this.PV_T2_Label.Name = "PV_T2_Label";
            this.PV_T2_Label.Size = new System.Drawing.Size(20, 13);
            this.PV_T2_Label.TabIndex = 120;
            this.PV_T2_Label.Text = "T2";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(15, 98);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(40, 13);
            this.label98.TabIndex = 116;
            this.label98.Text = "PV T.1";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(15, 111);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(40, 13);
            this.label99.TabIndex = 117;
            this.label99.Text = "PV T.2";
            // 
            // Motor_T3_Label
            // 
            this.Motor_T3_Label.AutoSize = true;
            this.Motor_T3_Label.Location = new System.Drawing.Point(99, 83);
            this.Motor_T3_Label.Name = "Motor_T3_Label";
            this.Motor_T3_Label.Size = new System.Drawing.Size(20, 13);
            this.Motor_T3_Label.TabIndex = 115;
            this.Motor_T3_Label.Text = "T3";
            // 
            // Motor_T1_Label
            // 
            this.Motor_T1_Label.AutoSize = true;
            this.Motor_T1_Label.Location = new System.Drawing.Point(99, 57);
            this.Motor_T1_Label.Name = "Motor_T1_Label";
            this.Motor_T1_Label.Size = new System.Drawing.Size(20, 13);
            this.Motor_T1_Label.TabIndex = 113;
            this.Motor_T1_Label.Text = "T1";
            // 
            // Motor_T2_Label
            // 
            this.Motor_T2_Label.AutoSize = true;
            this.Motor_T2_Label.Location = new System.Drawing.Point(99, 70);
            this.Motor_T2_Label.Name = "Motor_T2_Label";
            this.Motor_T2_Label.Size = new System.Drawing.Size(20, 13);
            this.Motor_T2_Label.TabIndex = 114;
            this.Motor_T2_Label.Text = "T2";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(15, 57);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(53, 13);
            this.label104.TabIndex = 110;
            this.label104.Text = "Motor T.1";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(15, 70);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(53, 13);
            this.label105.TabIndex = 111;
            this.label105.Text = "Motor T.2";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(15, 83);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(53, 13);
            this.label106.TabIndex = 112;
            this.label106.Text = "Motor T.3";
            // 
            // MPPT_T2_Label
            // 
            this.MPPT_T2_Label.AutoSize = true;
            this.MPPT_T2_Label.Location = new System.Drawing.Point(99, 44);
            this.MPPT_T2_Label.Name = "MPPT_T2_Label";
            this.MPPT_T2_Label.Size = new System.Drawing.Size(20, 13);
            this.MPPT_T2_Label.TabIndex = 109;
            this.MPPT_T2_Label.Text = "T3";
            // 
            // Pilot_Uyari_Label
            // 
            this.Pilot_Uyari_Label.AutoSize = true;
            this.Pilot_Uyari_Label.Location = new System.Drawing.Point(99, 18);
            this.Pilot_Uyari_Label.Name = "Pilot_Uyari_Label";
            this.Pilot_Uyari_Label.Size = new System.Drawing.Size(20, 13);
            this.Pilot_Uyari_Label.TabIndex = 107;
            this.Pilot_Uyari_Label.Text = "T1";
            // 
            // MPPT_T1_Label
            // 
            this.MPPT_T1_Label.AutoSize = true;
            this.MPPT_T1_Label.Location = new System.Drawing.Point(99, 31);
            this.MPPT_T1_Label.Name = "MPPT_T1_Label";
            this.MPPT_T1_Label.Size = new System.Drawing.Size(20, 13);
            this.MPPT_T1_Label.TabIndex = 108;
            this.MPPT_T1_Label.Text = "T2";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(15, 18);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(54, 13);
            this.label110.TabIndex = 99;
            this.label110.Text = "Pilot Uyarı";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(15, 31);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(56, 13);
            this.label111.TabIndex = 100;
            this.label111.Text = "MPPT T.1";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(15, 44);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(56, 13);
            this.label112.TabIndex = 101;
            this.label112.Text = "MPPT T.2";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(709, 157);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(463, 195);
            this.chart2.TabIndex = 133;
            this.chart2.Text = "chart2";
            // 
            // graph_clock
            // 
            this.graph_clock.Tick += new System.EventHandler(this.graph_clock_Tick);
            // 
            // Button1Minute
            // 
            this.Button1Minute.Location = new System.Drawing.Point(1057, 179);
            this.Button1Minute.Name = "Button1Minute";
            this.Button1Minute.Size = new System.Drawing.Size(75, 23);
            this.Button1Minute.TabIndex = 6;
            this.Button1Minute.Text = "1 Dakika";
            this.Button1Minute.UseVisualStyleBackColor = true;
            this.Button1Minute.Click += new System.EventHandler(this.Button1Minute_Click);
            // 
            // Button30Seccond
            // 
            this.Button30Seccond.Location = new System.Drawing.Point(1057, 208);
            this.Button30Seccond.Name = "Button30Seccond";
            this.Button30Seccond.Size = new System.Drawing.Size(75, 23);
            this.Button30Seccond.TabIndex = 134;
            this.Button30Seccond.Text = "30 Saniye";
            this.Button30Seccond.UseVisualStyleBackColor = true;
            this.Button30Seccond.Click += new System.EventHandler(this.Button30Seccond_Click);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(700, 351);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(463, 128);
            this.cartesianChart1.TabIndex = 135;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 557);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.Button30Seccond);
            this.Controls.Add(this.Button1Minute);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxConnectionStatue)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComboBoxPort;
        private System.Windows.Forms.Button ButtonScanPort;
        private System.Windows.Forms.ComboBox ComboBoxBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Button ButtonDisconnect;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.PictureBox PictureBoxConnectionStatue;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer modbus_master_clock;
        private System.Windows.Forms.Label BMS_Voltage1_Label;
        private System.Windows.Forms.Label BMS_Voltage2_Label;
        private System.Windows.Forms.Label BMS_Voltage3_Label;
        private System.Windows.Forms.Label BMS_Voltage4_Label;
        private System.Windows.Forms.Label BMS_Voltage5_Label;
        private System.Windows.Forms.Label BMS_Voltage6_Label;
        private System.Windows.Forms.Label BMS_Voltage7_Label;
        private System.Windows.Forms.Label BMS_Voltage8_Label;
        private System.Windows.Forms.Label BMS_Voltage9_Label;
        private System.Windows.Forms.Label BMS_Voltage10_Label;
        private System.Windows.Forms.Label BMS_Voltage11_Label;
        private System.Windows.Forms.Label BMS_Voltage12_Label;
        private System.Windows.Forms.Label BMS_Voltage13_Label;
        private System.Windows.Forms.Label BMS_Voltage14_Label;
        private System.Windows.Forms.Label BMS_Voltage15_Label;
        private System.Windows.Forms.Label BMS_Voltage16_Label;
        private System.Windows.Forms.Label BMS_Voltage17_Label;
        private System.Windows.Forms.Label BMS_Voltage18_Label;
        private System.Windows.Forms.Label BMS_Voltage19_Label;
        private System.Windows.Forms.Label BMS_Voltage20_Label;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label BMS_Voltage21_Label;
        private System.Windows.Forms.Label BMS_Voltage22_Label;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label BMS_Voltage23_Label;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label BMS_Voltage24_Label;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label BMS_Voltage25_Label;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label BMS_Voltage26_Label;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label BMS_Voltage27_Label;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label BMS_Voltage28_Label;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label BMS_Voltage29_Label;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label BMS_Voltage30_Label;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label BMS_Voltage31_Label;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label BMS_Voltage32_Label;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label BattTemp30_Label;
        private System.Windows.Forms.Label BattTemp29_Label;
        private System.Windows.Forms.Label BattTemp28_Label;
        private System.Windows.Forms.Label BattTemp27_Label;
        private System.Windows.Forms.Label BattTemp26_Label;
        private System.Windows.Forms.Label BattTemp25_Label;
        private System.Windows.Forms.Label BattTemp18_Label;
        private System.Windows.Forms.Label BattTemp20_Label;
        private System.Windows.Forms.Label BattTemp16_Label;
        private System.Windows.Forms.Label BattTemp24_Label;
        private System.Windows.Forms.Label BattTemp15_Label;
        private System.Windows.Forms.Label BattTemp19_Label;
        private System.Windows.Forms.Label BattTemp17_Label;
        private System.Windows.Forms.Label BattTemp23_Label;
        private System.Windows.Forms.Label BattTemp13_Label;
        private System.Windows.Forms.Label BattTemp21_Label;
        private System.Windows.Forms.Label BattTemp14_Label;
        private System.Windows.Forms.Label BattTemp22_Label;
        private System.Windows.Forms.Label BattTemp6_Label;
        private System.Windows.Forms.Label BattTemp8_Label;
        private System.Windows.Forms.Label BattTemp4_Label;
        private System.Windows.Forms.Label BattTemp12_Label;
        private System.Windows.Forms.Label BattTemp3_Label;
        private System.Windows.Forms.Label BattTemp7_Label;
        private System.Windows.Forms.Label BattTemp5_Label;
        private System.Windows.Forms.Label BattTemp11_Label;
        private System.Windows.Forms.Label BattTemp1_Label;
        private System.Windows.Forms.Label BattTemp9_Label;
        private System.Windows.Forms.Label BattTemp2_Label;
        private System.Windows.Forms.Label BattTemp10_Label;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label Speed_Label;
        private System.Windows.Forms.Label PVEnergy_Label;
        private System.Windows.Forms.Label BattVoltage_Label;
        private System.Windows.Forms.Label CabinTemp_Label;
        private System.Windows.Forms.Label PVCurrent_Label;
        private System.Windows.Forms.Label BattEnergy_Label;
        private System.Windows.Forms.Label BattCurrent_Label;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label Roll_Label;
        private System.Windows.Forms.Label Yaw_Label;
        private System.Windows.Forms.Label Pitch_Label;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label Roll;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label AccelZ_Label;
        private System.Windows.Forms.Label AccelX_Label;
        private System.Windows.Forms.Label AccelY_Label;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label GyroZ_Label;
        private System.Windows.Forms.Label GyroX_Label;
        private System.Windows.Forms.Label GyroY_Label;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label Longitude_Label;
        private System.Windows.Forms.Label Latitude_Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label GPS_Height_Label;
        private System.Windows.Forms.Label GPS_Speed_Label;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label PV_T1_Label;
        private System.Windows.Forms.Label PV_T2_Label;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label Motor_T3_Label;
        private System.Windows.Forms.Label Motor_T1_Label;
        private System.Windows.Forms.Label Motor_T2_Label;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label MPPT_T2_Label;
        private System.Windows.Forms.Label Pilot_Uyari_Label;
        private System.Windows.Forms.Label MPPT_T1_Label;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Label Motor_Current_Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Data_Time_Label;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Timer graph_clock;
        private System.Windows.Forms.Button Button1Minute;
        private System.Windows.Forms.Button Button30Seccond;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}

