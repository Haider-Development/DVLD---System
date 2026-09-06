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
    public partial class frmViewPersonLicensesHistory : Form
    {
        private int _PersonID;

        public frmViewPersonLicensesHistory(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;
        }

        private void frmViewPersonLicensesHistory_Load(object sender, EventArgs e)
        {
            if (_PersonID != -1)
            {
                ctrlPersonCard1.LoadPersonInfo(_PersonID);
                ctrlLicensesList1.LoadData(_PersonID);
            }

            else
            {
                clsMessageDialog.Show($"Could not found Person with ID : {_PersonID}\nthis form will be closed!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
