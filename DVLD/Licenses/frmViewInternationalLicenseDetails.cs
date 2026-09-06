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
    public partial class frmViewInternationalLicenseDetails : Form
    {
        private int _InternationalLicenseID;

        public frmViewInternationalLicenseDetails(int InternationalLicenseID)
        {
            InitializeComponent();
            _InternationalLicenseID = InternationalLicenseID;
        }

        private void frmViewInternationalLicenseDetails_Load(object sender, EventArgs e)
        {
            if (_InternationalLicenseID != -1)
                ctrlInternationalLicenseDetails1.LoadData(_InternationalLicenseID);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
