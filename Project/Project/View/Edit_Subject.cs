﻿using System;
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
    public partial class Edit_Subject : Form
    {
        Adding_Subject Adding_Subject; // need parameter value!!!
        public Edit_Subject()
        {
            InitializeComponent();
            MessageBox.Show(Adding_Subject.s+"");
            for (int x = 0; x < Adding_Subject.Subject_Adding_Subject.Count;x++)
            {

            }
        }
    }
}