using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary.Forms
{
    public partial class RememberForm : Form
    {
        public RememberForm()
        {
            InitializeComponent();
        }

        private void btnUzEng_Click(object sender, EventArgs e)
        {
            UzEngForm uzEngForm = new UzEngForm();
            uzEngForm.ShowDialog();
        }

        private void btnEngUz_Click(object sender, EventArgs e)
        {
            EngUzForm engUzForm = new EngUzForm();
            engUzForm.ShowDialog();
        }
    }
}
