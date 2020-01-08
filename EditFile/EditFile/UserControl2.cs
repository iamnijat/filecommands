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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
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
        private void UserControl2_Load(object sender, EventArgs e)
        {
            show1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a value","Empty Value",MessageBoxButtons.OK,MessageBoxIcon.Warning);
              
            }
            else
            {
                string selectedtext = comboBox1.SelectedItem.ToString();

                string filename = @"C:\Users\Niko\Documents\C# Files\" + selectedtext;


                string file = File.ReadAllText(filename, Encoding.ASCII);

                richTextBox1.Text = file;
            }
            
                

            }
        }
    }

