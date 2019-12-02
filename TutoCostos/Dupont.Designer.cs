namespace TutoCostos
{
    partial class Dupont
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
            this.txtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvRazones = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textMargenNeto = new System.Windows.Forms.TextBox();
            this.textRotacionActivos = new System.Windows.Forms.TextBox();
            this.textMultiplicadorCapital = new System.Windows.Forms.TextBox();
            this.textRoa = new System.Windows.Forms.TextBox();
            this.textRoe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textAnalisis = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRazones)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(13, 13);
            this.txtBox.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(339, 22);
            this.txtBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Abrir Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvRazones
            // 
            this.dgvRazones.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvRazones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRazones.Location = new System.Drawing.Point(13, 43);
            this.dgvRazones.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRazones.Name = "dgvRazones";
            this.dgvRazones.RowHeadersWidth = 51;
            this.dgvRazones.Size = new System.Drawing.Size(536, 511);
            this.dgvRazones.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(577, 13);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 26);
            this.button2.TabIndex = 53;
            this.button2.Text = "2017";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(685, 13);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 26);
            this.button3.TabIndex = 54;
            this.button3.Text = "2018";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textMargenNeto
            // 
            this.textMargenNeto.Location = new System.Drawing.Point(727, 66);
            this.textMargenNeto.Name = "textMargenNeto";
            this.textMargenNeto.Size = new System.Drawing.Size(168, 22);
            this.textMargenNeto.TabIndex = 55;
            // 
            // textRotacionActivos
            // 
            this.textRotacionActivos.Location = new System.Drawing.Point(727, 113);
            this.textRotacionActivos.Name = "textRotacionActivos";
            this.textRotacionActivos.Size = new System.Drawing.Size(168, 22);
            this.textRotacionActivos.TabIndex = 56;
            // 
            // textMultiplicadorCapital
            // 
            this.textMultiplicadorCapital.Location = new System.Drawing.Point(727, 157);
            this.textMultiplicadorCapital.Name = "textMultiplicadorCapital";
            this.textMultiplicadorCapital.Size = new System.Drawing.Size(168, 22);
            this.textMultiplicadorCapital.TabIndex = 57;
            // 
            // textRoa
            // 
            this.textRoa.Location = new System.Drawing.Point(727, 201);
            this.textRoa.Name = "textRoa";
            this.textRoa.Size = new System.Drawing.Size(168, 22);
            this.textRoa.TabIndex = 58;
            // 
            // textRoe
            // 
            this.textRoe.Location = new System.Drawing.Point(727, 246);
            this.textRoe.Name = "textRoe";
            this.textRoe.Size = new System.Drawing.Size(168, 22);
            this.textRoe.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Margen Neto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Rotacion de Activos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 17);
            this.label3.TabIndex = 62;
            this.label3.Text = "Multiplicador de Capital";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(668, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 63;
            this.label4.Text = "ROA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(668, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 64;
            this.label5.Text = "ROE";
            // 
            // textAnalisis
            // 
            this.textAnalisis.Enabled = false;
            this.textAnalisis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAnalisis.Location = new System.Drawing.Point(927, 43);
            this.textAnalisis.Multiline = true;
            this.textAnalisis.Name = "textAnalisis";
            this.textAnalisis.Size = new System.Drawing.Size(473, 313);
            this.textAnalisis.TabIndex = 65;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(927, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 23);
            this.button4.TabIndex = 66;
            this.button4.Text = "Mostrar Analisis";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Dupont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 578);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textAnalisis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textRoe);
            this.Controls.Add(this.textRoa);
            this.Controls.Add(this.textMultiplicadorCapital);
            this.Controls.Add(this.textRotacionActivos);
            this.Controls.Add(this.textMargenNeto);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvRazones);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox);
            this.Name = "Dupont";
            this.Text = "Dupont";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRazones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvRazones;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textMargenNeto;
        private System.Windows.Forms.TextBox textRotacionActivos;
        private System.Windows.Forms.TextBox textMultiplicadorCapital;
        private System.Windows.Forms.TextBox textRoa;
        private System.Windows.Forms.TextBox textRoe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textAnalisis;
        private System.Windows.Forms.Button button4;
    }
}