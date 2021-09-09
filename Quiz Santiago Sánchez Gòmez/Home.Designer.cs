
namespace Quiz_Santiago_Sánchez_Gòmez
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtxtResults = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtfacultad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtregistro = new System.Windows.Forms.Label();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtResults
            // 
            this.rtxtResults.Font = new System.Drawing.Font("Oswald", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtResults.Location = new System.Drawing.Point(518, 100);
            this.rtxtResults.Name = "rtxtResults";
            this.rtxtResults.Size = new System.Drawing.Size(208, 227);
            this.rtxtResults.TabIndex = 0;
            this.rtxtResults.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 20F);
            this.label1.Location = new System.Drawing.Point(46, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Oswald", 20F);
            this.label2.Location = new System.Drawing.Point(56, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Correo:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Oswald", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(167, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(182, 49);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Registrar Asistencia";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Oswald", 20F);
            this.label3.Location = new System.Drawing.Point(46, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Facultad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Oswald", 20F);
            this.label4.Location = new System.Drawing.Point(100, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 46);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Oswald", 20F);
            this.label5.Location = new System.Drawing.Point(64, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 46);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha:";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Oswald", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(167, 100);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(269, 37);
            this.txtnombre.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Oswald", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(167, 151);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(269, 37);
            this.txtID.TabIndex = 8;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Font = new System.Drawing.Font("Oswald", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.Location = new System.Drawing.Point(167, 197);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(269, 37);
            this.txtcorreo.TabIndex = 9;
            // 
            // txtfacultad
            // 
            this.txtfacultad.Font = new System.Drawing.Font("Oswald", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfacultad.Location = new System.Drawing.Point(167, 248);
            this.txtfacultad.Name = "txtfacultad";
            this.txtfacultad.Size = new System.Drawing.Size(269, 37);
            this.txtfacultad.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Oswald", 30F);
            this.label6.Location = new System.Drawing.Point(94, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(353, 68);
            this.label6.TabIndex = 12;
            this.label6.Text = "Información Necesaria";
            // 
            // txtregistro
            // 
            this.txtregistro.AutoSize = true;
            this.txtregistro.Font = new System.Drawing.Font("Oswald", 30F);
            this.txtregistro.Location = new System.Drawing.Point(548, 9);
            this.txtregistro.Name = "txtregistro";
            this.txtregistro.Size = new System.Drawing.Size(150, 68);
            this.txtregistro.TabIndex = 13;
            this.txtregistro.Text = "Registro";
            // 
            // dtfecha
            // 
            this.dtfecha.Location = new System.Drawing.Point(167, 307);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(269, 20);
            this.dtfecha.TabIndex = 14;
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Oswald", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(581, 359);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(87, 49);
            this.btnReport.TabIndex = 15;
            this.btnReport.Text = "Reporte";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.dtfecha);
            this.Controls.Add(this.txtregistro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtfacultad);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtResults);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtfacultad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtregistro;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.Button btnReport;
    }
}

