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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.splitTop = new System.Windows.Forms.SplitContainer();
            this.splitBottom = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTop)).BeginInit();
            this.splitTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitBottom)).BeginInit();
            this.splitBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
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
            this.splitMain.Size = new System.Drawing.Size(1264, 681);
            this.splitMain.SplitterDistance = 350;
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
            this.splitTop.Panel1.Resize += new System.EventHandler(this.splitContainer1_Panel1_Resize_1);
            // 
            // splitTop.Panel2
            // 
            this.splitTop.Panel2.Resize += new System.EventHandler(this.splitContainer1_Panel2_Resize);
            this.splitTop.Size = new System.Drawing.Size(1264, 350);
            this.splitTop.SplitterDistance = 623;
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
            this.splitBottom.Panel1.Resize += new System.EventHandler(this.splitContainer1_Panel1_Resize_1);
            // 
            // splitBottom.Panel2
            // 
            this.splitBottom.Panel2.Resize += new System.EventHandler(this.splitContainer1_Panel2_Resize);
            this.splitBottom.Size = new System.Drawing.Size(1264, 327);
            this.splitBottom.SplitterDistance = 623;
            this.splitBottom.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmMain";
            this.Text = "KronkBoxer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTop)).EndInit();
            this.splitTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitBottom)).EndInit();
            this.splitBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.SplitContainer splitBottom;
        private System.Windows.Forms.SplitContainer splitTop;


    }
}

