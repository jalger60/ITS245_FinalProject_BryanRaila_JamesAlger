﻿namespace Healtcare_Patient_Application
{
    partial class Login_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainLoginLB = new System.Windows.Forms.Label();
            this.UsernameLB = new System.Windows.Forms.Label();
            this.PasswordLB = new System.Windows.Forms.Label();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.PatientName = new System.Windows.Forms.Label();
            this.PatientAgeLB = new System.Windows.Forms.Label();
            this.GoToFamilyHistory = new System.Windows.Forms.Button();
            this.GoToGenMedicalHistoryBT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PasswordTB);
            this.panel1.Controls.Add(this.UserNameTB);
            this.panel1.Controls.Add(this.PasswordLB);
            this.panel1.Controls.Add(this.UsernameLB);
            this.panel1.Controls.Add(this.MainLoginLB);
            this.panel1.Location = new System.Drawing.Point(435, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 321);
            this.panel1.TabIndex = 0;
            // 
            // MainLoginLB
            // 
            this.MainLoginLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLoginLB.Location = new System.Drawing.Point(134, 9);
            this.MainLoginLB.Name = "MainLoginLB";
            this.MainLoginLB.Size = new System.Drawing.Size(158, 45);
            this.MainLoginLB.TabIndex = 3;
            this.MainLoginLB.Text = "User Login";
            this.MainLoginLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsernameLB
            // 
            this.UsernameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLB.Location = new System.Drawing.Point(3, 66);
            this.UsernameLB.Name = "UsernameLB";
            this.UsernameLB.Size = new System.Drawing.Size(152, 23);
            this.UsernameLB.TabIndex = 11;
            this.UsernameLB.Text = "Username: ";
            this.UsernameLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLB
            // 
            this.PasswordLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLB.Location = new System.Drawing.Point(3, 108);
            this.PasswordLB.Name = "PasswordLB";
            this.PasswordLB.Size = new System.Drawing.Size(152, 23);
            this.PasswordLB.TabIndex = 12;
            this.PasswordLB.Text = "Password:";
            this.PasswordLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserNameTB
            // 
            this.UserNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTB.Location = new System.Drawing.Point(139, 66);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(296, 31);
            this.UserNameTB.TabIndex = 13;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.Location = new System.Drawing.Point(139, 108);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(296, 31);
            this.PasswordTB.TabIndex = 14;
            // 
            // PatientName
            // 
            this.PatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientName.Location = new System.Drawing.Point(344, 29);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(448, 45);
            this.PatientName.TabIndex = 3;
            this.PatientName.Text = "Patient Name";
            this.PatientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientAgeLB
            // 
            this.PatientAgeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientAgeLB.Location = new System.Drawing.Point(798, 25);
            this.PatientAgeLB.Name = "PatientAgeLB";
            this.PatientAgeLB.Size = new System.Drawing.Size(169, 49);
            this.PatientAgeLB.TabIndex = 12;
            this.PatientAgeLB.Text = "Patient\'s Age";
            this.PatientAgeLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GoToFamilyHistory
            // 
            this.GoToFamilyHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToFamilyHistory.Location = new System.Drawing.Point(91, 111);
            this.GoToFamilyHistory.Name = "GoToFamilyHistory";
            this.GoToFamilyHistory.Size = new System.Drawing.Size(119, 43);
            this.GoToFamilyHistory.TabIndex = 13;
            this.GoToFamilyHistory.Text = "Go To Family History";
            this.GoToFamilyHistory.UseVisualStyleBackColor = true;
            this.GoToFamilyHistory.Click += new System.EventHandler(this.GoToFamilyHistory_Click);
            // 
            // GoToGenMedicalHistoryBT
            // 
            this.GoToGenMedicalHistoryBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToGenMedicalHistoryBT.Location = new System.Drawing.Point(91, 190);
            this.GoToGenMedicalHistoryBT.Name = "GoToGenMedicalHistoryBT";
            this.GoToGenMedicalHistoryBT.Size = new System.Drawing.Size(119, 62);
            this.GoToGenMedicalHistoryBT.TabIndex = 14;
            this.GoToGenMedicalHistoryBT.Text = "Go To General Medical History";
            this.GoToGenMedicalHistoryBT.UseVisualStyleBackColor = true;
            this.GoToGenMedicalHistoryBT.Click += new System.EventHandler(this.GoToGenMedicalHistoryBT_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1400, 583);
            this.Controls.Add(this.GoToGenMedicalHistoryBT);
            this.Controls.Add(this.GoToFamilyHistory);
            this.Controls.Add(this.PatientAgeLB);
            this.Controls.Add(this.PatientName);
            this.Controls.Add(this.panel1);
            this.Name = "Login_Form";
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MainLoginLB;
        private System.Windows.Forms.Label PasswordLB;
        private System.Windows.Forms.Label UsernameLB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.Label PatientName;
        private System.Windows.Forms.Label PatientAgeLB;
        private System.Windows.Forms.Button GoToFamilyHistory;
        private System.Windows.Forms.Button GoToGenMedicalHistoryBT;
    }
}