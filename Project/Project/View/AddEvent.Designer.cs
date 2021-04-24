namespace Project
{
    partial class AddEvent
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
            this.button2 = new System.Windows.Forms.Button();
            this.addEventConfirm = new System.Windows.Forms.Button();
            this.eventDate = new System.Windows.Forms.DateTimePicker();
            this.eventName = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.days2Accomplish = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.noOfSession = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // addEventConfirm
            // 
            this.addEventConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEventConfirm.Location = new System.Drawing.Point(141, 229);
            this.addEventConfirm.Name = "addEventConfirm";
            this.addEventConfirm.Size = new System.Drawing.Size(116, 44);
            this.addEventConfirm.TabIndex = 12;
            this.addEventConfirm.Text = "CONFIRM";
            this.addEventConfirm.UseVisualStyleBackColor = true;
            this.addEventConfirm.Click += new System.EventHandler(this.addEventConfirm_Click);
            // 
            // eventDate
            // 
            this.eventDate.CustomFormat = "dd/MM/yy HH:mm";
            this.eventDate.Location = new System.Drawing.Point(141, 117);
            this.eventDate.Name = "eventDate";
            this.eventDate.Size = new System.Drawing.Size(200, 20);
            this.eventDate.TabIndex = 11;
            // 
            // eventName
            // 
            this.eventName.Location = new System.Drawing.Point(141, 70);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(203, 17);
            this.eventName.TabIndex = 10;
            this.eventName.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "DATE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "EVENT NAME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "ADD EVENT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "NO. OF DAYS TO ACCOMPLISH:";
            // 
            // days2Accomplish
            // 
            this.days2Accomplish.Location = new System.Drawing.Point(244, 153);
            this.days2Accomplish.Name = "days2Accomplish";
            this.days2Accomplish.Size = new System.Drawing.Size(71, 15);
            this.days2Accomplish.TabIndex = 15;
            this.days2Accomplish.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "NO. OF SESSIONS/DAY:";
            // 
            // noOfSession
            // 
            this.noOfSession.Location = new System.Drawing.Point(244, 177);
            this.noOfSession.Name = "noOfSession";
            this.noOfSession.Size = new System.Drawing.Size(69, 21);
            this.noOfSession.TabIndex = 17;
            this.noOfSession.Text = "";
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 313);
            this.Controls.Add(this.noOfSession);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.days2Accomplish);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addEventConfirm);
            this.Controls.Add(this.eventDate);
            this.Controls.Add(this.eventName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addEventConfirm;
        private System.Windows.Forms.DateTimePicker eventDate;
        private System.Windows.Forms.RichTextBox eventName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox days2Accomplish;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox noOfSession;
    }
}