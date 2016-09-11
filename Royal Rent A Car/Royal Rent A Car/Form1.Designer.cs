namespace Royal_Rent_A_Car
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
            this.Lbl_Username = new MetroFramework.Controls.MetroLabel();
            this.Lbl_Password = new MetroFramework.Controls.MetroLabel();
            this.Txt_Username = new MetroFramework.Controls.MetroTextBox();
            this.Txt_Password = new MetroFramework.Controls.MetroTextBox();
            this.Btn_Login = new MetroFramework.Controls.MetroButton();
            this.Btn_Cancel = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Username
            // 
            this.Lbl_Username.AutoSize = true;
            this.Lbl_Username.Location = new System.Drawing.Point(74, 116);
            this.Lbl_Username.Name = "Lbl_Username";
            this.Lbl_Username.Size = new System.Drawing.Size(68, 19);
            this.Lbl_Username.TabIndex = 0;
            this.Lbl_Username.Text = "Username";
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(74, 164);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(63, 19);
            this.Lbl_Password.TabIndex = 1;
            this.Lbl_Password.Text = "Password";
            // 
            // Txt_Username
            // 
            // 
            // 
            // 
            this.Txt_Username.CustomButton.Image = null;
            this.Txt_Username.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.Txt_Username.CustomButton.Name = "";
            this.Txt_Username.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Username.CustomButton.TabIndex = 1;
            this.Txt_Username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Username.CustomButton.UseSelectable = true;
            this.Txt_Username.CustomButton.Visible = false;
            this.Txt_Username.Lines = new string[0];
            this.Txt_Username.Location = new System.Drawing.Point(193, 112);
            this.Txt_Username.MaxLength = 32767;
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.PasswordChar = '\0';
            this.Txt_Username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Username.SelectedText = "";
            this.Txt_Username.SelectionLength = 0;
            this.Txt_Username.SelectionStart = 0;
            this.Txt_Username.ShortcutsEnabled = true;
            this.Txt_Username.Size = new System.Drawing.Size(163, 23);
            this.Txt_Username.TabIndex = 2;
            this.Txt_Username.UseSelectable = true;
            this.Txt_Username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Txt_Password
            // 
            // 
            // 
            // 
            this.Txt_Password.CustomButton.Image = null;
            this.Txt_Password.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.Txt_Password.CustomButton.Name = "";
            this.Txt_Password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Password.CustomButton.TabIndex = 1;
            this.Txt_Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Password.CustomButton.UseSelectable = true;
            this.Txt_Password.CustomButton.Visible = false;
            this.Txt_Password.Lines = new string[0];
            this.Txt_Password.Location = new System.Drawing.Point(193, 160);
            this.Txt_Password.MaxLength = 32767;
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '\0';
            this.Txt_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Password.SelectedText = "";
            this.Txt_Password.SelectionLength = 0;
            this.Txt_Password.SelectionStart = 0;
            this.Txt_Password.ShortcutsEnabled = true;
            this.Txt_Password.Size = new System.Drawing.Size(163, 23);
            this.Txt_Password.TabIndex = 3;
            this.Txt_Password.UseSelectable = true;
            this.Txt_Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(149, 271);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(75, 23);
            this.Btn_Login.TabIndex = 4;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseSelectable = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(257, 271);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 5;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseSelectable = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 372);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_Username);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.Lbl_Username);
            this.Name = "Form1";
            this.Text = "User Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Lbl_Username;
        private MetroFramework.Controls.MetroLabel Lbl_Password;
        private MetroFramework.Controls.MetroTextBox Txt_Username;
        private MetroFramework.Controls.MetroTextBox Txt_Password;
        private MetroFramework.Controls.MetroButton Btn_Login;
        private MetroFramework.Controls.MetroButton Btn_Cancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

