
namespace GestiondeReservation.UC
{
    partial class ucRoom
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbNum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbNum.Location = new System.Drawing.Point(0, 50);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(22, 25);
            this.lbNum.TabIndex = 0;
            this.lbNum.Text = "0";
            // 
            // ucRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lbNum);
            this.Name = "ucRoom";
            this.Size = new System.Drawing.Size(232, 77);
            this.Load += new System.EventHandler(this.ucRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNum;
        //private System.Windows.Forms.ContextMenuStrip Menu;
        //private System.Windows.Forms.ToolStripMenuItem libérerMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem réserverMenuItem;
    }
}
