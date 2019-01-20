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

namespace NotePadApp
{
    public partial class NotePad : Form
    {
        public NotePad()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This App is made by \n Usama Jamil...");
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You want to exit!..","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                richTextBox1.Text += Clipboard.GetText(TextDataFormat.Text);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var notePad = new NotePad();
                                notePad.Show();
            
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var printdialog = new PrintDialog()
                                            .ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filedialog = new OpenFileDialog();
            filedialog.Title = "open new file...";
            filedialog.Filter = ".txt (NotePad files)  | *.txt";

            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                var fileReader = new StreamReader(filedialog.FileName);


                this.richTextBox1.Text = fileReader.ReadToEnd();
                this.Show();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelLetter.Text = "Letters :" + richTextBox1.Text.Length;

            var words = richTextBox1.Text
                                    .Trim()
                                    .Split(' ');
            toolStripStatusLabelWords.Text = "Words :" + words.Length; 
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Tag = "Save Your File...";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var writer = new StreamWriter(saveFileDialog.FileName + ".txt");

                    writer.WriteLine(richTextBox1.Text);
                    writer.Close();

                    MessageBox.Show("Saved");

                }
            }
            else
            {
                MessageBox.Show("There is no text here!...");
            }
        }
    }
}
