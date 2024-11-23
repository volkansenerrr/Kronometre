namespace Kronometre
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
            this.components = new System.ComponentModel.Container();
            this.lbl_zaman = new System.Windows.Forms.Label();
            this.btn_baslat = new System.Windows.Forms.Button();
            this.btn_durdur = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_sifirla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_zaman
            // 
            this.lbl_zaman.AutoSize = true;
            this.lbl_zaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_zaman.Location = new System.Drawing.Point(361, 134);
            this.lbl_zaman.Name = "lbl_zaman";
            this.lbl_zaman.Size = new System.Drawing.Size(90, 25);
            this.lbl_zaman.TabIndex = 0;
            this.lbl_zaman.Text = "00:00:00";
            // 
            // btn_baslat
            // 
            this.btn_baslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_baslat.Location = new System.Drawing.Point(246, 199);
            this.btn_baslat.Name = "btn_baslat";
            this.btn_baslat.Size = new System.Drawing.Size(93, 49);
            this.btn_baslat.TabIndex = 1;
            this.btn_baslat.Text = "Başlat";
            this.btn_baslat.UseVisualStyleBackColor = true;
            this.btn_baslat.Click += new System.EventHandler(this.btn_baslat_Click);
            // 
            // btn_durdur
            // 
            this.btn_durdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_durdur.Location = new System.Drawing.Point(360, 199);
            this.btn_durdur.Name = "btn_durdur";
            this.btn_durdur.Size = new System.Drawing.Size(92, 49);
            this.btn_durdur.TabIndex = 2;
            this.btn_durdur.Text = "Durdur";
            this.btn_durdur.UseVisualStyleBackColor = true;
            this.btn_durdur.Click += new System.EventHandler(this.btn_durdur_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_sifirla
            // 
            this.btn_sifirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sifirla.Location = new System.Drawing.Point(473, 199);
            this.btn_sifirla.Name = "btn_sifirla";
            this.btn_sifirla.Size = new System.Drawing.Size(97, 49);
            this.btn_sifirla.TabIndex = 3;
            this.btn_sifirla.Text = "Sıfırla";
            this.btn_sifirla.UseVisualStyleBackColor = true;
            this.btn_sifirla.Click += new System.EventHandler(this.btn_sifirla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sifirla);
            this.Controls.Add(this.btn_durdur);
            this.Controls.Add(this.btn_baslat);
            this.Controls.Add(this.lbl_zaman);
            this.Name = "Form1";
            this.Text = "Kronometre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_zaman;
        private System.Windows.Forms.Button btn_baslat;
        private System.Windows.Forms.Button btn_durdur;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_sifirla;
    }
}

