using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectiveChoiceApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Cryptography");
            comboBox1.Items.Add("Data Science");
            comboBox1.Items.Add("Functional Programming");
            comboBox1.Items.Add("Game Design");
            comboBox1.Items.Add("Parallel Programming");
            comboBox1.Items.Add("Web Development");

            //string[] letters = { "a", "b", "c" };
            //comboBox3.Items.Add(letters);

           /* ArrayList arr = new ArrayList();
            arr.Add("Select");
            arr.Add("Cryptography");
            arr.Add("Data Science");
            arr.Add("Functional Programming");
            arr.Add("Game Design");
            arr.Add("Parallel Programming");
            arr.Add("Web Development");
            comboBox1.DataSource = arr;*/
        }

        /*private String Choice1(String ch1)
        {
            if (comboBox1.SelectedItem == "Cryptography")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Data Science");
                comboBox2.Items.Add("Functional Programming");
                comboBox2.Items.Add("Game Design");
                comboBox2.Items.Add("Parallel Programming");
                comboBox2.Items.Add("Software Architecture");
                comboBox2.Items.Add("Web Development");
            }
            return "ss";
        }*/


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == "Cryptography")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Data Science");
                comboBox2.Items.Add("Functional Programming");
                comboBox2.Items.Add("Game Design");
                comboBox2.Items.Add("Parallel Programming");
                comboBox2.Items.Add("Web Development");
            }

            if (comboBox1.SelectedItem == "Data Science")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Cryptography");
                comboBox2.Items.Add("Functional Programming");
                comboBox2.Items.Add("Game Design");
                comboBox2.Items.Add("Parallel Programming");
                comboBox2.Items.Add("Web Development");
            }

            if (comboBox1.SelectedItem == "Functional Programming")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Cryptography");
                comboBox2.Items.Add("Data Science");
                comboBox2.Items.Add("Game Design");
                comboBox2.Items.Add("Parallel Programming");
                comboBox2.Items.Add("Web Development");
            }

            if (comboBox1.SelectedItem == "Game Design")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Cryptography");
                comboBox2.Items.Add("Data Science");
                comboBox2.Items.Add("Functional Programming");
                comboBox2.Items.Add("Parallel Programming");
                comboBox2.Items.Add("Web Development");
            }

            if (comboBox1.SelectedItem == "Parallel Programming")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Cryptography");
                comboBox2.Items.Add("Data Science");
                comboBox2.Items.Add("Functional Programming");
                comboBox2.Items.Add("Game Design");
                comboBox2.Items.Add("Web Development");
            }

            if (comboBox1.SelectedItem == "Web Development")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Cryptography");
                comboBox2.Items.Add("Data Science");
                comboBox2.Items.Add("Functional Programming");
                comboBox2.Items.Add("Game Design");
                comboBox2.Items.Add("Parallel Programming"); 
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Cryptography"&& comboBox2.SelectedItem == "Data Science")
            {
                comboBox3.Items.Clear();
               // comboBox3.Items.Add("Data Science");
                comboBox3.Items.Add("Functional Programming");
                comboBox3.Items.Add("Game Design");
                comboBox3.Items.Add("Parallel Programming");
                comboBox3.Items.Add("Web Development");
            }

            if (comboBox1.SelectedItem == "Cryptography" && comboBox2.SelectedItem == "Functional Programming")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Data Science");
                //comboBox3.Items.Add("Functional Programming");
                comboBox3.Items.Add("Game Design");
                comboBox3.Items.Add("Parallel Programming");
                comboBox3.Items.Add("Web Development");
            }

            if (comboBox1.SelectedItem == "Cryptography" && comboBox2.SelectedItem == "Game Design")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Data Science");
                comboBox3.Items.Add("Functional Programming");
                //comboBox3.Items.Add("Game Design");
                comboBox3.Items.Add("Parallel Programming");
                comboBox3.Items.Add("Web Development");
            }
            if (comboBox1.SelectedItem == "Cryptography" && comboBox2.SelectedItem == "Parallel Programming")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Data Science");
                comboBox3.Items.Add("Functional Programming");
                comboBox3.Items.Add("Game Design");
                //comboBox3.Items.Add("Parallel Programming");
                comboBox3.Items.Add("Web Development");
            }
            if (comboBox1.SelectedItem == "Cryptography" && comboBox2.SelectedItem == "Web Development")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Data Science");
                comboBox3.Items.Add("Functional Programming");
                comboBox3.Items.Add("Game Design");
                comboBox3.Items.Add("Parallel Programming");
                //comboBox3.Items.Add("Web Development");
            }
            
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            if (comboBox1.SelectedItem == "Data Science" && comboBox2.SelectedItem == "Cryptography")
            {
                comboBox3.Items.Clear();
                //comboBox3.Items.Add("Cryptography");
                comboBox3.Items.Add("Functional Programming");
                comboBox3.Items.Add("Game Design");
                comboBox3.Items.Add("Parallel Programming");
                comboBox3.Items.Add("Web Development");
            }

            if (comboBox1.SelectedItem == "Data Science" && comboBox2.SelectedItem == "Functional Programming")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Cryptography");
                //comboBox3.Items.Add("Functional Programming");
                comboBox3.Items.Add("Game Design");
                comboBox3.Items.Add("Parallel Programming");
                comboBox3.Items.Add("Web Development");
            }

            if (comboBox1.SelectedItem == "Data Science" && comboBox2.SelectedItem == "Game Design")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Cryptography");
                comboBox3.Items.Add("Functional Programming");
                //comboBox3.Items.Add("Game Design");
                comboBox3.Items.Add("Parallel Programming");
                comboBox3.Items.Add("Web Development");
            }

            if (comboBox1.SelectedItem == "Data Science" && comboBox2.SelectedItem == "Parallel Programming")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Cryptography");
                comboBox3.Items.Add("Functional Programming");
                comboBox3.Items.Add("Game Design");
                //comboBox3.Items.Add("Parallel Programming");
                comboBox3.Items.Add("Web Development");
            }

            if (comboBox1.SelectedItem == "Data Science" && comboBox2.SelectedItem == "Web Development")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Cryptography");
                comboBox3.Items.Add("Functional Programming");
                comboBox3.Items.Add("Game Design");
                comboBox3.Items.Add("Parallel Programming");
                //omboBox3.Items.Add("Web Development");
            }


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            if (comboBox1.SelectedItem == "Functional Programming" && comboBox2.SelectedItem == "Cryptography")
            {
                comboBox3.Items.Clear();
                //comboBox3.Items.Add("Cryptography");
                comboBox3.Items.Add("Data Science");
                comboBox3.Items.Add("Game Design");
                comboBox3.Items.Add("Parallel Programming");
                comboBox3.Items.Add("Web Development");
            }
            if (comboBox1.SelectedItem == "Functional Programming" && comboBox2.SelectedItem == "Data Science")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Cryptography");
                //comboBox3.Items.Add("Data Science");
                comboBox3.Items.Add("Game Design");
                comboBox3.Items.Add("Parallel Programming");
                comboBox3.Items.Add("Web Development");
            }
            if (comboBox1.SelectedItem == "Functional Programming" && comboBox2.SelectedItem == "Game Design")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Cryptography");
                comboBox3.Items.Add("Data Science");
                //comboBox3.Items.Add("Game Design");
                comboBox3.Items.Add("Parallel Programming");
                comboBox3.Items.Add("Web Development");
            }
            if (comboBox1.SelectedItem == "Functional Programming" && comboBox2.SelectedItem == "Parallel Programming")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Cryptography");
                comboBox3.Items.Add("Data Science");
                comboBox3.Items.Add("Game Design");
                //comboBox3.Items.Add("Parallel Programming");
                comboBox3.Items.Add("Web Development");
            }
            if (comboBox1.SelectedItem == "Functional Programming" && comboBox2.SelectedItem == "Web Development")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Cryptography");
                comboBox3.Items.Add("Data Science");
                comboBox3.Items.Add("Game Design");
                comboBox3.Items.Add("Parallel Programming");
                //comboBox3.Items.Add("Web Development");
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            if (comboBox1.SelectedItem == "Game Design" && comboBox2.SelectedItem == "Cryptography")
            {
                comboBox3.Items.Clear();
                //comboBox3.Items.Add("Cryptography");
                comboBox3.Items.Add("Data Science");
                comboBox3.Items.Add("Functional Programming");
                comboBox3.Items.Add("Parallel Programming");
                comboBox3.Items.Add("Web Development");
            }
            if (comboBox1.SelectedItem == "Game Design" && comboBox2.SelectedItem == "Data Science")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Cryptography");
                //comboBox3.Items.Add("Data Science");
                comboBox3.Items.Add("Functional Programming");
                comboBox3.Items.Add("Parallel Programming");
                comboBox3.Items.Add("Web Development");
            }
            if (comboBox1.SelectedItem == "Game Design" && comboBox2.SelectedItem == "Functional Programming")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Cryptography");
                comboBox3.Items.Add("Data Science");
                //comboBox3.Items.Add("Functional Programming");
                comboBox3.Items.Add("Parallel Programming");
                comboBox3.Items.Add("Web Development");
            }
            if (comboBox1.SelectedItem == "Game Design" && comboBox2.SelectedItem == "Parallel Programming")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Cryptography");
                comboBox3.Items.Add("Data Science");
                comboBox3.Items.Add("Functional Programming");
                //comboBox3.Items.Add("Parallel Programming");
                comboBox3.Items.Add("Web Development");
            }
            if (comboBox1.SelectedItem == "Game Design" && comboBox2.SelectedItem == "Web Development")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Cryptography");
                comboBox3.Items.Add("Data Science");
                comboBox3.Items.Add("Functional Programming");
                comboBox3.Items.Add("Parallel Programming");
                //comboBox3.Items.Add("Web Development");
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            if (comboBox1.SelectedItem == "Parallel Programming" && comboBox2.SelectedItem == "Cryptography")
            {
                comboBox3.Items.Clear();
                //comboBox3.Items.Add("Cryptography");
                comboBox3.Items.Add("Data Science");
                comboBox3.Items.Add("Functional Programming");
                comboBox3.Items.Add("Game Design");
                comboBox3.Items.Add("Web Development");
            }
            if (comboBox1.SelectedItem == "Parallel Programming" && comboBox2.SelectedItem == "Data Science")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Cryptography");
                //comboBox3.Items.Add("Data Science");
                comboBox3.Items.Add("Functional Programming");
                comboBox3.Items.Add("Game Design");
                comboBox3.Items.Add("Web Development");
            }
            if (comboBox1.SelectedItem == "Parallel Programming" && comboBox2.SelectedItem == "Functional Programming")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Cryptography");
                comboBox3.Items.Add("Data Science");
                //comboBox3.Items.Add("Functional Programming");
                comboBox3.Items.Add("Game Design");
                comboBox3.Items.Add("Web Development");
            }
            if (comboBox1.SelectedItem == "Parallel Programming" && comboBox2.SelectedItem == "Game Design")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Cryptography");
                comboBox3.Items.Add("Data Science");
                comboBox3.Items.Add("Functional Programming");
                //comboBox3.Items.Add("Game Design");
                comboBox3.Items.Add("Web Development");
            }
            if (comboBox1.SelectedItem == "Parallel Programming" && comboBox2.SelectedItem == "Web Development")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Cryptography");
                comboBox3.Items.Add("Data Science");
                comboBox3.Items.Add("Functional Programming");
                comboBox3.Items.Add("Game Design");
                //comboBox3.Items.Add("Web Development");
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            if (comboBox1.SelectedItem == "Web Development" && comboBox2.SelectedItem == "Cryptography")
            {
                comboBox3.Items.Clear();
                //comboBox3.Items.Add("Cryptography");
                comboBox3.Items.Add("Data Science");
                comboBox3.Items.Add("Functional Programming");
                comboBox3.Items.Add("Game Design");
                comboBox3.Items.Add("Parallel Programming");
            }
            if (comboBox1.SelectedItem == "Web Development" && comboBox2.SelectedItem == "Data Science")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Cryptography");
                //comboBox3.Items.Add("Data Science");
                comboBox3.Items.Add("Functional Programming");
                comboBox3.Items.Add("Game Design");
                comboBox3.Items.Add("Parallel Programming");
            }
            if (comboBox1.SelectedItem == "Web Development" && comboBox2.SelectedItem == "Functional Programming")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Cryptography");
                comboBox3.Items.Add("Data Science");
                //comboBox3.Items.Add("Functional Programming");
                comboBox3.Items.Add("Game Design");
                comboBox3.Items.Add("Parallel Programming");
            }
            if (comboBox1.SelectedItem == "Web Development" && comboBox2.SelectedItem == "Game Design")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Cryptography");
                comboBox3.Items.Add("Data Science");
                comboBox3.Items.Add("Functional Programming");
                //comboBox3.Items.Add("Game Design");
                comboBox3.Items.Add("Parallel Programming");
            }
            if (comboBox1.SelectedItem == "Web Development" && comboBox2.SelectedItem == "Parallel Programming")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Cryptography");
                comboBox3.Items.Add("Data Science");
                comboBox3.Items.Add("Functional Programming");
                comboBox3.Items.Add("Game Design");
                //comboBox3.Items.Add("Parallel Programming");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (comboBox1.SelectedItem == "Cryptography" && comboBox2.SelectedItem == "Data Science" && comboBox3.SelectedItem == "Functional Programming")
            {
                comboBox4.Items.Clear();
                // comboBox4.Items.Add("Data Science");
                //comboBox4.Items.Add("Functional Programming");
                comboBox4.Items.Add("Game Design");
                comboBox4.Items.Add("Parallel Programming");
                comboBox4.Items.Add("Web Development");
            }
            if (comboBox1.SelectedItem == "Cryptography" && comboBox2.SelectedItem == "Data Science" && comboBox3.SelectedItem == "Game Design")
            {
                comboBox4.Items.Clear();
                // comboBox4.Items.Add("Data Science");
                comboBox4.Items.Add("Functional Programming");
                //comboBox4.Items.Add("Game Design");
                comboBox4.Items.Add("Parallel Programming");
                comboBox4.Items.Add("Web Development");
            }
            if (comboBox1.SelectedItem == "Cryptography" && comboBox2.SelectedItem == "Data Science" && comboBox3.SelectedItem == "Parallel Programming")
            {
                comboBox4.Items.Clear();
                // comboBox4.Items.Add("Data Science");
                comboBox4.Items.Add("Functional Programming");
                comboBox4.Items.Add("Game Design");
                //comboBox4.Items.Add("Parallel Programming");
                comboBox4.Items.Add("Web Development");
            }
            if (comboBox1.SelectedItem == "Cryptography" && comboBox2.SelectedItem == "Data Science" && comboBox3.SelectedItem == "Web Development")
            {
                comboBox4.Items.Clear();
                // comboBox4.Items.Add("Data Science");
                comboBox4.Items.Add("Functional Programming");
                comboBox4.Items.Add("Game Design");
                comboBox4.Items.Add("Parallel Programming");
                //comboBox4.Items.Add("Web Development");
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            if (comboBox1.SelectedItem == "Data Science" && comboBox2.SelectedItem == "Cryptography" && comboBox3.SelectedItem == "Functional Programming")
            {
                comboBox4.Items.Clear();
                //comboBox4.Items.Add("Cryptography");
                //comboBox4.Items.Add("Functional Programming");
                comboBox4.Items.Add("Game Design");
                comboBox4.Items.Add("Parallel Programming");
                comboBox4.Items.Add("Web Development");
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
        
