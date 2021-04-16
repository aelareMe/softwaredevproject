
namespace Project.View
{
    partial class Adding_Subject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adding_Subject));
            this.panel1 = new System.Windows.Forms.Panel();
            this.adding_panel = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancel_subjectAdd_btn = new System.Windows.Forms.Button();
            this.add_subjectAdd_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.subject_list_view = new System.Windows.Forms.ListView();
            this.icon_list = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.subject_code = new Project.CelearningTextbox();
            this.celearningTextbox1 = new Project.CelearningTextbox();
            this.show_subjectDetails_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cancel_subjectDetail_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.subject_code_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.adding_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.show_subjectDetails_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.adding_panel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.celearningTextbox1);
            this.panel1.Controls.Add(this.subject_list_view);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 343);
            this.panel1.TabIndex = 0;
            // 
            // adding_panel
            // 
            this.adding_panel.Controls.Add(this.show_subjectDetails_panel);
            this.adding_panel.Controls.Add(this.listBox2);
            this.adding_panel.Controls.Add(this.listBox1);
            this.adding_panel.Controls.Add(this.listBox3);
            this.adding_panel.Controls.Add(this.label2);
            this.adding_panel.Controls.Add(this.label1);
            this.adding_panel.Controls.Add(this.subject_code);
            this.adding_panel.Controls.Add(this.cancel_subjectAdd_btn);
            this.adding_panel.Controls.Add(this.add_subjectAdd_btn);
            this.adding_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adding_panel.Location = new System.Drawing.Point(0, 38);
            this.adding_panel.Name = "adding_panel";
            this.adding_panel.Size = new System.Drawing.Size(403, 305);
            this.adding_panel.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.listBox2.Location = new System.Drawing.Point(279, 61);
            this.listBox2.Name = "listBox2";
            this.listBox2.ScrollAlwaysVisible = true;
            this.listBox2.Size = new System.Drawing.Size(49, 24);
            this.listBox2.TabIndex = 22;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.listBox1.Location = new System.Drawing.Point(224, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(49, 24);
            this.listBox1.TabIndex = 21;
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.listBox3.Location = new System.Drawing.Point(169, 61);
            this.listBox3.Name = "listBox3";
            this.listBox3.ScrollAlwaysVisible = true;
            this.listBox3.Size = new System.Drawing.Size(49, 24);
            this.listBox3.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Schedule Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Subject Code:";
            // 
            // cancel_subjectAdd_btn
            // 
            this.cancel_subjectAdd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_subjectAdd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_subjectAdd_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_subjectAdd_btn.Location = new System.Drawing.Point(289, 223);
            this.cancel_subjectAdd_btn.Name = "cancel_subjectAdd_btn";
            this.cancel_subjectAdd_btn.Size = new System.Drawing.Size(107, 51);
            this.cancel_subjectAdd_btn.TabIndex = 13;
            this.cancel_subjectAdd_btn.Text = "Cancel";
            this.cancel_subjectAdd_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancel_subjectAdd_btn.UseVisualStyleBackColor = true;
            this.cancel_subjectAdd_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // add_subjectAdd_btn
            // 
            this.add_subjectAdd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_subjectAdd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_subjectAdd_btn.ForeColor = System.Drawing.Color.White;
            this.add_subjectAdd_btn.Location = new System.Drawing.Point(176, 223);
            this.add_subjectAdd_btn.Name = "add_subjectAdd_btn";
            this.add_subjectAdd_btn.Size = new System.Drawing.Size(107, 51);
            this.add_subjectAdd_btn.TabIndex = 12;
            this.add_subjectAdd_btn.Text = "Add";
            this.add_subjectAdd_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_subjectAdd_btn.UseVisualStyleBackColor = true;
            this.add_subjectAdd_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 43);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // subject_list_view
            // 
            this.subject_list_view.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_list_view.HideSelection = false;
            this.subject_list_view.LargeImageList = this.icon_list;
            this.subject_list_view.Location = new System.Drawing.Point(12, 65);
            this.subject_list_view.Name = "subject_list_view";
            this.subject_list_view.Size = new System.Drawing.Size(379, 266);
            this.subject_list_view.SmallImageList = this.icon_list;
            this.subject_list_view.TabIndex = 0;
            this.subject_list_view.UseCompatibleStateImageBehavior = false;
            this.subject_list_view.SelectedIndexChanged += new System.EventHandler(this.subject_list_view_SelectedIndexChanged);
            // 
            // icon_list
            // 
            this.icon_list.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icon_list.ImageStream")));
            this.icon_list.TransparentColor = System.Drawing.Color.Transparent;
            this.icon_list.Images.SetKeyName(0, "sign-add-icon.png");
            this.icon_list.Images.SetKeyName(1, "pngwing.com_3_1_40x40.png");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // subject_code
            // 
            this.subject_code.BackColor = System.Drawing.Color.Transparent;
            this.subject_code.Br = System.Drawing.Color.White;
            this.subject_code.Font = new System.Drawing.Font("Arial", 12F);
            this.subject_code.ForeColor = System.Drawing.Color.Black;
            this.subject_code.Location = new System.Drawing.Point(169, 17);
            this.subject_code.Name = "subject_code";
            this.subject_code.Size = new System.Drawing.Size(220, 33);
            this.subject_code.TabIndex = 14;
            // 
            // celearningTextbox1
            // 
            this.celearningTextbox1.BackColor = System.Drawing.Color.Transparent;
            this.celearningTextbox1.Br = System.Drawing.Color.White;
            this.celearningTextbox1.Font = new System.Drawing.Font("Arial", 12F);
            this.celearningTextbox1.ForeColor = System.Drawing.Color.Black;
            this.celearningTextbox1.Location = new System.Drawing.Point(171, 12);
            this.celearningTextbox1.Name = "celearningTextbox1";
            this.celearningTextbox1.Size = new System.Drawing.Size(220, 33);
            this.celearningTextbox1.TabIndex = 1;
            // 
            // show_subjectDetails_panel
            // 
            this.show_subjectDetails_panel.Controls.Add(this.subject_code_lbl);
            this.show_subjectDetails_panel.Controls.Add(this.label3);
            this.show_subjectDetails_panel.Controls.Add(this.label4);
            this.show_subjectDetails_panel.Controls.Add(this.cancel_subjectDetail_btn);
            this.show_subjectDetails_panel.Controls.Add(this.button2);
            this.show_subjectDetails_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.show_subjectDetails_panel.Location = new System.Drawing.Point(0, 13);
            this.show_subjectDetails_panel.Name = "show_subjectDetails_panel";
            this.show_subjectDetails_panel.Size = new System.Drawing.Size(403, 292);
            this.show_subjectDetails_panel.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Schedule Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Subject Code:";
            // 
            // cancel_subjectDetail_btn
            // 
            this.cancel_subjectDetail_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_subjectDetail_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_subjectDetail_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_subjectDetail_btn.Location = new System.Drawing.Point(289, 223);
            this.cancel_subjectDetail_btn.Name = "cancel_subjectDetail_btn";
            this.cancel_subjectDetail_btn.Size = new System.Drawing.Size(107, 51);
            this.cancel_subjectDetail_btn.TabIndex = 13;
            this.cancel_subjectDetail_btn.Text = "Cancel";
            this.cancel_subjectDetail_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancel_subjectDetail_btn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(176, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 51);
            this.button2.TabIndex = 12;
            this.button2.Text = "Add";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // subject_code_lbl
            // 
            this.subject_code_lbl.AutoSize = true;
            this.subject_code_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_code_lbl.ForeColor = System.Drawing.Color.White;
            this.subject_code_lbl.Location = new System.Drawing.Point(172, 23);
            this.subject_code_lbl.Name = "subject_code_lbl";
            this.subject_code_lbl.Size = new System.Drawing.Size(0, 19);
            this.subject_code_lbl.TabIndex = 23;
            // 
            // Adding_Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 343);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adding_Subject";
            this.Text = "Adding_Subject";
            this.Load += new System.EventHandler(this.Adding_Subject_Load);
            this.panel1.ResumeLayout(false);
            this.adding_panel.ResumeLayout(false);
            this.adding_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.show_subjectDetails_panel.ResumeLayout(false);
            this.show_subjectDetails_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CelearningTextbox celearningTextbox1;
        private System.Windows.Forms.ListView subject_list_view;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList icon_list;
        private System.Windows.Forms.Panel adding_panel;
        private System.Windows.Forms.Button cancel_subjectAdd_btn;
        private System.Windows.Forms.Button add_subjectAdd_btn;
        private System.Windows.Forms.Timer timer1;
        private CelearningTextbox subject_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Panel show_subjectDetails_panel;
        private System.Windows.Forms.Label subject_code_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancel_subjectDetail_btn;
        private System.Windows.Forms.Button button2;
    }
}