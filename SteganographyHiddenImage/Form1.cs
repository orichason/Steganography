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

namespace SteganographyHiddenImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
        }

        int count = 0;
        Bitmap input1Image;
        Bitmap input2Image;


        bool twoImagesSelected = false;
        void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            DialogResult result = file.ShowDialog();
            if (result == DialogResult.Cancel || result == DialogResult.No || result == DialogResult.Abort)
            {
                MessageBox.Show("Please select an image!");
                return;
            }

            string extension = Path.GetExtension(file.FileName);

            if (extension != ".png" && extension != ".jpeg" && extension != ".jfif" && extension != ".bmp")
            {
                MessageBox.Show("Please use png, jpeg, or bmp");
                return;

            }


            Bitmap loadedImage = new Bitmap(file.FileName);

            if (count % 2 == 0)
            {
                input1Image = loadedImage;
                input1.Image = loadedImage;
                //input2.Location = new Point(input1.Right, input1.Top);
                count++;
            }
            else
            {
                if (loadedImage.Size == input1Image.Size)
                {
                    input2Image = loadedImage;
                    input2.Image = loadedImage;
                    count++;
                    twoImagesSelected = true;
                }

                else
                {
                    MessageBox.Show("Error: please match size with other image");
                }

                //Make sure we are the same size as image1
            }



        }

        string FormatBinaryString(StringBuilder binaryString, int paddedSize = 4)
        {
            int roundUp = paddedSize - binaryString.Length % paddedSize;
            if (roundUp == paddedSize)
            {
                roundUp = 0;
            }

            for (int i = 0; i < roundUp; i++)
            {
                binaryString.Insert(0, '0');
            }

            return binaryString.ToString();
        }
        string DecimaltoBinary(int number)
        {
            StringBuilder binaryString = new StringBuilder();

            //int number = int.Parse(decimalStr);

            do
            {
                int remainder = number % 2;

                number /= 2;

                binaryString.Insert(0, remainder);

            } while (number > 0);

            return FormatBinaryString(binaryString);
        }

        int BinaryToDecimal(string binaryStr)
        {
            int finalDecimal = 0;
            for (int i = binaryStr.Length - 1; i >= 0; i--)
            {
                int digit = binaryStr[i] - '0';
                int newDecimal = digit * (int)Math.Pow(2, binaryStr.Length - (i + 1));
                finalDecimal += newDecimal;
            }

            return finalDecimal;
        }

        byte GetSigFigs(byte byte1, byte byte2)
        {
            string byte1inBinary = DecimaltoBinary(byte1);
            string byte2inBinary = DecimaltoBinary(byte2);

            byte1inBinary = byte1inBinary.PadLeft(8, '0');
            byte2inBinary = byte2inBinary.PadLeft(8, '0');

            string result = "";

            for (int i = 0; i < 4; i++)
            {
                result += byte1inBinary[i];
            }

            for (int i = 0; i < 4; i++)
            {
                result += byte2inBinary[i];
            }

            byte newByte = (byte)BinaryToDecimal(result);

            return newByte;
        }

        private Color EncryptColor(Color a, Color b)
        {
            byte newR = GetSigFigs(a.R, b.R);
            byte newG = GetSigFigs(a.G, b.G);
            byte newB = GetSigFigs(a.B, b.B);

            Color newColor = Color.FromArgb(newR, newG, newB);

            return newColor;
        }

        Bitmap newImage;
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            //1.) Create image of correct size (size of the input images)
            //2.) Loop over every pixel in that new image
            //3.) Set each pixel to be yellow <-> Replace with taking most/least sig figs and swapping them
            //4.) Display image

            newImage = new Bitmap(input1Image.Width, input1Image.Height);

            for (int x = 0; x < newImage.Width; x++)
            {
                for (int y = 0; y < newImage.Height; y++)
                {
                    //Store R, G, B values for each input image
                    Color input1Color = input1Image.GetPixel(x, y);
                    Color input2Color = input2Image.GetPixel(x, y);
                    Color encrypt = EncryptColor(input1Color, input2Color);
                    newImage.SetPixel(x, y, encrypt);
                }
            }

            output.Image = newImage;
        }

        (byte, byte) SplittingByte(byte byte1)
        {
            //Get byte from pixel
            //split first half of byte and add '0000' to the end
            //take second half and add '0000' to the end
            //image1: first half
            //image2: second half

            string byteInBinary = DecimaltoBinary(byte1);
            byteInBinary = byteInBinary.PadLeft(8, '0');

            string image1ResultInString = byteInBinary.Substring(0, 4);
            //*******************make sure byte1InBinary is padded
            string image2ResultInString = byteInBinary.Substring(4, 4);

            image1ResultInString += "0000";
            image2ResultInString += "0000";

            int image1ResultInt = BinaryToDecimal(image1ResultInString);
            int image2ResultInt = BinaryToDecimal(image2ResultInString);

            return ((byte)image1ResultInt, (byte)image2ResultInt);
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            Bitmap DecryptImage1 = new Bitmap(newImage.Width, newImage.Height);
            Bitmap DecryptImage2 = new Bitmap(newImage.Width, newImage.Height);
            //(byte a, byte b) = Decrypt(43);
            for (int x = 0; x < newImage.Width; x++)
            {
                for (int y = 0; y < newImage.Height; y++)
                {
                    Color currentPositionColor = newImage.GetPixel(x, y);

                    (byte r1, byte r2) = SplittingByte(currentPositionColor.R);
                    (byte g1, byte g2) = SplittingByte(currentPositionColor.G);
                    (byte b1, byte b2) = SplittingByte(currentPositionColor.B);

                    DecryptImage1.SetPixel(x, y, Color.FromArgb(r1, g1, b1));
                    DecryptImage2.SetPixel(x, y, Color.FromArgb(r2, g2, b2));
                }
                
            }

            decryptImage1.Image = DecryptImage1;
            decryptImage2.Image = DecryptImage2;
        }
    }
}
