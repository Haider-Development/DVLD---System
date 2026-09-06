using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlLicenseDetails : UserControl
    {
        private int _LicenseClassID;
        private int _PersonID;
        private string _FullName;
        private string _IssueReason;

        private clsPerson _Person;
        private clsLicense _License;
        private clsLDLApplication _LDLApplication;

        public int PersonID
        {
            get { return _PersonID; }
            set { _PersonID = value; }
        }

        public int LicenseClassID
        {
            get { return _LicenseClassID; }
            set { _LicenseClassID = value; }
        }

        public ctrlLicenseDetails()
        {
            InitializeComponent();
        }

        private void _LoadImageSafely(string ImagePath)
        {
            if (File.Exists(ImagePath))
            {
                using (FileStream FS = new FileStream(ImagePath, FileMode.Open, FileAccess.Read))
                {
                    pbImage.Image = Image.FromStream(FS);
                    pbImage.Tag = ImagePath;
                }
            }
        }

        private bool _LoadData(int LicenseID)
        {
            if (clsLicense.IsLicenseExistByLicenseID(LicenseID))
            {
                _License = clsLicense.FindLicense(LicenseID);

                _PersonID = clsDriver.GetPersonID(_License.DriverID);
                _Person = clsPerson.FindPerson(_PersonID);

                if (_License != null && _Person != null)
                {
                    _LicenseClassID = _License.LicenseClass;
                    _FullName = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
                    lblClassType.Text = clsLicenseClass.GetLicenseClassName(_LicenseClassID);
                    lblName.Text = _FullName;
                    lblLicenseID.Text = LicenseID.ToString();
                    lblNationalNo.Text = _Person.NationalNumber;
                    lblGender.Text = (_Person.Gender == 0) ? "Male" : "Female";
                    lblIssueDate.Text = _License.IssueDate.ToShortDateString();
                    lblNotes.Text = _License.Notes;
                    lblIsActive.Text = (_License.IsActive) ? "Yes" : "No";
                    lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
                    lblDriverID.Text = _License.DriverID.ToString();
                    lblExpirationDate.Text = _License.ExpirationDate.ToShortDateString();
                    lblIsDetained.Text = (clsDetainedLicense.IsLicenseDetained(LicenseID)) ? "Yes" : "No";

                    if (clsLicense.IsLicenseExpired(_License.LicenseID))
                    {
                        _License.IsActive = false;
                        lblIsActive.Text = "Expired";
                    }

                    switch (_License.IssueReason)
                    {
                        case 1:
                            {
                                _IssueReason = "New Local Driving Service";
                                break;
                            }

                        case 2:
                            {
                                _IssueReason = "Renew Driving License Service";
                                break;
                            }

                        case 3:
                            {
                                _IssueReason = "Replacement For Lost";
                                break;
                            }

                        case 4:
                            {
                                _IssueReason = "Replacement For Damage";
                                break;
                            }
                    }

                    lblIssueReason.Text = _IssueReason;

                    if (_Person.ImagePath != "")
                        _LoadImageSafely(_Person.ImagePath);

                    else
                        pbImage.Image = (_Person.Gender == 0) ? Properties.Resources.man : Properties.Resources.woman;
                }

                return true;
            }

            else
            {
                clsMessageDialog.Show($"License With ID : [{LicenseID}] doesn't exist!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
        }

        public void LoadLicenseDetails(int LDLApplicationID)
        {
            _LDLApplication = clsLDLApplication.FindLDLApplication(LDLApplicationID);
            int LicenseID = clsLicense.GetLicenseIDByApplicationID(_LDLApplication.ApplicationID);
            _LoadData(LicenseID);
        }

        public bool LoadLicenseDetailsByLicenseID(int LicenseID)
        {
            return _LoadData(LicenseID);
        }
    }
}
