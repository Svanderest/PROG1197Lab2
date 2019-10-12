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
    public partial class ListAllForm : Form
    {
        public ListAllForm(Dictionary<string,Form> forms)
        {
            InitializeComponent();
            forms.Select(e => $"{e.Value.Text}: {e.Value.BackColor.Name}").ToList().ForEach(e => lstForms.Items.Add(e));
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
