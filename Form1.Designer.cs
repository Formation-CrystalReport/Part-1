namespace Basicsofcrystalreport
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.CryReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport_HelloWord1 = new Basicsofcrystalreport.CrystalRepport.CrystalReport_HelloWord();
            this.SuspendLayout();
            // 
            // CryReport
            // 
            this.CryReport.ActiveViewIndex = 0;
            this.CryReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CryReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.CryReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CryReport.Location = new System.Drawing.Point(0, 0);
            this.CryReport.Name = "CryReport";
            this.CryReport.ReportSource = this.CrystalReport_HelloWord1;
            this.CryReport.Size = new System.Drawing.Size(665, 340);
            this.CryReport.TabIndex = 0;
            this.CryReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 340);
            this.Controls.Add(this.CryReport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CryReport;
        private CrystalRepport.CrystalReport_HelloWord CrystalReport_HelloWord1;
    }
}

