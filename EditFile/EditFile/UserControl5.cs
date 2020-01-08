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
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();
        }
        void show1()
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Niko\Documents\C# Files");
            FileInfo[] Files = d.GetFiles("*.txt");

            foreach (FileInfo file in Files)
            {

                comboBox1.Items.Add(file.Name);

            }
        }

        void show2()
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Niko\Documents\C# Files");
            FileInfo[] Files = d.GetFiles("*.txt");

            foreach (FileInfo file in Files)
            {

                comboBox2.Items.Add(file.Name);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a value", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string selectedtext = comboBox1.SelectedItem.ToString();

                string filename = @"C:\Users\Niko\Documents\C# Files\" + selectedtext;

                string selectedtext1 = comboBox2.SelectedItem.ToString();

                string filename1 = @"C:\Users\Niko\Documents\C# Files\" + selectedtext1;

             
               
                File.Copy(filename, filename1, true);

                MessageBox.Show("Copy is successful", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                show1();
                show2();

            }
        }

        private void UserControl5_Load(object sender, EventArgs e)
        {
            show1();
            show2();
        }
    }
}
