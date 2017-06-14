namespace PicWinUSB
{
    partial class PicWinUSB
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PicWinUSB));
            this.BtIniciaADC = new System.Windows.Forms.Button();
            this.AdcBar = new System.Windows.Forms.ProgressBar();
            this.timerADC = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.PicBoxOsciloscopio = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.headerLogo = new ns1.BunifuImageButton();
            this.bunifuImageButton6 = new ns1.BunifuImageButton();
            this.headerTitle = new ns1.BunifuCustomLabel();
            this.container = new System.Windows.Forms.Panel();
            this.bunifuFlatButton5 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton4 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton3 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton2 = new ns1.BunifuFlatButton();
            this.ApagarLeds = new ns1.BunifuFlatButton();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new ns1.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new ns1.BunifuDragControl(this.components);
            this.bunifuImageButton9 = new ns1.BunifuImageButton();
            this.bunifuImageButton8 = new ns1.BunifuImageButton();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuCircleProgressbar1 = new ns1.BunifuCircleProgressbar();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton6 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton7 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton8 = new ns1.BunifuFlatButton();
            this.MovimientoImg = new ns1.BunifuImageButton();
            this.movimientoText = new ns1.BunifuCustomLabel();
            this.temperaturaText = new ns1.BunifuCustomLabel();
            this.luzText = new ns1.BunifuCustomLabel();
            this.gasText = new ns1.BunifuCustomLabel();
            this.gasBar = new ns1.BunifuProgressBar();
            this.luzBar = new ns1.BunifuProgressBar();
            this.temperaturaBar = new ns1.BunifuProgressBar();
            this.OsciloscText = new ns1.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxOsciloscopio)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovimientoImg)).BeginInit();
            this.SuspendLayout();
            // 
            // BtIniciaADC
            // 
            this.BtIniciaADC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtIniciaADC.Location = new System.Drawing.Point(28, 346);
            this.BtIniciaADC.Name = "BtIniciaADC";
            this.BtIniciaADC.Size = new System.Drawing.Size(230, 47);
            this.BtIniciaADC.TabIndex = 3;
            this.BtIniciaADC.Text = "Iniciar lecturas del canal AN0";
            this.BtIniciaADC.UseVisualStyleBackColor = true;
            this.BtIniciaADC.Click += new System.EventHandler(this.BtAdc_Click);
            // 
            // AdcBar
            // 
            this.AdcBar.Location = new System.Drawing.Point(890, 346);
            this.AdcBar.Name = "AdcBar";
            this.AdcBar.Size = new System.Drawing.Size(401, 48);
            this.AdcBar.TabIndex = 4;
            this.AdcBar.Click += new System.EventHandler(this.AdcBar_Click);
            // 
            // timerADC
            // 
            this.timerADC.Interval = 1;
            this.timerADC.Tick += new System.EventHandler(this.timerADC_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(25, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 20);
            this.label9.TabIndex = 84;
            this.label9.Text = "Conversión análogica digital";
            // 
            // PicBoxOsciloscopio
            // 
            this.PicBoxOsciloscopio.BackColor = System.Drawing.Color.White;
            this.PicBoxOsciloscopio.Location = new System.Drawing.Point(890, 66);
            this.PicBoxOsciloscopio.Name = "PicBoxOsciloscopio";
            this.PicBoxOsciloscopio.Size = new System.Drawing.Size(401, 256);
            this.PicBoxOsciloscopio.TabIndex = 85;
            this.PicBoxOsciloscopio.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.AllowDrop = true;
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.header.Controls.Add(this.headerLogo);
            this.header.Controls.Add(this.bunifuImageButton6);
            this.header.Controls.Add(this.headerTitle);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.header.Size = new System.Drawing.Size(1311, 42);
            this.header.TabIndex = 87;
            // 
            // headerLogo
            // 
            this.headerLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.headerLogo.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.headerLogo.Image = ((System.Drawing.Image)(resources.GetObject("headerLogo.Image")));
            this.headerLogo.ImageActive = null;
            this.headerLogo.Location = new System.Drawing.Point(5, 4);
            this.headerLogo.Name = "headerLogo";
            this.headerLogo.Size = new System.Drawing.Size(39, 33);
            this.headerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headerLogo.TabIndex = 7;
            this.headerLogo.TabStop = false;
            this.headerLogo.Zoom = 0;
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.bunifuImageButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton6.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.Image")));
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(1271, 0);
            this.bunifuImageButton6.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Padding = new System.Windows.Forms.Padding(30);
            this.bunifuImageButton6.Size = new System.Drawing.Size(30, 42);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton6.TabIndex = 7;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Zoom = 0;
            this.bunifuImageButton6.Click += new System.EventHandler(this.bunifuImageButton6_Click);
            // 
            // headerTitle
            // 
            this.headerTitle.AutoSize = true;
            this.headerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headerTitle.Location = new System.Drawing.Point(52, 12);
            this.headerTitle.Name = "headerTitle";
            this.headerTitle.Size = new System.Drawing.Size(310, 18);
            this.headerTitle.TabIndex = 8;
            this.headerTitle.Text = "IPN Escuela Superior de Computo - Sensorial";
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.container.Controls.Add(this.OsciloscText);
            this.container.Controls.Add(this.temperaturaBar);
            this.container.Controls.Add(this.luzBar);
            this.container.Controls.Add(this.movimientoText);
            this.container.Controls.Add(this.temperaturaText);
            this.container.Controls.Add(this.luzText);
            this.container.Controls.Add(this.gasText);
            this.container.Controls.Add(this.gasBar);
            this.container.Controls.Add(this.bunifuFlatButton8);
            this.container.Controls.Add(this.MovimientoImg);
            this.container.Controls.Add(this.bunifuFlatButton7);
            this.container.Controls.Add(this.bunifuFlatButton6);
            this.container.Controls.Add(this.bunifuFlatButton1);
            this.container.Controls.Add(this.bunifuFlatButton5);
            this.container.Controls.Add(this.bunifuFlatButton4);
            this.container.Controls.Add(this.bunifuFlatButton3);
            this.container.Controls.Add(this.bunifuFlatButton2);
            this.container.Controls.Add(this.ApagarLeds);
            this.container.Controls.Add(this.PicBoxOsciloscopio);
            this.container.Controls.Add(this.label9);
            this.container.Controls.Add(this.BtIniciaADC);
            this.container.Controls.Add(this.AdcBar);
            this.container.Location = new System.Drawing.Point(0, 178);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1311, 423);
            this.container.TabIndex = 88;
            this.container.Paint += new System.Windows.Forms.PaintEventHandler(this.container_Paint);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.Teal;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "Cambiar Estado Leds";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 90D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(685, 232);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(186, 35);
            this.bunifuFlatButton5.TabIndex = 91;
            this.bunifuFlatButton5.Text = "Cambiar Estado Leds";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.BtLedToggle_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Teal;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Encender Leds";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(685, 191);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(186, 35);
            this.bunifuFlatButton4.TabIndex = 90;
            this.bunifuFlatButton4.Text = "Encender Leds";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.BtLeds_on_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Teal;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Encender Rojo";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(685, 150);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(186, 35);
            this.bunifuFlatButton3.TabIndex = 89;
            this.bunifuFlatButton3.Text = "Encender Rojo";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.BtLed_rojo_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Teal;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Encender Verde";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(685, 109);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(186, 35);
            this.bunifuFlatButton2.TabIndex = 88;
            this.bunifuFlatButton2.Text = "Encender Verde";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.BtLed_verde_Click);
            // 
            // ApagarLeds
            // 
            this.ApagarLeds.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ApagarLeds.BackColor = System.Drawing.Color.Teal;
            this.ApagarLeds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ApagarLeds.BorderRadius = 0;
            this.ApagarLeds.ButtonText = "Apagar Leds";
            this.ApagarLeds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApagarLeds.DisabledColor = System.Drawing.Color.Gray;
            this.ApagarLeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.ApagarLeds.Iconcolor = System.Drawing.Color.Transparent;
            this.ApagarLeds.Iconimage = ((System.Drawing.Image)(resources.GetObject("ApagarLeds.Iconimage")));
            this.ApagarLeds.Iconimage_right = null;
            this.ApagarLeds.Iconimage_right_Selected = null;
            this.ApagarLeds.Iconimage_Selected = null;
            this.ApagarLeds.IconMarginLeft = 0;
            this.ApagarLeds.IconMarginRight = 0;
            this.ApagarLeds.IconRightVisible = true;
            this.ApagarLeds.IconRightZoom = 0D;
            this.ApagarLeds.IconVisible = true;
            this.ApagarLeds.IconZoom = 90D;
            this.ApagarLeds.IsTab = false;
            this.ApagarLeds.Location = new System.Drawing.Point(685, 68);
            this.ApagarLeds.Name = "ApagarLeds";
            this.ApagarLeds.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ApagarLeds.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ApagarLeds.OnHoverTextColor = System.Drawing.Color.White;
            this.ApagarLeds.selected = false;
            this.ApagarLeds.Size = new System.Drawing.Size(186, 35);
            this.ApagarLeds.TabIndex = 87;
            this.ApagarLeds.Text = "Apagar Leds";
            this.ApagarLeds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ApagarLeds.Textcolor = System.Drawing.Color.White;
            this.ApagarLeds.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApagarLeds.Click += new System.EventHandler(this.BtLeds_off_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.headerTitle;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.headerLogo;
            this.bunifuDragControl3.Vertical = true;
            // 
            // bunifuImageButton9
            // 
            this.bunifuImageButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.bunifuImageButton9.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton9.Image")));
            this.bunifuImageButton9.ImageActive = null;
            this.bunifuImageButton9.Location = new System.Drawing.Point(1146, 61);
            this.bunifuImageButton9.Name = "bunifuImageButton9";
            this.bunifuImageButton9.Size = new System.Drawing.Size(145, 92);
            this.bunifuImageButton9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton9.TabIndex = 93;
            this.bunifuImageButton9.TabStop = false;
            this.bunifuImageButton9.Zoom = 0;
            // 
            // bunifuImageButton8
            // 
            this.bunifuImageButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.bunifuImageButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton8.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton8.Image")));
            this.bunifuImageButton8.ImageActive = null;
            this.bunifuImageButton8.Location = new System.Drawing.Point(55, 90);
            this.bunifuImageButton8.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuImageButton8.Name = "bunifuImageButton8";
            this.bunifuImageButton8.Size = new System.Drawing.Size(51, 45);
            this.bunifuImageButton8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton8.TabIndex = 92;
            this.bunifuImageButton8.TabStop = false;
            this.bunifuImageButton8.Zoom = 15;
            this.bunifuImageButton8.Click += new System.EventHandler(this.bunifuImageButton8_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(142, 69);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(288, 37);
            this.bunifuCustomLabel3.TabIndex = 91;
            this.bunifuCustomLabel3.Text = "GUI para tu sensor";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(151, 110);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(136, 18);
            this.bunifuCustomLabel1.TabIndex = 90;
            this.bunifuCustomLabel1.Text = "Estado del sensor: ";
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = true;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 100;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.bunifuCircleProgressbar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuCircleProgressbar1.LabelVisible = false;
            this.bunifuCircleProgressbar1.LineProgressThickness = 5;
            this.bunifuCircleProgressbar1.LineThickness = 2;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(28, 61);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(103, 103);
            this.bunifuCircleProgressbar1.TabIndex = 89;
            this.bunifuCircleProgressbar1.Value = 60;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Sensor Movimiento";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(32, 67);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(188, 37);
            this.bunifuFlatButton1.TabIndex = 92;
            this.bunifuFlatButton1.Text = "Sensor Movimiento";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.BtPICsuma_Click);
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "Sensor Temperatura";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton6.Iconimage")));
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 90D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(32, 114);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(188, 37);
            this.bunifuFlatButton6.TabIndex = 93;
            this.bunifuFlatButton6.Text = "Sensor Temperatura";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton6.Click += new System.EventHandler(this.BtPICresta_Click);
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "Sensor Gas";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton7.Iconimage")));
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 90D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(32, 162);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(188, 37);
            this.bunifuFlatButton7.TabIndex = 94;
            this.bunifuFlatButton7.Text = "Sensor Gas";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton7.Click += new System.EventHandler(this.BtPICmultiplica_Click);
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 0;
            this.bunifuFlatButton8.ButtonText = "Sensor Luz";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton8.Iconimage")));
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 0;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = true;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = true;
            this.bunifuFlatButton8.IconZoom = 90D;
            this.bunifuFlatButton8.IsTab = false;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(32, 210);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(188, 37);
            this.bunifuFlatButton8.TabIndex = 94;
            this.bunifuFlatButton8.Text = "Sensor Luz";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton8.Click += new System.EventHandler(this.BtPICdivide_Click);
            // 
            // MovimientoImg
            // 
            this.MovimientoImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.MovimientoImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MovimientoImg.Image = ((System.Drawing.Image)(resources.GetObject("MovimientoImg.Image")));
            this.MovimientoImg.ImageActive = null;
            this.MovimientoImg.Location = new System.Drawing.Point(380, 59);
            this.MovimientoImg.Name = "MovimientoImg";
            this.MovimientoImg.Size = new System.Drawing.Size(57, 37);
            this.MovimientoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MovimientoImg.TabIndex = 94;
            this.MovimientoImg.TabStop = false;
            this.MovimientoImg.Zoom = 0;
            // 
            // movimientoText
            // 
            this.movimientoText.AutoSize = true;
            this.movimientoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.movimientoText.ForeColor = System.Drawing.Color.White;
            this.movimientoText.Location = new System.Drawing.Point(233, 71);
            this.movimientoText.Name = "movimientoText";
            this.movimientoText.Size = new System.Drawing.Size(24, 25);
            this.movimientoText.TabIndex = 101;
            this.movimientoText.Text = "0";
            // 
            // temperaturaText
            // 
            this.temperaturaText.AutoSize = true;
            this.temperaturaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.temperaturaText.ForeColor = System.Drawing.Color.White;
            this.temperaturaText.Location = new System.Drawing.Point(233, 121);
            this.temperaturaText.Name = "temperaturaText";
            this.temperaturaText.Size = new System.Drawing.Size(32, 25);
            this.temperaturaText.TabIndex = 100;
            this.temperaturaText.Text = "0°";
            // 
            // luzText
            // 
            this.luzText.AutoSize = true;
            this.luzText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.luzText.ForeColor = System.Drawing.Color.White;
            this.luzText.Location = new System.Drawing.Point(234, 216);
            this.luzText.Name = "luzText";
            this.luzText.Size = new System.Drawing.Size(46, 25);
            this.luzText.TabIndex = 99;
            this.luzText.Text = "0 lx";
            // 
            // gasText
            // 
            this.gasText.AutoSize = true;
            this.gasText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.gasText.ForeColor = System.Drawing.Color.White;
            this.gasText.Location = new System.Drawing.Point(234, 169);
            this.gasText.Name = "gasText";
            this.gasText.Size = new System.Drawing.Size(71, 25);
            this.gasText.TabIndex = 98;
            this.gasText.Text = "0 ppm";
            // 
            // gasBar
            // 
            this.gasBar.BackColor = System.Drawing.Color.Silver;
            this.gasBar.BorderRadius = 5;
            this.gasBar.Location = new System.Drawing.Point(381, 163);
            this.gasBar.MaximumValue = 100;
            this.gasBar.Name = "gasBar";
            this.gasBar.ProgressColor = System.Drawing.Color.Teal;
            this.gasBar.Size = new System.Drawing.Size(273, 32);
            this.gasBar.TabIndex = 95;
            this.gasBar.Value = 0;
            // 
            // luzBar
            // 
            this.luzBar.BackColor = System.Drawing.Color.Silver;
            this.luzBar.BorderRadius = 5;
            this.luzBar.Location = new System.Drawing.Point(381, 209);
            this.luzBar.MaximumValue = 100;
            this.luzBar.Name = "luzBar";
            this.luzBar.ProgressColor = System.Drawing.Color.Teal;
            this.luzBar.Size = new System.Drawing.Size(273, 32);
            this.luzBar.TabIndex = 102;
            this.luzBar.Value = 0;
            // 
            // temperaturaBar
            // 
            this.temperaturaBar.BackColor = System.Drawing.Color.Silver;
            this.temperaturaBar.BorderRadius = 5;
            this.temperaturaBar.Location = new System.Drawing.Point(381, 115);
            this.temperaturaBar.MaximumValue = 100;
            this.temperaturaBar.Name = "temperaturaBar";
            this.temperaturaBar.ProgressColor = System.Drawing.Color.Teal;
            this.temperaturaBar.Size = new System.Drawing.Size(273, 32);
            this.temperaturaBar.TabIndex = 103;
            this.temperaturaBar.Value = 0;
            // 
            // OsciloscText
            // 
            this.OsciloscText.AutoSize = true;
            this.OsciloscText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.OsciloscText.ForeColor = System.Drawing.Color.White;
            this.OsciloscText.Location = new System.Drawing.Point(825, 356);
            this.OsciloscText.Name = "OsciloscText";
            this.OsciloscText.Size = new System.Drawing.Size(42, 25);
            this.OsciloscText.TabIndex = 104;
            this.OsciloscText.Text = "0 u";
            // 
            // PicWinUSB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1311, 602);
            this.Controls.Add(this.bunifuImageButton9);
            this.Controls.Add(this.bunifuImageButton8);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCircleProgressbar1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PicWinUSB";
            this.Text = "ESCOM-IPN (PIC-WinUSB)";
            this.Load += new System.EventHandler(this.PicWinUSB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxOsciloscopio)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovimientoImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtIniciaADC;
        private System.Windows.Forms.ProgressBar AdcBar;
        private System.Windows.Forms.Timer timerADC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox PicBoxOsciloscopio;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel header;
        private ns1.BunifuImageButton headerLogo;
        private ns1.BunifuImageButton bunifuImageButton6;
        private ns1.BunifuCustomLabel headerTitle;
        private System.Windows.Forms.Panel container;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuDragControl bunifuDragControl2;
        private ns1.BunifuDragControl bunifuDragControl3;
        private ns1.BunifuImageButton bunifuImageButton9;
        private ns1.BunifuImageButton bunifuImageButton8;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private ns1.BunifuFlatButton bunifuFlatButton5;
        private ns1.BunifuFlatButton bunifuFlatButton4;
        private ns1.BunifuFlatButton bunifuFlatButton3;
        private ns1.BunifuFlatButton bunifuFlatButton2;
        private ns1.BunifuFlatButton ApagarLeds;
        private ns1.BunifuFlatButton bunifuFlatButton8;
        private ns1.BunifuFlatButton bunifuFlatButton7;
        private ns1.BunifuFlatButton bunifuFlatButton6;
        private ns1.BunifuFlatButton bunifuFlatButton1;
        private ns1.BunifuImageButton MovimientoImg;
        private ns1.BunifuCustomLabel movimientoText;
        private ns1.BunifuCustomLabel temperaturaText;
        private ns1.BunifuCustomLabel luzText;
        private ns1.BunifuCustomLabel gasText;
        private ns1.BunifuProgressBar gasBar;
        private ns1.BunifuProgressBar temperaturaBar;
        private ns1.BunifuProgressBar luzBar;
        private ns1.BunifuCustomLabel OsciloscText;
    }
}

