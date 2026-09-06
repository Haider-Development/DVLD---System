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
    public partial class ctrlLicenseDetailsWithFilter : UserControl
    {
        public delegate void LicenseFoundEventHandler(int LicenseID);
        public event LicenseFoundEventHandler OnLicenseFound;

        public bool FilterEnabled
        {
            get { return gbFilter.Enabled; }
            set { gbFilter.Enabled = value; }
        }

        public int PersonID { get; set; }
        public int LicenseClassID { get; set; }

        public ctrlLicenseDetailsWithFilter()
        {
            InitializeComponent();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                btnFindLicense.PerformClick();
            }
        }

        public bool LoadLicenseData(int LicenseID)
        {
            if (ctrlLicenseDetails1.LoadLicenseDetailsByLicenseID(LicenseID))
            {
                PersonID = ctrlLicenseDetails1.PersonID;
                LicenseClassID = ctrlLicenseDetails1.LicenseClassID;
                return true;
            }

            return false;
        }

        private void btnFindLicense_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtFilter.Text.Trim(), out int SelectedLicenseID))
            {
                if (LoadLicenseData(SelectedLicenseID))
                    OnLicenseFound?.Invoke(SelectedLicenseID);

                else
                    OnLicenseFound?.Invoke(-1);
            }

        }
    }
}
