namespace TestUserGallerU
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
            this.UserNotExists = new System.Windows.Forms.Button();
            this.UserExists = new System.Windows.Forms.Button();
            this.WorngEmail = new System.Windows.Forms.Button();
            this.WorngPass = new System.Windows.Forms.Button();
            this.EmailNotExists = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNotExists
            // 
            this.UserNotExists.Location = new System.Drawing.Point(12, 12);
            this.UserNotExists.Name = "UserNotExists";
            this.UserNotExists.Size = new System.Drawing.Size(159, 33);
            this.UserNotExists.TabIndex = 0;
            this.UserNotExists.Text = "Login  not Exists";
            this.UserNotExists.UseVisualStyleBackColor = true;
            this.UserNotExists.Click += new System.EventHandler(this.NewUser);
            // 
            // UserExists
            // 
            this.UserExists.Location = new System.Drawing.Point(390, 12);
            this.UserExists.Name = "UserExists";
            this.UserExists.Size = new System.Drawing.Size(95, 33);
            this.UserExists.TabIndex = 1;
            this.UserExists.Text = "Login Exists";
            this.UserExists.UseVisualStyleBackColor = true;
            this.UserExists.Click += new System.EventHandler(this.ExistsUser);
            // 
            // WorngEmail
            // 
            this.WorngEmail.Location = new System.Drawing.Point(64, 161);
            this.WorngEmail.Name = "WorngEmail";
            this.WorngEmail.Size = new System.Drawing.Size(107, 30);
            this.WorngEmail.TabIndex = 2;
            this.WorngEmail.Text = "Worng Email";
            this.WorngEmail.UseVisualStyleBackColor = true;
            this.WorngEmail.Click += new System.EventHandler(this.WorngEmail_Click);
            // 
            // WorngPass
            // 
            this.WorngPass.Location = new System.Drawing.Point(390, 157);
            this.WorngPass.Name = "WorngPass";
            this.WorngPass.Size = new System.Drawing.Size(93, 39);
            this.WorngPass.TabIndex = 3;
            this.WorngPass.Text = "Worng Pass";
            this.WorngPass.UseVisualStyleBackColor = true;
            this.WorngPass.Click += new System.EventHandler(this.WorngPass_Click);
            // 
            // EmailNotExists
            // 
            this.EmailNotExists.Location = new System.Drawing.Point(145, 264);
            this.EmailNotExists.Name = "EmailNotExists";
            this.EmailNotExists.Size = new System.Drawing.Size(155, 30);
            this.EmailNotExists.TabIndex = 4;
            this.EmailNotExists.Text = "Email Not Exists";
            this.EmailNotExists.UseVisualStyleBackColor = true;
            this.EmailNotExists.Click += new System.EventHandler(this.EmailNotExists_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmailNotExists);
            this.Controls.Add(this.WorngPass);
            this.Controls.Add(this.WorngEmail);
            this.Controls.Add(this.UserExists);
            this.Controls.Add(this.UserNotExists);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UserNotExists;
        private System.Windows.Forms.Button UserExists;
        private System.Windows.Forms.Button WorngEmail;
        private System.Windows.Forms.Button WorngPass;
        private System.Windows.Forms.Button EmailNotExists;
    }
}

