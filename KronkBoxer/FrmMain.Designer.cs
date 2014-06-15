namespace KronkBoxer
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.splitTop = new System.Windows.Forms.SplitContainer();
            this.splitBottom = new System.Windows.Forms.SplitContainer();
            this.stsBottom = new System.Windows.Forms.StatusStrip();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.chkAutoTeleport = new System.Windows.Forms.CheckBox();
            this.btnConfigKeys = new System.Windows.Forms.Button();
            this.tbxMainPlayer = new System.Windows.Forms.TextBox();
            this.tbxClientPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClientBrowse = new System.Windows.Forms.Button();
            this.numClients = new System.Windows.Forms.NumericUpDown();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.imlToggle = new System.Windows.Forms.ImageList(this.components);
            this.lblPerformance = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tmrChecker = new System.Windows.Forms.Timer(this.components);
            this.lblTPCountdown = new System.Windows.Forms.Label();
            this.btnFocus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTop)).BeginInit();
            this.splitTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitBottom)).BeginInit();
            this.splitBottom.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numClients)).BeginInit();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitMain.BackColor = System.Drawing.Color.DimGray;
            this.splitMain.Location = new System.Drawing.Point(0, 39);
            this.splitMain.Name = "splitMain";
            this.splitMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.splitTop);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.splitBottom);
            this.splitMain.Size = new System.Drawing.Size(784, 500);
            this.splitMain.SplitterDistance = 247;
            this.splitMain.TabIndex = 0;
            // 
            // splitTop
            // 
            this.splitTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTop.Location = new System.Drawing.Point(0, 0);
            this.splitTop.Name = "splitTop";
            // 
            // splitTop.Panel1
            // 
            this.splitTop.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // splitTop.Panel2
            // 
            this.splitTop.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitTop.Size = new System.Drawing.Size(784, 247);
            this.splitTop.SplitterDistance = 390;
            this.splitTop.TabIndex = 3;
            // 
            // splitBottom
            // 
            this.splitBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitBottom.Location = new System.Drawing.Point(0, 0);
            this.splitBottom.Name = "splitBottom";
            // 
            // splitBottom.Panel1
            // 
            this.splitBottom.Panel1.BackColor = System.Drawing.Color.Silver;
            // 
            // splitBottom.Panel2
            // 
            this.splitBottom.Panel2.BackColor = System.Drawing.Color.DarkGray;
            this.splitBottom.Size = new System.Drawing.Size(784, 249);
            this.splitBottom.SplitterDistance = 390;
            this.splitBottom.TabIndex = 4;
            // 
            // stsBottom
            // 
            this.stsBottom.Location = new System.Drawing.Point(0, 539);
            this.stsBottom.Name = "stsBottom";
            this.stsBottom.Size = new System.Drawing.Size(784, 22);
            this.stsBottom.TabIndex = 1;
            this.stsBottom.Text = "statusStrip1";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.Gray;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.btnFocus);
            this.pnlHeader.Controls.Add(this.lblTPCountdown);
            this.pnlHeader.Controls.Add(this.chkAutoTeleport);
            this.pnlHeader.Controls.Add(this.btnConfigKeys);
            this.pnlHeader.Controls.Add(this.tbxMainPlayer);
            this.pnlHeader.Controls.Add(this.tbxClientPath);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.btnClientBrowse);
            this.pnlHeader.Controls.Add(this.numClients);
            this.pnlHeader.Controls.Add(this.btnPause);
            this.pnlHeader.Controls.Add(this.btnToggle);
            this.pnlHeader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pnlHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHeader.Location = new System.Drawing.Point(-1, -1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(786, 39);
            this.pnlHeader.TabIndex = 2;
            // 
            // chkAutoTeleport
            // 
            this.chkAutoTeleport.AutoSize = true;
            this.chkAutoTeleport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkAutoTeleport.Location = new System.Drawing.Point(162, 3);
            this.chkAutoTeleport.Name = "chkAutoTeleport";
            this.chkAutoTeleport.Size = new System.Drawing.Size(113, 19);
            this.chkAutoTeleport.TabIndex = 9;
            this.chkAutoTeleport.Text = "Auto teleport to:";
            this.chkAutoTeleport.UseVisualStyleBackColor = true;
            this.chkAutoTeleport.CheckedChanged += new System.EventHandler(this.chkAutoTeleport_CheckedChanged);
            // 
            // btnConfigKeys
            // 
            this.btnConfigKeys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfigKeys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnConfigKeys.FlatAppearance.BorderSize = 0;
            this.btnConfigKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigKeys.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigKeys.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfigKeys.Image = ((System.Drawing.Image)(resources.GetObject("btnConfigKeys.Image")));
            this.btnConfigKeys.Location = new System.Drawing.Point(565, 3);
            this.btnConfigKeys.Name = "btnConfigKeys";
            this.btnConfigKeys.Size = new System.Drawing.Size(39, 31);
            this.btnConfigKeys.TabIndex = 8;
            this.btnConfigKeys.TabStop = false;
            this.btnConfigKeys.UseVisualStyleBackColor = false;
            this.btnConfigKeys.Click += new System.EventHandler(this.btnConfigKeys_Click);
            // 
            // tbxMainPlayer
            // 
            this.tbxMainPlayer.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMainPlayer.Location = new System.Drawing.Point(275, 3);
            this.tbxMainPlayer.Name = "tbxMainPlayer";
            this.tbxMainPlayer.Size = new System.Drawing.Size(87, 18);
            this.tbxMainPlayer.TabIndex = 7;
            this.tbxMainPlayer.TabStop = false;
            this.tbxMainPlayer.Text = "PlayerName";
            // 
            // tbxClientPath
            // 
            this.tbxClientPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxClientPath.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxClientPath.Location = new System.Drawing.Point(607, 3);
            this.tbxClientPath.Name = "tbxClientPath";
            this.tbxClientPath.Size = new System.Drawing.Size(174, 18);
            this.tbxClientPath.TabIndex = 4;
            this.tbxClientPath.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(605, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Client";
            // 
            // btnClientBrowse
            // 
            this.btnClientBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientBrowse.BackColor = System.Drawing.Color.DarkGray;
            this.btnClientBrowse.FlatAppearance.BorderSize = 0;
            this.btnClientBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientBrowse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientBrowse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClientBrowse.ImageIndex = 0;
            this.btnClientBrowse.Location = new System.Drawing.Point(716, 14);
            this.btnClientBrowse.Name = "btnClientBrowse";
            this.btnClientBrowse.Size = new System.Drawing.Size(64, 20);
            this.btnClientBrowse.TabIndex = 5;
            this.btnClientBrowse.TabStop = false;
            this.btnClientBrowse.Text = "Browse";
            this.btnClientBrowse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClientBrowse.UseVisualStyleBackColor = false;
            this.btnClientBrowse.Click += new System.EventHandler(this.btnClientBrowse_Click);
            // 
            // numClients
            // 
            this.numClients.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.numClients.Location = new System.Drawing.Point(113, 3);
            this.numClients.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numClients.Name = "numClients";
            this.numClients.Size = new System.Drawing.Size(43, 32);
            this.numClients.TabIndex = 3;
            this.numClients.TabStop = false;
            this.numClients.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(128)))), ((int)(((byte)(30)))));
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.Location = new System.Drawing.Point(71, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(39, 31);
            this.btnPause.TabIndex = 1;
            this.btnPause.TabStop = false;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnToggle
            // 
            this.btnToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(170)))), ((int)(((byte)(60)))));
            this.btnToggle.FlatAppearance.BorderSize = 0;
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnToggle.ImageIndex = 0;
            this.btnToggle.ImageList = this.imlToggle;
            this.btnToggle.Location = new System.Drawing.Point(3, 3);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(64, 31);
            this.btnToggle.TabIndex = 0;
            this.btnToggle.TabStop = false;
            this.btnToggle.UseVisualStyleBackColor = false;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // imlToggle
            // 
            this.imlToggle.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlToggle.ImageStream")));
            this.imlToggle.TransparentColor = System.Drawing.Color.Transparent;
            this.imlToggle.Images.SetKeyName(0, "play-32.gif");
            this.imlToggle.Images.SetKeyName(1, "stop-32.gif");
            // 
            // lblPerformance
            // 
            this.lblPerformance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPerformance.AutoSize = true;
            this.lblPerformance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerformance.Location = new System.Drawing.Point(647, 543);
            this.lblPerformance.Name = "lblPerformance";
            this.lblPerformance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPerformance.Size = new System.Drawing.Size(115, 15);
            this.lblPerformance.TabIndex = 0;
            this.lblPerformance.Text = "CPU 0%  |  RAM 50%";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(0, 543);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 15);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Stopped";
            // 
            // tmrChecker
            // 
            this.tmrChecker.Enabled = true;
            this.tmrChecker.Interval = 1000;
            this.tmrChecker.Tick += new System.EventHandler(this.tmrChecker_Tick);
            // 
            // lblTPCountdown
            // 
            this.lblTPCountdown.AutoSize = true;
            this.lblTPCountdown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTPCountdown.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTPCountdown.Location = new System.Drawing.Point(161, 19);
            this.lblTPCountdown.Name = "lblTPCountdown";
            this.lblTPCountdown.Size = new System.Drawing.Size(105, 15);
            this.lblTPCountdown.TabIndex = 10;
            this.lblTPCountdown.Text = "Teleporting in 10...";
            this.lblTPCountdown.Visible = false;
            // 
            // btnFocus
            // 
            this.btnFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFocus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(170)))), ((int)(((byte)(60)))));
            this.btnFocus.FlatAppearance.BorderSize = 0;
            this.btnFocus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFocus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFocus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFocus.ImageIndex = 0;
            this.btnFocus.Location = new System.Drawing.Point(391, 3);
            this.btnFocus.Name = "btnFocus";
            this.btnFocus.Size = new System.Drawing.Size(170, 31);
            this.btnFocus.TabIndex = 11;
            this.btnFocus.TabStop = false;
            this.btnFocus.Text = "Click here to broadcast keys";
            this.btnFocus.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPerformance);
            this.Controls.Add(this.stsBottom);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.splitMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmMain";
            this.Text = "KronkBoxer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmMain_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTop)).EndInit();
            this.splitTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitBottom)).EndInit();
            this.splitBottom.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.SplitContainer splitBottom;
        private System.Windows.Forms.SplitContainer splitTop;
        private System.Windows.Forms.StatusStrip stsBottom;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblPerformance;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.ImageList imlToggle;
        private System.Windows.Forms.NumericUpDown numClients;
        private System.Windows.Forms.TextBox tbxClientPath;
        private System.Windows.Forms.Button btnClientBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer tmrChecker;
        private System.Windows.Forms.Button btnConfigKeys;
        private System.Windows.Forms.TextBox tbxMainPlayer;
        private System.Windows.Forms.CheckBox chkAutoTeleport;
        private System.Windows.Forms.Label lblTPCountdown;
        private System.Windows.Forms.Button btnFocus;


    }
}

