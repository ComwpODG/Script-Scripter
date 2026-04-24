using System;
using System.IO;
using System.Windows.Forms;

namespace ScriptScripter
{
    public partial class Form1 : Form
    {
        private string inputFilePath = "";
        private string outputFolderPath = "";

        public Form1()
        {
            InitializeComponent();
        }

        // Pick input text file
        private void btnPickTextFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputFilePath = openFileDialog1.FileName;
                UpdateClarity();
            }
        }

        // Pick destination folder
        private void btnPickDestFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    outputFolderPath = folderDialog.SelectedPath;
                    UpdateClarity();
                }
            }
        }

        // Main generate button
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputFilePath) || string.IsNullOrEmpty(outputFolderPath))
            {
                MessageBox.Show("Please select both an input file and an output folder.");
                return;
            }

            try
            {
                string inputText = File.ReadAllText(inputFilePath);
                inputText = Sanitize(inputText);

                string outputFileName = Path.GetFileNameWithoutExtension(inputFilePath) + "_script.vbs";
                string fullOutputPath = Path.Combine(outputFolderPath, outputFileName);

                using (StreamWriter sw = new StreamWriter(fullOutputPath, false))
                {
                    WriteHeader(sw);
                    WriteChunks(sw, inputText, 5, 15);
                }

                MessageBox.Show("Script generated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Updates the "promise" label
        private void UpdateClarity()
        {
            if (string.IsNullOrEmpty(inputFilePath) && string.IsNullOrEmpty(outputFolderPath))
            {
                lblClarity.Text = "Select a text file and destination folder.";
                return;
            }

            else if (string.IsNullOrEmpty(outputFolderPath))
            {
                lblClarity.Text = "Select a destination folder.";
                return;
            }
            else if (string.IsNullOrEmpty(inputFilePath))
            {
                lblClarity.Text = "Select a text file.";
                return;
            }


            string fileName = Path.GetFileNameWithoutExtension(inputFilePath) + "_script.vbs";

            lblClarity.Text =
                $"The program will generate \"{fileName}\" at \"{outputFolderPath}\" " +
                $"containing the contents of \"{Path.GetFileName(inputFilePath)}\" as a script of keystrokes.";
        }

        private string Sanitize(string input)
        {
            return input
                .Replace(Environment.NewLine, " ")
                .Replace("\"", "'")
                .Replace("{", "-")
                .Replace("}", "-");
        }

        private void WriteHeader(StreamWriter sw)
        {
            sw.WriteLine("Set WshShell = WScript.CreateObject(\"WScript.Shell\")");
            sw.WriteLine("Delay = 15");
            sw.WriteLine($"WScript.Sleep 2000");
        }

        private void WriteChunks(StreamWriter sw, string text, int chunkSize, int delay)
        {
            int index = 0;

            while (index < text.Length)
            {
                sw.WriteLine("WshShell.SendKeys \"{ENTER}\"");
                sw.WriteLine($"WScript.Sleep {delay}");

                for (int i = 0; i < 6 && index < text.Length; i++)
                {
                    int remaining = text.Length - index;
                    int take = Math.Min(chunkSize, remaining);

                    string chunk = text.Substring(index, take);

                    sw.WriteLine($"WshShell.SendKeys \"{chunk}\"");
                    sw.WriteLine($"WScript.Sleep {delay}");

                    index += take;
                }
            }
        }
    }
}