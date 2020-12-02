using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseManagementSystem
{
    public partial class BACKGROUND : Form
    {
        public BACKGROUND()
        {
            InitializeComponent();
        }

        private void btnIssueBooks_Click(object sender, EventArgs e)
        {
            ISSUE i = new ISSUE();
            i.Show();
        }
    }
}
