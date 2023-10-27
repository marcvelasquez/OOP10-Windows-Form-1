namespace MyFirstWindow
{
    partial class Register
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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            registerCancelButton = new MaterialSkin.Controls.MaterialButton();
            registerConfirmButton = new MaterialSkin.Controls.MaterialButton();
            registerReenterPassword = new MaterialSkin.Controls.MaterialTextBox();
            registerTextboxLastName = new MaterialSkin.Controls.MaterialTextBox();
            registerPassword = new MaterialSkin.Controls.MaterialTextBox();
            registerTextBoxEmail = new MaterialSkin.Controls.MaterialTextBox();
            registerTextboxFirstName = new MaterialSkin.Controls.MaterialTextBox();
            label1 = new Label();
            registerTextboxUsername = new MaterialSkin.Controls.MaterialTextBox();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(registerTextboxUsername);
            materialCard1.Controls.Add(label7);
            materialCard1.Controls.Add(label6);
            materialCard1.Controls.Add(label5);
            materialCard1.Controls.Add(label4);
            materialCard1.Controls.Add(label3);
            materialCard1.Controls.Add(label2);
            materialCard1.Controls.Add(registerCancelButton);
            materialCard1.Controls.Add(registerConfirmButton);
            materialCard1.Controls.Add(registerReenterPassword);
            materialCard1.Controls.Add(registerTextboxLastName);
            materialCard1.Controls.Add(registerPassword);
            materialCard1.Controls.Add(registerTextBoxEmail);
            materialCard1.Controls.Add(registerTextboxFirstName);
            materialCard1.Controls.Add(label1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(51, 53);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(697, 514);
            materialCard1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(356, 280);
            label7.Name = "label7";
            label7.Size = new Size(158, 25);
            label7.TabIndex = 14;
            label7.Text = "Re-enter Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 280);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 13;
            label6.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(356, 180);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 12;
            label5.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 180);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 11;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(356, 83);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 10;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 84);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 9;
            label2.Text = "First Name";
            // 
            // registerCancelButton
            // 
            registerCancelButton.AutoSize = false;
            registerCancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            registerCancelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            registerCancelButton.Depth = 0;
            registerCancelButton.HighEmphasis = true;
            registerCancelButton.Icon = null;
            registerCancelButton.Location = new Point(230, 440);
            registerCancelButton.Margin = new Padding(4, 6, 4, 6);
            registerCancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            registerCancelButton.Name = "registerCancelButton";
            registerCancelButton.NoAccentTextColor = Color.Empty;
            registerCancelButton.Size = new Size(237, 54);
            registerCancelButton.TabIndex = 8;
            registerCancelButton.Text = "Cancel";
            registerCancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            registerCancelButton.UseAccentColor = false;
            registerCancelButton.UseVisualStyleBackColor = true;
            registerCancelButton.Click += materialButton2_Click;
            // 
            // registerConfirmButton
            // 
            registerConfirmButton.AutoSize = false;
            registerConfirmButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            registerConfirmButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            registerConfirmButton.Depth = 0;
            registerConfirmButton.HighEmphasis = true;
            registerConfirmButton.Icon = null;
            registerConfirmButton.Location = new Point(230, 374);
            registerConfirmButton.Margin = new Padding(4, 6, 4, 6);
            registerConfirmButton.MouseState = MaterialSkin.MouseState.HOVER;
            registerConfirmButton.Name = "registerConfirmButton";
            registerConfirmButton.NoAccentTextColor = Color.Empty;
            registerConfirmButton.Size = new Size(237, 54);
            registerConfirmButton.TabIndex = 7;
            registerConfirmButton.Text = "Confirm";
            registerConfirmButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            registerConfirmButton.UseAccentColor = false;
            registerConfirmButton.UseVisualStyleBackColor = true;
            registerConfirmButton.Click += registerConfirmButton_Click;
            // 
            // registerReenterPassword
            // 
            registerReenterPassword.AnimateReadOnly = false;
            registerReenterPassword.BorderStyle = BorderStyle.None;
            registerReenterPassword.Depth = 0;
            registerReenterPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            registerReenterPassword.LeadingIcon = null;
            registerReenterPassword.Location = new Point(356, 308);
            registerReenterPassword.MaxLength = 50;
            registerReenterPassword.MouseState = MaterialSkin.MouseState.OUT;
            registerReenterPassword.Multiline = false;
            registerReenterPassword.Name = "registerReenterPassword";
            registerReenterPassword.Size = new Size(324, 50);
            registerReenterPassword.TabIndex = 6;
            registerReenterPassword.Text = "";
            registerReenterPassword.TrailingIcon = null;
            // 
            // registerTextboxLastName
            // 
            registerTextboxLastName.AnimateReadOnly = false;
            registerTextboxLastName.BorderStyle = BorderStyle.None;
            registerTextboxLastName.Depth = 0;
            registerTextboxLastName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            registerTextboxLastName.LeadingIcon = null;
            registerTextboxLastName.Location = new Point(356, 111);
            registerTextboxLastName.MaxLength = 50;
            registerTextboxLastName.MouseState = MaterialSkin.MouseState.OUT;
            registerTextboxLastName.Multiline = false;
            registerTextboxLastName.Name = "registerTextboxLastName";
            registerTextboxLastName.Size = new Size(324, 50);
            registerTextboxLastName.TabIndex = 4;
            registerTextboxLastName.Text = "";
            registerTextboxLastName.TrailingIcon = null;
            // 
            // registerPassword
            // 
            registerPassword.AnimateReadOnly = false;
            registerPassword.BorderStyle = BorderStyle.None;
            registerPassword.Depth = 0;
            registerPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            registerPassword.LeadingIcon = null;
            registerPassword.Location = new Point(17, 308);
            registerPassword.MaxLength = 50;
            registerPassword.MouseState = MaterialSkin.MouseState.OUT;
            registerPassword.Multiline = false;
            registerPassword.Name = "registerPassword";
            registerPassword.Size = new Size(324, 50);
            registerPassword.TabIndex = 3;
            registerPassword.Text = "";
            registerPassword.TrailingIcon = null;
            // 
            // registerTextBoxEmail
            // 
            registerTextBoxEmail.AnimateReadOnly = false;
            registerTextBoxEmail.BorderStyle = BorderStyle.None;
            registerTextBoxEmail.Depth = 0;
            registerTextBoxEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            registerTextBoxEmail.LeadingIcon = null;
            registerTextBoxEmail.Location = new Point(17, 208);
            registerTextBoxEmail.MaxLength = 50;
            registerTextBoxEmail.MouseState = MaterialSkin.MouseState.OUT;
            registerTextBoxEmail.Multiline = false;
            registerTextBoxEmail.Name = "registerTextBoxEmail";
            registerTextBoxEmail.Size = new Size(324, 50);
            registerTextBoxEmail.TabIndex = 2;
            registerTextBoxEmail.Text = "";
            registerTextBoxEmail.TrailingIcon = null;
            // 
            // registerTextboxFirstName
            // 
            registerTextboxFirstName.AnimateReadOnly = false;
            registerTextboxFirstName.BorderStyle = BorderStyle.None;
            registerTextboxFirstName.Depth = 0;
            registerTextboxFirstName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            registerTextboxFirstName.LeadingIcon = null;
            registerTextboxFirstName.Location = new Point(17, 112);
            registerTextboxFirstName.MaxLength = 50;
            registerTextboxFirstName.MouseState = MaterialSkin.MouseState.OUT;
            registerTextboxFirstName.Multiline = false;
            registerTextboxFirstName.Name = "registerTextboxFirstName";
            registerTextboxFirstName.Size = new Size(324, 50);
            registerTextboxFirstName.TabIndex = 1;
            registerTextboxFirstName.Text = "";
            registerTextboxFirstName.TrailingIcon = null;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(283, 14);
            label1.Name = "label1";
            label1.Size = new Size(149, 48);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // registerTextboxUsername
            // 
            registerTextboxUsername.AnimateReadOnly = false;
            registerTextboxUsername.BorderStyle = BorderStyle.None;
            registerTextboxUsername.Depth = 0;
            registerTextboxUsername.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            registerTextboxUsername.LeadingIcon = null;
            registerTextboxUsername.Location = new Point(356, 208);
            registerTextboxUsername.MaxLength = 50;
            registerTextboxUsername.MouseState = MaterialSkin.MouseState.OUT;
            registerTextboxUsername.Multiline = false;
            registerTextboxUsername.Name = "registerTextboxUsername";
            registerTextboxUsername.Size = new Size(324, 50);
            registerTextboxUsername.TabIndex = 15;
            registerTextboxUsername.Text = "";
            registerTextboxUsername.TrailingIcon = null;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(materialCard1);
            FormStyle = FormStyles.ActionBar_None;
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "Register";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label label1;
        private MaterialSkin.Controls.MaterialTextBox registerTextboxLastName;
        private MaterialSkin.Controls.MaterialTextBox registerPassword;
        private MaterialSkin.Controls.MaterialTextBox registerTextBoxEmail;
        private MaterialSkin.Controls.MaterialTextBox registerTextboxFirstName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private MaterialSkin.Controls.MaterialButton registerCancelButton;
        private MaterialSkin.Controls.MaterialButton registerConfirmButton;
        private MaterialSkin.Controls.MaterialTextBox registerReenterPassword;
        private MaterialSkin.Controls.MaterialTextBox registerTextboxUsername;
    }
}