namespace Project
{
    partial class ActSched
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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numEvent = new System.Windows.Forms.Label();
            this.eventList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(80)))), ((int)(((byte)(139)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "EVENTS:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(188)))), ((int)(((byte)(222)))));
            this.button1.Location = new System.Drawing.Point(42, 424);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 55);
            this.button1.TabIndex = 11;
            this.button1.Text = "ADD EVENT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(80)))), ((int)(((byte)(139)))));
            this.label2.Location = new System.Drawing.Point(93, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "SUBJECT:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(255, 26);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(188)))), ((int)(((byte)(222)))));
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "ACTIVITY SCHEDULER";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(80)))), ((int)(((byte)(139)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(440, 21);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 36);
            this.button2.TabIndex = 15;
            this.button2.Text = "Load Scheduled Events";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numEvent
            // 
            this.numEvent.AutoSize = true;
            this.numEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(188)))), ((int)(((byte)(222)))));
            this.numEvent.Location = new System.Drawing.Point(652, 91);
            this.numEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numEvent.Name = "numEvent";
            this.numEvent.Size = new System.Drawing.Size(112, 20);
            this.numEvent.TabIndex = 16;
            this.numEvent.Text = " /300 events";
            // 
            // eventList
            // 
            this.eventList.AllowUserToAddRows = false;
            this.eventList.AllowUserToDeleteRows = false;
            this.eventList.AllowUserToResizeColumns = false;
            this.eventList.AllowUserToResizeRows = false;
            this.eventList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.eventList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.eventList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.eventList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventList.GridColor = System.Drawing.SystemColors.Control;
            this.eventList.Location = new System.Drawing.Point(91, 124);
            this.eventList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eventList.Name = "eventList";
            this.eventList.ReadOnly = true;
            this.eventList.RowHeadersVisible = false;
            this.eventList.RowTemplate.Height = 24;
            this.eventList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eventList.Size = new System.Drawing.Size(692, 156);
            this.eventList.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.eventList);
            this.panel1.Controls.Add(this.numEvent);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(41, 114);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 302);
            this.panel1.TabIndex = 27;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(188)))), ((int)(((byte)(222)))));
            this.button3.Location = new System.Drawing.Point(729, 424);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 55);
            this.button3.TabIndex = 29;
            this.button3.Text = "DELETE EVENT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(188)))), ((int)(((byte)(222)))));
            this.button4.Location = new System.Drawing.Point(237, 424);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(289, 55);
            this.button4.TabIndex = 30;
            this.button4.Text = "ADD SCHEDULED TIME";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(188)))), ((int)(((byte)(222)))));
            this.button5.Location = new System.Drawing.Point(534, 424);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 55);
            this.button5.TabIndex = 31;
            this.button5.Text = "COPY EVENT";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ActSched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(956, 495);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ActSched";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActivityScheduler";
            ((System.ComponentModel.ISupportInitialize)(this.eventList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label numEvent;
        private System.Windows.Forms.DataGridView eventList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}