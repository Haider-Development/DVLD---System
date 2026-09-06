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
    public partial class ctrlInternationalLicenseDetails : UserControl
    {
        private int _PersonID;
        private string _FullName;

        private clsPerson _Person;
        private clsInternationalLicense _InternationalLicense;

        public ctrlInternationalLicenseDetails()
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

        private void _LoadData(int InternationalLicenseID)
        {
            if (clsLicense.IsLicenseExistByLicenseID(InternationalLicenseID))
            {
                _InternationalLicense = clsInternationalLicense.FindInternatioanlLicense(InternationalLicenseID);

                _PersonID = clsDriver.GetPersonID(_InternationalLicense.DriverID);
                _Person = clsPerson.FindPerson(_PersonID);

                if (_InternationalLicense != null && _Person != null)
                {
                    if (clsInternationalLicense.IsInternationalLicenseExpired(_InternationalLicense.InternationalLicenseID))
                    {
                        _InternationalLicense.IsActive = false;
                    }

                    _FullName = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
                    lblName.Text = _FullName;
                    lblInternationalLicenseID.Text = InternationalLicenseID.ToString();
                    lblLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
                    lblNationalNo.Text = _Person.NationalNumber;
                    lblGender.Text = (_Person.Gender == 0) ? "Male" : "Female";
                    lblIssueDate.Text = _InternationalLicense.IssueDate.ToShortDateString();
                    lblApplicationID.Text = _InternationalLicense.ApplicationID.ToString();
                    lblIsActive.Text = (_InternationalLicense.IsActive) ? "Yes" : "No";
                    lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
                    lblDriverID.Text = _InternationalLicense.DriverID.ToString();
                    lblExpirationDate.Text = _InternationalLicense.ExpirationDate.ToShortDateString();

                    if (_Person.ImagePath != "")
                        _LoadImageSafely(_Person.ImagePath);

                    else
                        pbImage.Image = (_Person.Gender == 0) ? Properties.Resources.man : Properties.Resources.woman;
                }
            }

            else
                clsMessageDialog.Show($"International License With ID : [{InternationalLicenseID}] doesn't exist!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void LoadData(int InternationalLicenseID)
        {
            _LoadData(InternationalLicenseID);
        }
    }
}
