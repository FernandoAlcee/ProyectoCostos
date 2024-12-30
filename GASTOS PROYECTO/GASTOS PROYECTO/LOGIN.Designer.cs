namespace GASTOS_PROYECTO
{
    partial class LOGIN
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            Username_1 = new Label();
            Password_2 = new Label();
            txt_Username = new TextBox();
            txt_password = new TextBox();
            Button_Join = new Button();
            SuspendLayout();
            // 
            // Username_1
            // 
            Username_1.BackColor = Color.White;
            Username_1.FlatStyle = FlatStyle.Flat;
            Username_1.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username_1.Location = new Point(31, 47);
            Username_1.Name = "Username_1";
            Username_1.Size = new Size(183, 41);
            Username_1.TabIndex = 0;
            Username_1.Text = "Username";
            Username_1.Click += label1_Click;
            // 
            // Password_2
            // 
            Password_2.BackColor = Color.White;
            Password_2.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password_2.Location = new Point(31, 105);
            Password_2.Name = "Password_2";
            Password_2.Size = new Size(183, 41);
            Password_2.TabIndex = 1;
            Password_2.Text = "Password";
            // 
            // txt_Username
            // 
            txt_Username.Font = new Font("Segoe UI", 15F);
            txt_Username.Location = new Point(220, 47);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(352, 41);
            txt_Username.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 15F);
            txt_password.Location = new Point(220, 105);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(352, 41);
            txt_password.TabIndex = 3;
            // 
            // Button_Join
            // 
            Button_Join.BackColor = Color.FromArgb(192, 0, 0);
            Button_Join.BackgroundImageLayout = ImageLayout.Zoom;
            Button_Join.FlatAppearance.BorderSize = 0;
            Button_Join.FlatStyle = FlatStyle.Popup;
            Button_Join.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_Join.ForeColor = SystemColors.ActiveCaptionText;
            Button_Join.Location = new Point(94, 174);
            Button_Join.Name = "Button_Join";
            Button_Join.Size = new Size(446, 41);
            Button_Join.TabIndex = 4;
            Button_Join.Text = "Login";
            Button_Join.UseVisualStyleBackColor = false;
            // 
            // LOGIN
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Moccasin;
            ClientSize = new Size(646, 303);
            Controls.Add(Button_Join);
            Controls.Add(txt_password);
            Controls.Add(txt_Username);
            Controls.Add(Password_2);
            Controls.Add(Username_1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LOGIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username_1;
        private Label Password_2;
        private TextBox txt_Username;
        private TextBox txt_password;
        private Button Button_Join;
    }
}
