
namespace KutuphaneSistemi
{
    partial class PersonelBilgileri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelBilgileri));
            this.datagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnGetir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtArama = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnAra = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.DoubleBuffered = true;
            this.datagrid.EnableHeadersVisualStyles = false;
            this.datagrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagrid.HeaderBgColor = System.Drawing.Color.CadetBlue;
            this.datagrid.HeaderForeColor = System.Drawing.Color.CadetBlue;
            this.datagrid.Location = new System.Drawing.Point(12, 54);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagrid.Size = new System.Drawing.Size(770, 368);
            this.datagrid.TabIndex = 0;
            // 
            // btnGetir
            // 
            this.btnGetir.ActiveBorderThickness = 1;
            this.btnGetir.ActiveCornerRadius = 20;
            this.btnGetir.ActiveFillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetir.ActiveForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetir.ActiveLineColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetir.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGetir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetir.BackgroundImage")));
            this.btnGetir.ButtonText = "TÜM BİLGİLERİ GETİR";
            this.btnGetir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetir.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnGetir.IdleBorderThickness = 1;
            this.btnGetir.IdleCornerRadius = 20;
            this.btnGetir.IdleFillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetir.IdleForecolor = System.Drawing.Color.CadetBlue;
            this.btnGetir.IdleLineColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetir.Location = new System.Drawing.Point(292, 430);
            this.btnGetir.Margin = new System.Windows.Forms.Padding(5);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(233, 58);
            this.btnGetir.TabIndex = 2;
            this.btnGetir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // txtArama
            // 
            this.txtArama.BackColor = System.Drawing.Color.CadetBlue;
            this.txtArama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtArama.BackgroundImage")));
            this.txtArama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtArama.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtArama.Icon = ((System.Drawing.Image)(resources.GetObject("txtArama.Icon")));
            this.txtArama.Location = new System.Drawing.Point(118, 4);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(388, 42);
            this.txtArama.TabIndex = 4;
            this.txtArama.text = "Aramak İstediğiniz Personel Adını ve Soyadını Girin";
            // 
            // btnAra
            // 
            this.btnAra.ActiveBorderThickness = 1;
            this.btnAra.ActiveCornerRadius = 20;
            this.btnAra.ActiveFillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAra.ActiveForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAra.ActiveLineColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAra.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAra.BackgroundImage")));
            this.btnAra.ButtonText = "ARA";
            this.btnAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnAra.IdleBorderThickness = 1;
            this.btnAra.IdleCornerRadius = 20;
            this.btnAra.IdleFillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAra.IdleForecolor = System.Drawing.Color.CadetBlue;
            this.btnAra.IdleLineColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAra.Location = new System.Drawing.Point(514, 4);
            this.btnAra.Margin = new System.Windows.Forms.Padding(5);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(134, 42);
            this.btnAra.TabIndex = 5;
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // PersonelBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(793, 491);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.datagrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonelBilgileri";
            this.Text = "PersonelBilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid datagrid;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGetir;
        private Bunifu.Framework.UI.BunifuTextbox txtArama;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAra;
    }
}