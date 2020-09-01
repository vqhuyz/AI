namespace Reversi.Controls
{
    partial class PlayerInfoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbPlayerName = new System.Windows.Forms.GroupBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtDiscsCount = new System.Windows.Forms.TextBox();
            this.lblDiscsCount = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.plColor = new System.Windows.Forms.Panel();
            this.grbPlayerName.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPlayerName
            // 
            this.grbPlayerName.BackColor = System.Drawing.SystemColors.Control;
            this.grbPlayerName.Controls.Add(this.plColor);
            this.grbPlayerName.Controls.Add(this.lblColor);
            this.grbPlayerName.Controls.Add(this.txtDiscsCount);
            this.grbPlayerName.Controls.Add(this.lblDiscsCount);
            this.grbPlayerName.Controls.Add(this.txtType);
            this.grbPlayerName.Controls.Add(this.lblType);
            this.grbPlayerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbPlayerName.Location = new System.Drawing.Point(0, 0);
            this.grbPlayerName.Name = "grbPlayerName";
            this.grbPlayerName.Size = new System.Drawing.Size(150, 91);
            this.grbPlayerName.TabIndex = 0;
            this.grbPlayerName.TabStop = false;
            this.grbPlayerName.Text = "Player Name";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblType.Location = new System.Drawing.Point(6, 42);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            // 
            // txtType
            // 
            this.txtType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtType.Location = new System.Drawing.Point(90, 39);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(54, 20);
            this.txtType.TabIndex = 3;
            // 
            // txtDiscsCount
            // 
            this.txtDiscsCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDiscsCount.Location = new System.Drawing.Point(90, 65);
            this.txtDiscsCount.Name = "txtDiscsCount";
            this.txtDiscsCount.ReadOnly = true;
            this.txtDiscsCount.Size = new System.Drawing.Size(54, 20);
            this.txtDiscsCount.TabIndex = 5;
            // 
            // lblDiscsCount
            // 
            this.lblDiscsCount.AutoSize = true;
            this.lblDiscsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDiscsCount.Location = new System.Drawing.Point(6, 68);
            this.lblDiscsCount.Name = "lblDiscsCount";
            this.lblDiscsCount.Size = new System.Drawing.Size(78, 13);
            this.lblDiscsCount.TabIndex = 4;
            this.lblDiscsCount.Text = "Discs on board";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblColor.Location = new System.Drawing.Point(6, 18);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 0;
            this.lblColor.Text = "Color";
            // 
            // plColor
            // 
            this.plColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plColor.Location = new System.Drawing.Point(90, 18);
            this.plColor.Name = "plColor";
            this.plColor.Size = new System.Drawing.Size(32, 16);
            this.plColor.TabIndex = 1;
            // 
            // PlayerInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbPlayerName);
            this.MinimumSize = new System.Drawing.Size(150, 91);
            this.Name = "PlayerInfoControl";
            this.Size = new System.Drawing.Size(150, 91);
            this.grbPlayerName.ResumeLayout(false);
            this.grbPlayerName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPlayerName;
        private System.Windows.Forms.TextBox txtDiscsCount;
        private System.Windows.Forms.Label lblDiscsCount;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Panel plColor;
        private System.Windows.Forms.Label lblColor;
    }
}
