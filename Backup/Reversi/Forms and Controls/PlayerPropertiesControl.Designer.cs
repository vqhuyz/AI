namespace Reversi.Controls
{
    partial class PlayerPropertiesControl
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
            this.grbPlayerProperties = new System.Windows.Forms.GroupBox();
            this.cmbMaxDepth = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblMaxDepth = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.grbPlayerProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPlayerProperties
            // 
            this.grbPlayerProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grbPlayerProperties.Controls.Add(this.cmbMaxDepth);
            this.grbPlayerProperties.Controls.Add(this.txtName);
            this.grbPlayerProperties.Controls.Add(this.lblMaxDepth);
            this.grbPlayerProperties.Controls.Add(this.lblName);
            this.grbPlayerProperties.Controls.Add(this.lblType);
            this.grbPlayerProperties.Controls.Add(this.cmbType);
            this.grbPlayerProperties.Location = new System.Drawing.Point(0, 0);
            this.grbPlayerProperties.Name = "grbPlayerProperties";
            this.grbPlayerProperties.Size = new System.Drawing.Size(178, 100);
            this.grbPlayerProperties.TabIndex = 0;
            this.grbPlayerProperties.TabStop = false;
            this.grbPlayerProperties.Text = "Player color";
            // 
            // cmbMaxDepth
            // 
            this.cmbMaxDepth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMaxDepth.FormattingEnabled = true;
            this.cmbMaxDepth.Location = new System.Drawing.Point(72, 72);
            this.cmbMaxDepth.Name = "cmbMaxDepth";
            this.cmbMaxDepth.Size = new System.Drawing.Size(100, 21);
            this.cmbMaxDepth.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(72, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblMaxDepth
            // 
            this.lblMaxDepth.AutoSize = true;
            this.lblMaxDepth.Location = new System.Drawing.Point(6, 72);
            this.lblMaxDepth.Name = "lblMaxDepth";
            this.lblMaxDepth.Size = new System.Drawing.Size(60, 13);
            this.lblMaxDepth.TabIndex = 4;
            this.lblMaxDepth.Text = "Max. depth";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 19);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(72, 19);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(100, 21);
            this.cmbType.TabIndex = 1;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // PlayerPropertiesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbPlayerProperties);
            this.Name = "PlayerPropertiesControl";
            this.Size = new System.Drawing.Size(178, 100);
            this.grbPlayerProperties.ResumeLayout(false);
            this.grbPlayerProperties.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPlayerProperties;
        private System.Windows.Forms.ComboBox cmbMaxDepth;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblMaxDepth;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
    }
}