
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancel_subjectAdd_btn = new System.Windows.Forms.Button();
            this.add_subjectAdd_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.subject_list_view = new System.Windows.Forms.ListView();
            this.icon_list = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtSubjectDescription = new Project.CelearningTextbox();
            this.txtSubjectCode = new Project.CelearningTextbox();
            this.celearningTextbox1 = new Project.CelearningTextbox();
            this.panel1.SuspendLayout();
            this.adding_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 422);
            this.panel1.TabIndex = 0;
            // 
            // adding_panel
            // 
            this.adding_panel.Controls.Add(this.label3);
            this.adding_panel.Controls.Add(this.txtSubjectDescription);
            this.adding_panel.Controls.Add(this.label1);
            this.adding_panel.Controls.Add(this.txtSubjectCode);
            this.adding_panel.Controls.Add(this.cancel_subjectAdd_btn);
            this.adding_panel.Controls.Add(this.add_subjectAdd_btn);
            this.adding_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adding_panel.Location = new System.Drawing.Point(0, 47);
            this.adding_panel.Margin = new System.Windows.Forms.Padding(4);
            this.adding_panel.Name = "adding_panel";
            this.adding_panel.Size = new System.Drawing.Size(537, 375);
            this.adding_panel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Subject Code:";
            // 
            // cancel_subjectAdd_btn
            // 
            this.cancel_subjectAdd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_subjectAdd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_subjectAdd_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_subjectAdd_btn.Location = new System.Drawing.Point(385, 274);
            this.cancel_subjectAdd_btn.Margin = new System.Windows.Forms.Padding(4);
            this.cancel_subjectAdd_btn.Name = "cancel_subjectAdd_btn";
            this.cancel_subjectAdd_btn.Size = new System.Drawing.Size(143, 63);
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
            this.add_subjectAdd_btn.Location = new System.Drawing.Point(235, 274);
            this.add_subjectAdd_btn.Margin = new System.Windows.Forms.Padding(4);
            this.add_subjectAdd_btn.Name = "add_subjectAdd_btn";
            this.add_subjectAdd_btn.Size = new System.Drawing.Size(143, 63);
            this.add_subjectAdd_btn.TabIndex = 12;
            this.add_subjectAdd_btn.Text = "Add";
            this.add_subjectAdd_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_subjectAdd_btn.UseVisualStyleBackColor = true;
            this.add_subjectAdd_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(161, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 53);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // subject_list_view
            // 
            this.subject_list_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_list_view.HideSelection = false;
            this.subject_list_view.LargeImageList = this.icon_list;
            this.subject_list_view.Location = new System.Drawing.Point(16, 80);
            this.subject_list_view.Margin = new System.Windows.Forms.Padding(4);
            this.subject_list_view.Name = "subject_list_view";
            this.subject_list_view.Size = new System.Drawing.Size(504, 326);
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
            // txtSubjectDescription
            // 
            this.txtSubjectDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtSubjectDescription.Br = System.Drawing.Color.White;
            this.txtSubjectDescription.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSubjectDescription.ForeColor = System.Drawing.Color.Black;
            this.txtSubjectDescription.Location = new System.Drawing.Point(225, 90);
            this.txtSubjectDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubjectDescription.Name = "txtSubjectDescription";
            this.txtSubjectDescription.Size = new System.Drawing.Size(293, 41);
            this.txtSubjectDescription.TabIndex = 23;
            // 
            // txtSubjectCode
            // 
            this.txtSubjectCode.BackColor = System.Drawing.Color.Transparent;
            this.txtSubjectCode.Br = System.Drawing.Color.White;
            this.txtSubjectCode.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSubjectCode.ForeColor = System.Drawing.Color.Black;
            this.txtSubjectCode.Location = new System.Drawing.Point(225, 21);
            this.txtSubjectCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubjectCode.Name = "txtSubjectCode";
            this.txtSubjectCode.Size = new System.Drawing.Size(293, 41);
            this.txtSubjectCode.TabIndex = 14;
            // 
            // celearningTextbox1
            // 
            this.celearningTextbox1.BackColor = System.Drawing.Color.Transparent;
            this.celearningTextbox1.Br = System.Drawing.Color.White;
            this.celearningTextbox1.Font = new System.Drawing.Font("Arial", 12F);
            this.celearningTextbox1.ForeColor = System.Drawing.Color.Black;
            this.celearningTextbox1.Location = new System.Drawing.Point(228, 15);
            this.celearningTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.celearningTextbox1.Name = "celearningTextbox1";
            this.celearningTextbox1.Size = new System.Drawing.Size(293, 41);
            this.celearningTextbox1.TabIndex = 1;
            // 
            // Adding_Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 422);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Adding_Subject";
            this.Text = "Adding_Subject";
            this.Load += new System.EventHandler(this.Adding_Subject_Load);
            this.panel1.ResumeLayout(false);
            this.adding_panel.ResumeLayout(false);
            this.adding_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private CelearningTextbox txtSubjectCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private CelearningTextbox txtSubjectDescription;
    }
}