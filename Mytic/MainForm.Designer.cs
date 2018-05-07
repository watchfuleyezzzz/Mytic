namespace Mytic
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MarkerPanel = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.ISOUitlButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CleanUtilButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DiskUtilButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TempUtilButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SysUtilButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LogoButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.LogoLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MenuPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoButton)).BeginInit();
            this.SuspendLayout();
            // 
            // MarkerPanel
            // 
            this.MarkerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.MarkerPanel.Location = new System.Drawing.Point(0, 41);
            this.MarkerPanel.Name = "MarkerPanel";
            this.MarkerPanel.Size = new System.Drawing.Size(5, 48);
            this.MarkerPanel.TabIndex = 1;
            this.MarkerPanel.Visible = false;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.MenuPanel.Controls.Add(this.MarkerPanel);
            this.MenuPanel.Controls.Add(this.ISOUitlButton);
            this.MenuPanel.Controls.Add(this.CleanUtilButton);
            this.MenuPanel.Controls.Add(this.DiskUtilButton);
            this.MenuPanel.Controls.Add(this.TempUtilButton);
            this.MenuPanel.Controls.Add(this.SysUtilButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(180, 450);
            this.MenuPanel.TabIndex = 0;
            // 
            // ISOUitlButton
            // 
            this.ISOUitlButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.ISOUitlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.ISOUitlButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ISOUitlButton.BorderRadius = 0;
            this.ISOUitlButton.ButtonText = "ISO Tools";
            this.ISOUitlButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ISOUitlButton.DisabledColor = System.Drawing.Color.Gray;
            this.ISOUitlButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ISOUitlButton.Iconimage = global::Mytic.Properties.Resources.Burn_CD_96px;
            this.ISOUitlButton.Iconimage_right = null;
            this.ISOUitlButton.Iconimage_right_Selected = null;
            this.ISOUitlButton.Iconimage_Selected = null;
            this.ISOUitlButton.IconMarginLeft = 0;
            this.ISOUitlButton.IconMarginRight = 0;
            this.ISOUitlButton.IconRightVisible = true;
            this.ISOUitlButton.IconRightZoom = 0D;
            this.ISOUitlButton.IconVisible = true;
            this.ISOUitlButton.IconZoom = 60D;
            this.ISOUitlButton.IsTab = false;
            this.ISOUitlButton.Location = new System.Drawing.Point(0, 257);
            this.ISOUitlButton.Name = "ISOUitlButton";
            this.ISOUitlButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.ISOUitlButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.ISOUitlButton.OnHoverTextColor = System.Drawing.Color.White;
            this.ISOUitlButton.selected = false;
            this.ISOUitlButton.Size = new System.Drawing.Size(180, 48);
            this.ISOUitlButton.TabIndex = 4;
            this.ISOUitlButton.Text = "ISO Tools";
            this.ISOUitlButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ISOUitlButton.Textcolor = System.Drawing.Color.White;
            this.ISOUitlButton.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISOUitlButton.Click += new System.EventHandler(this.ISOUitlButton_Click);
            // 
            // CleanUtilButton
            // 
            this.CleanUtilButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.CleanUtilButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.CleanUtilButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CleanUtilButton.BorderRadius = 0;
            this.CleanUtilButton.ButtonText = "Clean Tools";
            this.CleanUtilButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CleanUtilButton.DisabledColor = System.Drawing.Color.Gray;
            this.CleanUtilButton.Iconcolor = System.Drawing.Color.Transparent;
            this.CleanUtilButton.Iconimage = global::Mytic.Properties.Resources.Broom_96px;
            this.CleanUtilButton.Iconimage_right = null;
            this.CleanUtilButton.Iconimage_right_Selected = null;
            this.CleanUtilButton.Iconimage_Selected = null;
            this.CleanUtilButton.IconMarginLeft = 0;
            this.CleanUtilButton.IconMarginRight = 0;
            this.CleanUtilButton.IconRightVisible = true;
            this.CleanUtilButton.IconRightZoom = 0D;
            this.CleanUtilButton.IconVisible = true;
            this.CleanUtilButton.IconZoom = 60D;
            this.CleanUtilButton.IsTab = false;
            this.CleanUtilButton.Location = new System.Drawing.Point(0, 203);
            this.CleanUtilButton.Name = "CleanUtilButton";
            this.CleanUtilButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.CleanUtilButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.CleanUtilButton.OnHoverTextColor = System.Drawing.Color.White;
            this.CleanUtilButton.selected = false;
            this.CleanUtilButton.Size = new System.Drawing.Size(180, 48);
            this.CleanUtilButton.TabIndex = 3;
            this.CleanUtilButton.Text = "Clean Tools";
            this.CleanUtilButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CleanUtilButton.Textcolor = System.Drawing.Color.White;
            this.CleanUtilButton.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanUtilButton.Click += new System.EventHandler(this.CleanUtilButton_Click);
            // 
            // DiskUtilButton
            // 
            this.DiskUtilButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.DiskUtilButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.DiskUtilButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DiskUtilButton.BorderRadius = 0;
            this.DiskUtilButton.ButtonText = "Disk Tools";
            this.DiskUtilButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiskUtilButton.DisabledColor = System.Drawing.Color.Gray;
            this.DiskUtilButton.Iconcolor = System.Drawing.Color.Transparent;
            this.DiskUtilButton.Iconimage = global::Mytic.Properties.Resources.HDD_96px;
            this.DiskUtilButton.Iconimage_right = null;
            this.DiskUtilButton.Iconimage_right_Selected = null;
            this.DiskUtilButton.Iconimage_Selected = null;
            this.DiskUtilButton.IconMarginLeft = 0;
            this.DiskUtilButton.IconMarginRight = 0;
            this.DiskUtilButton.IconRightVisible = true;
            this.DiskUtilButton.IconRightZoom = 0D;
            this.DiskUtilButton.IconVisible = true;
            this.DiskUtilButton.IconZoom = 60D;
            this.DiskUtilButton.IsTab = false;
            this.DiskUtilButton.Location = new System.Drawing.Point(0, 149);
            this.DiskUtilButton.Name = "DiskUtilButton";
            this.DiskUtilButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.DiskUtilButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.DiskUtilButton.OnHoverTextColor = System.Drawing.Color.White;
            this.DiskUtilButton.selected = false;
            this.DiskUtilButton.Size = new System.Drawing.Size(180, 48);
            this.DiskUtilButton.TabIndex = 2;
            this.DiskUtilButton.Text = "Disk Tools";
            this.DiskUtilButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DiskUtilButton.Textcolor = System.Drawing.Color.White;
            this.DiskUtilButton.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiskUtilButton.Click += new System.EventHandler(this.DiskUtilButton_Click);
            // 
            // TempUtilButton
            // 
            this.TempUtilButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.TempUtilButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.TempUtilButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TempUtilButton.BorderRadius = 0;
            this.TempUtilButton.ButtonText = "Temperature";
            this.TempUtilButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TempUtilButton.DisabledColor = System.Drawing.Color.Gray;
            this.TempUtilButton.Iconcolor = System.Drawing.Color.Transparent;
            this.TempUtilButton.Iconimage = global::Mytic.Properties.Resources.Temperature_96px;
            this.TempUtilButton.Iconimage_right = null;
            this.TempUtilButton.Iconimage_right_Selected = null;
            this.TempUtilButton.Iconimage_Selected = null;
            this.TempUtilButton.IconMarginLeft = 0;
            this.TempUtilButton.IconMarginRight = 0;
            this.TempUtilButton.IconRightVisible = true;
            this.TempUtilButton.IconRightZoom = 0D;
            this.TempUtilButton.IconVisible = true;
            this.TempUtilButton.IconZoom = 60D;
            this.TempUtilButton.IsTab = false;
            this.TempUtilButton.Location = new System.Drawing.Point(0, 95);
            this.TempUtilButton.Name = "TempUtilButton";
            this.TempUtilButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.TempUtilButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.TempUtilButton.OnHoverTextColor = System.Drawing.Color.White;
            this.TempUtilButton.selected = false;
            this.TempUtilButton.Size = new System.Drawing.Size(180, 48);
            this.TempUtilButton.TabIndex = 1;
            this.TempUtilButton.Text = "Temperature";
            this.TempUtilButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TempUtilButton.Textcolor = System.Drawing.Color.White;
            this.TempUtilButton.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempUtilButton.Click += new System.EventHandler(this.TempButton_Click);
            // 
            // SysUtilButton
            // 
            this.SysUtilButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.SysUtilButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.SysUtilButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SysUtilButton.BorderRadius = 0;
            this.SysUtilButton.ButtonText = "PC Info";
            this.SysUtilButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SysUtilButton.DisabledColor = System.Drawing.Color.Gray;
            this.SysUtilButton.Iconcolor = System.Drawing.Color.Transparent;
            this.SysUtilButton.Iconimage = global::Mytic.Properties.Resources.System_Information_96px;
            this.SysUtilButton.Iconimage_right = null;
            this.SysUtilButton.Iconimage_right_Selected = null;
            this.SysUtilButton.Iconimage_Selected = null;
            this.SysUtilButton.IconMarginLeft = 0;
            this.SysUtilButton.IconMarginRight = 0;
            this.SysUtilButton.IconRightVisible = true;
            this.SysUtilButton.IconRightZoom = 0D;
            this.SysUtilButton.IconVisible = true;
            this.SysUtilButton.IconZoom = 60D;
            this.SysUtilButton.IsTab = false;
            this.SysUtilButton.Location = new System.Drawing.Point(0, 41);
            this.SysUtilButton.Name = "SysUtilButton";
            this.SysUtilButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.SysUtilButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.SysUtilButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SysUtilButton.selected = false;
            this.SysUtilButton.Size = new System.Drawing.Size(180, 48);
            this.SysUtilButton.TabIndex = 0;
            this.SysUtilButton.Text = "PC Info";
            this.SysUtilButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SysUtilButton.Textcolor = System.Drawing.Color.White;
            this.SysUtilButton.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysUtilButton.Click += new System.EventHandler(this.SysUtilButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(180, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(620, 10);
            this.TopPanel.TabIndex = 1;
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.LogoPanel.Controls.Add(this.LogoButton);
            this.LogoPanel.Location = new System.Drawing.Point(228, 10);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(108, 113);
            this.LogoPanel.TabIndex = 2;
            // 
            // LogoButton
            // 
            this.LogoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.LogoButton.Image = ((System.Drawing.Image)(resources.GetObject("LogoButton.Image")));
            this.LogoButton.ImageActive = null;
            this.LogoButton.Location = new System.Drawing.Point(5, 4);
            this.LogoButton.Name = "LogoButton";
            this.LogoButton.Size = new System.Drawing.Size(98, 104);
            this.LogoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoButton.TabIndex = 0;
            this.LogoButton.TabStop = false;
            this.LogoButton.Zoom = 5;
            this.LogoButton.Click += new System.EventHandler(this.LogoButton_Click);
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.LogoLabel.Location = new System.Drawing.Point(314, 149);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(353, 128);
            this.LogoLabel.TabIndex = 3;
            this.LogoLabel.Text = "MYTIC";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogoLabel);
            this.Controls.Add(this.LogoPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Mytic";
            this.MenuPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private Bunifu.Framework.UI.BunifuFlatButton CleanUtilButton;
        private Bunifu.Framework.UI.BunifuFlatButton DiskUtilButton;
        private Bunifu.Framework.UI.BunifuFlatButton TempUtilButton;
        private Bunifu.Framework.UI.BunifuFlatButton SysUtilButton;
        private Bunifu.Framework.UI.BunifuFlatButton ISOUitlButton;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private Bunifu.Framework.UI.BunifuImageButton LogoButton;
        private Bunifu.Framework.UI.BunifuCustomLabel LogoLabel;
        private System.Windows.Forms.Panel MarkerPanel;
    }
}

