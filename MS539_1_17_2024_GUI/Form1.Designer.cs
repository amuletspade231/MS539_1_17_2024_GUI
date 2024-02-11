namespace SV_Crop_Calendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.seasonCalendar = new System.Windows.Forms.MonthCalendar();
            this.cropCLB = new System.Windows.Forms.CheckedListBox();
            this.noneRB = new System.Windows.Forms.RadioButton();
            this.speedGroRB = new System.Windows.Forms.RadioButton();
            this.deluxeSGRB = new System.Windows.Forms.RadioButton();
            this.calendarLabel = new System.Windows.Forms.Label();
            this.cropCLBLabel = new System.Windows.Forms.Label();
            this.SGRBLabel = new System.Windows.Forms.Label();
            this.parsnipPB = new System.Windows.Forms.PictureBox();
            this.strawberryPB = new System.Windows.Forms.PictureBox();
            this.cauliflowerPB = new System.Windows.Forms.PictureBox();
            this.tulipPB = new System.Windows.Forms.PictureBox();
            this.CropStatusLabel = new System.Windows.Forms.Label();
            this.parsnipStatusLabel = new System.Windows.Forms.Label();
            this.strawberryStatusLabel = new System.Windows.Forms.Label();
            this.cauliflowerStatusLabel = new System.Windows.Forms.Label();
            this.tulipStatusLabel = new System.Windows.Forms.Label();
            this.cropStatusPanel = new System.Windows.Forms.Panel();
            this.seasonMenuStrip = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.springToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomBtn = new System.Windows.Forms.Button();
            this.crop0 = new System.Windows.Forms.PictureBox();
            this.crop5 = new System.Windows.Forms.PictureBox();
            this.crop10 = new System.Windows.Forms.PictureBox();
            this.crop1 = new System.Windows.Forms.PictureBox();
            this.crop6 = new System.Windows.Forms.PictureBox();
            this.crop11 = new System.Windows.Forms.PictureBox();
            this.crop2 = new System.Windows.Forms.PictureBox();
            this.crop7 = new System.Windows.Forms.PictureBox();
            this.crop12 = new System.Windows.Forms.PictureBox();
            this.crop3 = new System.Windows.Forms.PictureBox();
            this.crop8 = new System.Windows.Forms.PictureBox();
            this.crop13 = new System.Windows.Forms.PictureBox();
            this.crop4 = new System.Windows.Forms.PictureBox();
            this.crop9 = new System.Windows.Forms.PictureBox();
            this.crop14 = new System.Windows.Forms.PictureBox();
            this.cropPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.parsnipPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strawberryPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cauliflowerPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tulipPB)).BeginInit();
            this.cropStatusPanel.SuspendLayout();
            this.seasonMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crop0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop14)).BeginInit();
            this.cropPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // seasonCalendar
            // 
            this.seasonCalendar.Location = new System.Drawing.Point(18, 18);
            this.seasonCalendar.MaxDate = new System.DateTime(2023, 2, 28, 0, 0, 0, 0);
            this.seasonCalendar.MaxSelectionCount = 1;
            this.seasonCalendar.MinDate = new System.DateTime(2023, 2, 1, 0, 0, 0, 0);
            this.seasonCalendar.Name = "seasonCalendar";
            this.seasonCalendar.ShowToday = false;
            this.seasonCalendar.ShowTodayCircle = false;
            this.seasonCalendar.TabIndex = 0;
            this.seasonCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.seasonCalendar_DateChanged);
            // 
            // cropCLB
            // 
            this.cropCLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cropCLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cropCLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cropCLB.FormattingEnabled = true;
            this.cropCLB.Items.AddRange(new object[] {
            "Parsnip",
            "Strawberry",
            "Cauliflower",
            "Tulip"});
            this.cropCLB.Location = new System.Drawing.Point(483, 55);
            this.cropCLB.Name = "cropCLB";
            this.cropCLB.Size = new System.Drawing.Size(170, 76);
            this.cropCLB.TabIndex = 1;
            this.cropCLB.ItemCheck += this.cropCLB_ItemCheck;
            // 
            // noneRB
            // 
            this.noneRB.AutoSize = true;
            this.noneRB.Checked = true;
            this.noneRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noneRB.Location = new System.Drawing.Point(275, 55);
            this.noneRB.Name = "noneRB";
            this.noneRB.Size = new System.Drawing.Size(123, 22);
            this.noneRB.TabIndex = 2;
            this.noneRB.TabStop = true;
            this.noneRB.Text = "No Speed-Gro";
            this.noneRB.UseVisualStyleBackColor = true;
            this.noneRB.CheckedChanged += new System.EventHandler(this.noneRB_CheckedChanged);
            // 
            // speedGroRB
            // 
            this.speedGroRB.AutoSize = true;
            this.speedGroRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedGroRB.Location = new System.Drawing.Point(275, 79);
            this.speedGroRB.Name = "speedGroRB";
            this.speedGroRB.Size = new System.Drawing.Size(99, 22);
            this.speedGroRB.TabIndex = 3;
            this.speedGroRB.TabStop = true;
            this.speedGroRB.Text = "Speed-Gro";
            this.speedGroRB.UseVisualStyleBackColor = true;
            this.speedGroRB.CheckedChanged += new System.EventHandler(this.speedGroRB_CheckedChanged);
            // 
            // deluxeSGRB
            // 
            this.deluxeSGRB.AutoSize = true;
            this.deluxeSGRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deluxeSGRB.Location = new System.Drawing.Point(275, 103);
            this.deluxeSGRB.Name = "deluxeSGRB";
            this.deluxeSGRB.Size = new System.Drawing.Size(148, 22);
            this.deluxeSGRB.TabIndex = 4;
            this.deluxeSGRB.TabStop = true;
            this.deluxeSGRB.Text = "Deluxe Speed-Gro";
            this.deluxeSGRB.UseVisualStyleBackColor = true;
            this.deluxeSGRB.CheckedChanged += new System.EventHandler(this.deluxeSGRB_CheckedChanged);
            // 
            // calendarLabel
            // 
            this.calendarLabel.AutoSize = true;
            this.calendarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarLabel.Location = new System.Drawing.Point(94, 28);
            this.calendarLabel.Name = "calendarLabel";
            this.calendarLabel.Size = new System.Drawing.Size(74, 25);
            this.calendarLabel.TabIndex = 5;
            this.calendarLabel.Text = "Spring";
            // 
            // cropCLBLabel
            // 
            this.cropCLBLabel.AutoSize = true;
            this.cropCLBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cropCLBLabel.Location = new System.Drawing.Point(479, 18);
            this.cropCLBLabel.Name = "cropCLBLabel";
            this.cropCLBLabel.Size = new System.Drawing.Size(215, 20);
            this.cropCLBLabel.TabIndex = 6;
            this.cropCLBLabel.Text = "What crops are you planting?";
            // 
            // SGRBLabel
            // 
            this.SGRBLabel.AutoSize = true;
            this.SGRBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SGRBLabel.Location = new System.Drawing.Point(271, 18);
            this.SGRBLabel.Name = "SGRBLabel";
            this.SGRBLabel.Size = new System.Drawing.Size(173, 20);
            this.SGRBLabel.TabIndex = 7;
            this.SGRBLabel.Text = "Are you using fertilizer?";
            // 
            // parsnipPB
            // 
            this.parsnipPB.Image = ((System.Drawing.Image)(resources.GetObject("parsnipPB.Image")));
            this.parsnipPB.InitialImage = ((System.Drawing.Image)(resources.GetObject("parsnipPB.InitialImage")));
            this.parsnipPB.Location = new System.Drawing.Point(84, 249);
            this.parsnipPB.Name = "parsnipPB";
            this.parsnipPB.Size = new System.Drawing.Size(47, 50);
            this.parsnipPB.TabIndex = 8;
            this.parsnipPB.TabStop = false;
            // 
            // strawberryPB
            // 
            this.strawberryPB.Image = ((System.Drawing.Image)(resources.GetObject("strawberryPB.Image")));
            this.strawberryPB.Location = new System.Drawing.Point(241, 249);
            this.strawberryPB.Name = "strawberryPB";
            this.strawberryPB.Size = new System.Drawing.Size(49, 50);
            this.strawberryPB.TabIndex = 9;
            this.strawberryPB.TabStop = false;
            // 
            // cauliflowerPB
            // 
            this.cauliflowerPB.Image = ((System.Drawing.Image)(resources.GetObject("cauliflowerPB.Image")));
            this.cauliflowerPB.Location = new System.Drawing.Point(401, 249);
            this.cauliflowerPB.Name = "cauliflowerPB";
            this.cauliflowerPB.Size = new System.Drawing.Size(50, 50);
            this.cauliflowerPB.TabIndex = 10;
            this.cauliflowerPB.TabStop = false;
            // 
            // tulipPB
            // 
            this.tulipPB.Image = ((System.Drawing.Image)(resources.GetObject("tulipPB.Image")));
            this.tulipPB.Location = new System.Drawing.Point(566, 249);
            this.tulipPB.Name = "tulipPB";
            this.tulipPB.Size = new System.Drawing.Size(51, 50);
            this.tulipPB.TabIndex = 11;
            this.tulipPB.TabStop = false;
            // 
            // CropStatusLabel
            // 
            this.CropStatusLabel.AutoSize = true;
            this.CropStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CropStatusLabel.Location = new System.Drawing.Point(292, 201);
            this.CropStatusLabel.Name = "CropStatusLabel";
            this.CropStatusLabel.Size = new System.Drawing.Size(106, 24);
            this.CropStatusLabel.TabIndex = 12;
            this.CropStatusLabel.Text = "Crop Status";
            // 
            // parsnipStatusLabel
            // 
            this.parsnipStatusLabel.AutoSize = true;
            this.parsnipStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parsnipStatusLabel.Location = new System.Drawing.Point(16, 0);
            this.parsnipStatusLabel.Name = "parsnipStatusLabel";
            this.parsnipStatusLabel.Size = new System.Drawing.Size(91, 20);
            this.parsnipStatusLabel.TabIndex = 13;
            this.parsnipStatusLabel.Text = "Not planted";
            // 
            // strawberryStatusLabel
            // 
            this.strawberryStatusLabel.AutoSize = true;
            this.strawberryStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strawberryStatusLabel.Location = new System.Drawing.Point(173, 0);
            this.strawberryStatusLabel.Name = "strawberryStatusLabel";
            this.strawberryStatusLabel.Size = new System.Drawing.Size(91, 20);
            this.strawberryStatusLabel.TabIndex = 14;
            this.strawberryStatusLabel.Text = "Not planted";
            // 
            // cauliflowerStatusLabel
            // 
            this.cauliflowerStatusLabel.AutoSize = true;
            this.cauliflowerStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cauliflowerStatusLabel.Location = new System.Drawing.Point(333, 0);
            this.cauliflowerStatusLabel.Name = "cauliflowerStatusLabel";
            this.cauliflowerStatusLabel.Size = new System.Drawing.Size(91, 20);
            this.cauliflowerStatusLabel.TabIndex = 15;
            this.cauliflowerStatusLabel.Text = "Not planted";
            // 
            // tulipStatusLabel
            // 
            this.tulipStatusLabel.AutoSize = true;
            this.tulipStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tulipStatusLabel.Location = new System.Drawing.Point(498, 0);
            this.tulipStatusLabel.Name = "tulipStatusLabel";
            this.tulipStatusLabel.Size = new System.Drawing.Size(91, 20);
            this.tulipStatusLabel.TabIndex = 16;
            this.tulipStatusLabel.Text = "Not planted";
            // 
            // cropStatusPanel
            // 
            this.cropStatusPanel.Controls.Add(this.parsnipStatusLabel);
            this.cropStatusPanel.Controls.Add(this.strawberryStatusLabel);
            this.cropStatusPanel.Controls.Add(this.cauliflowerStatusLabel);
            this.cropStatusPanel.Controls.Add(this.tulipStatusLabel);
            this.cropStatusPanel.Location = new System.Drawing.Point(64, 305);
            this.cropStatusPanel.Name = "cropStatusPanel";
            this.cropStatusPanel.Size = new System.Drawing.Size(630, 30);
            this.cropStatusPanel.TabIndex = 17;
            // 
            // seasonMenuStrip
            // 
            this.seasonMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.springToolStripMenuItem});
            this.seasonMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.seasonMenuStrip.Name = "seasonMenuStrip";
            this.seasonMenuStrip.Size = new System.Drawing.Size(748, 24);
            this.seasonMenuStrip.TabIndex = 18;
            this.seasonMenuStrip.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // springToolStripMenuItem
            // 
            this.springToolStripMenuItem.Name = "springToolStripMenuItem";
            this.springToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.springToolStripMenuItem.Text = "Spring";
            this.springToolStripMenuItem.Click += new System.EventHandler(this.springToolStripMenuItem_Click);
            // 
            // randomBtn
            // 
            this.randomBtn.Location = new System.Drawing.Point(275, 157);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(75, 23);
            this.randomBtn.TabIndex = 19;
            this.randomBtn.Text = "Random";
            this.randomBtn.UseVisualStyleBackColor = true;
            this.randomBtn.Click += new System.EventHandler(this.randomBtn_Click);
            // 
            // crop0
            // 
            this.crop0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.crop0.Location = new System.Drawing.Point(9, 7);
            this.crop0.Name = "crop0";
            this.crop0.Size = new System.Drawing.Size(50, 50);
            this.crop0.TabIndex = 20;
            this.crop0.TabStop = false;
            this.crop0.Click += new System.EventHandler(this.crop_Click);
            // 
            // crop5
            // 
            this.crop5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.crop5.Location = new System.Drawing.Point(9, 63);
            this.crop5.Name = "crop5";
            this.crop5.Size = new System.Drawing.Size(50, 50);
            this.crop5.TabIndex = 21;
            this.crop5.TabStop = false;
            this.crop5.Click += new System.EventHandler(this.crop_Click);
            // 
            // crop10
            // 
            this.crop10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.crop10.Location = new System.Drawing.Point(9, 119);
            this.crop10.Name = "crop10";
            this.crop10.Size = new System.Drawing.Size(50, 50);
            this.crop10.TabIndex = 22;
            this.crop10.TabStop = false;
            this.crop10.Click += new System.EventHandler(this.crop_Click);
            // 
            // crop1
            // 
            this.crop1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.crop1.Location = new System.Drawing.Point(66, 7);
            this.crop1.Name = "crop1";
            this.crop1.Size = new System.Drawing.Size(50, 50);
            this.crop1.TabIndex = 23;
            this.crop1.TabStop = false;
            this.crop1.Click += new System.EventHandler(this.crop_Click);
            // 
            // crop6
            // 
            this.crop6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.crop6.Location = new System.Drawing.Point(66, 63);
            this.crop6.Name = "crop6";
            this.crop6.Size = new System.Drawing.Size(50, 50);
            this.crop6.TabIndex = 24;
            this.crop6.TabStop = false;
            this.crop6.Click += new System.EventHandler(this.crop_Click);
            // 
            // crop11
            // 
            this.crop11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.crop11.Location = new System.Drawing.Point(66, 119);
            this.crop11.Name = "crop11";
            this.crop11.Size = new System.Drawing.Size(50, 50);
            this.crop11.TabIndex = 25;
            this.crop11.TabStop = false;
            this.crop11.Click += new System.EventHandler(this.crop_Click);
            // 
            // crop2
            // 
            this.crop2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.crop2.Location = new System.Drawing.Point(122, 7);
            this.crop2.Name = "crop2";
            this.crop2.Size = new System.Drawing.Size(50, 50);
            this.crop2.TabIndex = 26;
            this.crop2.TabStop = false;
            this.crop2.Click += new System.EventHandler(this.crop_Click);
            // 
            // crop7
            // 
            this.crop7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.crop7.Location = new System.Drawing.Point(122, 63);
            this.crop7.Name = "crop7";
            this.crop7.Size = new System.Drawing.Size(50, 50);
            this.crop7.TabIndex = 27;
            this.crop7.TabStop = false;
            this.crop7.Click += new System.EventHandler(this.crop_Click);
            // 
            // crop12
            // 
            this.crop12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.crop12.Location = new System.Drawing.Point(122, 119);
            this.crop12.Name = "crop12";
            this.crop12.Size = new System.Drawing.Size(50, 50);
            this.crop12.TabIndex = 28;
            this.crop12.TabStop = false;
            this.crop12.Click += new System.EventHandler(this.crop_Click);
            // 
            // crop3
            // 
            this.crop3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.crop3.Location = new System.Drawing.Point(178, 7);
            this.crop3.Name = "crop3";
            this.crop3.Size = new System.Drawing.Size(50, 50);
            this.crop3.TabIndex = 29;
            this.crop3.TabStop = false;
            this.crop3.Click += new System.EventHandler(this.crop_Click);
            // 
            // crop8
            // 
            this.crop8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.crop8.Location = new System.Drawing.Point(178, 63);
            this.crop8.Name = "crop8";
            this.crop8.Size = new System.Drawing.Size(50, 50);
            this.crop8.TabIndex = 30;
            this.crop8.TabStop = false;
            this.crop8.Click += new System.EventHandler(this.crop_Click);
            // 
            // crop13
            // 
            this.crop13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.crop13.Location = new System.Drawing.Point(178, 119);
            this.crop13.Name = "crop13";
            this.crop13.Size = new System.Drawing.Size(50, 50);
            this.crop13.TabIndex = 31;
            this.crop13.TabStop = false;
            this.crop13.Click += new System.EventHandler(this.crop_Click);
            // 
            // crop4
            // 
            this.crop4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.crop4.Location = new System.Drawing.Point(234, 7);
            this.crop4.Name = "crop4";
            this.crop4.Size = new System.Drawing.Size(50, 50);
            this.crop4.TabIndex = 32;
            this.crop4.TabStop = false;
            this.crop4.Click += new System.EventHandler(this.crop_Click);
            // 
            // crop9
            // 
            this.crop9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.crop9.Location = new System.Drawing.Point(234, 63);
            this.crop9.Name = "crop9";
            this.crop9.Size = new System.Drawing.Size(50, 50);
            this.crop9.TabIndex = 33;
            this.crop9.TabStop = false;
            this.crop9.Click += new System.EventHandler(this.crop_Click);
            // 
            // crop14
            // 
            this.crop14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.crop14.Location = new System.Drawing.Point(234, 119);
            this.crop14.Name = "crop14";
            this.crop14.Size = new System.Drawing.Size(50, 50);
            this.crop14.TabIndex = 34;
            this.crop14.TabStop = false;
            this.crop14.Click += new System.EventHandler(this.crop_Click);
            // 
            // cropPanel
            // 
            this.cropPanel.Controls.Add(this.crop14);
            this.cropPanel.Controls.Add(this.crop9);
            this.cropPanel.Controls.Add(this.crop4);
            this.cropPanel.Controls.Add(this.crop13);
            this.cropPanel.Controls.Add(this.crop8);
            this.cropPanel.Controls.Add(this.crop3);
            this.cropPanel.Controls.Add(this.crop12);
            this.cropPanel.Controls.Add(this.crop7);
            this.cropPanel.Controls.Add(this.crop2);
            this.cropPanel.Controls.Add(this.crop11);
            this.cropPanel.Controls.Add(this.crop6);
            this.cropPanel.Controls.Add(this.crop1);
            this.cropPanel.Controls.Add(this.crop10);
            this.cropPanel.Controls.Add(this.crop5);
            this.cropPanel.Controls.Add(this.crop0);
            this.cropPanel.Location = new System.Drawing.Point(223, 383);
            this.cropPanel.Name = "cropPanel";
            this.cropPanel.Size = new System.Drawing.Size(296, 180);
            this.cropPanel.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(748, 579);
            this.Controls.Add(this.cropPanel);
            this.Controls.Add(this.randomBtn);
            this.Controls.Add(this.cropStatusPanel);
            this.Controls.Add(this.CropStatusLabel);
            this.Controls.Add(this.tulipPB);
            this.Controls.Add(this.cauliflowerPB);
            this.Controls.Add(this.strawberryPB);
            this.Controls.Add(this.parsnipPB);
            this.Controls.Add(this.SGRBLabel);
            this.Controls.Add(this.cropCLBLabel);
            this.Controls.Add(this.calendarLabel);
            this.Controls.Add(this.deluxeSGRB);
            this.Controls.Add(this.speedGroRB);
            this.Controls.Add(this.noneRB);
            this.Controls.Add(this.cropCLB);
            this.Controls.Add(this.seasonCalendar);
            this.Name = "Form1";
            this.Text = "Stardew Valley Crop Calendar";
            ((System.ComponentModel.ISupportInitialize)(this.parsnipPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strawberryPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cauliflowerPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tulipPB)).EndInit();
            this.cropStatusPanel.ResumeLayout(false);
            this.cropStatusPanel.PerformLayout();
            this.seasonMenuStrip.ResumeLayout(false);
            this.seasonMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crop0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crop14)).EndInit();
            this.cropPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar seasonCalendar;
        private System.Windows.Forms.CheckedListBox cropCLB;
        private System.Windows.Forms.RadioButton noneRB;
        private System.Windows.Forms.RadioButton speedGroRB;
        private System.Windows.Forms.RadioButton deluxeSGRB;
        private System.Windows.Forms.Label calendarLabel;
        private System.Windows.Forms.Label cropCLBLabel;
        private System.Windows.Forms.Label SGRBLabel;
        private System.Windows.Forms.PictureBox parsnipPB;
        private System.Windows.Forms.PictureBox strawberryPB;
        private System.Windows.Forms.PictureBox cauliflowerPB;
        private System.Windows.Forms.PictureBox tulipPB;
        private System.Windows.Forms.Label CropStatusLabel;
        private System.Windows.Forms.Label parsnipStatusLabel;
        private System.Windows.Forms.Label strawberryStatusLabel;
        private System.Windows.Forms.Label cauliflowerStatusLabel;
        private System.Windows.Forms.Label tulipStatusLabel;
        private System.Windows.Forms.Panel cropStatusPanel;
        private System.Windows.Forms.MenuStrip seasonMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem springToolStripMenuItem;
        private System.Windows.Forms.Button randomBtn;
        private System.Windows.Forms.PictureBox crop0;
        private System.Windows.Forms.PictureBox crop5;
        private System.Windows.Forms.PictureBox crop10;
        private System.Windows.Forms.PictureBox crop1;
        private System.Windows.Forms.PictureBox crop6;
        private System.Windows.Forms.PictureBox crop11;
        private System.Windows.Forms.PictureBox crop2;
        private System.Windows.Forms.PictureBox crop7;
        private System.Windows.Forms.PictureBox crop12;
        private System.Windows.Forms.PictureBox crop3;
        private System.Windows.Forms.PictureBox crop8;
        private System.Windows.Forms.PictureBox crop13;
        private System.Windows.Forms.PictureBox crop4;
        private System.Windows.Forms.PictureBox crop9;
        private System.Windows.Forms.PictureBox crop14;
        private System.Windows.Forms.Panel cropPanel;
    }
}

