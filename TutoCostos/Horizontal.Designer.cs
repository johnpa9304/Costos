namespace TutoCostos
{
    partial class Horizontal
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
            this.dgvHorizontal = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.abrirArchivoBtn = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.textAnalisis = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorizontal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHorizontal
            // 
            this.dgvHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHorizontal.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvHorizontal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorizontal.Location = new System.Drawing.Point(16, 50);
            this.dgvHorizontal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHorizontal.Name = "dgvHorizontal";
            this.dgvHorizontal.RowHeadersWidth = 51;
            this.dgvHorizontal.Size = new System.Drawing.Size(771, 596);
            this.dgvHorizontal.TabIndex = 0;
            this.dgvHorizontal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // abrirArchivoBtn
            // 
            this.abrirArchivoBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.abrirArchivoBtn.Location = new System.Drawing.Point(317, 15);
            this.abrirArchivoBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.abrirArchivoBtn.Name = "abrirArchivoBtn";
            this.abrirArchivoBtn.Size = new System.Drawing.Size(100, 28);
            this.abrirArchivoBtn.TabIndex = 1;
            this.abrirArchivoBtn.Text = "Abrir Archivo";
            this.abrirArchivoBtn.UseVisualStyleBackColor = false;
            this.abrirArchivoBtn.Click += new System.EventHandler(this.abrirArchivoBtn_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(17, 16);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(291, 22);
            this.txtPath.TabIndex = 2;
            // 
            // textAnalisis
            // 
            this.textAnalisis.Enabled = false;
            this.textAnalisis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAnalisis.Location = new System.Drawing.Point(836, 50);
            this.textAnalisis.Multiline = true;
            this.textAnalisis.Name = "textAnalisis";
            this.textAnalisis.Size = new System.Drawing.Size(473, 313);
            this.textAnalisis.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(836, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Mostrar Analisis";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Horizontal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textAnalisis);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.abrirArchivoBtn);
            this.Controls.Add(this.dgvHorizontal);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Horizontal";
            this.Text = "Análisis Horizontal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorizontal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHorizontal;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button abrirArchivoBtn;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox textAnalisis;
        private System.Windows.Forms.Button button1;
    }
}