
namespace Password_Manager
{
    partial class PasswordManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordManager));
            this.generateButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.specialLettersCheckBox = new System.Windows.Forms.CheckBox();
            this.numbersCheckBox = new System.Windows.Forms.CheckBox();
            this.lowerCaseLettersCheckBox = new System.Windows.Forms.CheckBox();
            this.upperCaseLettersCheckBox = new System.Windows.Forms.CheckBox();
            this.lengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.copyButton = new System.Windows.Forms.Button();
            this.passwordManagerTabControl = new System.Windows.Forms.TabControl();
            this.passwordGeneratorTabPage = new System.Windows.Forms.TabPage();
            this.passwordGeneratorGroupBox = new System.Windows.Forms.GroupBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.passwordManagerTabPage = new System.Windows.Forms.TabPage();
            this.passwordManagerLabel = new System.Windows.Forms.Label();
            this.passwordGeneratorErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lengthNumericUpDown)).BeginInit();
            this.passwordManagerTabControl.SuspendLayout();
            this.passwordGeneratorTabPage.SuspendLayout();
            this.passwordGeneratorGroupBox.SuspendLayout();
            this.passwordManagerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordGeneratorErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generateButton.Location = new System.Drawing.Point(15, 314);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(399, 28);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(15, 36);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(323, 23);
            this.passwordTextBox.TabIndex = 1;
            // 
            // specialLettersCheckBox
            // 
            this.specialLettersCheckBox.AutoSize = true;
            this.specialLettersCheckBox.Location = new System.Drawing.Point(15, 74);
            this.specialLettersCheckBox.Name = "specialLettersCheckBox";
            this.specialLettersCheckBox.Size = new System.Drawing.Size(113, 19);
            this.specialLettersCheckBox.TabIndex = 2;
            this.specialLettersCheckBox.Text = "Include Symbols";
            this.specialLettersCheckBox.UseVisualStyleBackColor = true;
            // 
            // numbersCheckBox
            // 
            this.numbersCheckBox.AutoSize = true;
            this.numbersCheckBox.Location = new System.Drawing.Point(15, 118);
            this.numbersCheckBox.Name = "numbersCheckBox";
            this.numbersCheckBox.Size = new System.Drawing.Size(117, 19);
            this.numbersCheckBox.TabIndex = 3;
            this.numbersCheckBox.Text = "Include Numbers";
            this.numbersCheckBox.UseVisualStyleBackColor = true;
            // 
            // lowerCaseLettersCheckBox
            // 
            this.lowerCaseLettersCheckBox.AutoSize = true;
            this.lowerCaseLettersCheckBox.Location = new System.Drawing.Point(16, 166);
            this.lowerCaseLettersCheckBox.Name = "lowerCaseLettersCheckBox";
            this.lowerCaseLettersCheckBox.Size = new System.Drawing.Size(161, 19);
            this.lowerCaseLettersCheckBox.TabIndex = 4;
            this.lowerCaseLettersCheckBox.Text = "Include Lowercase Letters";
            this.lowerCaseLettersCheckBox.UseVisualStyleBackColor = true;
            // 
            // upperCaseLettersCheckBox
            // 
            this.upperCaseLettersCheckBox.AutoSize = true;
            this.upperCaseLettersCheckBox.Location = new System.Drawing.Point(15, 212);
            this.upperCaseLettersCheckBox.Name = "upperCaseLettersCheckBox";
            this.upperCaseLettersCheckBox.Size = new System.Drawing.Size(161, 19);
            this.upperCaseLettersCheckBox.TabIndex = 5;
            this.upperCaseLettersCheckBox.Text = "Include Uppercase Letters";
            this.upperCaseLettersCheckBox.UseVisualStyleBackColor = true;
            // 
            // lengthNumericUpDown
            // 
            this.lengthNumericUpDown.Location = new System.Drawing.Point(93, 259);
            this.lengthNumericUpDown.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.lengthNumericUpDown.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.lengthNumericUpDown.Name = "lengthNumericUpDown";
            this.lengthNumericUpDown.Size = new System.Drawing.Size(41, 23);
            this.lengthNumericUpDown.TabIndex = 6;
            this.lengthNumericUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // copyButton
            // 
            this.copyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copyButton.Location = new System.Drawing.Point(358, 32);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(56, 28);
            this.copyButton.TabIndex = 7;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // passwordManagerTabControl
            // 
            this.passwordManagerTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.passwordManagerTabControl.Controls.Add(this.passwordGeneratorTabPage);
            this.passwordManagerTabControl.Controls.Add(this.passwordManagerTabPage);
            this.passwordManagerTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordManagerTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.passwordManagerTabControl.ItemSize = new System.Drawing.Size(25, 150);
            this.passwordManagerTabControl.Location = new System.Drawing.Point(0, 0);
            this.passwordManagerTabControl.Multiline = true;
            this.passwordManagerTabControl.Name = "passwordManagerTabControl";
            this.passwordManagerTabControl.SelectedIndex = 0;
            this.passwordManagerTabControl.Size = new System.Drawing.Size(568, 384);
            this.passwordManagerTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.passwordManagerTabControl.TabIndex = 8;
            // 
            // passwordGeneratorTabPage
            // 
            this.passwordGeneratorTabPage.Controls.Add(this.passwordGeneratorGroupBox);
            this.passwordGeneratorTabPage.Location = new System.Drawing.Point(154, 4);
            this.passwordGeneratorTabPage.Name = "passwordGeneratorTabPage";
            this.passwordGeneratorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.passwordGeneratorTabPage.Size = new System.Drawing.Size(410, 376);
            this.passwordGeneratorTabPage.TabIndex = 0;
            this.passwordGeneratorTabPage.Text = "Password Generator";
            this.passwordGeneratorTabPage.UseVisualStyleBackColor = true;
            // 
            // passwordGeneratorGroupBox
            // 
            this.passwordGeneratorGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordGeneratorGroupBox.Controls.Add(this.lengthLabel);
            this.passwordGeneratorGroupBox.Controls.Add(this.passwordTextBox);
            this.passwordGeneratorGroupBox.Controls.Add(this.copyButton);
            this.passwordGeneratorGroupBox.Controls.Add(this.numbersCheckBox);
            this.passwordGeneratorGroupBox.Controls.Add(this.generateButton);
            this.passwordGeneratorGroupBox.Controls.Add(this.lowerCaseLettersCheckBox);
            this.passwordGeneratorGroupBox.Controls.Add(this.lengthNumericUpDown);
            this.passwordGeneratorGroupBox.Controls.Add(this.specialLettersCheckBox);
            this.passwordGeneratorGroupBox.Controls.Add(this.upperCaseLettersCheckBox);
            this.passwordGeneratorGroupBox.Location = new System.Drawing.Point(5, 6);
            this.passwordGeneratorGroupBox.Name = "passwordGeneratorGroupBox";
            this.passwordGeneratorGroupBox.Size = new System.Drawing.Size(419, 365);
            this.passwordGeneratorGroupBox.TabIndex = 8;
            this.passwordGeneratorGroupBox.TabStop = false;
            this.passwordGeneratorGroupBox.Text = "Password Generator";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(12, 263);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(44, 15);
            this.lengthLabel.TabIndex = 9;
            this.lengthLabel.Text = "Length";
            // 
            // passwordManagerTabPage
            // 
            this.passwordManagerTabPage.Controls.Add(this.passwordManagerLabel);
            this.passwordManagerTabPage.Location = new System.Drawing.Point(154, 4);
            this.passwordManagerTabPage.Name = "passwordManagerTabPage";
            this.passwordManagerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.passwordManagerTabPage.Size = new System.Drawing.Size(410, 376);
            this.passwordManagerTabPage.TabIndex = 1;
            this.passwordManagerTabPage.Text = "Password Manager";
            this.passwordManagerTabPage.UseVisualStyleBackColor = true;
            // 
            // passwordManagerLabel
            // 
            this.passwordManagerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordManagerLabel.AutoSize = true;
            this.passwordManagerLabel.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordManagerLabel.Location = new System.Drawing.Point(68, 162);
            this.passwordManagerLabel.Name = "passwordManagerLabel";
            this.passwordManagerLabel.Size = new System.Drawing.Size(270, 57);
            this.passwordManagerLabel.TabIndex = 0;
            this.passwordManagerLabel.Text = "Comming Soon";
            this.passwordManagerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordGeneratorErrorProvider
            // 
            this.passwordGeneratorErrorProvider.ContainerControl = this;
            // 
            // PasswordManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 384);
            this.Controls.Add(this.passwordManagerTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(574, 423);
            this.Name = "PasswordManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Manager";
            ((System.ComponentModel.ISupportInitialize)(this.lengthNumericUpDown)).EndInit();
            this.passwordManagerTabControl.ResumeLayout(false);
            this.passwordGeneratorTabPage.ResumeLayout(false);
            this.passwordGeneratorGroupBox.ResumeLayout(false);
            this.passwordGeneratorGroupBox.PerformLayout();
            this.passwordManagerTabPage.ResumeLayout(false);
            this.passwordManagerTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordGeneratorErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.CheckBox specialLettersCheckBox;
        private System.Windows.Forms.CheckBox numbersCheckBox;
        private System.Windows.Forms.CheckBox lowerCaseLettersCheckBox;
        private System.Windows.Forms.CheckBox upperCaseLettersCheckBox;
        private System.Windows.Forms.NumericUpDown lengthNumericUpDown;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TabControl passwordManagerTabControl;
        private System.Windows.Forms.TabPage passwordGeneratorTabPage;
        private System.Windows.Forms.TabPage passwordManagerTabPage;
        private System.Windows.Forms.GroupBox passwordGeneratorGroupBox;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.ErrorProvider passwordGeneratorErrorProvider;
        private System.Windows.Forms.Label passwordManagerLabel;
    }
}

