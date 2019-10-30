namespace MindustryMod
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonTitleMin = new System.Windows.Forms.PictureBox();
            this.buttonTitleMax = new System.Windows.Forms.PictureBox();
            this.buttonTitleClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHider = new System.Windows.Forms.Panel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabProject = new System.Windows.Forms.TabPage();
            this.tabBasic = new System.Windows.Forms.TabPage();
            this.tabBasic1 = new MindustryMod.TabPage.TabBasic();
            this.tabBlock = new System.Windows.Forms.TabPage();
            this.tabItem = new System.Windows.Forms.TabPage();
            this.tabSound = new System.Windows.Forms.TabPage();
            this.tabImage = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSound = new MindustryMod.FormControl.NanoNavigationButton();
            this.buttonImage = new MindustryMod.FormControl.NanoNavigationButton();
            this.buttonItem = new MindustryMod.FormControl.NanoNavigationButton();
            this.buttonBlock = new MindustryMod.FormControl.NanoNavigationButton();
            this.buttonBasic = new MindustryMod.FormControl.NanoNavigationButton();
            this.buttonProject = new MindustryMod.FormControl.NanoNavigationButton();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonTitleMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonTitleMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonTitleClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabBasic.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Controls.Add(this.buttonTitleMin);
            this.panelTitle.Controls.Add(this.buttonTitleMax);
            this.panelTitle.Controls.Add(this.buttonTitleClose);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1280, 30);
            this.panelTitle.TabIndex = 0;
            this.panelTitle.DoubleClick += new System.EventHandler(this.panelTitle_DoubleClick);
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.panelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(7, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(223, 14);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Mindusty Mod Editer - Made by Hotkey";
            this.labelTitle.DoubleClick += new System.EventHandler(this.panelTitle_DoubleClick);
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.labelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.labelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            // 
            // buttonTitleMin
            // 
            this.buttonTitleMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTitleMin.Image = global::MindustryMod.Properties.Resources.BtnMin_White;
            this.buttonTitleMin.Location = new System.Drawing.Point(1190, 0);
            this.buttonTitleMin.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTitleMin.Name = "buttonTitleMin";
            this.buttonTitleMin.Size = new System.Drawing.Size(30, 30);
            this.buttonTitleMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonTitleMin.TabIndex = 2;
            this.buttonTitleMin.TabStop = false;
            this.buttonTitleMin.Click += new System.EventHandler(this.buttonTitleMin_Click);
            this.buttonTitleMin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonTitleMin_MouseDown);
            this.buttonTitleMin.MouseLeave += new System.EventHandler(this.buttonTitleMin_MouseLeave);
            // 
            // buttonTitleMax
            // 
            this.buttonTitleMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTitleMax.Image = global::MindustryMod.Properties.Resources.BtnMax_White;
            this.buttonTitleMax.Location = new System.Drawing.Point(1220, 0);
            this.buttonTitleMax.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTitleMax.Name = "buttonTitleMax";
            this.buttonTitleMax.Size = new System.Drawing.Size(30, 30);
            this.buttonTitleMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonTitleMax.TabIndex = 1;
            this.buttonTitleMax.TabStop = false;
            this.buttonTitleMax.Click += new System.EventHandler(this.buttonTitleMax_Click);
            this.buttonTitleMax.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonTitleMax_MouseDown);
            this.buttonTitleMax.MouseLeave += new System.EventHandler(this.buttonTitleMax_MouseLeave);
            // 
            // buttonTitleClose
            // 
            this.buttonTitleClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTitleClose.Image = global::MindustryMod.Properties.Resources.BtnClose_White;
            this.buttonTitleClose.Location = new System.Drawing.Point(1250, 0);
            this.buttonTitleClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTitleClose.Name = "buttonTitleClose";
            this.buttonTitleClose.Size = new System.Drawing.Size(30, 30);
            this.buttonTitleClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonTitleClose.TabIndex = 0;
            this.buttonTitleClose.TabStop = false;
            this.buttonTitleClose.Click += new System.EventHandler(this.buttonTitleClose_Click);
            this.buttonTitleClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonTitleClose_MouseDown);
            this.buttonTitleClose.MouseLeave += new System.EventHandler(this.buttonTitleClose_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 690);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelHider);
            this.panel1.Controls.Add(this.tabControlMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(230, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 690);
            this.panel1.TabIndex = 2;
            // 
            // panelHider
            // 
            this.panelHider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHider.Location = new System.Drawing.Point(0, 668);
            this.panelHider.Name = "panelHider";
            this.panelHider.Size = new System.Drawing.Size(1050, 1);
            this.panelHider.TabIndex = 0;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabProject);
            this.tabControlMain.Controls.Add(this.tabBasic);
            this.tabControlMain.Controls.Add(this.tabBlock);
            this.tabControlMain.Controls.Add(this.tabItem);
            this.tabControlMain.Controls.Add(this.tabSound);
            this.tabControlMain.Controls.Add(this.tabImage);
            this.tabControlMain.Location = new System.Drawing.Point(-4, -8);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1058, 698);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlMain.TabIndex = 1;
            // 
            // tabProject
            // 
            this.tabProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(225)))));
            this.tabProject.Location = new System.Drawing.Point(4, 4);
            this.tabProject.Name = "tabProject";
            this.tabProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabProject.Size = new System.Drawing.Size(1050, 672);
            this.tabProject.TabIndex = 1;
            this.tabProject.Text = "tabProject";
            // 
            // tabBasic
            // 
            this.tabBasic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(225)))));
            this.tabBasic.Controls.Add(this.tabBasic1);
            this.tabBasic.Location = new System.Drawing.Point(4, 4);
            this.tabBasic.Name = "tabBasic";
            this.tabBasic.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasic.Size = new System.Drawing.Size(1050, 672);
            this.tabBasic.TabIndex = 0;
            this.tabBasic.Text = "tabBasic";
            this.tabBasic.Click += new System.EventHandler(this.tabBasic_Click);
            // 
            // tabBasic1
            // 
            this.tabBasic1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabBasic1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(225)))));
            this.tabBasic1.Location = new System.Drawing.Point(0, 0);
            this.tabBasic1.Margin = new System.Windows.Forms.Padding(0);
            this.tabBasic1.Name = "tabBasic1";
            this.tabBasic1.Size = new System.Drawing.Size(1044, 666);
            this.tabBasic1.TabIndex = 0;
            // 
            // tabBlock
            // 
            this.tabBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(225)))));
            this.tabBlock.Location = new System.Drawing.Point(4, 4);
            this.tabBlock.Name = "tabBlock";
            this.tabBlock.Size = new System.Drawing.Size(1050, 672);
            this.tabBlock.TabIndex = 2;
            this.tabBlock.Text = "tabBlock";
            // 
            // tabItem
            // 
            this.tabItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(225)))));
            this.tabItem.Location = new System.Drawing.Point(4, 4);
            this.tabItem.Name = "tabItem";
            this.tabItem.Size = new System.Drawing.Size(1050, 672);
            this.tabItem.TabIndex = 3;
            this.tabItem.Text = "tabItem";
            // 
            // tabSound
            // 
            this.tabSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(225)))));
            this.tabSound.Location = new System.Drawing.Point(4, 4);
            this.tabSound.Name = "tabSound";
            this.tabSound.Size = new System.Drawing.Size(1050, 672);
            this.tabSound.TabIndex = 4;
            this.tabSound.Text = "tabSound";
            // 
            // tabImage
            // 
            this.tabImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(225)))));
            this.tabImage.Location = new System.Drawing.Point(4, 4);
            this.tabImage.Name = "tabImage";
            this.tabImage.Size = new System.Drawing.Size(1050, 672);
            this.tabImage.TabIndex = 5;
            this.tabImage.Text = "tabImage";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel3.Controls.Add(this.buttonSound);
            this.panel3.Controls.Add(this.buttonImage);
            this.panel3.Controls.Add(this.buttonItem);
            this.panel3.Controls.Add(this.buttonBlock);
            this.panel3.Controls.Add(this.buttonBasic);
            this.panel3.Controls.Add(this.buttonProject);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 690);
            this.panel3.TabIndex = 0;
            // 
            // buttonSound
            // 
            this.buttonSound.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.buttonSound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonSound.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonSound.Icon = global::MindustryMod.Properties.Resources.baseline_music_video_white_48dp;
            this.buttonSound.IsSelected = false;
            this.buttonSound.Location = new System.Drawing.Point(0, 263);
            this.buttonSound.Name = "buttonSound";
            this.buttonSound.Size = new System.Drawing.Size(230, 45);
            this.buttonSound.TabIndex = 11;
            this.buttonSound.Text = "Sound Setting";
            this.buttonSound.Click += new System.EventHandler(this.buttonSound_Click);
            // 
            // buttonImage
            // 
            this.buttonImage.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.buttonImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonImage.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonImage.Icon = global::MindustryMod.Properties.Resources.baseline_collections_white_48dp;
            this.buttonImage.IsSelected = false;
            this.buttonImage.Location = new System.Drawing.Point(0, 212);
            this.buttonImage.Name = "buttonImage";
            this.buttonImage.Size = new System.Drawing.Size(230, 45);
            this.buttonImage.TabIndex = 10;
            this.buttonImage.Text = "Image Setting";
            this.buttonImage.Click += new System.EventHandler(this.buttonImage_Click);
            // 
            // buttonItem
            // 
            this.buttonItem.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.buttonItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonItem.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonItem.Icon = global::MindustryMod.Properties.Resources.baseline_category_white_48dp;
            this.buttonItem.IsSelected = false;
            this.buttonItem.Location = new System.Drawing.Point(0, 161);
            this.buttonItem.Name = "buttonItem";
            this.buttonItem.Size = new System.Drawing.Size(230, 45);
            this.buttonItem.TabIndex = 9;
            this.buttonItem.Text = "Item Setting";
            this.buttonItem.Click += new System.EventHandler(this.buttonItem_Click);
            // 
            // buttonBlock
            // 
            this.buttonBlock.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.buttonBlock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonBlock.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonBlock.Icon = global::MindustryMod.Properties.Resources.box__1_;
            this.buttonBlock.IsSelected = false;
            this.buttonBlock.Location = new System.Drawing.Point(0, 110);
            this.buttonBlock.Name = "buttonBlock";
            this.buttonBlock.Size = new System.Drawing.Size(230, 45);
            this.buttonBlock.TabIndex = 8;
            this.buttonBlock.Text = "Block Setting";
            this.buttonBlock.Click += new System.EventHandler(this.buttonBlock_Click);
            // 
            // buttonBasic
            // 
            this.buttonBasic.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.buttonBasic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBasic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonBasic.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonBasic.Icon = global::MindustryMod.Properties.Resources.baseline_home_white_48dp;
            this.buttonBasic.IsSelected = false;
            this.buttonBasic.Location = new System.Drawing.Point(0, 59);
            this.buttonBasic.Name = "buttonBasic";
            this.buttonBasic.Size = new System.Drawing.Size(230, 45);
            this.buttonBasic.TabIndex = 7;
            this.buttonBasic.Text = "Basic Setting";
            this.buttonBasic.Click += new System.EventHandler(this.buttonBasic_Click);
            // 
            // buttonProject
            // 
            this.buttonProject.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.buttonProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.buttonProject.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonProject.Icon = global::MindustryMod.Properties.Resources.baseline_book_white_48dp;
            this.buttonProject.IsSelected = true;
            this.buttonProject.Location = new System.Drawing.Point(0, 8);
            this.buttonProject.Name = "buttonProject";
            this.buttonProject.Size = new System.Drawing.Size(230, 45);
            this.buttonProject.TabIndex = 6;
            this.buttonProject.Text = "Project";
            this.buttonProject.Click += new System.EventHandler(this.buttonProject_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonTitleMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonTitleMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonTitleClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabBasic.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox buttonTitleMin;
        private System.Windows.Forms.PictureBox buttonTitleMax;
        private System.Windows.Forms.PictureBox buttonTitleClose;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabProject;
        private System.Windows.Forms.TabPage tabBasic;
        private System.Windows.Forms.Panel panelHider;
        private System.Windows.Forms.TabPage tabBlock;
        private System.Windows.Forms.TabPage tabItem;
        private System.Windows.Forms.TabPage tabSound;
        private System.Windows.Forms.TabPage tabImage;
        private System.Windows.Forms.Panel panel1;
        private FormControl.NanoNavigationButton buttonBasic;
        private FormControl.NanoNavigationButton buttonProject;
        private FormControl.NanoNavigationButton buttonSound;
        private FormControl.NanoNavigationButton buttonImage;
        private FormControl.NanoNavigationButton buttonItem;
        private FormControl.NanoNavigationButton buttonBlock;
        private TabPage.TabBasic tabBasic1;
    }
}

