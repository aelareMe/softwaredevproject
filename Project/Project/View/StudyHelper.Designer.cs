namespace Project
{
    partial class StudyHelper
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
            this.percentLbl = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.setBtn = new System.Windows.Forms.Button();
            this.percentTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // percentLbl
            // 
            this.percentLbl.AutoSize = true;
            this.percentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentLbl.Location = new System.Drawing.Point(313, 254);
            this.percentLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.percentLbl.Name = "percentLbl";
            this.percentLbl.Size = new System.Drawing.Size(21, 17);
            this.percentLbl.TabIndex = 25;
            this.percentLbl.Text = "%";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(13, 441);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 28);
            this.button3.TabIndex = 24;
            this.button3.Text = "ACTIVITY SCHEDULER";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(512, 441);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 28);
            this.exitBtn.TabIndex = 23;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(271, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "MESSAGE:";
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(64, 313);
            this.messageBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(495, 67);
            this.messageBox.TabIndex = 21;
            this.messageBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "YOUR PROGRESS:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(64, 222);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(496, 28);
            this.progressBar.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "STUDY PROGRESS (%):";
            // 
            // setBtn
            // 
            this.setBtn.Location = new System.Drawing.Point(365, 117);
            this.setBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setBtn.Name = "setBtn";
            this.setBtn.Size = new System.Drawing.Size(100, 39);
            this.setBtn.TabIndex = 17;
            this.setBtn.Text = "SET";
            this.setBtn.UseVisualStyleBackColor = true;
            // 
            // percentTb
            // 
            this.percentTb.Location = new System.Drawing.Point(220, 126);
            this.percentTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.percentTb.Name = "percentTb";
            this.percentTb.Size = new System.Drawing.Size(113, 22);
            this.percentTb.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "STUDY HELPER";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StudyHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.percentLbl);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.setBtn);
            this.Controls.Add(this.percentTb);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StudyHelper";
            this.Text = "StudyHelper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label percentLbl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox messageBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button setBtn;
        private System.Windows.Forms.TextBox percentTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}