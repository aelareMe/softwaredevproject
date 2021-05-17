using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.View
{
    public partial class Help : Form
    {
        private string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
        public Help()
        {
            InitializeComponent();
            _filePath = Directory.GetParent(_filePath).FullName+@"\Debug";
            _filePath += @"\user-manual.pdf";
            pdffile.src = _filePath;
        }

        private void Help_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
