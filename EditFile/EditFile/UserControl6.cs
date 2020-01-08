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
    public partial class UserControl6 : UserControl
    {
        public UserControl6()
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

        private void UserControl6_Load(object sender, EventArgs e)
        {
            show1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || textBox1.Text == "")
            {
                MessageBox.Show("Please select a value", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string selectedtext = comboBox1.SelectedItem.ToString();

                string filename = @"C:\Users\Niko\Documents\C# Files\" + selectedtext;

                string selectedtext1 = textBox1.Text.ToString();

                string filename1 = @"C:\Users\Niko\Documents\C# Files\" + selectedtext1 + ".txt";



                File.Move(filename, filename1);

                MessageBox.Show("Rename is successful", "Rename", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Items.Clear();
                textBox1.Clear();
                show1();
                

            }
        }
    }
}
