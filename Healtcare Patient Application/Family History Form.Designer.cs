﻿namespace Healtcare_Patient_Application
{
    partial class Family_History_Form
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
            this.PatientName = new System.Windows.Forms.Label();
            this.FamilyIDLB = new System.Windows.Forms.Label();
            this.PatientIDLB = new System.Windows.Forms.Label();
            this.FamilyIDTB = new System.Windows.Forms.TextBox();
            this.PatientIDTB = new System.Windows.Forms.TextBox();
            this.FamilyNameLB = new System.Windows.Forms.Label();
            this.FamilyNameTB = new System.Windows.Forms.TextBox();
            this.RelationLB = new System.Windows.Forms.Label();
            this.FamilyRelationTB = new System.Windows.Forms.TextBox();
            this.AliveLB = new System.Windows.Forms.Label();
            this.AliveTB = new System.Windows.Forms.TextBox();
            this.LiveswithpatientLB = new System.Windows.Forms.Label();
            this.LiveswithPatientTB = new System.Windows.Forms.TextBox();
            this.MajorDisordersLB = new System.Windows.Forms.Label();
            this.MajorDisordersTB = new System.Windows.Forms.TextBox();
            this.SpecificTypeDisorderLB = new System.Windows.Forms.Label();
            this.SpecificDisorderTypeTB = new System.Windows.Forms.TextBox();
            this.RecDeletedLB = new System.Windows.Forms.Label();
            this.RecordDeletedTB = new System.Windows.Forms.TextBox();
            this.FamHisAddBT = new System.Windows.Forms.Button();
            this.FamHisModifyBT = new System.Windows.Forms.Button();
            this.FamHisSaveBT = new System.Windows.Forms.Button();
            this.FamHisUndoBT = new System.Windows.Forms.Button();
            this.FamHisDeleteBT = new System.Windows.Forms.Button();
            this.GoToGenMedicalHistoryBT = new System.Windows.Forms.Button();
            this.PatientAgeLB = new System.Windows.Forms.Label();
            this.GoToLoginPageBT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RecordDeletedTB);
            this.panel1.Controls.Add(this.RecDeletedLB);
            this.panel1.Controls.Add(this.SpecificDisorderTypeTB);
            this.panel1.Controls.Add(this.SpecificTypeDisorderLB);
            this.panel1.Controls.Add(this.MajorDisordersTB);
            this.panel1.Controls.Add(this.MajorDisordersLB);
            this.panel1.Controls.Add(this.LiveswithPatientTB);
            this.panel1.Controls.Add(this.LiveswithpatientLB);
            this.panel1.Controls.Add(this.AliveTB);
            this.panel1.Controls.Add(this.AliveLB);
            this.panel1.Controls.Add(this.FamilyRelationTB);
            this.panel1.Controls.Add(this.RelationLB);
            this.panel1.Controls.Add(this.FamilyNameTB);
            this.panel1.Controls.Add(this.FamilyNameLB);
            this.panel1.Controls.Add(this.PatientIDTB);
            this.panel1.Controls.Add(this.FamilyIDTB);
            this.panel1.Controls.Add(this.PatientIDLB);
            this.panel1.Controls.Add(this.FamilyIDLB);
            this.panel1.Location = new System.Drawing.Point(211, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 369);
            this.panel1.TabIndex = 1;
            // 
            // PatientName
            // 
            this.PatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientName.Location = new System.Drawing.Point(472, 30);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(448, 45);
            this.PatientName.TabIndex = 2;
            this.PatientName.Text = "Patient Name";
            this.PatientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PatientName.Click += new System.EventHandler(this.PatientName_Click);
            // 
            // FamilyIDLB
            // 
            this.FamilyIDLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamilyIDLB.Location = new System.Drawing.Point(3, 9);
            this.FamilyIDLB.Name = "FamilyIDLB";
            this.FamilyIDLB.Size = new System.Drawing.Size(82, 23);
            this.FamilyIDLB.TabIndex = 0;
            this.FamilyIDLB.Text = "FamilyID";
            this.FamilyIDLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientIDLB
            // 
            this.PatientIDLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientIDLB.Location = new System.Drawing.Point(197, 10);
            this.PatientIDLB.Name = "PatientIDLB";
            this.PatientIDLB.Size = new System.Drawing.Size(100, 23);
            this.PatientIDLB.TabIndex = 1;
            this.PatientIDLB.Text = "PatientID";
            this.PatientIDLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FamilyIDTB
            // 
            this.FamilyIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamilyIDTB.Location = new System.Drawing.Point(82, 10);
            this.FamilyIDTB.Name = "FamilyIDTB";
            this.FamilyIDTB.Size = new System.Drawing.Size(100, 22);
            this.FamilyIDTB.TabIndex = 2;
            // 
            // PatientIDTB
            // 
            this.PatientIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientIDTB.Location = new System.Drawing.Point(287, 11);
            this.PatientIDTB.Name = "PatientIDTB";
            this.PatientIDTB.Size = new System.Drawing.Size(100, 22);
            this.PatientIDTB.TabIndex = 3;
            // 
            // FamilyNameLB
            // 
            this.FamilyNameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamilyNameLB.Location = new System.Drawing.Point(398, 9);
            this.FamilyNameLB.Name = "FamilyNameLB";
            this.FamilyNameLB.Size = new System.Drawing.Size(66, 23);
            this.FamilyNameLB.TabIndex = 4;
            this.FamilyNameLB.Text = "Name";
            this.FamilyNameLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FamilyNameTB
            // 
            this.FamilyNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamilyNameTB.Location = new System.Drawing.Point(458, 10);
            this.FamilyNameTB.Name = "FamilyNameTB";
            this.FamilyNameTB.Size = new System.Drawing.Size(215, 22);
            this.FamilyNameTB.TabIndex = 5;
            // 
            // RelationLB
            // 
            this.RelationLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelationLB.Location = new System.Drawing.Point(1, 45);
            this.RelationLB.Name = "RelationLB";
            this.RelationLB.Size = new System.Drawing.Size(84, 23);
            this.RelationLB.TabIndex = 6;
            this.RelationLB.Text = "Relation";
            this.RelationLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FamilyRelationTB
            // 
            this.FamilyRelationTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamilyRelationTB.Location = new System.Drawing.Point(82, 46);
            this.FamilyRelationTB.Name = "FamilyRelationTB";
            this.FamilyRelationTB.Size = new System.Drawing.Size(215, 22);
            this.FamilyRelationTB.TabIndex = 7;
            // 
            // AliveLB
            // 
            this.AliveLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AliveLB.Location = new System.Drawing.Point(306, 45);
            this.AliveLB.Name = "AliveLB";
            this.AliveLB.Size = new System.Drawing.Size(52, 23);
            this.AliveLB.TabIndex = 8;
            this.AliveLB.Text = "Alive";
            this.AliveLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AliveTB
            // 
            this.AliveTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AliveTB.Location = new System.Drawing.Point(364, 46);
            this.AliveTB.Name = "AliveTB";
            this.AliveTB.Size = new System.Drawing.Size(100, 22);
            this.AliveTB.TabIndex = 9;
            // 
            // LiveswithpatientLB
            // 
            this.LiveswithpatientLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiveswithpatientLB.Location = new System.Drawing.Point(3, 71);
            this.LiveswithpatientLB.Name = "LiveswithpatientLB";
            this.LiveswithpatientLB.Size = new System.Drawing.Size(130, 23);
            this.LiveswithpatientLB.TabIndex = 10;
            this.LiveswithpatientLB.Text = "Lives with Patient";
            this.LiveswithpatientLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LiveswithPatientTB
            // 
            this.LiveswithPatientTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiveswithPatientTB.Location = new System.Drawing.Point(139, 72);
            this.LiveswithPatientTB.Name = "LiveswithPatientTB";
            this.LiveswithPatientTB.Size = new System.Drawing.Size(100, 22);
            this.LiveswithPatientTB.TabIndex = 11;
            // 
            // MajorDisordersLB
            // 
            this.MajorDisordersLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MajorDisordersLB.Location = new System.Drawing.Point(3, 94);
            this.MajorDisordersLB.Name = "MajorDisordersLB";
            this.MajorDisordersLB.Size = new System.Drawing.Size(130, 23);
            this.MajorDisordersLB.TabIndex = 12;
            this.MajorDisordersLB.Text = "Major Disorders";
            this.MajorDisordersLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MajorDisordersTB
            // 
            this.MajorDisordersTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MajorDisordersTB.Location = new System.Drawing.Point(6, 120);
            this.MajorDisordersTB.Multiline = true;
            this.MajorDisordersTB.Name = "MajorDisordersTB";
            this.MajorDisordersTB.Size = new System.Drawing.Size(528, 54);
            this.MajorDisordersTB.TabIndex = 13;
            // 
            // SpecificTypeDisorderLB
            // 
            this.SpecificTypeDisorderLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecificTypeDisorderLB.Location = new System.Drawing.Point(3, 177);
            this.SpecificTypeDisorderLB.Name = "SpecificTypeDisorderLB";
            this.SpecificTypeDisorderLB.Size = new System.Drawing.Size(181, 23);
            this.SpecificTypeDisorderLB.TabIndex = 14;
            this.SpecificTypeDisorderLB.Text = "Specific Disorder Types";
            this.SpecificTypeDisorderLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpecificDisorderTypeTB
            // 
            this.SpecificDisorderTypeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecificDisorderTypeTB.Location = new System.Drawing.Point(6, 203);
            this.SpecificDisorderTypeTB.Multiline = true;
            this.SpecificDisorderTypeTB.Name = "SpecificDisorderTypeTB";
            this.SpecificDisorderTypeTB.Size = new System.Drawing.Size(528, 54);
            this.SpecificDisorderTypeTB.TabIndex = 15;
            // 
            // RecDeletedLB
            // 
            this.RecDeletedLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecDeletedLB.Location = new System.Drawing.Point(3, 263);
            this.RecDeletedLB.Name = "RecDeletedLB";
            this.RecDeletedLB.Size = new System.Drawing.Size(130, 23);
            this.RecDeletedLB.TabIndex = 16;
            this.RecDeletedLB.Text = "Record Deleted";
            this.RecDeletedLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecordDeletedTB
            // 
            this.RecordDeletedTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordDeletedTB.Location = new System.Drawing.Point(139, 263);
            this.RecordDeletedTB.Name = "RecordDeletedTB";
            this.RecordDeletedTB.Size = new System.Drawing.Size(100, 22);
            this.RecordDeletedTB.TabIndex = 17;
            // 
            // FamHisAddBT
            // 
            this.FamHisAddBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamHisAddBT.Location = new System.Drawing.Point(211, 482);
            this.FamHisAddBT.Name = "FamHisAddBT";
            this.FamHisAddBT.Size = new System.Drawing.Size(131, 51);
            this.FamHisAddBT.TabIndex = 3;
            this.FamHisAddBT.Text = "Add Family History Record";
            this.FamHisAddBT.UseVisualStyleBackColor = true;
            this.FamHisAddBT.Click += new System.EventHandler(this.FamHisAddBT_Click);
            // 
            // FamHisModifyBT
            // 
            this.FamHisModifyBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamHisModifyBT.Location = new System.Drawing.Point(372, 482);
            this.FamHisModifyBT.Name = "FamHisModifyBT";
            this.FamHisModifyBT.Size = new System.Drawing.Size(136, 51);
            this.FamHisModifyBT.TabIndex = 4;
            this.FamHisModifyBT.Text = "Modify Family History Record";
            this.FamHisModifyBT.UseVisualStyleBackColor = true;
            this.FamHisModifyBT.Click += new System.EventHandler(this.FamHisModifyBT_Click);
            // 
            // FamHisSaveBT
            // 
            this.FamHisSaveBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamHisSaveBT.Location = new System.Drawing.Point(533, 482);
            this.FamHisSaveBT.Name = "FamHisSaveBT";
            this.FamHisSaveBT.Size = new System.Drawing.Size(142, 51);
            this.FamHisSaveBT.TabIndex = 5;
            this.FamHisSaveBT.Text = "Save Family History Record";
            this.FamHisSaveBT.UseVisualStyleBackColor = true;
            this.FamHisSaveBT.Click += new System.EventHandler(this.FamHisSaveBT_Click);
            // 
            // FamHisUndoBT
            // 
            this.FamHisUndoBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamHisUndoBT.Location = new System.Drawing.Point(706, 482);
            this.FamHisUndoBT.Name = "FamHisUndoBT";
            this.FamHisUndoBT.Size = new System.Drawing.Size(112, 51);
            this.FamHisUndoBT.TabIndex = 6;
            this.FamHisUndoBT.Text = "Undo Family Changes";
            this.FamHisUndoBT.UseVisualStyleBackColor = true;
            // 
            // FamHisDeleteBT
            // 
            this.FamHisDeleteBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamHisDeleteBT.Location = new System.Drawing.Point(834, 482);
            this.FamHisDeleteBT.Name = "FamHisDeleteBT";
            this.FamHisDeleteBT.Size = new System.Drawing.Size(143, 51);
            this.FamHisDeleteBT.TabIndex = 7;
            this.FamHisDeleteBT.Text = "Delete Family History Record";
            this.FamHisDeleteBT.UseVisualStyleBackColor = true;
            // 
            // GoToGenMedicalHistoryBT
            // 
            this.GoToGenMedicalHistoryBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToGenMedicalHistoryBT.Location = new System.Drawing.Point(24, 87);
            this.GoToGenMedicalHistoryBT.Name = "GoToGenMedicalHistoryBT";
            this.GoToGenMedicalHistoryBT.Size = new System.Drawing.Size(126, 44);
            this.GoToGenMedicalHistoryBT.TabIndex = 9;
            this.GoToGenMedicalHistoryBT.Text = "Go To General Medical History";
            this.GoToGenMedicalHistoryBT.UseVisualStyleBackColor = true;
            this.GoToGenMedicalHistoryBT.Click += new System.EventHandler(this.GoToGenMedicalHistoryBT_Click);
            // 
            // PatientAgeLB
            // 
            this.PatientAgeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientAgeLB.Location = new System.Drawing.Point(926, 26);
            this.PatientAgeLB.Name = "PatientAgeLB";
            this.PatientAgeLB.Size = new System.Drawing.Size(169, 49);
            this.PatientAgeLB.TabIndex = 10;
            this.PatientAgeLB.Text = "Patient\'s Age";
            this.PatientAgeLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GoToLoginPageBT
            // 
            this.GoToLoginPageBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToLoginPageBT.Location = new System.Drawing.Point(24, 150);
            this.GoToLoginPageBT.Name = "GoToLoginPageBT";
            this.GoToLoginPageBT.Size = new System.Drawing.Size(126, 44);
            this.GoToLoginPageBT.TabIndex = 13;
            this.GoToLoginPageBT.Text = "Go To Login Page";
            this.GoToLoginPageBT.UseVisualStyleBackColor = true;
            this.GoToLoginPageBT.Click += new System.EventHandler(this.GoToLoginPageBT_Click);
            // 
            // Family_History_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1452, 597);
            this.Controls.Add(this.GoToLoginPageBT);
            this.Controls.Add(this.PatientAgeLB);
            this.Controls.Add(this.GoToGenMedicalHistoryBT);
            this.Controls.Add(this.FamHisDeleteBT);
            this.Controls.Add(this.FamHisUndoBT);
            this.Controls.Add(this.FamHisSaveBT);
            this.Controls.Add(this.FamHisModifyBT);
            this.Controls.Add(this.FamHisAddBT);
            this.Controls.Add(this.PatientName);
            this.Controls.Add(this.panel1);
            this.Name = "Family_History_Form";
            this.Text = "Family History Form";
            this.Load += new System.EventHandler(this.Family_History_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PatientName;
        private System.Windows.Forms.Label FamilyIDLB;
        private System.Windows.Forms.Label PatientIDLB;
        private System.Windows.Forms.TextBox PatientIDTB;
        private System.Windows.Forms.TextBox FamilyIDTB;
        private System.Windows.Forms.TextBox FamilyNameTB;
        private System.Windows.Forms.Label FamilyNameLB;
        private System.Windows.Forms.Label RelationLB;
        private System.Windows.Forms.Label LiveswithpatientLB;
        private System.Windows.Forms.TextBox AliveTB;
        private System.Windows.Forms.Label AliveLB;
        private System.Windows.Forms.TextBox FamilyRelationTB;
        private System.Windows.Forms.TextBox LiveswithPatientTB;
        private System.Windows.Forms.TextBox MajorDisordersTB;
        private System.Windows.Forms.Label MajorDisordersLB;
        private System.Windows.Forms.TextBox RecordDeletedTB;
        private System.Windows.Forms.Label RecDeletedLB;
        private System.Windows.Forms.TextBox SpecificDisorderTypeTB;
        private System.Windows.Forms.Label SpecificTypeDisorderLB;
        private System.Windows.Forms.Button FamHisAddBT;
        private System.Windows.Forms.Button FamHisModifyBT;
        private System.Windows.Forms.Button FamHisSaveBT;
        private System.Windows.Forms.Button FamHisUndoBT;
        private System.Windows.Forms.Button FamHisDeleteBT;
        private System.Windows.Forms.Button GoToGenMedicalHistoryBT;
        private System.Windows.Forms.Label PatientAgeLB;
        private System.Windows.Forms.Button GoToLoginPageBT;
    }
}