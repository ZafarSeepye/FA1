using System;
using System.Windows.Forms;

namespace HomeAffairsDigitalIdentityProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ── Validate ID Button ──────────────────────────────────────────
        private void btnValidate_Click(object sender, EventArgs e)
        {
            // Check that fields are not empty
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtID.Text) ||
                cmbCitizen.SelectedIndex == -1)
            {
                lblResult.Text = "Please fill in all fields before validating.";
                lblResult.ForeColor = System.Drawing.Color.OrangeRed;
                return;
            }

            // Create a CitizenProfile object and validate
            CitizenProfile profile = new CitizenProfile(
                txtName.Text.Trim(),
                txtID.Text.Trim(),
                cmbCitizen.SelectedItem.ToString()
            );

            string result = profile.ValidateID();
            lblResult.Text = result;

            // Change colour based on result
            lblResult.ForeColor = result.StartsWith("True")
                ? System.Drawing.Color.DarkGreen
                : System.Drawing.Color.Red;
        }

        // ── Generate Profile Button ─────────────────────────────────────
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtID.Text) ||
                cmbCitizen.SelectedIndex == -1)
            {
                txtSummary.Text = "Please fill in all fields first.";
                return;
            }

            CitizenProfile profile = new CitizenProfile(
                txtName.Text.Trim(),
                txtID.Text.Trim(),
                cmbCitizen.SelectedItem.ToString()
            );

            string validation = profile.ValidateID();
            string timestamp = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            txtSummary.Text =
                "==== DIGITAL CITIZEN SUMMARY ====" + Environment.NewLine +
                "Name:           " + profile.FullName + Environment.NewLine +
                "ID Number:      " + profile.IDNumber + Environment.NewLine +
                "Age:            " + profile.Age + Environment.NewLine +
                "Citizenship:    " + profile.CitizenshipStatus + Environment.NewLine +
                "Validation:     " + validation + Environment.NewLine +
                "Processed at:   Home Affairs Digital Desk" + Environment.NewLine +
                "Timestamp:      " + timestamp;
        }
    }
}