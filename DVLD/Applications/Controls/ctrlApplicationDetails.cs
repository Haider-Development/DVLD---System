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
    public partial class ctrlApplicationDetails : UserControl
    {
        private int _LDLApplicationID;
        private clsLDLApplicationView _LDLApplicationView;
        private clsLDLApplication _LDLApplication;

        public ctrlApplicationDetails()
        {
            InitializeComponent();
        }

        private void _LoadData(int LDLApplicationID)
        {
            _LDLApplicationView = clsLDLApplicationView.FindLDLApplication(_LDLApplicationID);
            _LDLApplication = clsLDLApplication.FindLDLApplication(_LDLApplicationID);

            if (_LDLApplicationView != null && _LDLApplication != null)
            {
                lblLDLApplicationID.Text = _LDLApplicationID.ToString();
                lblPassedTests.Text = _LDLApplicationView.PassedTestCount.ToString() + "/3";
                lblLicenseName.Text = _LDLApplicationView.ClassName;
                
                lblApplicationID.Text = _LDLApplication.ApplicationID.ToString();
                lblStatus.Text = _LDLApplicationView.ApplicationStatus;
                lblFees.Text = _LDLApplication.PaidFees.ToString();
                lblType.Text = clsApplicationType.GetAapplicationTypeTitle(_LDLApplication.ApplicationTypeID);
                lblApplicant.Text = _LDLApplicationView.ApplicantName;
                lblDate.Text = _LDLApplication.ApplicationDate.ToString();
                lblStatusDate.Text = _LDLApplication.LastStatusDate.ToString();
                lblCreatedBy.Text = clsUser.GetUsernameByID(_LDLApplication.CreatedByUserID);
            }
        }

        public void LoadApplicationInfo(int LDLApplicationID)
        {
            _LDLApplicationID = LDLApplicationID;
            _LoadData(_LDLApplicationID);
        }

        private void llPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonDetails Frm = new frmPersonDetails(_LDLApplication.ApplicantPersonID);
            Frm.ShowDialog();
        }

    }
}
