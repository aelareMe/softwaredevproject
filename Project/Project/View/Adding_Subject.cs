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
    public partial class Adding_Subject : Form
    {
        private List<string> Subjects = new List<string>();
        private Add_Subject add_subject = new Add_Subject();
        int PW;
        bool Hided;
        public Adding_Subject()
        {
            InitializeComponent();
            PW = adding_panel.Height;
            Hided = false;
            //adding_panel.Visible = false;
            adding_panel.Visible = false;
 
        }

        private void Adding_Subject_Load(object sender, EventArgs e)
        {
            subject_list_view.Items.Add("Add Subject",0);
        }

        private void subject_list_view_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subject_list_view.FocusedItem != null)
            {
                if (subject_list_view.FocusedItem.Index == 0)
                {
                    if (Hided) cancel_subjectAdd_btn.Text = "Cancel";
                    else cancel_subjectAdd_btn.Text = "Cancel";
                    timer1.Start();
                    adding_panel.Visible = true;
                }

            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            if (Hided) cancel_subjectAdd_btn.Text = "Cancel";
            else cancel_subjectAdd_btn.Text = "Cancel";
            timer1.Start();
        }

        private void add_subject_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (Hided)
            {
                adding_panel.Height = adding_panel.Height + 20;
                if (adding_panel.Height >= PW)
                {
                    timer1.Stop();
                    Hided = false;
                    this.Refresh();
                }
            }
            else
            {
                adding_panel.Height = adding_panel.Height - 20;
                if (adding_panel.Height <= 0)
                {
                    timer1.Stop();
                    Hided = true;
                    this.Refresh();
                }
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Subjects.Add(subject_code.Text.ToString());
            subject_code.Text = "";
            subject_list_view.Items.Add(Subjects.ElementAt(Subjects.Count()-1).ToString(),1);
            if (Hided) cancel_subjectAdd_btn.Text = "Cancel";
            else cancel_subjectAdd_btn.Text = "Cancel";
            timer1.Start();
        }

    }
}
