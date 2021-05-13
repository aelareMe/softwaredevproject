using Project.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.View
{
    public partial class CopyEvent : Form
    {

        public int selectedId = 0;
        public CopyEvent(DataTable subjectList)
        {
            InitializeComponent();
            comboBox1.DataSource = subjectList;
            comboBox1.DisplayMember = "study_name";
            comboBox1.ValueMember = "study_id";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            selectedId = Int32.Parse(comboBox1.SelectedValue.ToString());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
