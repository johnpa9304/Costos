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
            this.dgvHorizontal.Location = new System.Drawing.Point(12, 41);
            this.dgvHorizontal.Name = "dgvHorizontal";
            this.dgvHorizontal.Size = new System.Drawing.Size(544, 484);
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
            this.abrirArchivoBtn.Location = new System.Drawing.Point(238, 12);
            this.abrirArchivoBtn.Name = "abrirArchivoBtn";
            this.abrirArchivoBtn.Size = new System.Drawing.Size(75, 23);
            this.abrirArchivoBtn.TabIndex = 1;
            this.abrirArchivoBtn.Text = "Abrir Archivo";
            this.abrirArchivoBtn.UseVisualStyleBackColor = false;
            this.abrirArchivoBtn.Click += new System.EventHandler(this.abrirArchivoBtn_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(13, 13);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(219, 20);
            this.txtPath.TabIndex = 2;
            // 
            // Horizontal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 537);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.abrirArchivoBtn);
            this.Controls.Add(this.dgvHorizontal);
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
    }
}