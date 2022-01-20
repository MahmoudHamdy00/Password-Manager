
namespace Password_Manager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.generate_btn = new System.Windows.Forms.Button();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.includeSymbols = new System.Windows.Forms.CheckBox();
            this.includeNumbers = new System.Windows.Forms.CheckBox();
            this.includeLowercaseCharacters = new System.Windows.Forms.CheckBox();
            this.includeUppercaseCharacters = new System.Windows.Forms.CheckBox();
            this.length = new System.Windows.Forms.NumericUpDown();
            this.copy_btn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.length)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // generate_btn
            // 
            this.generate_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generate_btn.Location = new System.Drawing.Point(17, 410);
            this.generate_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.generate_btn.Name = "generate_btn";
            this.generate_btn.Size = new System.Drawing.Size(456, 38);
            this.generate_btn.TabIndex = 0;
            this.generate_btn.Text = "Generate";
            this.generate_btn.UseVisualStyleBackColor = true;
            this.generate_btn.Click += new System.EventHandler(this.generate_btn_Click);
            // 
            // password_textBox
            // 
            this.password_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_textBox.Location = new System.Drawing.Point(17, 48);
            this.password_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(369, 27);
            this.password_textBox.TabIndex = 1;
            this.password_textBox.TextChanged += new System.EventHandler(this.password_textBox_TextChanged);
            // 
            // includeSymbols
            // 
            this.includeSymbols.AutoSize = true;
            this.includeSymbols.Location = new System.Drawing.Point(17, 98);
            this.includeSymbols.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.includeSymbols.Name = "includeSymbols";
            this.includeSymbols.Size = new System.Drawing.Size(139, 24);
            this.includeSymbols.TabIndex = 2;
            this.includeSymbols.Text = "Include Symbols";
            this.includeSymbols.UseVisualStyleBackColor = true;
            // 
            // includeNumbers
            // 
            this.includeNumbers.AutoSize = true;
            this.includeNumbers.Location = new System.Drawing.Point(17, 158);
            this.includeNumbers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.includeNumbers.Name = "includeNumbers";
            this.includeNumbers.Size = new System.Drawing.Size(143, 24);
            this.includeNumbers.TabIndex = 3;
            this.includeNumbers.Text = "Include Numbers";
            this.includeNumbers.UseVisualStyleBackColor = true;
            // 
            // includeLowercaseCharacters
            // 
            this.includeLowercaseCharacters.AutoSize = true;
            this.includeLowercaseCharacters.Location = new System.Drawing.Point(18, 222);
            this.includeLowercaseCharacters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.includeLowercaseCharacters.Name = "includeLowercaseCharacters";
            this.includeLowercaseCharacters.Size = new System.Drawing.Size(225, 24);
            this.includeLowercaseCharacters.TabIndex = 4;
            this.includeLowercaseCharacters.Text = "Include Lowercase Characters";
            this.includeLowercaseCharacters.UseVisualStyleBackColor = true;
            // 
            // includeUppercaseCharacters
            // 
            this.includeUppercaseCharacters.AutoSize = true;
            this.includeUppercaseCharacters.Location = new System.Drawing.Point(17, 282);
            this.includeUppercaseCharacters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.includeUppercaseCharacters.Name = "includeUppercaseCharacters";
            this.includeUppercaseCharacters.Size = new System.Drawing.Size(226, 24);
            this.includeUppercaseCharacters.TabIndex = 5;
            this.includeUppercaseCharacters.Text = "Include Uppercase Characters";
            this.includeUppercaseCharacters.UseVisualStyleBackColor = true;
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(106, 345);
            this.length.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.length.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.length.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(47, 27);
            this.length.TabIndex = 6;
            this.length.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // copy_btn
            // 
            this.copy_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copy_btn.Location = new System.Drawing.Point(409, 42);
            this.copy_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.copy_btn.Name = "copy_btn";
            this.copy_btn.Size = new System.Drawing.Size(64, 38);
            this.copy_btn.TabIndex = 7;
            this.copy_btn.Text = "Copy";
            this.copy_btn.UseVisualStyleBackColor = true;
            this.copy_btn.Click += new System.EventHandler(this.copy_btn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(25, 150);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(649, 504);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(154, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(491, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Password Generator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.password_textBox);
            this.groupBox1.Controls.Add(this.copy_btn);
            this.groupBox1.Controls.Add(this.includeNumbers);
            this.groupBox1.Controls.Add(this.generate_btn);
            this.groupBox1.Controls.Add(this.includeLowercaseCharacters);
            this.groupBox1.Controls.Add(this.length);
            this.groupBox1.Controls.Add(this.includeSymbols);
            this.groupBox1.Controls.Add(this.includeUppercaseCharacters);
            this.groupBox1.Location = new System.Drawing.Point(6, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(479, 479);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password Generator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Length";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(154, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(491, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Password Manager";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(78, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 71);
            this.label2.TabIndex = 0;
            this.label2.Text = "Comming Soon";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 504);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(654, 551);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.length)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.CheckBox includeSymbols;
        private System.Windows.Forms.CheckBox includeNumbers;
        private System.Windows.Forms.CheckBox includeLowercaseCharacters;
        private System.Windows.Forms.CheckBox includeUppercaseCharacters;
        private System.Windows.Forms.NumericUpDown length;
        private System.Windows.Forms.Button copy_btn;
        private System.Windows.Forms.Button generate_btn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
    }
}

