using DVLD_BusinessLayer;
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
    public partial class frmDetainLicense : Form
    {
        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private int _LicenseID = -1;

        private DateTime _TodaysDate;

        private clsDetainedLicense _Detain = new clsDetainedLicense();

        private void _LicenseFound(int LicenseID)
        {
            if (LicenseID == -1)
            {
                _LicenseID = -1;

                lblLicenseID.Text = "???";

                llViewLicenseHistory.Enabled = false;
                btnDetain.Enabled = false;
            }

            else
            {
                _LicenseID = LicenseID;

                lblLicenseID.Text = _LicenseID.ToString();

                llViewLicenseHistory.Enabled = true;
                btnDetain.Enabled = true;
            }
        }

        private bool _IsFineZero()
        {
            if (nudFineFees.Value == 0)
            {
                clsMessageDialog.Show("Please Add Fine Fees before you confirm Detain!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void _LoadData()
        {
            _TodaysDate = DateTime.Now;
            lblDetainDate.Text = _TodaysDate.ToShortDateString();
            lblCreatedBy.Text = clsGlobalSettings.CurrentUser.Username;

            ctrlLicenseDetailsWithFilter1.OnLicenseFound += _LicenseFound;
        }
        
        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_LicenseID == -1)
            {
                clsMessageDialog.Show("Select a License First to move to next page!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tcLicenseDetain.SelectTab(PageApplicationInfo);
        }

        private void tcLicenseDetain_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == PageApplicationInfo && _LicenseID == -1)
            {
                e.Cancel = true;
                clsMessageDialog.Show("Select a License First to move to next page!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcLicenseDetain.SelectTab(PageOldLicenseInfo);
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (tcLicenseDetain.SelectedTab == PageOldLicenseInfo)
            {
                clsMessageDialog.Show($"Please move to the next page first and Check Detain info!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!clsLicense.IsLicenseValid(_LicenseID))
            {
                clsMessageDialog.Show($"This License is Deactivated ... Please make sure about License status!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clsDetainedLicense.IsLicenseDetained(_LicenseID))
            {
                clsMessageDialog.Show($"This License is already Detained ... You can only Detain for Active Licenses!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_IsFineZero())
                return;

            if (clsMessageDialog.Show($"Are You Sure you want to Detain this license?", "Confirm", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                _Detain.LicenseID = _LicenseID;
                _Detain.DetainDate = _TodaysDate;
                _Detain.FineFees = nudFineFees.Value;
                _Detain.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;

                if (_Detain.Save())
                {
                    clsMessageDialog.Show($"License has been Detained successfully!\nDetain ID : [{_Detain.DetainID}]",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lblDetainID.Text = _Detain.DetainID.ToString();

                    ctrlLicenseDetailsWithFilter1.FilterEnabled = false;
                    btnDetain.Enabled = false;
                    llViewLicenseDetails.Enabled = true;
                }

                else
                {
                    clsMessageDialog.Show($"Cannot Detain this Driving License!", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llViewLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmViewPersonLicensesHistory Frm = new frmViewPersonLicensesHistory(ctrlLicenseDetailsWithFilter1.PersonID);
            Frm.ShowDialog();
        }

        private void llViewLicenseDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmViewLicenseDetails Frm = new frmViewLicenseDetails(_LicenseID);
            Frm.ShowDialog();
        }

    }
}
