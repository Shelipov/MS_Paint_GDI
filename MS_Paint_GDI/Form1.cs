using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.IO;
using MS_Paint_GDI.Models;

namespace MS_Paint_GDI
{
    public partial class Form1 : Form
    {
        OpenSave save = new OpenSave();
        
        
        Color painColor1;
        Color paintColor2;
        bool paintColorSelected = true;
        bool choose = false;
        bool draw = false;
        Bitmap globalBitmap;
        Bitmap bitmapForInverseImage;
        int x, y = 0;
        int brushSize = 1;
        Item currItem;
        string text;
        
        public enum Item
        {
            line, Ellipse, Rectangle, Brush, Eraser, FillEllipse, FillRectangle, Pencil, Triangle,Text, Bucket
        }

        public Form1()
        {
            InitializeComponent();
        }
        LinkedList<ToolStripButton> listToolStrip = new LinkedList<ToolStripButton>();

        private void Form1_Load(object sender, EventArgs e)
        {
            painColor1 = pictureBoxColor1.BackColor;
            paintColor2 = pictureBoxColor2.BackColor;

            listToolStrip.AddLast(Карандаш);
            listToolStrip.AddLast(Кисть);
            listToolStrip.AddLast(Ластик);
            listToolStrip.AddLast(Заливка);
            listToolStrip.AddLast(Линия);
            listToolStrip.AddLast(Прямоугольник);
            listToolStrip.AddLast(Треугольник);
            listToolStrip.AddLast(Текст);
            listToolStrip.AddLast(Элипс);
            listToolStrip.AddLast(FillEllipse);
            listToolStrip.AddLast(FillRectangle);
        }

        private void pictureBoxImage_MouseDown(object sender, MouseEventArgs e)
        {
            globalBitmap = (Bitmap)pictureBoxImage.Image.Clone();
            
            draw = true;
            x = e.X;
            y = e.Y;
           
        }

        private void pictureBoxImage_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
            
        }

        private void pictureBoxImage_MouseMove(object sender, MouseEventArgs e)
        {
           
            if (draw)
            {
                Bitmap bitmapLocalDraw = null;
                Graphics graohicsLocalDraw = null;

                int x1 = x < e.X ? x : e.X;
                int x2 = x > e.X ? x : e.X;
                int y1 = y < e.Y ? y : e.Y;
                int y2 = y > e.Y ? y : e.Y;
                Rectangle rectanglePositionDraw = new Rectangle(x1, y1, x2 - x1, y2 - y1);

                switch (currItem)
                {
                    case Item.Bucket:
                        /// МЫШКУ УДЕРЖИВАТЬ ВНУТРИ ФИГУРЫ НАЖАТОЙ ДОЛГО ОБРАБАТЫВАЕТ!!!!
                        MapFill gd = new MapFill();
                        Point point = new Point(e.X, e.Y);
                        bitmapLocalDraw = (Bitmap)pictureBoxImage.Image;
                        graohicsLocalDraw = Graphics.FromImage(bitmapLocalDraw);
                        gd.Fill(graohicsLocalDraw, point, painColor1, ref bitmapLocalDraw);

                        break;
                    case Item.Triangle:
                        Point[] points = { new Point(x1, y1), new Point(x2, y2), new Point(x1, y2) };
                        Pen blackPen = new Pen(new SolidBrush(painColor1), brushSize);
                        bitmapLocalDraw = (Bitmap)globalBitmap.Clone();
                        graohicsLocalDraw = Graphics.FromImage(bitmapLocalDraw);
                        graohicsLocalDraw.DrawPolygon(blackPen, points);

                        break;
                    case Item.Pencil:
                        bitmapLocalDraw = (Bitmap)pictureBoxImage.Image;
                        graohicsLocalDraw = Graphics.FromImage(bitmapLocalDraw);
                        graohicsLocalDraw.FillEllipse(new SolidBrush(painColor1), e.X - brushSize / 2, e.Y - brushSize / 2,
                        brushSize, brushSize);
                        break;
                    case Item.Text:
                        bitmapLocalDraw = (Bitmap)pictureBoxImage.Image;
                        graohicsLocalDraw = Graphics.FromImage(bitmapLocalDraw);
                        String drawString = text;
                        Font drawFont = new Font("Arial", 16);
                        SolidBrush drawBrush = new SolidBrush(painColor1);
                        PointF drawPoint = new PointF(x, y);
                        StringFormat drawFormat = new StringFormat();
                        drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
                        graohicsLocalDraw.DrawString(drawString, drawFont, drawBrush, drawPoint);
                        textBox1.Visible = false;
                        break;

                    case Item.line:
                        bitmapLocalDraw = (Bitmap)globalBitmap.Clone();
                        graohicsLocalDraw = Graphics.FromImage(bitmapLocalDraw);
                        graohicsLocalDraw.DrawLine(new Pen(new SolidBrush(painColor1), brushSize),
                                    new Point(x, y), new Point(e.X, e.Y));
                        break;

                    case Item.Rectangle:
                        bitmapLocalDraw = (Bitmap)globalBitmap.Clone();
                        graohicsLocalDraw = Graphics.FromImage(bitmapLocalDraw);
                        graohicsLocalDraw.DrawRectangle(new Pen(painColor1, brushSize), rectanglePositionDraw);
                        break;

                    case Item.FillRectangle:
                        bitmapLocalDraw = (Bitmap)globalBitmap.Clone();
                        graohicsLocalDraw = Graphics.FromImage(bitmapLocalDraw);
                        graohicsLocalDraw.FillRectangle(new SolidBrush(paintColor2), rectanglePositionDraw);
                        graohicsLocalDraw.DrawRectangle(new Pen(painColor1, brushSize), rectanglePositionDraw);
                        break;

                    case Item.Ellipse:
                        bitmapLocalDraw = (Bitmap)globalBitmap.Clone();
                        graohicsLocalDraw = Graphics.FromImage(bitmapLocalDraw);
                        graohicsLocalDraw.DrawEllipse(new Pen(painColor1, brushSize), rectanglePositionDraw);
                        break;

                    case Item.FillEllipse:
                        bitmapLocalDraw = (Bitmap)globalBitmap.Clone();
                        graohicsLocalDraw = Graphics.FromImage(bitmapLocalDraw);
                        graohicsLocalDraw.FillEllipse(new SolidBrush(paintColor2), rectanglePositionDraw);
                        graohicsLocalDraw.DrawEllipse(new Pen(painColor1, brushSize), rectanglePositionDraw);
                        break;

                    case Item.Brush:
                        bitmapLocalDraw = (Bitmap)pictureBoxImage.Image;
                        graohicsLocalDraw = Graphics.FromImage(bitmapLocalDraw);
                        graohicsLocalDraw.FillEllipse(new SolidBrush(painColor1), e.X - brushSize / 2, e.Y - brushSize / 2,
                        brushSize, brushSize);
                        break;

                    case Item.Eraser:
                        bitmapLocalDraw = (Bitmap)pictureBoxImage.Image;
                        graohicsLocalDraw = Graphics.FromImage(bitmapLocalDraw);
                        graohicsLocalDraw.FillEllipse(new SolidBrush(pictureBoxImage.BackColor), e.X - brushSize / 2, e.Y - brushSize / 2,
                        brushSize, brushSize);
                        pictureBoxImage.Invalidate();
                        break;
                }

                pictureBoxImage.Image = bitmapLocalDraw;
            }
        }

        private void pictureBoxColorSelect_MouseDown(object sender, MouseEventArgs e)
        {
            choose = true;
           
        }

        private void pictureBoxColorSelect_MouseUp(object sender, MouseEventArgs e)
        {
            choose = false;
            
        }

        private void pictureBoxColorSelect_MouseMove(object sender, MouseEventArgs e)
        {
            if (choose && (e.Y < pictureBoxColorSelect.Height && e.Y > 0))
                if (e.X < pictureBoxColorSelect.Width && e.X > 0)
                {
                    Bitmap bitmapLocal = (Bitmap)pictureBoxColorSelect.Image.Clone();

                    painColor1 = bitmapLocal.GetPixel(e.X, e.Y);

                    if (paintColorSelected)
                    {
                        pictureBoxColor1.BackColor = painColor1;
                    }
                    else
                    {
                        pictureBoxColor2.BackColor = painColor1;
                    }
                }

        }
        private void pictureBoxColor2_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            pictureBoxColor2.BackColor = colorDialog1.Color;
            paintColorSelected = false;
            painColor1 = pictureBoxColor2.BackColor;
            paintColor2 = pictureBoxColor1.BackColor;
            pictureBoxColor1.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxColor2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBoxColor1_DoubleClick(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            pictureBoxColor1.BackColor = colorDialog1.Color;
            paintColorSelected = true;
            painColor1 = pictureBoxColor1.BackColor;
            paintColor2 = pictureBoxColor2.BackColor;
            pictureBoxColor2.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxColor1.BorderStyle = BorderStyle.Fixed3D;
        }
        private void pictureBoxColor1_Click(object sender, EventArgs e)
        {

            paintColorSelected = true;
            painColor1 = pictureBoxColor1.BackColor;
            paintColor2 = pictureBoxColor2.BackColor;
            pictureBoxColor2.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxColor1.BorderStyle = BorderStyle.Fixed3D;

        }

        private void pictureBoxColor2_Click(object sender, EventArgs e)
        {

            paintColorSelected = false;
            painColor1 = pictureBoxColor2.BackColor;
            paintColor2 = pictureBoxColor1.BackColor;
            pictureBoxColor1.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxColor2.BorderStyle = BorderStyle.Fixed3D;
        }
        private void changeSelectedColorToolStripButton(ToolStripButton tb)
        {
            foreach (ToolStripButton tsb in listToolStrip)
            {
                tsb.Checked = false;
            }
            tb.Checked = true;
        }
        private void Линия_Click(object sender, EventArgs e)
        {
            currItem = Item.line;
            changeSelectedColorToolStripButton(Линия);
            
        }

        private void Элипс_Click(object sender, EventArgs e)
        {
            currItem = Item.Ellipse;
            changeSelectedColorToolStripButton(Элипс);
        }

        private void Прямоугольник_Click(object sender, EventArgs e)
        {
            currItem = Item.Rectangle;
            changeSelectedColorToolStripButton(Прямоугольник);
        }

        private void Кисть_Click(object sender, EventArgs e)
        {
            currItem = Item.Brush;
            changeSelectedColorToolStripButton(Кисть);
        }
        private void Заливка_Click(object sender, EventArgs e)
        {
            currItem = Item.Bucket;
            changeSelectedColorToolStripButton(Заливка);

        }

        private void FillRectangle_Click(object sender, EventArgs e)
        {
            currItem = Item.FillRectangle;
            changeSelectedColorToolStripButton(FillRectangle);
        }

        private void FillEllipse_Click(object sender, EventArgs e)
        {
            currItem = Item.FillEllipse;
            changeSelectedColorToolStripButton(FillEllipse);
        }
        private void Ластик_Click(object sender, EventArgs e)
        {
            currItem = Item.Eraser;
            changeSelectedColorToolStripButton(Ластик);
        }
        private void Треугольник_Click(object sender, EventArgs e)
        {
            currItem = Item.Triangle;
            changeSelectedColorToolStripButton(Треугольник);
        }

        private void Текст_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            currItem = Item.Text;
            changeSelectedColorToolStripButton(Текст);

        }

        private void Карандаш_Click(object sender, EventArgs e)
        {
            currItem = Item.Pencil;
            changeSelectedColorToolStripButton(Карандаш);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            text = textBox1.Text;
        }
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save.Create(pictureBoxImage);
            
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save.saveImage(pictureBoxImage);
        }

        
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save.Open(pictureBoxImage);
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save.Exit(pictureBoxImage);
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            brushSize = trackBar1.Value;
        }

        private void InverseImage(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            bitmapForInverseImage = (Bitmap)pictureBoxImage.Image.Clone();
            byte A, R, G, B;
            Color pixelColor;
            for (int y = 0; y < bitmapForInverseImage.Height; y++)
            {
                worker.ReportProgress(y);
                for (int x = 0; x < bitmapForInverseImage.Width; x++)
                {
                    pixelColor = bitmapForInverseImage.GetPixel(x, y);
                    A = pixelColor.A;
                    R = pixelColor.R;
                    G = pixelColor.G;
                    B = pixelColor.B;
                    bitmapForInverseImage.SetPixel(x, y, Color.FromArgb(A, 0xFF - R, 0xFF - G, 0xFF - B));
                }
                Thread.Sleep(50);
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            pictureBoxImage.Image = bitmapForInverseImage;
            progressBar1.Visible = false;
        }

        private void Inverse_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = pictureBoxImage.Height + 1;
            backgroundWorker1.RunWorkerAsync();
        }

    }
}
