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
    public partial class ctrlTestDetails : UserControl
    {
        private clsLDLApplication _LDLApplication;
        private clsLDLApplicationView _LDLApplicationView;
        
        public decimal TestFees { get; set; }
        public DateTime ChangeDateValue
        {
            get { return dtpTestDate.Value; }
            set { dtpTestDate.Value = value;}
        }
        public string Title
        {
            get { return lblTestType.Text; }
            set {  lblTestType.Text = value; }
        }
        public Image TestImage
        {
            get { return pbTestType.Image; }
            set {  pbTestType.Image = value; }
        }

        public string BoxTitle
        {
            get { return gbTestType.Text; }
            set { gbTestType.Text = value; }
        }

        public bool DateEnabled
        {
            get { return dtpTestDate.Enabled; }
            set { dtpTestDate.Enabled = value; }
        }

        public ctrlTestDetails()
        {
            InitializeComponent();
        }

        public void LoadData(int LDLApplicationID, int Trials, int TestTypeID)
        {
            _LDLApplication = clsLDLApplication.FindLDLApplication(LDLApplicationID);
            _LDLApplicationView = clsLDLApplicationView.FindLDLApplication(LDLApplicationID);
            TestFees = clsTestType.GetTestTypeFees(TestTypeID);

            lblLDLApplicationID.Text = LDLApplicationID.ToString();
            lblClassName.Text = _LDLApplicationView.ClassName;
            lblPersonName.Text = _LDLApplicationView.ApplicantName;
            lblTrials.Text = Trials.ToString();
            lblFees.Text = TestFees.ToString();
            dtpTestDate.MinDate = DateTime.Now;
        }

    }
}
