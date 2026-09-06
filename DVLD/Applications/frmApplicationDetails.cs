using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmApplicationDetails : Form
    {
        private int _LDLApplicationID;

        public frmApplicationDetails(int LDLApplicationID)
        {
            InitializeComponent();

            _LDLApplicationID = LDLApplicationID;
        }

        private void frmApplicationDetails_Load(object sender, EventArgs e)
        {
            ctrlApplicationDetails1.LoadApplicationInfo(_LDLApplicationID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
