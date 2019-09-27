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
    public partial class NameForm : Form
    {
        public string FormName
        {
            get { return txtFormName.Text; }
        }

        public NameForm()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (((FrmParent)MdiParent).ChildForms.Keys.Contains(txtFormName.Text))
                lblName.Text = "This name is already taken";
            else
                this.Close();
        }
    }
}
