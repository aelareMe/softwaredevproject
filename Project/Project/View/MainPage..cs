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
    public partial class MainPage : Form
    {

        DataTable _studyList = new DataTable();
        DataTable _studyProgress = new DataTable();
        public MainPage()
        {
            InitializeComponent();
        }

        public DataTable studyList {
            get { return _studyList; }
            set { _studyList = value; } }
        public DataTable studyProgress {
            get { return _studyProgress; }
            set { _studyProgress = value; }
        }

        public String txbName { set { lblName.Text = value; } }
    }
}
