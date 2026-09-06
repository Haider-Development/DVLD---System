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
    public partial class frmUserDetails : Form
    {
        int _UserID;

        public frmUserDetails(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            if (_UserID != -1)
                ctrlUserCard1.LoadUserInfo(_UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
