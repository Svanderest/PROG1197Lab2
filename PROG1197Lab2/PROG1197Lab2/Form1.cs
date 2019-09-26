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
    public partial class FrmParent : Form
    {
        public FrmParent()
        {
            InitializeComponent();
            this.Controls.Add(new Form());
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?","Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Multiple Document Interface\nWritten by Sebastian van der Est\nPROG1197 Lab 2", "About");
        }

        private void SelectColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "hello world";
        }

        private void ColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color c;
            switch(((ToolStripMenuItem)sender).Text)
            {
                case "Red":
                    c = Color.Red;
                    break;
                case "Green":
                    c = Color.Green;
                    break;
                case "Blue":
                    c = Color.Blue;
                    break;
                default:
                    ColorDialog cd = new ColorDialog();
                    var res = cd.ShowDialog();
                    if (res == DialogResult.Cancel)
                        return;
                    c = cd.Color;
                    break;
            }
            tssColour.BackColor = c;
            tssColour.Text = string.Format("Selected Colour: {0}",c.Name);
        }
    }
}
