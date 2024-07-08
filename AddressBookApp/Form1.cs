// Form1.cs
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        private List<Contact> contacts = new List<Contact>();

        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string phone = phoneTextBox.Text;

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(phone))
            {
                Contact newContact = new Contact
                {
                    Name = name,
                    Email = email,
                    PhoneNumber = phone
                };

                contacts.Add(newContact);
                MessageBox.Show("Contact saved!");

                // Clear the text boxes
                nameTextBox.Text = "";
                emailTextBox.Text = "";
                phoneTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill in all the fields.");
            }
        }
    }

    public class Contact
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
