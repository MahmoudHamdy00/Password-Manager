using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            includeLowercaseCharacters.Checked = true;
            includeUppercaseCharacters.Checked = true;
            includeNumbers.Checked = true;
            includeSymbols.Checked = true;
            //generate_btn.PerformClick();
            generate_btn_Click(this, new EventArgs());
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);

        }

        private void generate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                password_textBox.Text = PasswordManager.get_strong_password(Convert.ToInt32(length.Value), includeLowercaseCharacters.Checked, includeUppercaseCharacters.Checked, includeSymbols.Checked, includeNumbers.Checked);
                set_error_if_password_is_week();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void copy_btn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(password_textBox.Text);
        }

        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 10.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        void set_error_if_password_is_week()
        {
            errorProvider1.Clear();
            if (!PasswordManager.is_strong_password(password_textBox.Text))
            {
                errorProvider1.SetError(password_textBox, $"Password is week, Your password must be at least 8 characters and include\n- Uppercase Characters\n- Lowercase Characters\n- Numbers\n- Symbols {{one of {PasswordManager.specialChars} at least}}");
                copy_btn.BackColor = Color.Red;
            }
            else
                copy_btn.BackColor = Color.Green;
        }
        private void password_textBox_TextChanged(object sender, EventArgs e)
        {
            set_error_if_password_is_week();
        }
    }
}
