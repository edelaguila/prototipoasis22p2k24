﻿
namespace Capa_Vista_Reporteria
{
    partial class visualizar
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.direccion_reporte = new System.Windows.Forms.TextBox();
            this.ReporteExamen1 = new Capa_Vista_Reporteria.ReporteExamen();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.ReporteExamen1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(788, 430);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // direccion_reporte
            // 
            this.direccion_reporte.Location = new System.Drawing.Point(478, 238);
            this.direccion_reporte.Name = "direccion_reporte";
            this.direccion_reporte.Size = new System.Drawing.Size(202, 20);
            this.direccion_reporte.TabIndex = 1;
            this.direccion_reporte.Visible = false;
            // 
            // visualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 430);
            this.Controls.Add(this.direccion_reporte);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "visualizar";
            this.Text = "visualizar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TextBox direccion_reporte;
        private ReporteExamen ReporteExamen1;
    }
}