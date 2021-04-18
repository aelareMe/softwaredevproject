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
    public partial class ActSched : Form
    {
        public ActSched()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //add event button
        {
            AddEvent aE = new AddEvent();
            aE.ShowDialog();
            if (aE.confirm_flag) //if ni confirm ang user sa add event
            {

                eventList.Items.Add(aE.e1.name + "    -    " + aE.e1.date.ToShortDateString() + " with " + aE.e1.remainingDays + " days left.");

            }

        }
    }
}
