using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG1197Lab2
{
    public partial class Splash : Form
    {
        Timer t;
        public Splash()
        {
            InitializeComponent();
        }       

        private void Splash_Load(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 1000;
            t.Tick += Timeout;
            t.Start();
        }

        private void Timeout(object sender, EventArgs e)
        {
            t.Stop();
            Hide();
            new FrmParent().ShowDialog();
            Close();
        }
    }
}
