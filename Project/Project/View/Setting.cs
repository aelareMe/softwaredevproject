using Project.Object;
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
    public partial class Setting : Form
    {
        UserInfObject _userInfObject;

        public Setting(UserInfObject _userInfObject)
        {
            InitializeComponent();
            name_txt.Text = _userInfObject.getName();
            int numPassword =_userInfObject.getPassword().Length;
            for (int x = 0; x < numPassword; x++)
            {
                password_txt.Text += "*";
            }
            userName_txt.Text = _userInfObject.getUsername();
            Id_txt.Text =_userInfObject.getId().ToString();
        }
        UserInfObject obj = new UserInfObject();

        private void changeProfile_btn_Click(object sender, EventArgs e)
        {
            // setting profile change button
        }
    }
}
