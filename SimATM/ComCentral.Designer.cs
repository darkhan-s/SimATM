namespace SimATM
{
    partial class ComCen
    {

        private System.ComponentModel.IContainer components = null;

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
            this.toggleButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.VisualDRStatus = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toggleButton
            // 
            this.toggleButton.BackColor = System.Drawing.Color.LightGray;
            this.toggleButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleButton.Location = new System.Drawing.Point(12, 58);
            this.toggleButton.Name = "toggleButton";
            this.toggleButton.Size = new System.Drawing.Size(120, 40);
            this.toggleButton.TabIndex = 1;
            this.toggleButton.Text = "Switch Data Race";
            this.toggleButton.UseVisualStyleBackColor = false;
            this.toggleButton.Click += new System.EventHandler(this.toggleButton_Click);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.LightGray;
            this.createButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(12, 12);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(120, 40);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Generate ATM";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // VisualDRStatus
            // 
            this.VisualDRStatus.AutoSize = true;
            this.VisualDRStatus.Font = new System.Drawing.Font("Arial", 9F);
            this.VisualDRStatus.Location = new System.Drawing.Point(115, 137);
            this.VisualDRStatus.Name = "VisualDRStatus";
            this.VisualDRStatus.Size = new System.Drawing.Size(0, 15);
            this.VisualDRStatus.TabIndex = 3;
            // 
            // textBox
            // 
            this.textBox.AutoSize = true;
            this.textBox.Font = new System.Drawing.Font("Arial", 9F);
            this.textBox.ForeColor = System.Drawing.Color.LightGray;
            this.textBox.Location = new System.Drawing.Point(9, 137);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(106, 15);
            this.textBox.TabIndex = 4;
            this.textBox.Text = "Data Race Status:";
            // 
            // ComCen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(144, 161);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.VisualDRStatus);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.toggleButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ComCen";
            this.Text = "ATM Simulator";
            this.Load += new System.EventHandler(this.setupComCen);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button toggleButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label VisualDRStatus;
        private System.Windows.Forms.Label textBox;
    }
}

