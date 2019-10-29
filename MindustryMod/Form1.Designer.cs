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
            this.buttonTitleMin = new System.Windows.Forms.PictureBox();
            this.buttonTitleMax = new System.Windows.Forms.PictureBox();
            this.buttonTitleClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonTitleMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonTitleMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonTitleClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
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
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 690);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 690);
            this.panel3.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(8, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(228, 12);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Mindusty Mod Editer - Made by Hotkey";
            this.labelTitle.DoubleClick += new System.EventHandler(this.panelTitle_DoubleClick);
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.labelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.labelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
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
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonTitleMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonTitleMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonTitleClose)).EndInit();
            this.panel2.ResumeLayout(false);
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
    }
}

