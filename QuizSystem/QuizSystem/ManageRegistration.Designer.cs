namespace QuizSystem
{
    partial class ManageRegistration
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(222, 194);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(164, 20);
            this.txtPassword.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(222, 145);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 20);
            this.txtName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Silver;
            this.Login.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(315, 275);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(71, 44);
            this.Login.TabIndex = 16;
            this.Login.Text = "Register";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.cmdRegister);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 58);
            this.label3.TabIndex = 14;
            this.label3.Text = "Quiz System";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(222, 220);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(164, 20);
            this.txtContactNo.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Contact No";
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(222, 168);
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(164, 20);
            this.txtCNIC.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "CNIC No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(137, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Role";
            // 
            // txtRole
            // 
            this.txtRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtRole.FormattingEnabled = true;
            this.txtRole.Items.AddRange(new object[] {
            "Teacher",
            "Student"});
            this.txtRole.Location = new System.Drawing.Point(222, 246);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(164, 21);
            this.txtRole.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(222, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 44);
            this.button1.TabIndex = 25;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.cmdLogin);
            // 
            // ManageRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(502, 331);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCNIC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "ManageRegistration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtRole;
        private System.Windows.Forms.Button button1;
    }
}