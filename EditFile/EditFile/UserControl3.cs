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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
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
        private void UserControl3_Load(object sender, EventArgs e)
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




                if (File.Exists(filename))
                {
                    File.Delete(filename);

                    comboBox1.Items.Clear();

                    comboBox1.Text = "All Files";
                    MessageBox.Show("Delete is successful", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    show1();
                }
            }
            
        }
    }
}
