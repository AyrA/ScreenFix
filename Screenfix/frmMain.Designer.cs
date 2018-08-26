namespace Screenfix
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnFixAll = new System.Windows.Forms.Button();
            this.btnFixOne = new System.Windows.Forms.Button();
            this.cbScreen = new System.Windows.Forms.ComboBox();
            this.lblWarn = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnFlash = new System.Windows.Forms.Button();
            this.pPreview = new System.Windows.Forms.Panel();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnFixAll
            // 
            this.btnFixAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFixAll.Location = new System.Drawing.Point(12, 12);
            this.btnFixAll.Name = "btnFixAll";
            this.btnFixAll.Size = new System.Drawing.Size(368, 23);
            this.btnFixAll.TabIndex = 0;
            this.btnFixAll.Text = "Fix all Screens";
            this.btnFixAll.UseVisualStyleBackColor = true;
            this.btnFixAll.Click += new System.EventHandler(this.btnFixAll_Click);
            // 
            // btnFixOne
            // 
            this.btnFixOne.Location = new System.Drawing.Point(12, 41);
            this.btnFixOne.Name = "btnFixOne";
            this.btnFixOne.Size = new System.Drawing.Size(139, 23);
            this.btnFixOne.TabIndex = 1;
            this.btnFixOne.Text = "Fix this screen only";
            this.btnFixOne.UseVisualStyleBackColor = true;
            this.btnFixOne.Click += new System.EventHandler(this.btnFixOne_Click);
            // 
            // cbScreen
            // 
            this.cbScreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbScreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScreen.FormattingEnabled = true;
            this.cbScreen.Location = new System.Drawing.Point(157, 43);
            this.cbScreen.Name = "cbScreen";
            this.cbScreen.Size = new System.Drawing.Size(167, 21);
            this.cbScreen.TabIndex = 2;
            // 
            // lblWarn
            // 
            this.lblWarn.AutoSize = true;
            this.lblWarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarn.ForeColor = System.Drawing.Color.Red;
            this.lblWarn.Location = new System.Drawing.Point(12, 86);
            this.lblWarn.Name = "lblWarn";
            this.lblWarn.Size = new System.Drawing.Size(126, 26);
            this.lblWarn.TabIndex = 4;
            this.lblWarn.Text = "WARNING";
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.AutoEllipsis = true;
            this.lblInfo.Location = new System.Drawing.Point(14, 124);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(366, 140);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // btnFlash
            // 
            this.btnFlash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFlash.Location = new System.Drawing.Point(330, 41);
            this.btnFlash.Name = "btnFlash";
            this.btnFlash.Size = new System.Drawing.Size(50, 23);
            this.btnFlash.TabIndex = 3;
            this.btnFlash.Text = "Flash";
            this.btnFlash.UseVisualStyleBackColor = true;
            this.btnFlash.Click += new System.EventHandler(this.btnFlash_Click);
            // 
            // pPreview
            // 
            this.pPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPreview.Location = new System.Drawing.Point(340, 70);
            this.pPreview.Name = "pPreview";
            this.pPreview.Size = new System.Drawing.Size(40, 40);
            this.pPreview.TabIndex = 6;
            this.ttMain.SetToolTip(this.pPreview, "Current Pattern");
            // 
            // ttMain
            // 
            this.ttMain.AutoPopDelay = 10000;
            this.ttMain.InitialDelay = 100;
            this.ttMain.ReshowDelay = 1;
            this.ttMain.ToolTipTitle = "ScreenFix";
            this.ttMain.UseAnimation = false;
            this.ttMain.UseFading = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 273);
            this.Controls.Add(this.pPreview);
            this.Controls.Add(this.btnFlash);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblWarn);
            this.Controls.Add(this.cbScreen);
            this.Controls.Add(this.btnFixOne);
            this.Controls.Add(this.btnFixAll);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "frmMain";
            this.Text = "ScreenFix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFixAll;
        private System.Windows.Forms.Button btnFixOne;
        private System.Windows.Forms.ComboBox cbScreen;
        private System.Windows.Forms.Label lblWarn;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnFlash;
        private System.Windows.Forms.Panel pPreview;
        private System.Windows.Forms.ToolTip ttMain;
    }
}

