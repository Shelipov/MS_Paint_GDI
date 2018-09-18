namespace MS_Paint_GDI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InverseImageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Карандаш = new System.Windows.Forms.ToolStripButton();
            this.Кисть = new System.Windows.Forms.ToolStripButton();
            this.Ластик = new System.Windows.Forms.ToolStripButton();
            this.Заливка = new System.Windows.Forms.ToolStripButton();
            this.Текст = new System.Windows.Forms.ToolStripButton();
            this.Прямоугольник = new System.Windows.Forms.ToolStripButton();
            this.Треугольник = new System.Windows.Forms.ToolStripButton();
            this.Линия = new System.Windows.Forms.ToolStripButton();
            this.Элипс = new System.Windows.Forms.ToolStripButton();
            this.FillRectangle = new System.Windows.Forms.ToolStripButton();
            this.FillEllipse = new System.Windows.Forms.ToolStripButton();
            this.Inverse = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxColor1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxColor2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.pictureBoxColorSelect = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.InverseImageToolStripMenuItem1});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // InverseImageToolStripMenuItem1
            // 
            this.InverseImageToolStripMenuItem1.Name = "InverseImageToolStripMenuItem1";
            this.InverseImageToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Карандаш,
            this.Кисть,
            this.Ластик,
            this.Заливка,
            this.Текст,
            this.Прямоугольник,
            this.Треугольник,
            this.Линия,
            this.Элипс,
            this.FillRectangle,
            this.FillEllipse,
            this.Inverse});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Карандаш
            // 
            this.Карандаш.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Карандаш.Image = ((System.Drawing.Image)(resources.GetObject("Карандаш.Image")));
            this.Карандаш.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Карандаш.Name = "Карандаш";
            this.Карандаш.Size = new System.Drawing.Size(23, 22);
            this.Карандаш.Text = "Карандаш";
            this.Карандаш.Click += new System.EventHandler(this.Карандаш_Click);
            // 
            // Кисть
            // 
            this.Кисть.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Кисть.Image = ((System.Drawing.Image)(resources.GetObject("Кисть.Image")));
            this.Кисть.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Кисть.Name = "Кисть";
            this.Кисть.Size = new System.Drawing.Size(23, 22);
            this.Кисть.Text = "Кисть";
            this.Кисть.Click += new System.EventHandler(this.Кисть_Click);
            // 
            // Ластик
            // 
            this.Ластик.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Ластик.Image = ((System.Drawing.Image)(resources.GetObject("Ластик.Image")));
            this.Ластик.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Ластик.Name = "Ластик";
            this.Ластик.Size = new System.Drawing.Size(23, 22);
            this.Ластик.Text = "Ластик";
            this.Ластик.Click += new System.EventHandler(this.Ластик_Click);
            // 
            // Заливка
            // 
            this.Заливка.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Заливка.Image = ((System.Drawing.Image)(resources.GetObject("Заливка.Image")));
            this.Заливка.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Заливка.Name = "Заливка";
            this.Заливка.Size = new System.Drawing.Size(23, 22);
            this.Заливка.Text = "Заливка";
            this.Заливка.Click += new System.EventHandler(this.Заливка_Click);
            // 
            // Текст
            // 
            this.Текст.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Текст.Image = ((System.Drawing.Image)(resources.GetObject("Текст.Image")));
            this.Текст.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Текст.Name = "Текст";
            this.Текст.Size = new System.Drawing.Size(23, 22);
            this.Текст.Text = "Текст";
            this.Текст.Click += new System.EventHandler(this.Текст_Click);
            // 
            // Прямоугольник
            // 
            this.Прямоугольник.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Прямоугольник.Image = ((System.Drawing.Image)(resources.GetObject("Прямоугольник.Image")));
            this.Прямоугольник.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Прямоугольник.Name = "Прямоугольник";
            this.Прямоугольник.Size = new System.Drawing.Size(23, 22);
            this.Прямоугольник.Text = "Прямоугольник";
            this.Прямоугольник.Click += new System.EventHandler(this.Прямоугольник_Click);
            // 
            // Треугольник
            // 
            this.Треугольник.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Треугольник.Image = ((System.Drawing.Image)(resources.GetObject("Треугольник.Image")));
            this.Треугольник.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Треугольник.Name = "Треугольник";
            this.Треугольник.Size = new System.Drawing.Size(23, 22);
            this.Треугольник.Text = "Треугольник";
            this.Треугольник.Click += new System.EventHandler(this.Треугольник_Click);
            // 
            // Линия
            // 
            this.Линия.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Линия.Image = ((System.Drawing.Image)(resources.GetObject("Линия.Image")));
            this.Линия.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Линия.Name = "Линия";
            this.Линия.Size = new System.Drawing.Size(23, 22);
            this.Линия.Text = "Линия";
            this.Линия.Click += new System.EventHandler(this.Линия_Click);
            // 
            // Элипс
            // 
            this.Элипс.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Элипс.Image = ((System.Drawing.Image)(resources.GetObject("Элипс.Image")));
            this.Элипс.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Элипс.Name = "Элипс";
            this.Элипс.Size = new System.Drawing.Size(23, 22);
            this.Элипс.Text = "Элипс";
            this.Элипс.Click += new System.EventHandler(this.Элипс_Click);
            // 
            // FillRectangle
            // 
            this.FillRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FillRectangle.Image = ((System.Drawing.Image)(resources.GetObject("FillRectangle.Image")));
            this.FillRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillRectangle.Name = "FillRectangle";
            this.FillRectangle.Size = new System.Drawing.Size(23, 22);
            this.FillRectangle.Text = "Залитый Прямоугольник";
            this.FillRectangle.Click += new System.EventHandler(this.FillRectangle_Click);
            // 
            // FillEllipse
            // 
            this.FillEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FillEllipse.Image = ((System.Drawing.Image)(resources.GetObject("FillEllipse.Image")));
            this.FillEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillEllipse.Name = "FillEllipse";
            this.FillEllipse.Size = new System.Drawing.Size(23, 22);
            this.FillEllipse.Text = "Залитый Элипс";
            this.FillEllipse.Click += new System.EventHandler(this.FillEllipse_Click);
            // 
            // Inverse
            // 
            this.Inverse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Inverse.Image = ((System.Drawing.Image)(resources.GetObject("Inverse.Image")));
            this.Inverse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Inverse.Name = "Inverse";
            this.Inverse.Size = new System.Drawing.Size(23, 22);
            this.Inverse.Text = "Инверсия Рисунка";
            this.Inverse.Click += new System.EventHandler(this.Inverse_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            this.colorDialog1.HelpRequest += new System.EventHandler(this.pictureBoxColor1_Click);
            // 
            // pictureBoxColor1
            // 
            this.pictureBoxColor1.BackColor = System.Drawing.Color.Blue;
            this.pictureBoxColor1.Location = new System.Drawing.Point(670, 53);
            this.pictureBoxColor1.Name = "pictureBoxColor1";
            this.pictureBoxColor1.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxColor1.TabIndex = 2;
            this.pictureBoxColor1.TabStop = false;
            this.pictureBoxColor1.Click += new System.EventHandler(this.pictureBoxColor1_Click);
            this.pictureBoxColor1.DoubleClick += new System.EventHandler(this.pictureBoxColor1_DoubleClick);
            // 
            // pictureBoxColor2
            // 
            this.pictureBoxColor2.BackColor = System.Drawing.Color.Yellow;
            this.pictureBoxColor2.Location = new System.Drawing.Point(670, 109);
            this.pictureBoxColor2.Name = "pictureBoxColor2";
            this.pictureBoxColor2.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxColor2.TabIndex = 3;
            this.pictureBoxColor2.TabStop = false;
            this.pictureBoxColor2.Click += new System.EventHandler(this.pictureBoxColor2_Click);
            this.pictureBoxColor2.DoubleClick += new System.EventHandler(this.pictureBoxColor2_DoubleClick);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxImage.Location = new System.Drawing.Point(0, 52);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(664, 399);
            this.pictureBoxImage.TabIndex = 4;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxImage_MouseDown);
            this.pictureBoxImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxImage_MouseMove);
            this.pictureBoxImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxImage_MouseUp);
            // 
            // pictureBoxColorSelect
            // 
            this.pictureBoxColorSelect.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxColorSelect.Location = new System.Drawing.Point(671, 166);
            this.pictureBoxColorSelect.Name = "pictureBoxColorSelect";
            this.pictureBoxColorSelect.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxColorSelect.TabIndex = 5;
            this.pictureBoxColorSelect.TabStop = false;
            this.pictureBoxColorSelect.Visible = false;
            this.pictureBoxColorSelect.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxColorSelect_MouseDown);
            this.pictureBoxColorSelect.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxColorSelect_MouseMove);
            this.pictureBoxColorSelect.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxColorSelect_MouseUp);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(670, 222);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(671, 264);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.InverseImage);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(671, 385);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Visible = false;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // colorDialog2
            // 
            this.colorDialog2.FullOpen = true;
            this.colorDialog2.HelpRequest += new System.EventHandler(this.pictureBoxColor2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBoxColorSelect);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.pictureBoxColor2);
            this.Controls.Add(this.pictureBoxColor1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Карандаш;
        private System.Windows.Forms.ToolStripButton Кисть;
        private System.Windows.Forms.ToolStripButton Ластик;
        private System.Windows.Forms.ToolStripButton Заливка;
        private System.Windows.Forms.ToolStripButton Текст;
        private System.Windows.Forms.ToolStripButton Прямоугольник;
        private System.Windows.Forms.ToolStripButton Треугольник;
        private System.Windows.Forms.ToolStripButton Линия;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxColor1;
        private System.Windows.Forms.PictureBox pictureBoxColor2;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.PictureBox pictureBoxColorSelect;
        private System.Windows.Forms.ToolStripButton Элипс;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripMenuItem InverseImageToolStripMenuItem1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripButton FillRectangle;
        private System.Windows.Forms.ToolStripButton FillEllipse;
        private System.Windows.Forms.ToolStripButton Inverse;
    }
}

