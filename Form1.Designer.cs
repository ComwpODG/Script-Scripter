
namespace ScriptScripter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPickTextFile = new System.Windows.Forms.Button();
            this.btnPickDestFolder = new System.Windows.Forms.Button();
            this.lblClarity = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "select your txt file";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(369, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Batch File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPickTextFile
            // 
            this.btnPickTextFile.Location = new System.Drawing.Point(12, 12);
            this.btnPickTextFile.Name = "btnPickTextFile";
            this.btnPickTextFile.Size = new System.Drawing.Size(189, 23);
            this.btnPickTextFile.TabIndex = 4;
            this.btnPickTextFile.Text = "Select Text File";
            this.btnPickTextFile.UseVisualStyleBackColor = true;
            this.btnPickTextFile.Click += new System.EventHandler(this.btnPickTextFile_Click);
            // 
            // btnPickDestFolder
            // 
            this.btnPickDestFolder.Location = new System.Drawing.Point(207, 12);
            this.btnPickDestFolder.Name = "btnPickDestFolder";
            this.btnPickDestFolder.Size = new System.Drawing.Size(174, 23);
            this.btnPickDestFolder.TabIndex = 5;
            this.btnPickDestFolder.Text = "Select Destination Folder";
            this.btnPickDestFolder.UseVisualStyleBackColor = true;
            this.btnPickDestFolder.Click += new System.EventHandler(this.btnPickDestFolder_Click);
            // 
            // lblClarity
            // 
            this.lblClarity.Location = new System.Drawing.Point(9, 51);
            this.lblClarity.Name = "lblClarity";
            this.lblClarity.Size = new System.Drawing.Size(372, 94);
            this.lblClarity.TabIndex = 6;
            this.lblClarity.Text = "Select a text file and a destination folder.";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "select your txt file";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 194);
            this.Controls.Add(this.lblClarity);
            this.Controls.Add(this.btnPickDestFolder);
            this.Controls.Add(this.btnPickTextFile);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Script Scripter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPickTextFile;
        private System.Windows.Forms.Button btnPickDestFolder;
        private System.Windows.Forms.Label lblClarity;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

