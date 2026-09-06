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
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        private int _PersonID = -1;
        private string _NationalNumber = "";

        clsPerson _Person;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int PersonID { get { return this._PersonID; } set { _PersonID = value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NationalNumber { get { return _NationalNumber; } set { _NationalNumber = value; } }

        public bool FilterEnabled
        {
            get { return gbFilter.Enabled; }
            set { gbFilter.Enabled = value; }
        }

        public int FilterSelectedIndex
        {
            get { return cbFilter.SelectedIndex; }
            set { cbFilter.SelectedIndex = value; }
        }

        public string FilterText
        {
            get { return cbFilter.Text; }
            set { cbFilter.Text = value; }
        }

        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        private void _FindPerson()
        {
            switch (cbFilter.Text)
            {
                case "Person ID":
                    {
                        int.TryParse(txtFilter.Text, out int PersonID);

                        if (clsPerson.IsPersonExist(PersonID))
                        {
                            _Person = clsPerson.FindPerson(PersonID);
                            _PersonID = _Person.ID;
                            _NationalNumber = _Person.NationalNumber;
                            ctrlPersonCard1.LoadPersonInfo(PersonID);
                        }

                        else
                            clsMessageDialog.Show($"Cannot find person with PersonID : {PersonID}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }

                case "National No":
                    {
                        string NationalNumber = txtFilter.Text.Trim();

                        if (clsPerson.IsPersonExist(NationalNumber))
                        {
                            _Person = clsPerson.FindPerson(NationalNumber);
                            _NationalNumber = _Person.NationalNumber;
                            _PersonID = _Person.ID;
                            ctrlPersonCard1.LoadPersonInfo(NationalNumber);
                        }

                        else
                            clsMessageDialog.Show($"Cannot find person with National No : {NationalNumber}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }
            }
        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            _FindPerson();
        }

        public void LoadUserInfo(int PersonID)
        {
            _PersonID = PersonID;
            cbFilter.SelectedIndex = 0;
            txtFilter.Text = PersonID.ToString();

            ctrlPersonCard1.LoadPersonInfo(PersonID);
        }

        public void LoadPersonInfo(int PersonID)
        {
            _PersonID = PersonID;
            ctrlPersonCard1.LoadPersonInfo(PersonID);
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson Frm = new frmAddEditPerson(-1);
            Frm.DataBack += _DataBack;
            Frm.ShowDialog();
        }

        private void _DataBack(object sender, int PersonID)
        {
            _PersonID = PersonID;

            LoadUserInfo(this.PersonID);
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Person ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == (char)13)
            {
                btnFindPerson.PerformClick();
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Clear();
            txtFilter.Focus();
        }

    }
}
