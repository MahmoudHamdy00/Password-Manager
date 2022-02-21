using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class PasswordManager : Form
    {
        private const string numbers = "0123456789";
        private const string specialLetters = "@$!%*#?&";
        private const string lowerCaseLetters = "abcdefghijklmnopqrstuvwxyz";
        private const string upperCaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly Random random = new Random();
        private static readonly Regex strongPasswordPattern = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@$!%*?&])[a-zA-Z0-9@$!%*?&]{8,}$");

        public PasswordManager()
        {
            InitializeComponent();
            numbersCheckBox.Checked = true;
            specialLettersCheckBox.Checked = true;
            lowerCaseLettersCheckBox.Checked = true;
            upperCaseLettersCheckBox.Checked = true;
            GenerateButton_Click(this, new EventArgs());
            passwordManagerTabControl.DrawItem += new DrawItemEventHandler(PasswordManagerTabControl_DrawItem);
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!numbersCheckBox.Checked && !specialLettersCheckBox.Checked &&
                    !lowerCaseLettersCheckBox.Checked && !upperCaseLettersCheckBox.Checked)
                    throw new Exception("You have to check one type of letters at least");

                string password = "";
                string allowedLetters = "";
                int length = Convert.ToInt32(lengthNumericUpDown.Value);

                if (numbersCheckBox.Checked && specialLettersCheckBox.Checked &&
                    lowerCaseLettersCheckBox.Checked && upperCaseLettersCheckBox.Checked)
                {
                    allowedLetters = numbers + lowerCaseLetters + upperCaseLetters + specialLetters;
                    do
                    {
                        password = new string(value: Enumerable.Repeat(
                            element: allowedLetters, count: length).Select(
                            selector => selector[random.Next(
                                maxValue: selector.Length)]).ToArray());
                    } while (!strongPasswordPattern.IsMatch(password));
                }
                else
                {
                    if (numbersCheckBox.Checked)
                    {
                        allowedLetters += numbers;
                    }
                    if (specialLettersCheckBox.Checked)
                    {
                        allowedLetters += specialLetters;
                    }
                    if (lowerCaseLettersCheckBox.Checked)
                    {
                        allowedLetters += lowerCaseLetters;
                    }
                    if (upperCaseLettersCheckBox.Checked)
                    {
                        allowedLetters += upperCaseLetters;
                    }

                    password = new string(value: Enumerable.Repeat(
                        element: allowedLetters, count: length).Select(
                        selector => selector[random.Next(
                            maxValue: selector.Length)]).ToArray());
                }

                passwordTextBox.Text = password;

                CheckPasswordStrenth();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passwordTextBox.Text);
        }

        private void PasswordManagerTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Brush textBrush;

            // Get the item from the collection.
            TabPage tabPage = passwordManagerTabControl.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle tabBounds = passwordManagerTabControl.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background color, and don't paint a focus rectangle.
                textBrush = new SolidBrush(Color.White);
                graphics.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                textBrush = new SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font font = new Font("Arial", 10.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat stringFlags = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            graphics.DrawString(tabPage.Text, font, textBrush, tabBounds, stringFlags);
        }

        private void CheckPasswordStrenth()
        {
            passwordGeneratorErrorProvider.Clear();
            if (!strongPasswordPattern.IsMatch(passwordTextBox.Text))
            {
                passwordGeneratorErrorProvider.SetError(passwordTextBox, $"Password is week, Your password must be at least 8 characters and include\n- Uppercase Characters\n- Lowercase Characters\n- Numbers\n- Symbols {{one of {specialLetters} at least}}");
                copyButton.BackColor = Color.Red;
            }
            else
            {
                copyButton.BackColor = Color.Green;
            }
        }
    }
}
