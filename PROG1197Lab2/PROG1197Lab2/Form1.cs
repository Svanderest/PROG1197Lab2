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
        public Dictionary<string, Form> ChildForms;
        public FrmParent()
        {
            InitializeComponent();
            ChildForms = new Dictionary<string, Form>();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?","Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm ().ShowDialog();
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

        private void CreateNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameForm n = new NameForm { MdiParent = this };
            n.FormClosed += CreateChildForm;
            n.Deactivate += (sndr, ea) => { n.Activate(); };
            n.Show();
        }        

        private void CreateChildForm(object sender, FormClosedEventArgs e)
        {
            Form f = new Form
            {
                Text = ((NameForm)sender).FormName,
                BackColor = tssColour.BackColor,
                MdiParent = this
            };
            ChildForms.Add(f.Text, f);
            f.Show();
            f.FormClosed += ChildFormClosed;
        }

        private void ChildFormClosed(object sender, FormClosedEventArgs e)
        {
            ChildForms.Remove(((Form)sender).Text);
        }
    }
}
