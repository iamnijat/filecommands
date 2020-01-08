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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        string filename, filepath;
        StreamWriter sw;

        private void button3_Click(object sender, EventArgs e)
        {

            richTextBox1.Clear();
            /*
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = openFileDialog1.FileName;
                
                string str = sr.ReadLine();
                while (str != null)
                {
                    richTextBox1.Text = str;
                    str = sr.ReadLine();
                }
                MessageBox.Show("Opening is successful", "Opening", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            */
            OpenFileDialog dtg = new OpenFileDialog();

            dtg.Title = "Choose a file you want to open";
            dtg.Filter = "Regular Text file (*.txt)|*.txt";

            if (dtg.ShowDialog() == DialogResult.OK)
            {

                string file = File.ReadAllText(dtg.FileName, Encoding.ASCII);
                textBox1.Text = dtg.FileName;
                richTextBox1.Text = file;
           
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = folderBrowserDialog1.SelectedPath.ToString();
                filename = richTextBox1.Text;

                if (File.Exists(filepath + "\\" + filename + ".txt"))

                {

                    MessageBox.Show("TextFile is created before", "Creating", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    sw = File.CreateText(filepath + "\\" + filename + ".txt");
                    sw.Close();
                    MessageBox.Show("TextFile is created", "Creating", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

               

               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            string text = richTextBox1.Text;
            //MessageBox.Show(path);
            //MessageBox.Show(text);


            File.WriteAllText(path, richTextBox1.Text);
            MessageBox.Show("Saving is successful", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog dtg = new SaveFileDialog();

            dtg.Title = "Choose a location where you want to save file";
            dtg.Filter = "Regular Text file (*.txt)|*.txt";

            if (dtg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dtg.FileName, richTextBox1.Text);

                MessageBox.Show("Saving is successful", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FontDialog dtg = new FontDialog();
            if (dtg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = dtg.Font;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ColorDialog dtg = new ColorDialog();
            if (dtg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = dtg.Color;

            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
