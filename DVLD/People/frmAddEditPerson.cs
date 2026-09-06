using DVLD.Properties;
using DVLD_BusinessLayer;
using Guna.UI2.WinForms;
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
    public partial class frmAddEditPerson : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;

        private enum enMode : sbyte { enAddNewMode = 1, enUpdateMode = 2 }
        private enMode _Mode = enMode.enAddNewMode;

        clsPerson _Person;
        int _PersonID;

        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;

            if (_PersonID != -1)
                _Mode = enMode.enUpdateMode;
            else
                _Mode = enMode.enAddNewMode;
        }

        private void _LoadCountries()
        {
            DataTable CountriesDataTable = clsCountry.CountriesList();

            foreach (DataRow Row in CountriesDataTable.Rows)
            {
                cbCountries.Items.Add(Row["CountryName"]);
            }
        }

        private void _ValidatingDateOfBirth()
        {
            dtpBirthDate.MaxDate = DateTime.Now.AddYears(-18);
        }

        private string _CopyImageToProjectFolder(string SourceFilePath)
        {
            string ProjectImagesFolder = Path.Combine(Application.StartupPath, "People-Images");

            if (!Directory.Exists(ProjectImagesFolder))
            {
                Directory.CreateDirectory(ProjectImagesFolder);
            }

            string Ext = Path.GetExtension(SourceFilePath);
            string NewFileName = Guid.NewGuid().ToString() + Ext;

            string DestinationFilePath = Path.Combine(ProjectImagesFolder, NewFileName);

            File.Copy(SourceFilePath, DestinationFilePath, true);

            return DestinationFilePath;
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

        private void _DeleteOldImage(string ImagePath)
        {
            if (!string.IsNullOrEmpty(ImagePath) && File.Exists(ImagePath))
            {
                File.Delete(ImagePath);
            }
        }

        private void _LoadData()
        {
            _LoadCountries();
            cbCountries.SelectedIndex = 0;
            _ValidatingDateOfBirth();

            if (_Mode == enMode.enAddNewMode)
            {
                lblAddEdit.Text = "Add New Person";
                _Person = new clsPerson();
                return;
            }

            _Person = clsPerson.FindPerson(_PersonID);

            lblAddEdit.Text = "Edit Person";
            lblPersonID.Text = _PersonID.ToString();

            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNumber;

            if (_Person.Gender == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            txtEmail.Text = _Person.Email;
            txtAddress.Text = _Person.Address;
            dtpBirthDate.Value = _Person.DateOfBirth;
            txtPhone.Text = _Person.Phone;
            cbCountries.Text = clsCountry.FindCountryByID(_Person.NationalityCountryID).CountryName;

            if (_Person.ImagePath != null || _Person.ImagePath != "")
            {
                _LoadImageSafely(_Person.ImagePath);
            }

            llRemoveImage.Visible = (pbImage.Tag != null);
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void txtBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((Guna2TextBox)sender).Text) || string.IsNullOrEmpty(((Guna2TextBox)sender).Text))
            {
                e.Cancel = true;
                ((Guna2TextBox)sender).Focus();
                errorProvider1.SetError((Guna2TextBox)sender, "This Field Cannot be Empty!");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError((Guna2TextBox)sender, "");
            }
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((Guna2TextBox)sender).Text) || string.IsNullOrEmpty(((Guna2TextBox)sender).Text))
            {
                e.Cancel = true;
                ((Guna2TextBox)sender).Focus();
                errorProvider1.SetError((Guna2TextBox)sender, "This Field Cannot be Empty!");
                return;
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError((Guna2TextBox)sender, "");
            }

            string NationalNumber = txtNationalNo.Text.Trim();

            if (_Mode == enMode.enAddNewMode || (_Mode == enMode.enUpdateMode && NationalNumber != _Person.NationalNumber))
            {
                if (clsPerson.IsPersonExist(NationalNumber))
                {
                    e.Cancel = true;
                    ((Guna2TextBox)sender).Focus();
                    errorProvider1.SetError((Guna2TextBox)sender, "this National Number is Used!");
                }

                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError((Guna2TextBox)sender, "");
                }
            }
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string SelectedFilePath = openFileDialog1.FileName;
                pbImage.Tag = SelectedFilePath;

                _LoadImageSafely(SelectedFilePath);
                llRemoveImage.Visible = true;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
                return;

            if (!txtEmail.Text.Contains("@gmail.com"))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "Invalid Email! ... enter a Valid one");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");
            }
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pbImage.Tag?.ToString()) && rbMale.Checked)
                pbImage.Image = Properties.Resources.man;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pbImage.Tag?.ToString()) && rbFemale.Checked)
                pbImage.Image = Properties.Resources.woman;
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImage.Tag = null;

            pbImage.Image = rbMale.Checked? Properties.Resources.man : Properties.Resources.woman;
            llRemoveImage.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_PersonID != -1)
                DataBack?.Invoke(this, _PersonID);

            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                clsMessageDialog.Show("Some Fileds Are Not valid or Empty! Please check your inputs again", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string OldImagePath = "";

            if (!string.IsNullOrEmpty(_Person.ImagePath))
                OldImagePath = _Person.ImagePath;

            int NationalityCountryID = clsCountry.FindCountryByName(cbCountries.Text).ID;

            _Person.NationalNumber = txtNationalNo.Text;
            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.LastName = txtLastName.Text;
            _Person.Email = txtEmail.Text;
            _Person.Address = txtAddress.Text;
            _Person.DateOfBirth = dtpBirthDate.Value;
            _Person.Phone = txtPhone.Text;
            _Person.NationalityCountryID = NationalityCountryID;

            if (rbMale.Checked)
                _Person.Gender = 0;
            else
                _Person.Gender = 1;

            if (pbImage.Tag != null && !string.IsNullOrEmpty(pbImage.Tag.ToString()))
                _Person.ImagePath = _CopyImageToProjectFolder(pbImage.Tag.ToString());
            else
                _Person.ImagePath = "";

            if (_Person.Save())
                clsMessageDialog.Show("Person has been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                clsMessageDialog.Show("Person cannot be saved!", "falied", MessageBoxButtons.OK, MessageBoxIcon.Error);

            _PersonID = _Person.ID;

            _Mode = enMode.enUpdateMode;
            lblAddEdit.Text = "Edit Person";
            lblPersonID.Text = _PersonID.ToString();

            if (OldImagePath != _Person.ImagePath)
                _DeleteOldImage(OldImagePath);
        }

        private void rbGender_Validating(object sender, CancelEventArgs e)
        {
            if (!rbMale.Checked && !rbFemale.Checked)
            {
                e.Cancel = true;
                ((Guna2RadioButton)sender).Focus();
                errorProvider1.SetError((Guna2RadioButton)sender, "Choose a Gender First!");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError((Guna2RadioButton)sender, "");
            }
        }
    }
}
