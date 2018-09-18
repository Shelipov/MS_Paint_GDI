using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Paint_GDI;

namespace MS_Paint_GDI.Models
{
    class OpenSave
    {
        public void saveImage(PictureBox pictureBoxImage)
        {
            Bitmap bitmapLocal = new Bitmap(pictureBoxImage.Width, pictureBoxImage.Height);
            Graphics graphicsLocal = Graphics.FromImage(bitmapLocal);
            Rectangle rect = pictureBoxImage.RectangleToScreen(pictureBoxImage.ClientRectangle);
            graphicsLocal.CopyFromScreen(rect.Location, Point.Empty, pictureBoxImage.Size);
            graphicsLocal.Dispose();
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Png files|*.png|jpeg files|*.jpg|bitmaps|*.bmp";
            if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(saveDialog.FileName))
                {
                    File.Delete(saveDialog.FileName);
                }
                if (saveDialog.FileName.Contains("jpg"))
                {
                    bitmapLocal.Save(saveDialog.FileName, ImageFormat.Jpeg);
                }
                if (saveDialog.FileName.Contains("png"))
                {
                    bitmapLocal.Save(saveDialog.FileName, ImageFormat.Png);
                }
                if (saveDialog.FileName.Contains("bmp"))
                {
                    bitmapLocal.Save(saveDialog.FileName, ImageFormat.Bmp);
                }
            }
        }
        public void Exit(PictureBox pictureBoxImage)
        {
            DialogResult dr = MessageBox.Show("Do you want to save alterations?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            if (dr == DialogResult.Yes)
            {
                saveImage(pictureBoxImage);
                Application.Exit();
                //this.Close();
            }
            if (dr == DialogResult.No)
            {
                //this.Close();
                Application.Exit();
            }
        }
        public void Open(PictureBox pictureBoxImage)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Png files|*.png|jpeg files|*.jpg|bitmaps|*.bmp";
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBoxImage.Width = (Image.FromFile(fileDialog.FileName).Width);
                pictureBoxImage.Height = (Image.FromFile(fileDialog.FileName).Height);
                pictureBoxImage.Image = (Image)Image.FromFile(fileDialog.FileName).Clone();
            }
        }
        public void Create(PictureBox pictureBoxImage)
        {
            pictureBoxImage.Image = null;
            Graphics graphicsLocal = pictureBoxImage.CreateGraphics();
            Bitmap bitmapLocal = new Bitmap(pictureBoxImage.Width, pictureBoxImage.Height, graphicsLocal);
            pictureBoxImage.Image = bitmapLocal;
            pictureBoxImage.BackColor = Color.White;
        }
    }
}
