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
    public partial class frmPersonDetails : Form
    {
        private int _PersonID = -1;
        private string _NationalNumber = "";

        public frmPersonDetails(int ID)
        {
            InitializeComponent();

            _PersonID = ID;
        }

        public frmPersonDetails(string NationalNumber)
        {
            InitializeComponent();

            _NationalNumber = NationalNumber;
        }

        private void frmPersonDetails_Load(object sender, EventArgs e)
        {
            if (_PersonID != -1)
                ctrlPersonCard1.LoadPersonInfo(_PersonID);

            else if (_NationalNumber != "")
                ctrlPersonCard1.LoadPersonInfo(_NationalNumber);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
