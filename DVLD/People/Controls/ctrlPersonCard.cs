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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD
{
    public partial class ctrlPersonCard : UserControl
    {
        private int _PersonID;
        private clsPerson _Person;
        private string[] _FullName;

        public int PersonID
        {
            get { return _PersonID; }
        }

        public clsPerson Person
        {
            get { return _Person; }
        }

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int ID)
        {
            _Person = clsPerson.FindPerson(ID);

            if (_Person != null)
            { 
                _PersonID = _Person.ID;
                _FillPersonInfo();
            }
        }

        public void LoadPersonInfo(string NationalNumber)
        {
            _Person = clsPerson.FindPerson(NationalNumber);

            if (_Person != null)
            {
                _PersonID = _Person.ID;
                _FillPersonInfo();
            }
        }

        private void _LoadImageSafely(string ImagePath)
        {
            if (File.Exists(ImagePath))
            {
                using (FileStream FS = new FileStream(ImagePath, FileMode.Open, FileAccess.Read))
                {
                    pbImage.Image = System.Drawing.Image.FromStream(FS);
                    pbImage.Tag = ImagePath;
                }
            }

            else
                pbImage.Image = (_Person.Gender == 0) ? Properties.Resources.man : Properties.Resources.woman;
        }

        private void _FillPersonInfo()
        {
            _FullName = new string[4]{ _Person.FirstName, _Person.SecondName, _Person.ThirdName, _Person.LastName };

            lblPersonID.Text = _Person.ID.ToString();
            lblName.Text = string.Join(" ", _FullName);
            lblNationalNo.Text = _Person.NationalNumber;
            lblEmail.Text = _Person.Email;
            lblAddress.Text = _Person.Address;
            lblBirthDate.Text = _Person.DateOfBirth.ToShortDateString();
            lblPhone.Text = _Person.Phone;
            lblCountry.Text = clsCountry.FindCountryByID(_Person.NationalityCountryID).CountryName;
            lblGender.Text = (_Person.Gender == 0) ? "Male" : "Female";
            _LoadImageSafely(_Person.ImagePath);
        }

        private void llEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_Person != null)
            {
                frmAddEditPerson Frm = new frmAddEditPerson(_PersonID);
                Frm.ShowDialog();
                LoadPersonInfo(_PersonID);
            }
        }

    }
}
