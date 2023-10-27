namespace MyFirstWindow
{
    partial class MainForm
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
            labelMainWelcome = new Label();
            mainContent = new Label();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // labelMainWelcome
            // 
            labelMainWelcome.AutoSize = true;
            labelMainWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelMainWelcome.Location = new Point(51, 63);
            labelMainWelcome.Name = "labelMainWelcome";
            labelMainWelcome.Size = new Size(640, 48);
            labelMainWelcome.TabIndex = 0;
            labelMainWelcome.Text = "Welcome to Aincrad, Marc Velasquez";
            // 
            // mainContent
            // 
            mainContent.AutoSize = true;
            mainContent.Location = new Point(61, 136);
            mainContent.Name = "mainContent";
            mainContent.Size = new Size(59, 25);
            mainContent.TabIndex = 1;
            mainContent.Text = "label1";
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(332, 430);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(158, 36);
            materialButton1.TabIndex = 2;
            materialButton1.Text = "Log Out";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(materialButton1);
            Controls.Add(mainContent);
            Controls.Add(labelMainWelcome);
            FormStyle = FormStyles.ActionBar_None;
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "MainForm";
            Padding = new Padding(3, 24, 3, 3);
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMainWelcome;
        private Label mainContent;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}