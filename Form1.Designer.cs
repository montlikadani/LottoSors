namespace LottoSors {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numberPanel = new System.Windows.Forms.Panel();
            this.sorsolasButton = new System.Windows.Forms.Button();
            this.winningText = new System.Windows.Forms.Label();
            this.playedText = new System.Windows.Forms.Label();
            this.pointText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberPanel
            // 
            this.numberPanel.AutoSize = true;
            this.numberPanel.BackColor = System.Drawing.Color.Azure;
            this.numberPanel.Location = new System.Drawing.Point(12, 12);
            this.numberPanel.Name = "numberPanel";
            this.numberPanel.Size = new System.Drawing.Size(581, 199);
            this.numberPanel.TabIndex = 0;
            // 
            // sorsolasButton
            // 
            this.sorsolasButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sorsolasButton.Image = global::LottoSors.Properties.Resources.shamrock_lucky_icon;
            this.sorsolasButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sorsolasButton.Location = new System.Drawing.Point(171, 366);
            this.sorsolasButton.Name = "sorsolasButton";
            this.sorsolasButton.Size = new System.Drawing.Size(86, 36);
            this.sorsolasButton.TabIndex = 1;
            this.sorsolasButton.Text = "Sorsolás";
            this.sorsolasButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sorsolasButton.UseVisualStyleBackColor = true;
            this.sorsolasButton.Click += new System.EventHandler(this.sorsolasButton_Click);
            // 
            // winningText
            // 
            this.winningText.AutoSize = true;
            this.winningText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.winningText.Location = new System.Drawing.Point(306, 350);
            this.winningText.Name = "winningText";
            this.winningText.Size = new System.Drawing.Size(83, 13);
            this.winningText.TabIndex = 2;
            this.winningText.Text = "Nyerőszámok ->";
            // 
            // playedText
            // 
            this.playedText.AutoSize = true;
            this.playedText.Location = new System.Drawing.Point(306, 378);
            this.playedText.Name = "playedText";
            this.playedText.Size = new System.Drawing.Size(73, 13);
            this.playedText.TabIndex = 3;
            this.playedText.Text = "Megjátszott ->";
            // 
            // pointText
            // 
            this.pointText.AutoSize = true;
            this.pointText.ForeColor = System.Drawing.Color.Red;
            this.pointText.Location = new System.Drawing.Point(306, 401);
            this.pointText.Name = "pointText";
            this.pointText.Size = new System.Drawing.Size(51, 13);
            this.pointText.TabIndex = 4;
            this.pointText.Text = "Találat ->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.pointText);
            this.Controls.Add(this.playedText);
            this.Controls.Add(this.winningText);
            this.Controls.Add(this.sorsolasButton);
            this.Controls.Add(this.numberPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lottósorsolás";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel numberPanel;
        private System.Windows.Forms.Button sorsolasButton;
        private System.Windows.Forms.Label winningText;
        private System.Windows.Forms.Label playedText;
        private System.Windows.Forms.Label pointText;
    }
}

