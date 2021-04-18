using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AddEvent : Form
    {
        public Event e1;
        public bool confirm_flag;
        public AddEvent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) //exit button
        {
            AddEvent.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e) //add event button
        {
            if (eventName.Text == "" || (eventDate.Value - DateTime.Today).TotalDays < 0) //if blank ang event name or ang date nga giset kay humana with respect sa date today
            {
                MessageBox.Show("Blank event name or event date can't be due past with today. Please try again.");
                return;
            }
            else
            {
                e1 = new Event(eventName.Text, eventDate.Value);
                confirm_flag = true;
                MessageBox.Show("Success");
                return;
            }


        }
    }
}
