using System;
using System.Linq;
using System.Windows.Forms;

namespace pregatirepawexamsub1
{
    public partial class RegistrationForm : Form
    {
        public Registration Registration { get; private set; }
        private bool isNew;

        public RegistrationForm() : this(null) { }

        public RegistrationForm(Registration reg)
        {
            InitializeComponent();
            cmbPackage.DataSource = DataStore.AccessPackages;
            if (reg == null)
            {
                isNew = true;
                Registration = new Registration();
                numPasses.Value = 1;
            }
            else
            {
                isNew = false;
                Registration = reg;
                txtCompany.Text = reg.CompanyName;
                numPasses.Value = reg.NoOfPasses;
                cmbPackage.SelectedItem = DataStore.AccessPackages.FirstOrDefault(p => p.Id == reg.AccessPackageId);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCompany.Text))
            {
                MessageBox.Show("Company Name is required.", "Validation", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.None;
                return;
            }
            if (cmbPackage.SelectedItem == null)
            {
                MessageBox.Show("Please select a package.", "Validation", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.None;
                return;
            }
            Registration.CompanyName = txtCompany.Text.Trim();
            Registration.NoOfPasses = (int)numPasses.Value;
            Registration.AccessPackageId = ((AccessPackage)cmbPackage.SelectedItem).Id;
        }
    }
}