using System;
using System.Drawing;
using System.Windows.Forms;

namespace FavouriteLanguages1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // runs when the form first opens
        private void Form1_Load(object sender, EventArgs e)
        {
            // add some starter languages to the list
            listBoxLanguages.Items.Add("C#");
            listBoxLanguages.Items.Add("Python");
            listBoxLanguages.Items.Add("Java");
            listBoxLanguages.Items.Add("JavaScript");
            listBoxLanguages.Items.Add("Go");

            // clear the placeholder text when user clicks the textbox
            txtLanguage.GotFocus += (s, ev) =>
            {
                if (txtLanguage.Text == "Enter programming language")
                {
                    txtLanguage.Text = "";
                    txtLanguage.ForeColor = Color.Black;
                }
            };

            // restore placeholder if user clicks away with nothing typed
            txtLanguage.LostFocus += (s, ev) =>
            {
                if (txtLanguage.Text == "")
                {
                    txtLanguage.Text = "Enter programming language";
                    txtLanguage.ForeColor = Color.Gray;
                }
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string language = txtLanguage.Text.Trim();

            // prevent empty input or placeholder text being added
            if (string.IsNullOrEmpty(language) || language == "Enter programming language")
            {
                MessageBox.Show("Please enter a programming language first.", "Empty Input");
                return;
            }

            // prevent duplicates - check every item in the list
            foreach (var item in listBoxLanguages.Items)
            {
                if (item.ToString().ToLower() == language.ToLower())
                {
                    MessageBox.Show($"'{language}' is already in the list!", "Duplicate Language");
                    return;
                }
            }

            // if we get here, it's valid - add it
            listBoxLanguages.Items.Add(language);

            // clear the textbox and show status
            txtLanguage.Text = "";
            lblStatus.Text = $"Added '{language}' at {DateTime.Now:dd MMM yyyy HH:mm:ss}";
            lblStatus.ForeColor = Color.Green;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // check that the user has actually selected something
            if (listBoxLanguages.SelectedItem == null)
            {
                MessageBox.Show("Please click on a language in the list first.", "Nothing Selected");
                return;
            }

            string selected = listBoxLanguages.SelectedItem.ToString();

            // remove it
            listBoxLanguages.Items.Remove(listBoxLanguages.SelectedItem);

            // show status message
            lblStatus.Text = $"Removed '{selected}' at {DateTime.Now:dd MMM yyyy HH:mm:ss}";
            lblStatus.ForeColor = Color.Red;
        }
    }
}