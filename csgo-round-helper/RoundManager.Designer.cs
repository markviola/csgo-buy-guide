namespace csgo_round_helper
{
    partial class RoundManager
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
            this.CTScoreLabel = new System.Windows.Forms.Label();
            this.scoreColonLabel = new System.Windows.Forms.Label();
            this.TScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CTScoreLabel
            // 
            this.CTScoreLabel.AutoSize = true;
            this.CTScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTScoreLabel.Location = new System.Drawing.Point(479, 9);
            this.CTScoreLabel.Name = "CTScoreLabel";
            this.CTScoreLabel.Size = new System.Drawing.Size(40, 25);
            this.CTScoreLabel.TabIndex = 0;
            this.CTScoreLabel.Text = "CT";
            this.CTScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreColonLabel
            // 
            this.scoreColonLabel.AutoSize = true;
            this.scoreColonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreColonLabel.Location = new System.Drawing.Point(525, 9);
            this.scoreColonLabel.Name = "scoreColonLabel";
            this.scoreColonLabel.Size = new System.Drawing.Size(18, 25);
            this.scoreColonLabel.TabIndex = 1;
            this.scoreColonLabel.Text = ":";
            this.scoreColonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TScoreLabel
            // 
            this.TScoreLabel.AutoSize = true;
            this.TScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TScoreLabel.Location = new System.Drawing.Point(549, 9);
            this.TScoreLabel.Name = "TScoreLabel";
            this.TScoreLabel.Size = new System.Drawing.Size(25, 25);
            this.TScoreLabel.TabIndex = 2;
            this.TScoreLabel.Text = "T";
            this.TScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoundHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 539);
            this.Controls.Add(this.TScoreLabel);
            this.Controls.Add(this.scoreColonLabel);
            this.Controls.Add(this.CTScoreLabel);
            this.Name = "RoundHelper";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CTScoreLabel;
        private System.Windows.Forms.Label scoreColonLabel;
        private System.Windows.Forms.Label TScoreLabel;
    }
}

