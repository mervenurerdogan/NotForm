namespace NotForm
{
    partial class Form1
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
            this.DersIdTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OrtBtn = new System.Windows.Forms.Button();
            this.GuncelBtn = new System.Windows.Forms.Button();
            this.SilBtn = new System.Windows.Forms.Button();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OrtlamaTxt = new System.Windows.Forms.TextBox();
            this.FinalTxt = new System.Windows.Forms.TextBox();
            this.VizeTxt = new System.Windows.Forms.TextBox();
            this.DersAdiTxt = new System.Windows.Forms.TextBox();
            this.DersKoduTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DersIdTxt
            // 
            this.DersIdTxt.Enabled = false;
            this.DersIdTxt.Location = new System.Drawing.Point(165, 26);
            this.DersIdTxt.Name = "DersIdTxt";
            this.DersIdTxt.Size = new System.Drawing.Size(120, 20);
            this.DersIdTxt.TabIndex = 33;
            this.DersIdTxt.TextChanged += new System.EventHandler(this.DersIdTxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(54, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ders ID:";
            // 
            // OrtBtn
            // 
            this.OrtBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.OrtBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OrtBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.OrtBtn.Location = new System.Drawing.Point(573, 228);
            this.OrtBtn.Name = "OrtBtn";
            this.OrtBtn.Size = new System.Drawing.Size(132, 40);
            this.OrtBtn.TabIndex = 31;
            this.OrtBtn.Text = "ORTALAMA";
            this.OrtBtn.UseVisualStyleBackColor = false;
            this.OrtBtn.Click += new System.EventHandler(this.OrtBtn_Click);
            // 
            // GuncelBtn
            // 
            this.GuncelBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.GuncelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GuncelBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.GuncelBtn.Location = new System.Drawing.Point(439, 229);
            this.GuncelBtn.Name = "GuncelBtn";
            this.GuncelBtn.Size = new System.Drawing.Size(132, 40);
            this.GuncelBtn.TabIndex = 30;
            this.GuncelBtn.Text = "GÜNCELLE";
            this.GuncelBtn.UseVisualStyleBackColor = false;
            this.GuncelBtn.Click += new System.EventHandler(this.GuncelBtn_Click);
            // 
            // SilBtn
            // 
            this.SilBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SilBtn.Location = new System.Drawing.Point(573, 172);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(132, 40);
            this.SilBtn.TabIndex = 29;
            this.SilBtn.Text = "SİL";
            this.SilBtn.UseVisualStyleBackColor = false;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // EkleBtn
            // 
            this.EkleBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.EkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EkleBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.EkleBtn.Location = new System.Drawing.Point(439, 172);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(132, 40);
            this.EkleBtn.TabIndex = 28;
            this.EkleBtn.Text = "EKLE";
            this.EkleBtn.UseVisualStyleBackColor = false;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(692, 200);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(58, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ortalama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(54, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Final Notu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(54, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Vize Notu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(54, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ders  Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(54, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ders Kodu:";
            // 
            // OrtlamaTxt
            // 
            this.OrtlamaTxt.Location = new System.Drawing.Point(165, 239);
            this.OrtlamaTxt.Name = "OrtlamaTxt";
            this.OrtlamaTxt.Size = new System.Drawing.Size(120, 20);
            this.OrtlamaTxt.TabIndex = 21;
            // 
            // FinalTxt
            // 
            this.FinalTxt.Location = new System.Drawing.Point(165, 192);
            this.FinalTxt.Name = "FinalTxt";
            this.FinalTxt.Size = new System.Drawing.Size(120, 20);
            this.FinalTxt.TabIndex = 20;
            // 
            // VizeTxt
            // 
            this.VizeTxt.Location = new System.Drawing.Point(165, 147);
            this.VizeTxt.Name = "VizeTxt";
            this.VizeTxt.Size = new System.Drawing.Size(120, 20);
            this.VizeTxt.TabIndex = 19;
            // 
            // DersAdiTxt
            // 
            this.DersAdiTxt.Location = new System.Drawing.Point(165, 105);
            this.DersAdiTxt.Name = "DersAdiTxt";
            this.DersAdiTxt.Size = new System.Drawing.Size(120, 20);
            this.DersAdiTxt.TabIndex = 18;
            // 
            // DersKoduTxt
            // 
            this.DersKoduTxt.Location = new System.Drawing.Point(165, 63);
            this.DersKoduTxt.Name = "DersKoduTxt";
            this.DersKoduTxt.Size = new System.Drawing.Size(120, 20);
            this.DersKoduTxt.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(820, 486);
            this.Controls.Add(this.DersIdTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OrtBtn);
            this.Controls.Add(this.GuncelBtn);
            this.Controls.Add(this.SilBtn);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrtlamaTxt);
            this.Controls.Add(this.FinalTxt);
            this.Controls.Add(this.VizeTxt);
            this.Controls.Add(this.DersAdiTxt);
            this.Controls.Add(this.DersKoduTxt);
            this.Name = "Form1";
            this.Text = "NotHesapla";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DersIdTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button OrtBtn;
        private System.Windows.Forms.Button GuncelBtn;
        private System.Windows.Forms.Button SilBtn;
        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OrtlamaTxt;
        private System.Windows.Forms.TextBox FinalTxt;
        private System.Windows.Forms.TextBox VizeTxt;
        private System.Windows.Forms.TextBox DersAdiTxt;
        private System.Windows.Forms.TextBox DersKoduTxt;
    }
}

