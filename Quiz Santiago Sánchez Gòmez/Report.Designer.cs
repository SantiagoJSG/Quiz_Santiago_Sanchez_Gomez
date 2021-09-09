
namespace Quiz_Santiago_Sánchez_Gòmez
{
    partial class Report
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
            this.rtxtResults = new System.Windows.Forms.RichTextBox();
            this.txtregistro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxtResults
            // 
            this.rtxtResults.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtResults.Location = new System.Drawing.Point(66, 91);
            this.rtxtResults.Name = "rtxtResults";
            this.rtxtResults.Size = new System.Drawing.Size(660, 335);
            this.rtxtResults.TabIndex = 1;
            this.rtxtResults.Text = "";
            // 
            // txtregistro
            // 
            this.txtregistro.AutoSize = true;
            this.txtregistro.Font = new System.Drawing.Font("Oswald", 30F);
            this.txtregistro.Location = new System.Drawing.Point(335, 9);
            this.txtregistro.Name = "txtregistro";
            this.txtregistro.Size = new System.Drawing.Size(144, 68);
            this.txtregistro.TabIndex = 14;
            this.txtregistro.Text = "Reporte";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtregistro);
            this.Controls.Add(this.rtxtResults);
            this.Name = "Report";
            this.Text = "Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtResults;
        private System.Windows.Forms.Label txtregistro;
    }
}