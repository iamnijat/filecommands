using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EditFile
{
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }
        string filename, filepath;
        StreamWriter sw;
        void show1()
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Niko\Documents\C# Files");//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files

            foreach (FileInfo file in Files)
            {
                //str = str + ", " + file.Name;
                comboBox1.Items.Add(file.Name);

            }
        }
        private void UserControl4_Load(object sender, EventArgs e)
        {
            show1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a value", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string selectedtext = comboBox1.SelectedItem.ToString();

                string filename = @"C:\Users\Niko\Documents\C# Files\" + selectedtext;

                MessageBox.Show(File.GetCreationTime(filename).ToString());
            }
           
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a value", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string selectedtext = comboBox1.SelectedItem.ToString();

                string filename = @"C:\Users\Niko\Documents\C# Files\" + selectedtext;



                MessageBox.Show(File.GetLastAccessTime(filename).ToString());
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a value", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string selectedtext = comboBox1.SelectedItem.ToString();

                string filename = @"C:\Users\Niko\Documents\C# Files\" + selectedtext;



                MessageBox.Show(File.GetLastWriteTime(filename).ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a value", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string selectedtext = comboBox1.SelectedItem.ToString();

                string filename = @"C:\Users\Niko\Documents\C# Files\" + selectedtext;
                MessageBox.Show(File.GetAccessControl(filename).ToString());
            }



            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a value", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string selectedtext = comboBox1.SelectedItem.ToString();

                string filename = @"C:\Users\Niko\Documents\C# Files\" + selectedtext;



                System.IO.FileInfo file = new System.IO.FileInfo(filename);
                MessageBox.Show("Size : " + file.Length + " Bite");
            }


            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a value", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string selectedtext = comboBox1.SelectedItem.ToString();

                string filename = @"C:\Users\Niko\Documents\C# Files\" + selectedtext;



                System.IO.FileInfo file = new System.IO.FileInfo(filename);
                MessageBox.Show("File Name : " + file.Name);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a value", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string selectedtext = comboBox1.SelectedItem.ToString();

                string filename = @"C:\Users\Niko\Documents\C# Files\" + selectedtext;



                System.IO.FileInfo file = new System.IO.FileInfo(filename);
                MessageBox.Show("File Extension : " + file.Extension);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a value", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string selectedtext = comboBox1.SelectedItem.ToString();

                string filename = @"C:\Users\Niko\Documents\C# Files\" + selectedtext;



                System.IO.FileInfo file = new System.IO.FileInfo(filename);
                MessageBox.Show("File Directory Name : " + file.DirectoryName);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a value", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string selectedtext = comboBox1.SelectedItem.ToString();

                string filename = @"C:\Users\Niko\Documents\C# Files\" + selectedtext;



                System.IO.FileInfo file = new System.IO.FileInfo(filename);
                MessageBox.Show("File Full Name : " + file.FullName);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            
        }
    }
}
