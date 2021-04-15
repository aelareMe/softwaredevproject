using Project.Interface;
using Project.Presenter;
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
    public partial class Signup : Form , ISignup
    {
        LoginSignupPresenter presenter;


        public Signup()
        {
            InitializeComponent();
            presenter = new LoginSignupPresenter(this);
        }

        public string username
        {
            get { return textBox1.Text; }
        }

        public string password
        {
            get { return textBox2.Text; }
        }

        public Form currentForm { get { return this; } }

        public string name
        {
            get { return textBox3.Text; }
        }



         private void button2_Click(object sender, EventArgs e)
        {
            presenter.signup();
        }
    }
}
