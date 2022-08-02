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

        private List<Label> labels = new List<Label>();
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
            RenderLabelPropertyInfo(null);
        }

        private void btnBarcodeGenerate_Click(object sender, EventArgs e)
        {
            RenderBarcode();
        }

        private void RenderBarcode()
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
                        TextFont = currentFont
                    }
                };

                barcodePicBox.Image = writer.Write(barcodeTxtBox.Text);
                barcodePicBox.BackColor = Color.White;
            }
            catch (Exception exc)
            {
                MessageBox.Show(this, exc.Message, "You fucked up bitch boi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnExtraAdd_Click(object sender, EventArgs e)
        {

            var currentLabel = new Label { Text = extraTxtBox.Text, Location = new Point(0, 0), TabIndex = 11};
         
            currentLabel.AutoSize = true;
            currentLabel.Font  = currentFont;
            currentLabel.BackColor = System.Drawing.Color.Transparent;

            currentLabel.Location = new Point(this.barcodePicBox.Width - ((this.barcodePicBox.Width / 2) + (currentLabel.Width)),
                                              this.barcodePicBox.Height - ((this.barcodePicBox.Height / 8) + currentLabel.Height));

            currentLabel.MouseDown += lblExtra_MouseDown;
            currentLabel.MouseMove += lblExtra_MouseMove;
            labels.Add(currentLabel);
            barcodePicBox.Controls.Add(currentLabel);

            RepositionLabels();
        }

        private void RepositionLabels()
        {
            int labelCount = labels.Count;
            Point initialReferencePoint = new Point();
            for(int i = 0; i < labelCount; i++)
            {
                var curLabel = labels[i];

                if(i == 0)
                {
                    initialReferencePoint = curLabel.Location;
                }
                else
                {
                    initialReferencePoint = new Point(initialReferencePoint.X, initialReferencePoint.Y - curLabel.Height);
                    curLabel.Location = initialReferencePoint;
                }
            }
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
                labels.Remove(selectedLabel);
                barcodePicBox.Controls.Remove(selectedLabel);
                this.selectedLabel = null;
            }

            RenderLabelPropertyInfo(this.selectedLabel);
        }

        private void RenderLabelPropertyInfo(Label label)
        {
            propertiesLayoutPanel.Visible = label != null;

            if (label == null)
                return;

            extraTextPropertyTxtBox.Text = label.Text;
        }

        private void ApplyLabelPropertyInfo(Label label)
        {
            label.Font = currentFont;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            //TODO: save to specific location using file picker
            var bitmapImage = new Bitmap(barcodePicBox.ClientRectangle.Width, barcodePicBox.ClientRectangle.Height);
            barcodePicBox.DrawToBitmap(bitmapImage, new Rectangle(0, 0, bitmapImage.Width, bitmapImage.Height));
            saveFileDialog.Filter = "PNG Image|*.png;";
            saveFileDialog.Title = "Save an Image File";
            saveFileDialog.ShowDialog();


            if(saveFileDialog.FileName != "")
            {
                System.IO.FileStream fs =
          (System.IO.FileStream)saveFileDialog.OpenFile();
                bitmapImage.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                fs.Close();
            }
            
        }

        //Font pickers here
        private void btnPickFont_Click(object sender, EventArgs e)
        {
            if (fontPicker.ShowDialog() == DialogResult.OK)
            {
                currentFont = fontPicker.Font;
                btnPickFont.Text = fontPicker.Font.Name;
            }
        }

        private void btnBarcodeFont_Click(object sender, EventArgs e)
        {
            if(fontPicker.ShowDialog() == DialogResult.OK)
            {
                currentFont = fontPicker.Font;
                btnBarcodeFont.Text = fontPicker.Font.Name;
                RenderBarcode();
            }
        }

        private void btnChangeText_Click(object sender, EventArgs e)
        {
            if(fontPicker.ShowDialog() == DialogResult.OK)
            {
                this.selectedLabel.Font = fontPicker.Font;
            }
        }

        private void extraTextPropertyTxtBox_TextChanged(object sender, EventArgs e)
        {
            if(this.selectedLabel == null)
            {
                return;
            }

            this.selectedLabel.Text = extraTextPropertyTxtBox.Text;
        }
    }
}
