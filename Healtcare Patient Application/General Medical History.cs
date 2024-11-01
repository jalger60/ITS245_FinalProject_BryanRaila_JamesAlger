using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healtcare_Patient_Application
{
    public partial class GMH : Form
    {
        public GMH()
        {
            InitializeComponent();
        }

        private void GMH_Load(object sender, EventArgs e)
        {
            SetViewMode();


        }

        private void SetViewMode()
        {
            TobaccoTB.Enabled = false;
            TobaccoTB.BackColor = Color.LightGray;
            
            TobaccoDurationTB.Enabled = false;
            TobaccoDurationTB.BackColor = Color.LightGray;

            TobaccoQuanTB.Enabled = false;
            TobaccoQuanTB.BackColor = Color.LightGray;

            DrinkAlcoholTB.Enabled = false;
            DrinkAlcoholTB.BackColor = Color.LightGray;

            AlcoholQuanTB.Enabled = false;
            AlcoholQuanTB.BackColor = Color.LightGray;

            AlcoholDurTB.Enabled = false;
            AlcoholDurTB.BackColor = Color.LightGray;

            DrugTB.Enabled = false;
            DrugTB.BackColor = Color.LightGray;

            DrugTypeTB.Enabled = false;
            DrugTypeTB.BackColor = Color.LightGray;

            BloodTypeTB.Enabled = false;
            BloodTypeTB.BackColor = Color.LightGray;

            RHTB.Enabled = false;
            RHTB.BackColor = Color.LightGray;

            LMPTB.Enabled = false;
            LMPTB.BackColor = Color.LightGray;

            MaritalStatusTB.Enabled = false;
            MaritalStatusTB.BackColor = Color.LightGray;

            NumChildrenTB.Enabled = false;
            NumChildrenTB.BackColor = Color.LightGray;

            EducationLevelTB.Enabled = false;
            EducationLevelTB.BackColor = Color.LightGray;
            
            DietaryTB.Enabled = false;
            DietaryTB.BackColor = Color.LightGray;

            BehavioralHistoryTB.Enabled = false;
            BehavioralHistoryTB.BackColor = Color.LightGray;

            MMNTB.Enabled = false;
            MMNTB.BackColor = Color.LightGray;

            MMYTB.Enabled = false;
            MMYTB.BackColor = Color.LightGray;

            HXTB.Enabled = false;
            HXTB.BackColor = Color.LightGray;

            MedHistoryTB.Enabled = false;
            MedHistoryTB.BackColor = Color.LightGray;


        }

        private void SetEditMode()
        {
            TobaccoTB.Enabled = true;
            TobaccoTB.BackColor = Color.White;

            TobaccoDurationTB.Enabled = true;
            TobaccoDurationTB.BackColor = Color.White;

            TobaccoQuanTB.ReadOnly = true;
            TobaccoQuanTB.BackColor = Color.White;

            DrinkAlcoholTB.Enabled = true;
            DrinkAlcoholTB.BackColor = Color.White;

            AlcoholQuanTB.Enabled = true;
            AlcoholQuanTB.BackColor = Color.White;

            AlcoholDurTB.Enabled = true;
            AlcoholDurTB.BackColor = Color.White;

            DrugTB.Enabled = true;
            DrugTB.BackColor = Color.White;

            DrugTypeTB.Enabled = true;
            DrugTypeTB.BackColor = Color.White;

            BloodTypeTB.Enabled = true;
            BloodTypeTB.BackColor = Color.White;

            RHTB.Enabled = true;
            RHTB.BackColor = Color.White;

            LMPTB.Enabled = true;
            LMPTB.BackColor = Color.White;

            MaritalStatusTB.Enabled = true;
            MaritalStatusTB.BackColor = Color.White;

            NumChildrenTB.Enabled = true;
            NumChildrenTB.BackColor = Color.White;

            EducationLevelTB.Enabled = true;
            EducationLevelTB.BackColor = Color.White;

            DietaryTB.Enabled = true;
            DietaryTB.BackColor = Color.White;

            BehavioralHistoryTB.Enabled = true;
            BehavioralHistoryTB.BackColor = Color.White;

            MMNTB.Enabled = true;
            MMNTB.BackColor = Color.White;

            MMYTB.Enabled = true;
            MMYTB.BackColor = Color.White;

            HXTB.Enabled = true;
            HXTB.BackColor = Color.White;

            MedHistoryTB.Enabled = true;
            MedHistoryTB.BackColor = Color.White;

        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            SetEditMode();
        }

        private void ModifyBT_Click(object sender, EventArgs e)
        {
            SetEditMode();

        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            SetViewMode();
        }

        private void GoToFamilyHistoryBT_Click(object sender, EventArgs e)
        {
            Form Family_History = new Family_History_Form();
            Family_History.Show();
            this.Hide();

        }

        private void GoToLoginPageBT_Click(object sender, EventArgs e)
        {
            Form Login = new Login_Form();
            Login.Show();
            this.Hide();
        }
    }
}

