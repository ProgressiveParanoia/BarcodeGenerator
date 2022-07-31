using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.Rendering;

namespace QRGenerator
{
    public partial class BarcodeReader : Form
    {
        private Type Renderer { get; set; }

        //private List<Label> labels = new List<Label>();
        private Font currentFont;

        private bool hasClicked;
        private Label selectedLabel;

        private Point barcodeBoxLocalPosition;
        private Point mousedownLocation;
        public BarcodeReader()
        {
            InitializeComponent();

            currentFont = fontPicker.Font;
            Renderer = typeof(BitmapRenderer);
        }

        private void btnBarcodeGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                var writer = new BarcodeWriter
                {
                    Format = BarcodeFormat.CODE_128,
                    Options = new EncodingOptions
                    {
                        Height = barcodePicBox.Height - (barcodePicBox.Height / 4),
                        Width = barcodePicBox.Width
                    },
                   // Renderer = (IBarcodeRenderer<Bitmap>)Activator.CreateInstance(Renderer)
                    Renderer = new BitmapRenderer //
                    {
                        TextFont = new Font("Arial", 48, FontStyle.Bold)
                    }

                };

                barcodePicBox.Image = writer.Write(barcodeTxtBox.Text);
                barcodePicBox.BackColor = Color.White;
            }catch(Exception exc)
            {
                MessageBox.Show(this, exc.Message, "You fucked up bitch boi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExtraAdd_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomX = rnd.Next(20, this.barcodePicBox.Width - 20);
            int randomY = rnd.Next(20, this.barcodePicBox.Height - 20);

            var currentLabel = new Label { Text = extraTxtBox.Text, Location = new Point(randomX, randomY), TabIndex = 11};
            currentLabel.AutoSize = true;
            currentLabel.Font  = currentFont;
            currentLabel.BackColor = System.Drawing.Color.Transparent;

            currentLabel.MouseDown += lblExtra_MouseDown;
            currentLabel.MouseMove += lblExtra_MouseMove;
            //labels.Add(currentLabel);
            barcodePicBox.Controls.Add(currentLabel);
        }

        private void lblExtra_MouseDown(object sender, MouseEventArgs e)
        {
            this.selectedLabel = sender as Label;

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                mousedownLocation = e.Location;
            }

            if(e.Button == MouseButtons.Right)
            {
                barcodePicBox.Controls.Remove(selectedLabel);
                this.selectedLabel = null;
            }
        }
        
        private void lblExtra_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                selectedLabel.Left = e.X + selectedLabel.Left - mousedownLocation.X;
                selectedLabel.Top = e.Y + selectedLabel.Top - mousedownLocation.Y;
                Console.WriteLine("Mouse position:" + this.selectedLabel.Location);
            }
        }

        private void btnPickFont_Click(object sender, EventArgs e)
        {
            if (fontPicker.ShowDialog() == DialogResult.OK)
            {
                currentFont = fontPicker.Font;
                btnPickFont.Text = fontPicker.Font.Name;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //TODO: save to specific location using file picker
            var bitmapImage = new Bitmap(barcodePicBox.ClientRectangle.Width, barcodePicBox.ClientRectangle.Height);
            barcodePicBox.DrawToBitmap(bitmapImage, new Rectangle(0, 0, bitmapImage.Width, bitmapImage.Height));
            bitmapImage.Save("ame_test_png.png", System.Drawing.Imaging.ImageFormat.Png);
        }

    }
}
