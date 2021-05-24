using Project.DbConnect;
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
    public partial class SplashScreen : Form
    {

        Transactions trans = new Transactions();
        bool _testCOnnectionResult = false;
        public SplashScreen()
        {

            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            testDatabase();
        }


        public async void testDatabase() {
            Task[] task1 = { asyncDbConnection() };
            await Task.WhenAll(task1);
        }


        public void testConnection()
        {
            bool temp = false;

            if (!trans.OpenConnection())
            {
                temp = trans.createDatabase();
                if (temp)
                {
                    _testCOnnectionResult = trans.createTables();
                }
            }
            else {
                _testCOnnectionResult = true;

            }
        }


        public async Task asyncDbConnection()
        {
            while (true)
            {
                if (!_testCOnnectionResult)
                {
                    testConnection();
                }
                else {

                    Login frm = new Login();
                    frm.Show();
                    this.Hide();
                    break;

                }

                await Task.Delay(2000);
            }
        }
    }


}
