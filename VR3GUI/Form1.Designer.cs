namespace VR3GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbProgramConfiguration = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.iST = new System.Windows.Forms.TextBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.lblExtension = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnBrowsePath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblVrPath = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaxPitchAngle = new System.Windows.Forms.TextBox();
            this.txtPartialCheckAngle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFullCheckAngle = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPartialCheckAngle = new System.Windows.Forms.Label();
            this.lblFullCheckAngle = new System.Windows.Forms.Label();
            this.lblNearMissDistance = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRespawnEndDistance = new System.Windows.Forms.TextBox();
            this.lblRespawnEndDistance = new System.Windows.Forms.Label();
            this.txtRespawnStartDistance = new System.Windows.Forms.TextBox();
            this.lblRespawnStartDistance = new System.Windows.Forms.Label();
            this.lblMeters = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.txtNearMissDistance = new System.Windows.Forms.TextBox();
            this.txtDataCollectionPeriod = new System.Windows.Forms.TextBox();
            this.lblDataCollectionPeriod = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbPreset = new System.Windows.Forms.ComboBox();
            this.btnSetPreset = new System.Windows.Forms.Button();
            this.btnRenamePreset = new System.Windows.Forms.Button();
            this.btnRemovePreset = new System.Windows.Forms.Button();
            this.btnAddPreset = new System.Windows.Forms.Button();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.btnEditTrial = new System.Windows.Forms.Button();
            this.btnRemoveTrial = new System.Windows.Forms.Button();
            this.btnAddTrial = new System.Windows.Forms.Button();
            this.databaseDataSet = new VR3GUI.DatabaseDataSet();
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCopyTrial = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbProgramConfiguration.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Sex);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(368, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Participant Variables";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sex:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Sex
            // 
            this.Sex.FormattingEnabled = true;
            this.Sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Sex.Location = new System.Drawing.Point(262, 50);
            this.Sex.Margin = new System.Windows.Forms.Padding(2);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(65, 21);
            this.Sex.TabIndex = 6;
            this.Sex.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Height (m):";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(166, 50);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(53, 20);
            this.txtAge.TabIndex = 3;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(70, 50);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(53, 20);
            this.txtHeight.TabIndex = 2;
            this.txtHeight.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(35, 16);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(310, 20);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Location = new System.Drawing.Point(390, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(250, 84);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quick Conversion";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 53);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Set As Height";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Inches:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = " Feet:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Height (m):";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(171, 15);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(53, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(82, 53);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(53, 20);
            this.textBox5.TabIndex = 2;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(70, 17);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(53, 20);
            this.textBox6.TabIndex = 1;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Trials:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // gbProgramConfiguration
            // 
            this.gbProgramConfiguration.Controls.Add(this.label18);
            this.gbProgramConfiguration.Controls.Add(this.label15);
            this.gbProgramConfiguration.Controls.Add(this.iST);
            this.gbProgramConfiguration.Controls.Add(this.gbOptions);
            this.gbProgramConfiguration.Controls.Add(this.label9);
            this.gbProgramConfiguration.Controls.Add(this.label10);
            this.gbProgramConfiguration.Controls.Add(this.txtMaxPitchAngle);
            this.gbProgramConfiguration.Controls.Add(this.txtPartialCheckAngle);
            this.gbProgramConfiguration.Controls.Add(this.label11);
            this.gbProgramConfiguration.Controls.Add(this.txtFullCheckAngle);
            this.gbProgramConfiguration.Controls.Add(this.label12);
            this.gbProgramConfiguration.Controls.Add(this.lblPartialCheckAngle);
            this.gbProgramConfiguration.Controls.Add(this.lblFullCheckAngle);
            this.gbProgramConfiguration.Controls.Add(this.lblNearMissDistance);
            this.gbProgramConfiguration.Controls.Add(this.label13);
            this.gbProgramConfiguration.Controls.Add(this.label14);
            this.gbProgramConfiguration.Controls.Add(this.txtRespawnEndDistance);
            this.gbProgramConfiguration.Controls.Add(this.lblRespawnEndDistance);
            this.gbProgramConfiguration.Controls.Add(this.txtRespawnStartDistance);
            this.gbProgramConfiguration.Controls.Add(this.lblRespawnStartDistance);
            this.gbProgramConfiguration.Controls.Add(this.lblMeters);
            this.gbProgramConfiguration.Controls.Add(this.lblSeconds);
            this.gbProgramConfiguration.Controls.Add(this.txtNearMissDistance);
            this.gbProgramConfiguration.Controls.Add(this.txtDataCollectionPeriod);
            this.gbProgramConfiguration.Controls.Add(this.lblDataCollectionPeriod);
            this.gbProgramConfiguration.Location = new System.Drawing.Point(664, 133);
            this.gbProgramConfiguration.Name = "gbProgramConfiguration";
            this.gbProgramConfiguration.Size = new System.Drawing.Size(384, 332);
            this.gbProgramConfiguration.TabIndex = 13;
            this.gbProgramConfiguration.TabStop = false;
            this.gbProgramConfiguration.Text = "Program Config";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(178, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "seconds";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Intial Spawn Time:";
            this.label15.Click += new System.EventHandler(this.Label15_Click);
            // 
            // iST
            // 
            this.iST.Location = new System.Drawing.Point(137, 64);
            this.iST.Name = "iST";
            this.iST.Size = new System.Drawing.Size(37, 20);
            this.iST.TabIndex = 21;
            this.iST.Text = "2.0";
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.lblExtension);
            this.gbOptions.Controls.Add(this.textBox7);
            this.gbOptions.Controls.Add(this.btnBrowsePath);
            this.gbOptions.Controls.Add(this.txtPath);
            this.gbOptions.Controls.Add(this.lblVrPath);
            this.gbOptions.Location = new System.Drawing.Point(0, 202);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(352, 80);
            this.gbOptions.TabIndex = 14;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "File Saving Directory";
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(8, 22);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(96, 13);
            this.lblExtension.TabIndex = 12;
            this.lblExtension.Text = "VR File Extension :";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(104, 19);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(64, 20);
            this.textBox7.TabIndex = 11;
            this.textBox7.Text = ".txt";
            // 
            // btnBrowsePath
            // 
            this.btnBrowsePath.Location = new System.Drawing.Point(289, 43);
            this.btnBrowsePath.Name = "btnBrowsePath";
            this.btnBrowsePath.Size = new System.Drawing.Size(54, 23);
            this.btnBrowsePath.TabIndex = 10;
            this.btnBrowsePath.Text = "Browse...";
            this.btnBrowsePath.UseVisualStyleBackColor = true;
            this.btnBrowsePath.Click += new System.EventHandler(this.BtnBrowsePath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(104, 45);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(182, 20);
            this.txtPath.TabIndex = 9;
            this.txtPath.Text = "C:\\\\vr\\\\vr3\\\\_testing_data\\\\";
            this.txtPath.TextChanged += new System.EventHandler(this.TxtPath_TextChanged);
            // 
            // lblVrPath
            // 
            this.lblVrPath.AutoSize = true;
            this.lblVrPath.Location = new System.Drawing.Point(9, 48);
            this.lblVrPath.Name = "lblVrPath";
            this.lblVrPath.Size = new System.Drawing.Size(91, 13);
            this.lblVrPath.TabIndex = 8;
            this.lblVrPath.Text = "Path to VR Data :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(180, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "degrees";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(180, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "degrees";
            // 
            // txtMaxPitchAngle
            // 
            this.txtMaxPitchAngle.Location = new System.Drawing.Point(137, 177);
            this.txtMaxPitchAngle.Name = "txtMaxPitchAngle";
            this.txtMaxPitchAngle.Size = new System.Drawing.Size(37, 20);
            this.txtMaxPitchAngle.TabIndex = 18;
            this.txtMaxPitchAngle.Text = "20";
            // 
            // txtPartialCheckAngle
            // 
            this.txtPartialCheckAngle.Location = new System.Drawing.Point(137, 153);
            this.txtPartialCheckAngle.Name = "txtPartialCheckAngle";
            this.txtPartialCheckAngle.Size = new System.Drawing.Size(37, 20);
            this.txtPartialCheckAngle.TabIndex = 17;
            this.txtPartialCheckAngle.Text = "45";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(180, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "degrees";
            // 
            // txtFullCheckAngle
            // 
            this.txtFullCheckAngle.Location = new System.Drawing.Point(137, 132);
            this.txtFullCheckAngle.Name = "txtFullCheckAngle";
            this.txtFullCheckAngle.Size = new System.Drawing.Size(37, 20);
            this.txtFullCheckAngle.TabIndex = 15;
            this.txtFullCheckAngle.Text = "65";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Max Pitch Angle:";
            // 
            // lblPartialCheckAngle
            // 
            this.lblPartialCheckAngle.AutoSize = true;
            this.lblPartialCheckAngle.Location = new System.Drawing.Point(6, 160);
            this.lblPartialCheckAngle.Name = "lblPartialCheckAngle";
            this.lblPartialCheckAngle.Size = new System.Drawing.Size(103, 13);
            this.lblPartialCheckAngle.TabIndex = 13;
            this.lblPartialCheckAngle.Text = "Partial Check Angle:";
            // 
            // lblFullCheckAngle
            // 
            this.lblFullCheckAngle.AutoSize = true;
            this.lblFullCheckAngle.Location = new System.Drawing.Point(6, 137);
            this.lblFullCheckAngle.Name = "lblFullCheckAngle";
            this.lblFullCheckAngle.Size = new System.Drawing.Size(90, 13);
            this.lblFullCheckAngle.TabIndex = 12;
            this.lblFullCheckAngle.Text = "Full Check Angle:";
            // 
            // lblNearMissDistance
            // 
            this.lblNearMissDistance.AutoSize = true;
            this.lblNearMissDistance.Location = new System.Drawing.Point(6, 43);
            this.lblNearMissDistance.Name = "lblNearMissDistance";
            this.lblNearMissDistance.Size = new System.Drawing.Size(102, 13);
            this.lblNearMissDistance.TabIndex = 2;
            this.lblNearMissDistance.Text = "Near-Miss Distance:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(180, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "meters";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(180, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "meters";
            // 
            // txtRespawnEndDistance
            // 
            this.txtRespawnEndDistance.Location = new System.Drawing.Point(137, 111);
            this.txtRespawnEndDistance.Name = "txtRespawnEndDistance";
            this.txtRespawnEndDistance.Size = new System.Drawing.Size(37, 20);
            this.txtRespawnEndDistance.TabIndex = 9;
            this.txtRespawnEndDistance.Text = "130";
            // 
            // lblRespawnEndDistance
            // 
            this.lblRespawnEndDistance.AutoSize = true;
            this.lblRespawnEndDistance.Location = new System.Drawing.Point(6, 115);
            this.lblRespawnEndDistance.Name = "lblRespawnEndDistance";
            this.lblRespawnEndDistance.Size = new System.Drawing.Size(122, 13);
            this.lblRespawnEndDistance.TabIndex = 8;
            this.lblRespawnEndDistance.Text = "Respawn End Distance:";
            // 
            // txtRespawnStartDistance
            // 
            this.txtRespawnStartDistance.Location = new System.Drawing.Point(137, 90);
            this.txtRespawnStartDistance.Name = "txtRespawnStartDistance";
            this.txtRespawnStartDistance.Size = new System.Drawing.Size(37, 20);
            this.txtRespawnStartDistance.TabIndex = 7;
            this.txtRespawnStartDistance.Text = "-200";
            this.txtRespawnStartDistance.TextChanged += new System.EventHandler(this.TxtRespawnStartDistance_TextChanged);
            // 
            // lblRespawnStartDistance
            // 
            this.lblRespawnStartDistance.AutoSize = true;
            this.lblRespawnStartDistance.Location = new System.Drawing.Point(6, 92);
            this.lblRespawnStartDistance.Name = "lblRespawnStartDistance";
            this.lblRespawnStartDistance.Size = new System.Drawing.Size(125, 13);
            this.lblRespawnStartDistance.TabIndex = 6;
            this.lblRespawnStartDistance.Text = "Respawn Start Distance:";
            // 
            // lblMeters
            // 
            this.lblMeters.AutoSize = true;
            this.lblMeters.Location = new System.Drawing.Point(180, 43);
            this.lblMeters.Name = "lblMeters";
            this.lblMeters.Size = new System.Drawing.Size(38, 13);
            this.lblMeters.TabIndex = 5;
            this.lblMeters.Text = "meters";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(180, 21);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(47, 13);
            this.lblSeconds.TabIndex = 4;
            this.lblSeconds.Text = "seconds";
            // 
            // txtNearMissDistance
            // 
            this.txtNearMissDistance.Location = new System.Drawing.Point(137, 41);
            this.txtNearMissDistance.Name = "txtNearMissDistance";
            this.txtNearMissDistance.Size = new System.Drawing.Size(37, 20);
            this.txtNearMissDistance.TabIndex = 3;
            this.txtNearMissDistance.Text = "1";
            this.txtNearMissDistance.TextChanged += new System.EventHandler(this.txtNearMissDistance_TextChanged);
            // 
            // txtDataCollectionPeriod
            // 
            this.txtDataCollectionPeriod.Location = new System.Drawing.Point(137, 18);
            this.txtDataCollectionPeriod.Name = "txtDataCollectionPeriod";
            this.txtDataCollectionPeriod.Size = new System.Drawing.Size(37, 20);
            this.txtDataCollectionPeriod.TabIndex = 1;
            this.txtDataCollectionPeriod.Text = "0.01";
            this.txtDataCollectionPeriod.TextChanged += new System.EventHandler(this.txtDataCollectionPeriod_TextChanged);
            // 
            // lblDataCollectionPeriod
            // 
            this.lblDataCollectionPeriod.AutoSize = true;
            this.lblDataCollectionPeriod.Location = new System.Drawing.Point(6, 19);
            this.lblDataCollectionPeriod.Name = "lblDataCollectionPeriod";
            this.lblDataCollectionPeriod.Size = new System.Drawing.Size(115, 13);
            this.lblDataCollectionPeriod.TabIndex = 0;
            this.lblDataCollectionPeriod.Text = "Data Collection Period:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Location = new System.Drawing.Point(653, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(140, 84);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Speed Conversion";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 21);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = " km/hr:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(26, 50);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "m/s:";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(58, 50);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(53, 20);
            this.textBox9.TabIndex = 2;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(58, 19);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(53, 20);
            this.textBox10.TabIndex = 1;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbPreset);
            this.groupBox4.Controls.Add(this.btnSetPreset);
            this.groupBox4.Controls.Add(this.btnRenamePreset);
            this.groupBox4.Controls.Add(this.btnRemovePreset);
            this.groupBox4.Controls.Add(this.btnAddPreset);
            this.groupBox4.Controls.Add(this.conditionLabel);
            this.groupBox4.Location = new System.Drawing.Point(815, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 83);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Preset Conditions";
            // 
            // cbPreset
            // 
            this.cbPreset.DisplayMember = "Name";
            this.cbPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPreset.FormattingEnabled = true;
            this.cbPreset.Location = new System.Drawing.Point(67, 20);
            this.cbPreset.Name = "cbPreset";
            this.cbPreset.Size = new System.Drawing.Size(160, 21);
            this.cbPreset.TabIndex = 0;
            this.cbPreset.SelectedIndexChanged += new System.EventHandler(this.CbPreset_SelectedIndexChanged);
            // 
            // btnSetPreset
            // 
            this.btnSetPreset.Location = new System.Drawing.Point(59, 49);
            this.btnSetPreset.Name = "btnSetPreset";
            this.btnSetPreset.Size = new System.Drawing.Size(47, 23);
            this.btnSetPreset.TabIndex = 4;
            this.btnSetPreset.Text = "Load";
            this.btnSetPreset.UseVisualStyleBackColor = true;
            this.btnSetPreset.Click += new System.EventHandler(this.BtnSetPreset_Click);
            // 
            // btnRenamePreset
            // 
            this.btnRenamePreset.Location = new System.Drawing.Point(112, 49);
            this.btnRenamePreset.Name = "btnRenamePreset";
            this.btnRenamePreset.Size = new System.Drawing.Size(55, 23);
            this.btnRenamePreset.TabIndex = 3;
            this.btnRenamePreset.Text = "Edit";
            this.btnRenamePreset.UseVisualStyleBackColor = true;
            this.btnRenamePreset.Click += new System.EventHandler(this.BtnRenamePreset_Click);
            // 
            // btnRemovePreset
            // 
            this.btnRemovePreset.Location = new System.Drawing.Point(173, 50);
            this.btnRemovePreset.Name = "btnRemovePreset";
            this.btnRemovePreset.Size = new System.Drawing.Size(60, 23);
            this.btnRemovePreset.TabIndex = 2;
            this.btnRemovePreset.Text = "Remove";
            this.btnRemovePreset.UseVisualStyleBackColor = true;
            this.btnRemovePreset.Click += new System.EventHandler(this.BtnRemovePreset_Click);
            // 
            // btnAddPreset
            // 
            this.btnAddPreset.Location = new System.Drawing.Point(6, 49);
            this.btnAddPreset.Name = "btnAddPreset";
            this.btnAddPreset.Size = new System.Drawing.Size(47, 23);
            this.btnAddPreset.TabIndex = 1;
            this.btnAddPreset.Text = "Add...";
            this.btnAddPreset.UseVisualStyleBackColor = true;
            this.btnAddPreset.Click += new System.EventHandler(this.BtnAddPreset_Click);
            // 
            // conditionLabel
            // 
            this.conditionLabel.AutoSize = true;
            this.conditionLabel.Location = new System.Drawing.Point(6, 22);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(54, 13);
            this.conditionLabel.TabIndex = 18;
            this.conditionLabel.Text = "Condition:";
            // 
            // btnEditTrial
            // 
            this.btnEditTrial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditTrial.Location = new System.Drawing.Point(360, 535);
            this.btnEditTrial.Name = "btnEditTrial";
            this.btnEditTrial.Size = new System.Drawing.Size(75, 23);
            this.btnEditTrial.TabIndex = 20;
            this.btnEditTrial.Text = "Edit Trial...";
            this.btnEditTrial.UseVisualStyleBackColor = true;
            this.btnEditTrial.Click += new System.EventHandler(this.BtnEditTrial_Click);
            // 
            // btnRemoveTrial
            // 
            this.btnRemoveTrial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveTrial.Location = new System.Drawing.Point(261, 535);
            this.btnRemoveTrial.Name = "btnRemoveTrial";
            this.btnRemoveTrial.Size = new System.Drawing.Size(93, 23);
            this.btnRemoveTrial.TabIndex = 19;
            this.btnRemoveTrial.Text = "Remove Trial...";
            this.btnRemoveTrial.UseVisualStyleBackColor = true;
            this.btnRemoveTrial.Click += new System.EventHandler(this.btnRemoveTrial_Click);
            // 
            // btnAddTrial
            // 
            this.btnAddTrial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddTrial.Location = new System.Drawing.Point(180, 535);
            this.btnAddTrial.Name = "btnAddTrial";
            this.btnAddTrial.Size = new System.Drawing.Size(75, 23);
            this.btnAddTrial.TabIndex = 18;
            this.btnAddTrial.Text = "Add Trial...";
            this.btnAddTrial.UseVisualStyleBackColor = true;
            this.btnAddTrial.Click += new System.EventHandler(this.btnAddTrial_Click);
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            this.databaseDataSetBindingSource.CurrentChanged += new System.EventHandler(this.DatabaseDataSetBindingSource_CurrentChanged);
            // 
            // btnCopyTrial
            // 
            this.btnCopyTrial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyTrial.Location = new System.Drawing.Point(99, 535);
            this.btnCopyTrial.Name = "btnCopyTrial";
            this.btnCopyTrial.Size = new System.Drawing.Size(75, 23);
            this.btnCopyTrial.TabIndex = 21;
            this.btnCopyTrial.Text = "Copy Trial";
            this.btnCopyTrial.UseVisualStyleBackColor = true;
            this.btnCopyTrial.Click += new System.EventHandler(this.btnCopyTrial_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Location = new System.Drawing.Point(824, 526);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 32);
            this.btnStart.TabIndex = 24;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 134);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(628, 359);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(441, 535);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Clear All ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(22, 535);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Randomize Order";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1116, 616);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnCopyTrial);
            this.Controls.Add(this.btnEditTrial);
            this.Controls.Add(this.btnRemoveTrial);
            this.Controls.Add(this.btnAddTrial);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbProgramConfiguration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "VR3.0 GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbProgramConfiguration.ResumeLayout(false);
            this.gbProgramConfiguration.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Sex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.GroupBox gbProgramConfiguration;
        internal System.Windows.Forms.GroupBox gbOptions;
        internal System.Windows.Forms.Label lblExtension;
        internal System.Windows.Forms.TextBox textBox7;
        internal System.Windows.Forms.Button btnBrowsePath;
        internal System.Windows.Forms.Label lblVrPath;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txtMaxPitchAngle;
        internal System.Windows.Forms.TextBox txtPartialCheckAngle;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox txtFullCheckAngle;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label lblPartialCheckAngle;
        internal System.Windows.Forms.Label lblFullCheckAngle;
        internal System.Windows.Forms.Label lblNearMissDistance;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.TextBox txtRespawnEndDistance;
        internal System.Windows.Forms.Label lblRespawnEndDistance;
        internal System.Windows.Forms.TextBox txtRespawnStartDistance;
        internal System.Windows.Forms.Label lblRespawnStartDistance;
        internal System.Windows.Forms.Label lblMeters;
        internal System.Windows.Forms.Label lblSeconds;
        internal System.Windows.Forms.TextBox txtNearMissDistance;
        internal System.Windows.Forms.TextBox txtDataCollectionPeriod;
        internal System.Windows.Forms.Label lblDataCollectionPeriod;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.ComboBox cbPreset;
        internal System.Windows.Forms.Button btnSetPreset;
        internal System.Windows.Forms.Button btnRenamePreset;
        internal System.Windows.Forms.Button btnRemovePreset;
        internal System.Windows.Forms.Button btnAddPreset;
        internal System.Windows.Forms.Label conditionLabel;
        internal System.Windows.Forms.Button btnEditTrial;
        internal System.Windows.Forms.Button btnRemoveTrial;
        internal System.Windows.Forms.Button btnAddTrial;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        internal System.Windows.Forms.Button btnCopyTrial;
        internal System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.TextBox iST;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtPath;
        internal System.Windows.Forms.Button button3;
    }
}

