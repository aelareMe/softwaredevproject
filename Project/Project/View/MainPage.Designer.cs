namespace Project.View
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSubjectsEnrolled = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.currentPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.minmize = new System.Windows.Forms.Button();
            this.clse = new System.Windows.Forms.Button();
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.help_btn = new System.Windows.Forms.Button();
            this.edit_subject_btn = new System.Windows.Forms.Button();
            this.Setting_btn = new System.Windows.Forms.Button();
            this.addAcitivty_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.currentPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(80)))), ((int)(((byte)(139)))));
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subjects Enrolled:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(240, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "WELCOME:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(188)))), ((int)(((byte)(222)))));
            this.lblName.Location = new System.Drawing.Point(453, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 36);
            this.lblName.TabIndex = 6;
            // 
            // lblSubjectsEnrolled
            // 
            this.lblSubjectsEnrolled.AutoSize = true;
            this.lblSubjectsEnrolled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectsEnrolled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(188)))), ((int)(((byte)(222)))));
            this.lblSubjectsEnrolled.Location = new System.Drawing.Point(234, 32);
            this.lblSubjectsEnrolled.Name = "lblSubjectsEnrolled";
            this.lblSubjectsEnrolled.Size = new System.Drawing.Size(19, 20);
            this.lblSubjectsEnrolled.TabIndex = 9;
            this.lblSubjectsEnrolled.Text = "0";
            this.toolTip1.SetToolTip(this.lblSubjectsEnrolled, "Subject Enrolled");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(80)))), ((int)(((byte)(139)))));
            this.label2.Location = new System.Drawing.Point(145, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Subject List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(23, 143);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(444, 295);
            this.dataGridView1.TabIndex = 24;
            this.toolTip1.SetToolTip(this.dataGridView1, "All Listed Subject");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 52);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.Location = new System.Drawing.Point(503, 143);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(471, 295);
            this.dataGridView2.TabIndex = 25;
            this.toolTip1.SetToolTip(this.dataGridView2, "Listed Activities");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.currentPanel);
            this.panel1.Location = new System.Drawing.Point(221, 110);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 528);
            this.panel1.TabIndex = 26;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(80)))), ((int)(((byte)(139)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(767, 462);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(207, 52);
            this.button5.TabIndex = 29;
            this.button5.Text = "See Detailed Progress";
            this.toolTip1.SetToolTip(this.button5, "Set your study sessions and study progress");
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // currentPanel
            // 
            this.currentPanel.Controls.Add(this.label1);
            this.currentPanel.Controls.Add(this.lblSubjectsEnrolled);
            this.currentPanel.Location = new System.Drawing.Point(0, 0);
            this.currentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.currentPanel.Name = "currentPanel";
            this.currentPanel.Size = new System.Drawing.Size(991, 528);
            this.currentPanel.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1227, 652);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.minmize);
            this.panel3.Controls.Add(this.clse);
            this.panel3.Location = new System.Drawing.Point(221, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1005, 54);
            this.panel3.TabIndex = 30;
            // 
            // minmize
            // 
            this.minmize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(128)))), ((int)(((byte)(180)))));
            this.minmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minmize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minmize.ForeColor = System.Drawing.Color.White;
            this.minmize.Location = new System.Drawing.Point(869, 7);
            this.minmize.Margin = new System.Windows.Forms.Padding(4);
            this.minmize.Name = "minmize";
            this.minmize.Size = new System.Drawing.Size(55, 39);
            this.minmize.TabIndex = 29;
            this.minmize.Text = "___";
            this.toolTip1.SetToolTip(this.minmize, "Minimize");
            this.minmize.UseVisualStyleBackColor = false;
            this.minmize.Click += new System.EventHandler(this.minmize_Click);
            // 
            // clse
            // 
            this.clse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(80)))), ((int)(((byte)(139)))));
            this.clse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clse.ForeColor = System.Drawing.Color.White;
            this.clse.Location = new System.Drawing.Point(932, 7);
            this.clse.Margin = new System.Windows.Forms.Padding(4);
            this.clse.Name = "clse";
            this.clse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clse.Size = new System.Drawing.Size(55, 39);
            this.clse.TabIndex = 28;
            this.clse.Text = "X";
            this.toolTip1.SetToolTip(this.clse, "Close");
            this.clse.UseVisualStyleBackColor = false;
            this.clse.Click += new System.EventHandler(this.clse_Click);
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon2.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon2.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon2.Icon")));
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            this.notifyIcon2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel3;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // help_btn
            // 
            this.help_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(31)))));
            this.help_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.help_btn.FlatAppearance.BorderSize = 0;
            this.help_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_btn.ForeColor = System.Drawing.Color.White;
            this.help_btn.Image = ((System.Drawing.Image)(resources.GetObject("help_btn.Image")));
            this.help_btn.Location = new System.Drawing.Point(0, 118);
            this.help_btn.Margin = new System.Windows.Forms.Padding(4);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(167, 53);
            this.help_btn.TabIndex = 14;
            this.help_btn.Text = "  Help";
            this.help_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.help_btn, "Help");
            this.help_btn.UseVisualStyleBackColor = false;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // edit_subject_btn
            // 
            this.edit_subject_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(31)))));
            this.edit_subject_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.edit_subject_btn.FlatAppearance.BorderSize = 0;
            this.edit_subject_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_subject_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_subject_btn.ForeColor = System.Drawing.Color.White;
            this.edit_subject_btn.Image = ((System.Drawing.Image)(resources.GetObject("edit_subject_btn.Image")));
            this.edit_subject_btn.Location = new System.Drawing.Point(0, 125);
            this.edit_subject_btn.Margin = new System.Windows.Forms.Padding(4);
            this.edit_subject_btn.Name = "edit_subject_btn";
            this.edit_subject_btn.Size = new System.Drawing.Size(167, 65);
            this.edit_subject_btn.TabIndex = 9;
            this.edit_subject_btn.Text = "ADD SUBJECT";
            this.edit_subject_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.edit_subject_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.edit_subject_btn, "Add Subject");
            this.edit_subject_btn.UseVisualStyleBackColor = false;
            this.edit_subject_btn.Click += new System.EventHandler(this.edit_subject_btn_Click);
            // 
            // Setting_btn
            // 
            this.Setting_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(31)))));
            this.Setting_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Setting_btn.FlatAppearance.BorderSize = 0;
            this.Setting_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Setting_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setting_btn.ForeColor = System.Drawing.Color.White;
            this.Setting_btn.Image = ((System.Drawing.Image)(resources.GetObject("Setting_btn.Image")));
            this.Setting_btn.Location = new System.Drawing.Point(0, 65);
            this.Setting_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Setting_btn.Name = "Setting_btn";
            this.Setting_btn.Size = new System.Drawing.Size(167, 53);
            this.Setting_btn.TabIndex = 13;
            this.Setting_btn.Text = "  Setting";
            this.Setting_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.Setting_btn, "Setting");
            this.Setting_btn.UseVisualStyleBackColor = false;
            this.Setting_btn.Click += new System.EventHandler(this.Setting_btn_Click);
            // 
            // addAcitivty_btn
            // 
            this.addAcitivty_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(31)))));
            this.addAcitivty_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addAcitivty_btn.FlatAppearance.BorderSize = 0;
            this.addAcitivty_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAcitivty_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAcitivty_btn.ForeColor = System.Drawing.Color.White;
            this.addAcitivty_btn.Image = ((System.Drawing.Image)(resources.GetObject("addAcitivty_btn.Image")));
            this.addAcitivty_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addAcitivty_btn.Location = new System.Drawing.Point(0, 0);
            this.addAcitivty_btn.Margin = new System.Windows.Forms.Padding(4);
            this.addAcitivty_btn.Name = "addAcitivty_btn";
            this.addAcitivty_btn.Size = new System.Drawing.Size(167, 65);
            this.addAcitivty_btn.TabIndex = 12;
            this.addAcitivty_btn.Text = "ADD ACTIVITY";
            this.addAcitivty_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.addAcitivty_btn, "Add Activity");
            this.addAcitivty_btn.UseVisualStyleBackColor = false;
            this.addAcitivty_btn.Click += new System.EventHandler(this.addAcitivty_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(43, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Home");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(31)))));
            this.panel5.Controls.Add(this.help_btn);
            this.panel5.Controls.Add(this.Setting_btn);
            this.panel5.Controls.Add(this.addAcitivty_btn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 190);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(167, 195);
            this.panel5.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(31)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.edit_subject_btn);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(167, 652);
            this.panel4.TabIndex = 29;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(31)))));
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(167, 125);
            this.panel6.TabIndex = 7;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1227, 652);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.currentPanel.ResumeLayout(false);
            this.currentPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSubjectsEnrolled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        //private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button clse;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel currentPanel;
        private System.Windows.Forms.Button minmize;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button help_btn;
        private System.Windows.Forms.Button Setting_btn;
        private System.Windows.Forms.Button addAcitivty_btn;
        private System.Windows.Forms.Button edit_subject_btn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}