using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MakeACatClient.MakeACatServiceRef;

namespace MakeACatClient
{
    public partial class frmMain : Form
    {
        // Keeps track of all your cats created
        public static List<Cat> mycats = new List<Cat>();

        public frmMain()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// method InitializeGUI()
        /// Description: This sets up the GUI for the first time when
        /// the form loads. 
        /// </summary>
        private void InitializeGUI()
        {
            // Clear Input Controls
            txtName.Text = string.Empty;
            numAge.Value = 1;
            cmbBreed.Text = string.Empty;
            cmbGender.Text = string.Empty;

            // Clear Output Controls
            lstCats.Items.Clear();

        } // end of InitializeGUI()

        /// <summary>
        /// Make a Cat!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeACat_Click(object sender, EventArgs e)
        {
            // Validate the Input
            if(!ValidateInput())
            {
                MessageBox.Show("Please Enter Cat Details", "Error");
                return;
            }

            // Assemble the Cat Attributes from the Form
            string name = txtName.Text;
            int age = (int)numAge.Value;
            CatBreed breed = (CatBreed)Enum.Parse(typeof(CatBreed),cmbBreed.Text);
            GenderType gender = (GenderType)Enum.Parse(typeof(GenderType), cmbGender.Text);

            // Make a Proxy to the Service
            MakeACatServiceClient proxy = new MakeACatServiceClient();

            // Call the Service
            Cat cat = proxy.MakeACat(name, breed, gender, age);

            // Add to the Master Cat List
            mycats.Add(cat);

            // Update the GUI
            UpdateGUI();

        } // end of method

        /// <summary>
        /// Validate the User Form Inputs
        /// </summary>
        /// <returns>True if Valid, False Otherwise</returns>
        public bool ValidateInput()
        {
            if(String.IsNullOrEmpty(txtName.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(cmbBreed.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(cmbGender.Text))
            {
                return false;
            }

            return true;

        } // end of method

        /// <summary>
        /// Update the GUI with the List of Cats
        /// </summary>
        private void UpdateGUI()
        {
            lstCats.Items.Clear();
            
            if (mycats.Count != 0)
            {
                foreach (Cat cat in mycats)
                {
                    string str = String.Format("{0}",cat.Name);
                    lstCats.Items.Add(str);
                }
            } 

        } // end of UpdateGUI()

        /// <summary>
        /// Get Five Cats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeCats_Click(object sender, EventArgs e)
        {

            // Make a Proxy to the Service
            MakeACatServiceClient proxy = new MakeACatServiceClient();

            // Call the Service
            CatList cats = proxy.MakeCats();

            // Add to the Master Cat List
            foreach (Cat cat in cats)
            {
                mycats.Add(cat);
            }

            // Update the GUI
            UpdateGUI();

        } // end of method

        /// <summary>
        /// Select List Box Item Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstCats_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstCats.SelectedIndex;

            // Object has not been initialized
            if ((selectedIndex < 0) || (mycats.Count == 0))
                return;

            Cat cat = mycats[selectedIndex];
         
            // if not null
            if (cat != null)
            {
                txtName.Text = cat.Name;
                numAge.Value = cat.Age;
                cmbBreed.Text = cat.Breed.ToString();
                cmbGender.Text = cat.Gender.ToString();
                picCat.Image = cat.Photo;
            }
        } // end of method

    } // end of class
} // end of namespace
