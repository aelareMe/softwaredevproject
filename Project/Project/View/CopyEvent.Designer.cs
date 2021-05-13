namespace Project.View
{
    partial class CopyEvent
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(80)))), ((int)(((byte)(139)))));
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "SUBJECT:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(175, 27);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 24);
            this.comboBox1.TabIndex = 16;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(188)))), ((int)(((byte)(222)))));
            this.button5.Location = new System.Drawing.Point(217, 72);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(167, 42);
            this.button5.TabIndex = 32;
            this.button5.Text = "COPY";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(188)))), ((int)(((byte)(222)))));
            this.button1.Location = new System.Drawing.Point(13, 72);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 42);
            this.button1.TabIndex = 33;
            this.button1.Text = "CANCEL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CopyEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(412, 145);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Name = "CopyEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CopyEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
    }
}