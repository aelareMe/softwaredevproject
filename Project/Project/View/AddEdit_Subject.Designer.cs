
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
            this.add_subject_panel = new System.Windows.Forms.Panel();
            this.edit_subject_panel = new System.Windows.Forms.Panel();
            this.edit_cancel_btn = new System.Windows.Forms.Button();
            this.edit_subject_description = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edit_subject_edit_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.adding_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cancel_subjectAdd_btn = new System.Windows.Forms.Button();
            this.SubjectDescription_txt = new System.Windows.Forms.RichTextBox();
            this.add_subjectAdd_btn = new System.Windows.Forms.Button();
            this.add_Subject_limiter = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.delete_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.subject_list_view = new System.Windows.Forms.ListView();
            this.icon_list = new System.Windows.Forms.ImageList(this.components);
            this.Search_btn = new System.Windows.Forms.Button();
            this.view_subject_panel = new System.Windows.Forms.Panel();
            this.view_subject_details = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.view_subject_desription = new System.Windows.Forms.TextBox();
            this.subjectCode_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.edit_subject_code = new Project.CelearningTextbox();
            this.SubjectCode_txt = new Project.CelearningTextbox();
            this.search_txtbox = new Project.CelearningTextbox();
            this.add_subject_panel.SuspendLayout();
            this.edit_subject_panel.SuspendLayout();
            this.adding_panel.SuspendLayout();
            this.view_subject_panel.SuspendLayout();
            this.view_subject_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // add_subject_panel
            // 
            this.add_subject_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.add_subject_panel.Controls.Add(this.edit_subject_panel);
            this.add_subject_panel.Controls.Add(this.label2);
            this.add_subject_panel.Controls.Add(this.adding_panel);
            this.add_subject_panel.Controls.Add(this.add_Subject_limiter);
            this.add_subject_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_subject_panel.Location = new System.Drawing.Point(0, 0);
            this.add_subject_panel.Name = "add_subject_panel";
            this.add_subject_panel.Size = new System.Drawing.Size(732, 442);
            this.add_subject_panel.TabIndex = 0;
            // 
            // edit_subject_panel
            // 
            this.edit_subject_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.edit_subject_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.edit_subject_panel.Controls.Add(this.edit_cancel_btn);
            this.edit_subject_panel.Controls.Add(this.edit_subject_code);
            this.edit_subject_panel.Controls.Add(this.edit_subject_description);
            this.edit_subject_panel.Controls.Add(this.label4);
            this.edit_subject_panel.Controls.Add(this.label5);
            this.edit_subject_panel.Controls.Add(this.edit_subject_edit_btn);
            this.edit_subject_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edit_subject_panel.Location = new System.Drawing.Point(0, 0);
            this.edit_subject_panel.Name = "edit_subject_panel";
            this.edit_subject_panel.Size = new System.Drawing.Size(732, 442);
            this.edit_subject_panel.TabIndex = 38;
            // 
            // edit_cancel_btn
            // 
            this.edit_cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.edit_cancel_btn.FlatAppearance.BorderSize = 0;
            this.edit_cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_cancel_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_cancel_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(80)))), ((int)(((byte)(139)))));
            this.edit_cancel_btn.Location = new System.Drawing.Point(597, 373);
            this.edit_cancel_btn.Name = "edit_cancel_btn";
            this.edit_cancel_btn.Size = new System.Drawing.Size(91, 48);
            this.edit_cancel_btn.TabIndex = 28;
            this.edit_cancel_btn.Text = "Cancel";
            this.edit_cancel_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit_cancel_btn.UseVisualStyleBackColor = false;
            this.edit_cancel_btn.Click += new System.EventHandler(this.edit_cancel_btn_Click);
            // 
            // edit_subject_description
            // 
            this.edit_subject_description.BackColor = System.Drawing.Color.White;
            this.edit_subject_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_subject_description.Location = new System.Drawing.Point(208, 55);
            this.edit_subject_description.Name = "edit_subject_description";
            this.edit_subject_description.Size = new System.Drawing.Size(478, 308);
            this.edit_subject_description.TabIndex = 26;
            this.edit_subject_description.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(80)))), ((int)(((byte)(139)))));
            this.label5.Location = new System.Drawing.Point(15, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Subject Code:";
            // 
            // edit_subject_edit_btn
            // 
            this.edit_subject_edit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(188)))), ((int)(((byte)(222)))));
            this.edit_subject_edit_btn.FlatAppearance.BorderSize = 0;
            this.edit_subject_edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_subject_edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_subject_edit_btn.ForeColor = System.Drawing.Color.Black;
            this.edit_subject_edit_btn.Location = new System.Drawing.Point(479, 374);
            this.edit_subject_edit_btn.Name = "edit_subject_edit_btn";
            this.edit_subject_edit_btn.Size = new System.Drawing.Size(91, 48);
            this.edit_subject_edit_btn.TabIndex = 12;
            this.edit_subject_edit_btn.Text = "EDIT";
            this.edit_subject_edit_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit_subject_edit_btn.UseVisualStyleBackColor = false;
            this.edit_subject_edit_btn.Click += new System.EventHandler(this.edit_subject_edit_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 26);
            this.label2.TabIndex = 35;
            this.label2.Text = "Subject Limit";
            // 
            // adding_panel
            // 
            this.adding_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.adding_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.adding_panel.Controls.Add(this.label1);
            this.adding_panel.Controls.Add(this.label3);
            this.adding_panel.Controls.Add(this.button2);
            this.adding_panel.Controls.Add(this.button1);
            this.adding_panel.Controls.Add(this.cancel_subjectAdd_btn);
            this.adding_panel.Controls.Add(this.SubjectCode_txt);
            this.adding_panel.Controls.Add(this.SubjectDescription_txt);
            this.adding_panel.Controls.Add(this.add_subjectAdd_btn);
            this.adding_panel.Location = new System.Drawing.Point(175, 29);
            this.adding_panel.Name = "adding_panel";
            this.adding_panel.Size = new System.Drawing.Size(500, 400);
            this.adding_panel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(80)))), ((int)(((byte)(139)))));
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Subject Code:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(67, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 58);
            this.button2.TabIndex = 30;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(67, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 58);
            this.button1.TabIndex = 29;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cancel_subjectAdd_btn
            // 
            this.cancel_subjectAdd_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.cancel_subjectAdd_btn.FlatAppearance.BorderSize = 0;
            this.cancel_subjectAdd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_subjectAdd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_subjectAdd_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(80)))), ((int)(((byte)(139)))));
            this.cancel_subjectAdd_btn.Location = new System.Drawing.Point(386, 323);
            this.cancel_subjectAdd_btn.Name = "cancel_subjectAdd_btn";
            this.cancel_subjectAdd_btn.Size = new System.Drawing.Size(89, 48);
            this.cancel_subjectAdd_btn.TabIndex = 28;
            this.cancel_subjectAdd_btn.Text = "Cancel";
            this.cancel_subjectAdd_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancel_subjectAdd_btn.UseVisualStyleBackColor = false;
            this.cancel_subjectAdd_btn.Click += new System.EventHandler(this.cancel_btn_Click_1);
            // 
            // SubjectDescription_txt
            // 
            this.SubjectDescription_txt.BackColor = System.Drawing.Color.White;
            this.SubjectDescription_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectDescription_txt.Location = new System.Drawing.Point(184, 57);
            this.SubjectDescription_txt.Name = "SubjectDescription_txt";
            this.SubjectDescription_txt.Size = new System.Drawing.Size(291, 260);
            this.SubjectDescription_txt.TabIndex = 26;
            this.SubjectDescription_txt.Text = "";
            // 
            // add_subjectAdd_btn
            // 
            this.add_subjectAdd_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(188)))), ((int)(((byte)(222)))));
            this.add_subjectAdd_btn.FlatAppearance.BorderSize = 0;
            this.add_subjectAdd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_subjectAdd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.add_subjectAdd_btn.ForeColor = System.Drawing.Color.Black;
            this.add_subjectAdd_btn.Location = new System.Drawing.Point(276, 323);
            this.add_subjectAdd_btn.Name = "add_subjectAdd_btn";
            this.add_subjectAdd_btn.Size = new System.Drawing.Size(89, 48);
            this.add_subjectAdd_btn.TabIndex = 12;
            this.add_subjectAdd_btn.Text = "Add";
            this.add_subjectAdd_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_subjectAdd_btn.UseVisualStyleBackColor = false;
            this.add_subjectAdd_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // add_Subject_limiter
            // 
            this.add_Subject_limiter.animated = true;
            this.add_Subject_limiter.animationIterval = 5;
            this.add_Subject_limiter.animationSpeed = 10;
            this.add_Subject_limiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.add_Subject_limiter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_Subject_limiter.BackgroundImage")));
            this.add_Subject_limiter.CausesValidation = false;
            this.add_Subject_limiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Pixel);
            this.add_Subject_limiter.ForeColor = System.Drawing.Color.Red;
            this.add_Subject_limiter.LabelVisible = true;
            this.add_Subject_limiter.LineProgressThickness = 8;
            this.add_Subject_limiter.LineThickness = 8;
            this.add_Subject_limiter.Location = new System.Drawing.Point(51, 252);
            this.add_Subject_limiter.Margin = new System.Windows.Forms.Padding(6);
            this.add_Subject_limiter.MaxValue = 30;
            this.add_Subject_limiter.Name = "add_Subject_limiter";
            this.add_Subject_limiter.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.add_Subject_limiter.ProgressColor = System.Drawing.Color.Red;
            this.add_Subject_limiter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.add_Subject_limiter.Size = new System.Drawing.Size(100, 100);
            this.add_Subject_limiter.TabIndex = 34;
            this.add_Subject_limiter.Value = 0;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.Black;
            this.delete_btn.Image = ((System.Drawing.Image)(resources.GetObject("delete_btn.Image")));
            this.delete_btn.Location = new System.Drawing.Point(633, 372);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(55, 58);
            this.delete_btn.TabIndex = 41;
            this.delete_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.edit_btn.FlatAppearance.BorderSize = 0;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.ForeColor = System.Drawing.Color.Black;
            this.edit_btn.Image = ((System.Drawing.Image)(resources.GetObject("edit_btn.Image")));
            this.edit_btn.Location = new System.Drawing.Point(559, 374);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(55, 58);
            this.edit_btn.TabIndex = 37;
            this.edit_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // subject_list_view
            // 
            this.subject_list_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.subject_list_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_list_view.ForeColor = System.Drawing.Color.White;
            this.subject_list_view.HideSelection = false;
            this.subject_list_view.LargeImageList = this.icon_list;
            this.subject_list_view.Location = new System.Drawing.Point(9, 72);
            this.subject_list_view.Name = "subject_list_view";
            this.subject_list_view.Size = new System.Drawing.Size(711, 338);
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
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.Search_btn.FlatAppearance.BorderSize = 0;
            this.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.ForeColor = System.Drawing.Color.Black;
            this.Search_btn.Image = ((System.Drawing.Image)(resources.GetObject("Search_btn.Image")));
            this.Search_btn.Location = new System.Drawing.Point(678, 12);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(42, 44);
            this.Search_btn.TabIndex = 36;
            this.Search_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // view_subject_panel
            // 
            this.view_subject_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.view_subject_panel.Controls.Add(this.add_subject_panel);
            this.view_subject_panel.Controls.Add(this.view_subject_details);
            this.view_subject_panel.Controls.Add(this.subject_list_view);
            this.view_subject_panel.Controls.Add(this.delete_btn);
            this.view_subject_panel.Controls.Add(this.search_txtbox);
            this.view_subject_panel.Controls.Add(this.Search_btn);
            this.view_subject_panel.Controls.Add(this.back_btn);
            this.view_subject_panel.Controls.Add(this.edit_btn);
            this.view_subject_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_subject_panel.Location = new System.Drawing.Point(0, 0);
            this.view_subject_panel.Name = "view_subject_panel";
            this.view_subject_panel.Size = new System.Drawing.Size(732, 442);
            this.view_subject_panel.TabIndex = 39;
            // 
            // view_subject_details
            // 
            this.view_subject_details.AutoScroll = true;
            this.view_subject_details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.view_subject_details.Controls.Add(this.label7);
            this.view_subject_details.Controls.Add(this.label8);
            this.view_subject_details.Controls.Add(this.dataGridView1);
            this.view_subject_details.Controls.Add(this.view_subject_desription);
            this.view_subject_details.Controls.Add(this.subjectCode_lbl);
            this.view_subject_details.Controls.Add(this.label6);
            this.view_subject_details.Location = new System.Drawing.Point(379, 72);
            this.view_subject_details.Name = "view_subject_details";
            this.view_subject_details.Size = new System.Drawing.Size(341, 293);
            this.view_subject_details.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(80)))), ((int)(((byte)(139)))));
            this.label7.Location = new System.Drawing.Point(3, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 24);
            this.label7.TabIndex = 44;
            this.label7.Text = "Subject Code:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 26);
            this.label8.TabIndex = 43;
            this.label8.Text = "Activities:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(260, 210);
            this.dataGridView1.TabIndex = 42;
            // 
            // view_subject_desription
            // 
            this.view_subject_desription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.view_subject_desription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.view_subject_desription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_subject_desription.ForeColor = System.Drawing.Color.White;
            this.view_subject_desription.Location = new System.Drawing.Point(36, 77);
            this.view_subject_desription.Multiline = true;
            this.view_subject_desription.Name = "view_subject_desription";
            this.view_subject_desription.ReadOnly = true;
            this.view_subject_desription.Size = new System.Drawing.Size(275, 122);
            this.view_subject_desription.TabIndex = 41;
            // 
            // subjectCode_lbl
            // 
            this.subjectCode_lbl.AutoSize = true;
            this.subjectCode_lbl.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectCode_lbl.ForeColor = System.Drawing.Color.White;
            this.subjectCode_lbl.Location = new System.Drawing.Point(181, 17);
            this.subjectCode_lbl.Name = "subjectCode_lbl";
            this.subjectCode_lbl.Size = new System.Drawing.Size(0, 26);
            this.subjectCode_lbl.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 26);
            this.label6.TabIndex = 24;
            this.label6.Text = "Description:";
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.Black;
            this.back_btn.Image = ((System.Drawing.Image)(resources.GetObject("back_btn.Image")));
            this.back_btn.Location = new System.Drawing.Point(415, 372);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(65, 55);
            this.back_btn.TabIndex = 40;
            this.back_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // edit_subject_code
            // 
            this.edit_subject_code.BackColor = System.Drawing.Color.Transparent;
            this.edit_subject_code.Br = System.Drawing.Color.White;
            this.edit_subject_code.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_subject_code.ForeColor = System.Drawing.Color.Black;
            this.edit_subject_code.Location = new System.Drawing.Point(210, 13);
            this.edit_subject_code.Name = "edit_subject_code";
            this.edit_subject_code.Size = new System.Drawing.Size(210, 34);
            this.edit_subject_code.TabIndex = 27;
            // 
            // SubjectCode_txt
            // 
            this.SubjectCode_txt.BackColor = System.Drawing.Color.Transparent;
            this.SubjectCode_txt.Br = System.Drawing.Color.White;
            this.SubjectCode_txt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectCode_txt.ForeColor = System.Drawing.Color.Black;
            this.SubjectCode_txt.Location = new System.Drawing.Point(184, 9);
            this.SubjectCode_txt.Name = "SubjectCode_txt";
            this.SubjectCode_txt.Size = new System.Drawing.Size(208, 34);
            this.SubjectCode_txt.TabIndex = 27;
            // 
            // search_txtbox
            // 
            this.search_txtbox.BackColor = System.Drawing.Color.Transparent;
            this.search_txtbox.Br = System.Drawing.Color.White;
            this.search_txtbox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txtbox.ForeColor = System.Drawing.Color.Black;
            this.search_txtbox.Location = new System.Drawing.Point(463, 18);
            this.search_txtbox.Name = "search_txtbox";
            this.search_txtbox.Size = new System.Drawing.Size(208, 34);
            this.search_txtbox.TabIndex = 28;
            this.search_txtbox.TextChanged += new System.EventHandler(this.search_txtbox_TextChanged);
            // 
            // Adding_Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 442);
            this.Controls.Add(this.view_subject_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adding_Subject";
            this.Text = "Adding_Subject";
            this.Load += new System.EventHandler(this.Adding_Subject_Load);
            this.add_subject_panel.ResumeLayout(false);
            this.add_subject_panel.PerformLayout();
            this.edit_subject_panel.ResumeLayout(false);
            this.edit_subject_panel.PerformLayout();
            this.adding_panel.ResumeLayout(false);
            this.adding_panel.PerformLayout();
            this.view_subject_panel.ResumeLayout(false);
            this.view_subject_details.ResumeLayout(false);
            this.view_subject_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel add_subject_panel;
        private CelearningTextbox celearningTextbox1;
        private System.Windows.Forms.ListView subject_list_view;
        private System.Windows.Forms.ImageList icon_list;
        private System.Windows.Forms.Panel adding_panel;
        private System.Windows.Forms.Button add_subjectAdd_btn;
        private CelearningTextbox txtSubjectCode;
        private CelearningTextbox txtSubjectDescription;
        private System.Windows.Forms.RichTextBox SubjectDescription_txt;
        private CelearningTextbox SubjectCode_txt;
        private System.Windows.Forms.Button cancel_subjectAdd_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private CelearningTextbox search_txtbox;
        private Bunifu.Framework.UI.BunifuCircleProgressbar add_Subject_limiter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Panel edit_subject_panel;
        private System.Windows.Forms.Panel view_subject_panel;
        private System.Windows.Forms.Panel view_subject_details;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label subjectCode_lbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox view_subject_desription;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button edit_cancel_btn;
        private CelearningTextbox edit_subject_code;
        private System.Windows.Forms.RichTextBox edit_subject_description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button edit_subject_edit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}