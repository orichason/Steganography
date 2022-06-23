
namespace SteganographyHiddenImage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.input1 = new System.Windows.Forms.PictureBox();
            this.input2 = new System.Windows.Forms.PictureBox();
            this.output = new System.Windows.Forms.PictureBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.decryptImage1 = new System.Windows.Forms.PictureBox();
            this.decryptImage2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.input1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decryptImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decryptImage2)).BeginInit();
            this.SuspendLayout();
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // input1
            // 
            this.input1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.input1.Location = new System.Drawing.Point(12, 65);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(250, 250);
            this.input1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.input1.TabIndex = 1;
            this.input1.TabStop = false;
            // 
            // input2
            // 
            this.input2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.input2.Location = new System.Drawing.Point(289, 65);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(250, 250);
            this.input2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.input2.TabIndex = 2;
            this.input2.TabStop = false;
            // 
            // output
            // 
            this.output.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.output.Location = new System.Drawing.Point(681, 65);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(250, 250);
            this.output.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.output.TabIndex = 3;
            this.output.TabStop = false;
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(681, 13);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(95, 46);
            this.EncryptButton.TabIndex = 4;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(545, 343);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(96, 46);
            this.DecryptButton.TabIndex = 5;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // decryptImage1
            // 
            this.decryptImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.decryptImage1.Location = new System.Drawing.Point(12, 343);
            this.decryptImage1.Name = "decryptImage1";
            this.decryptImage1.Size = new System.Drawing.Size(250, 250);
            this.decryptImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.decryptImage1.TabIndex = 6;
            this.decryptImage1.TabStop = false;
            // 
            // decryptImage2
            // 
            this.decryptImage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.decryptImage2.Location = new System.Drawing.Point(289, 343);
            this.decryptImage2.Name = "decryptImage2";
            this.decryptImage2.Size = new System.Drawing.Size(250, 250);
            this.decryptImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.decryptImage2.TabIndex = 7;
            this.decryptImage2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1242, 653);
            this.Controls.Add(this.decryptImage2);
            this.Controls.Add(this.decryptImage1);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.input1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decryptImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decryptImage2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox input1;
        private System.Windows.Forms.PictureBox input2;
        private System.Windows.Forms.PictureBox output;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.PictureBox decryptImage1;
        private System.Windows.Forms.PictureBox decryptImage2;
    }
}

