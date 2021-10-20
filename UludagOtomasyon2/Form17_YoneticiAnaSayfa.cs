using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UludagOtomasyon2
{
    public partial class Form17_YoneticiAnaSayfa : Form
    {
        public Form17_YoneticiAnaSayfa()
        {
            InitializeComponent();
        }

        private void Form17_YoneticiAnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
