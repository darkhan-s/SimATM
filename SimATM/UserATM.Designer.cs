namespace SimATM
{
    partial class userSim
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
            this.recordButton = new System.Windows.Forms.Button();
            this.emptyButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.RHButton = new System.Windows.Forms.Button();
            this.RLButton = new System.Windows.Forms.Button();
            this.LLButton = new System.Windows.Forms.Button();
            this.LHButton = new System.Windows.Forms.Button();
            this.comDisplay = new System.Windows.Forms.Label();
            this.userDisplay = new System.Windows.Forms.Label();
            this.LHLabel = new System.Windows.Forms.Label();
            this.LLLabel = new System.Windows.Forms.Label();
            this.RHLabel = new System.Windows.Forms.Label();
            this.RLLabel = new System.Windows.Forms.Label();
            this.Display = new System.Windows.Forms.Label();
            this.LMButton = new System.Windows.Forms.Button();
            this.RMButton = new System.Windows.Forms.Button();
            this.LMLabel = new System.Windows.Forms.Label();
            this.RMLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // recordButton
            // 
            this.recordButton.BackColor = System.Drawing.Color.Lime;
            this.recordButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.recordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordButton.Font = new System.Drawing.Font("Arial", 8F);
            this.recordButton.Location = new System.Drawing.Point(250, 154);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(50, 50);
            this.recordButton.TabIndex = 0;
            this.recordButton.Text = "Enter";
            this.recordButton.UseVisualStyleBackColor = false;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // emptyButton
            // 
            this.emptyButton.BackColor = System.Drawing.Color.Yellow;
            this.emptyButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.emptyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emptyButton.Font = new System.Drawing.Font("Arial", 8F);
            this.emptyButton.Location = new System.Drawing.Point(250, 200);
            this.emptyButton.Name = "emptyButton";
            this.emptyButton.Size = new System.Drawing.Size(50, 50);
            this.emptyButton.TabIndex = 1;
            this.emptyButton.Text = "Clear";
            this.emptyButton.UseVisualStyleBackColor = false;
            this.emptyButton.Click += new System.EventHandler(this.emptyButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Red;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Arial", 8F);
            this.closeButton.Location = new System.Drawing.Point(250, 250);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(50, 50);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Cancel";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // RHButton
            // 
            this.RHButton.BackColor = System.Drawing.Color.LightGray;
            this.RHButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.RHButton.Location = new System.Drawing.Point(306, 25);
            this.RHButton.Name = "RHButton";
            this.RHButton.Size = new System.Drawing.Size(30, 30);
            this.RHButton.TabIndex = 4;
            this.RHButton.UseVisualStyleBackColor = false;
            this.RHButton.Click += new System.EventHandler(this.RHButton_Click);
            // 
            // RLButton
            // 
            this.RLButton.BackColor = System.Drawing.Color.LightGray;
            this.RLButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.RLButton.Location = new System.Drawing.Point(306, 97);
            this.RLButton.Name = "RLButton";
            this.RLButton.Size = new System.Drawing.Size(30, 30);
            this.RLButton.TabIndex = 5;
            this.RLButton.UseVisualStyleBackColor = false;
            this.RLButton.Click += new System.EventHandler(this.RLButton_Click);
            // 
            // LLButton
            // 
            this.LLButton.BackColor = System.Drawing.Color.LightGray;
            this.LLButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.LLButton.Location = new System.Drawing.Point(64, 97);
            this.LLButton.Name = "LLButton";
            this.LLButton.Size = new System.Drawing.Size(30, 30);
            this.LLButton.TabIndex = 6;
            this.LLButton.UseVisualStyleBackColor = false;
            this.LLButton.Click += new System.EventHandler(this.LLButton_Click);
            // 
            // LHButton
            // 
            this.LHButton.BackColor = System.Drawing.Color.LightGray;
            this.LHButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.LHButton.Location = new System.Drawing.Point(64, 25);
            this.LHButton.Name = "LHButton";
            this.LHButton.Size = new System.Drawing.Size(30, 30);
            this.LHButton.TabIndex = 7;
            this.LHButton.UseVisualStyleBackColor = false;
            this.LHButton.Click += new System.EventHandler(this.LHButton_Click);
            // 
            // comDisplay
            // 
            this.comDisplay.BackColor = System.Drawing.Color.CornflowerBlue;
            this.comDisplay.Font = new System.Drawing.Font("Arial", 9F);
            this.comDisplay.ForeColor = System.Drawing.Color.White;
            this.comDisplay.Location = new System.Drawing.Point(113, 25);
            this.comDisplay.Name = "comDisplay";
            this.comDisplay.Size = new System.Drawing.Size(174, 50);
            this.comDisplay.TabIndex = 8;
            this.comDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userDisplay
            // 
            this.userDisplay.BackColor = System.Drawing.Color.CornflowerBlue;
            this.userDisplay.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDisplay.ForeColor = System.Drawing.Color.White;
            this.userDisplay.Location = new System.Drawing.Point(116, 92);
            this.userDisplay.Name = "userDisplay";
            this.userDisplay.Size = new System.Drawing.Size(171, 50);
            this.userDisplay.TabIndex = 9;
            this.userDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LHLabel
            // 
            this.LHLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LHLabel.Font = new System.Drawing.Font("Arial", 8F);
            this.LHLabel.ForeColor = System.Drawing.Color.White;
            this.LHLabel.Location = new System.Drawing.Point(100, 25);
            this.LHLabel.Name = "LHLabel";
            this.LHLabel.Size = new System.Drawing.Size(70, 30);
            this.LHLabel.TabIndex = 10;
            this.LHLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LLLabel
            // 
            this.LLLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LLLabel.Font = new System.Drawing.Font("Arial", 8F);
            this.LLLabel.ForeColor = System.Drawing.Color.White;
            this.LLLabel.Location = new System.Drawing.Point(100, 92);
            this.LLLabel.Name = "LLLabel";
            this.LLLabel.Size = new System.Drawing.Size(70, 35);
            this.LLLabel.TabIndex = 11;
            this.LLLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RHLabel
            // 
            this.RHLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.RHLabel.Font = new System.Drawing.Font("Arial", 8F);
            this.RHLabel.ForeColor = System.Drawing.Color.White;
            this.RHLabel.Location = new System.Drawing.Point(227, 25);
            this.RHLabel.Name = "RHLabel";
            this.RHLabel.Size = new System.Drawing.Size(70, 30);
            this.RHLabel.TabIndex = 12;
            this.RHLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RLLabel
            // 
            this.RLLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.RLLabel.Font = new System.Drawing.Font("Arial", 8F);
            this.RLLabel.ForeColor = System.Drawing.Color.White;
            this.RLLabel.Location = new System.Drawing.Point(227, 92);
            this.RLLabel.Name = "RLLabel";
            this.RLLabel.Size = new System.Drawing.Size(70, 35);
            this.RLLabel.TabIndex = 13;
            this.RLLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Display.Font = new System.Drawing.Font("Arial", 9F);
            this.Display.ForeColor = System.Drawing.Color.White;
            this.Display.Location = new System.Drawing.Point(100, 9);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(200, 133);
            this.Display.TabIndex = 14;
            // 
            // LMButton
            // 
            this.LMButton.BackColor = System.Drawing.Color.LightGray;
            this.LMButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.LMButton.Location = new System.Drawing.Point(64, 61);
            this.LMButton.Name = "LMButton";
            this.LMButton.Size = new System.Drawing.Size(30, 30);
            this.LMButton.TabIndex = 15;
            this.LMButton.UseVisualStyleBackColor = false;
            this.LMButton.Click += new System.EventHandler(this.LMButton_Click);
            // 
            // RMButton
            // 
            this.RMButton.BackColor = System.Drawing.Color.LightGray;
            this.RMButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.RMButton.Location = new System.Drawing.Point(306, 61);
            this.RMButton.Name = "RMButton";
            this.RMButton.Size = new System.Drawing.Size(30, 30);
            this.RMButton.TabIndex = 16;
            this.RMButton.UseVisualStyleBackColor = false;
            this.RMButton.Click += new System.EventHandler(this.RMButton_Click);
            // 
            // LMLabel
            // 
            this.LMLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LMLabel.Font = new System.Drawing.Font("Arial", 8F);
            this.LMLabel.ForeColor = System.Drawing.Color.White;
            this.LMLabel.Location = new System.Drawing.Point(100, 61);
            this.LMLabel.Name = "LMLabel";
            this.LMLabel.Size = new System.Drawing.Size(70, 30);
            this.LMLabel.TabIndex = 17;
            this.LMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RMLabel
            // 
            this.RMLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.RMLabel.Font = new System.Drawing.Font("Arial", 8F);
            this.RMLabel.ForeColor = System.Drawing.Color.White;
            this.RMLabel.Location = new System.Drawing.Point(230, 61);
            this.RMLabel.Name = "RMLabel";
            this.RMLabel.Size = new System.Drawing.Size(70, 30);
            this.RMLabel.TabIndex = 18;
            this.RMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(386, 388);
            this.Controls.Add(this.RMLabel);
            this.Controls.Add(this.LMLabel);
            this.Controls.Add(this.RMButton);
            this.Controls.Add(this.LMButton);
            this.Controls.Add(this.userDisplay);
            this.Controls.Add(this.LHButton);
            this.Controls.Add(this.LLButton);
            this.Controls.Add(this.RLButton);
            this.Controls.Add(this.RHButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.emptyButton);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.RLLabel);
            this.Controls.Add(this.LLLabel);
            this.Controls.Add(this.comDisplay);
            this.Controls.Add(this.LHLabel);
            this.Controls.Add(this.RHLabel);
            this.Controls.Add(this.Display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "userSim";
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.setupUI);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Button emptyButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button RHButton;
        private System.Windows.Forms.Button RLButton;
        private System.Windows.Forms.Button LLButton;
        private System.Windows.Forms.Button LHButton;
        private System.Windows.Forms.Label comDisplay;
        private System.Windows.Forms.Label userDisplay;
        private System.Windows.Forms.Label LHLabel;
        private System.Windows.Forms.Label LLLabel;
        private System.Windows.Forms.Label RHLabel;
        private System.Windows.Forms.Label RLLabel;
        private System.Windows.Forms.Label Display;
        private System.Windows.Forms.Button LMButton;
        private System.Windows.Forms.Button RMButton;
        private System.Windows.Forms.Label LMLabel;
        private System.Windows.Forms.Label RMLabel;
    }
}