using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRGenerator
{
    public partial class PictureViewer : Form
    {
        public PictureViewer()
        {
            InitializeComponent();
        }

        private void btnShowPic_Click(object sender, EventArgs e)
        {
            // Show the Open File Dialog. If the user clicks OK, load the
            // picture that the user chose.
            if (picFileSelector.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Load(picFileSelector.FileName);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackgroundColor_Click(object sender, EventArgs e)
        {
            if(colorPicker.ShowDialog() == DialogResult.OK)
            {
                pictureBox.BackColor = colorPicker.Color;
            }
        }

        private void btnClearPic_Click(object sender, EventArgs e)
        {
            //Clear the picture
            pictureBox.Image = null;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox.SizeMode = checkBox.Checked ? PictureBoxSizeMode.StretchImage : PictureBoxSizeMode.AutoSize;
        }
    }
}
