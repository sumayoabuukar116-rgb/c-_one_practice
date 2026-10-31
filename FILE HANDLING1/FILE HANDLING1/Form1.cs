using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FILE_HANDLING1
{
    public partial class Form1 : Form
    {
        string[] selectedFiles;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (selectedFiles == null || selectedFiles.Length == 0)
            {
                MessageBox.Show("Please Open Files First");
                return;
            }

            listBox1.Items.Clear();

            foreach (string file in selectedFiles)
            {
                string[] lines = File.ReadAllLines(file);

                foreach (string line in lines)
                {
                    listBox1.Items.Add(line);
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Text Files|*.txt";
            open.Multiselect = true;

            if (open.ShowDialog() == DialogResult.OK)
            {
                selectedFiles = open.FileNames;

                MessageBox.Show("Files selected successfully");
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
            {
                listBox1.Items.Add(txtInput.Text);

                txtInput.Clear();
            }
            else
            {
                MessageBox.Show("Enter some text");
            }
        }

        private void btnDeleteOne_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Select an item to delete");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "Text Files|*.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(
                    save.FileName,
                    listBox1.Items.Cast<string>()
                );

                MessageBox.Show("Saved Successfully");
            }
        }
    }
}
