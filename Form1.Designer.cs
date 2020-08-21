namespace Esdeger_Direnc_Hesaplama_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelR1 = new System.Windows.Forms.Label();
            this.labelR2 = new System.Windows.Forms.Label();
            this.textBoxR1 = new System.Windows.Forms.TextBox();
            this.textBoxR2 = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.radioButtonParalel = new System.Windows.Forms.RadioButton();
            this.radioButtonSeri = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelR1
            // 
            this.labelR1.AutoSize = true;
            this.labelR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelR1.Location = new System.Drawing.Point(86, 93);
            this.labelR1.Name = "labelR1";
            this.labelR1.Size = new System.Drawing.Size(39, 16);
            this.labelR1.TabIndex = 0;
            this.labelR1.Text = "R1 =";
            // 
            // labelR2
            // 
            this.labelR2.AutoSize = true;
            this.labelR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelR2.Location = new System.Drawing.Point(86, 152);
            this.labelR2.Name = "labelR2";
            this.labelR2.Size = new System.Drawing.Size(39, 16);
            this.labelR2.TabIndex = 0;
            this.labelR2.Text = "R2 =";
            // 
            // textBoxR1
            // 
            this.textBoxR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxR1.Location = new System.Drawing.Point(122, 90);
            this.textBoxR1.Multiline = true;
            this.textBoxR1.Name = "textBoxR1";
            this.textBoxR1.Size = new System.Drawing.Size(104, 26);
            this.textBoxR1.TabIndex = 1;
            this.textBoxR1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxR1_KeyPress);
            // 
            // textBoxR2
            // 
            this.textBoxR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxR2.Location = new System.Drawing.Point(122, 149);
            this.textBoxR2.Multiline = true;
            this.textBoxR2.Name = "textBoxR2";
            this.textBoxR2.Size = new System.Drawing.Size(104, 26);
            this.textBoxR2.TabIndex = 1;
            this.textBoxR2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxR2_KeyPress);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Image = ((System.Drawing.Image)(resources.GetObject("btnHesapla.Image")));
            this.btnHesapla.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHesapla.Location = new System.Drawing.Point(122, 224);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(104, 69);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // radioButtonParalel
            // 
            this.radioButtonParalel.AutoSize = true;
            this.radioButtonParalel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonParalel.Location = new System.Drawing.Point(329, 146);
            this.radioButtonParalel.Name = "radioButtonParalel";
            this.radioButtonParalel.Size = new System.Drawing.Size(98, 22);
            this.radioButtonParalel.TabIndex = 3;
            this.radioButtonParalel.TabStop = true;
            this.radioButtonParalel.Text = "PARALEL";
            this.radioButtonParalel.UseVisualStyleBackColor = true;
            // 
            // radioButtonSeri
            // 
            this.radioButtonSeri.AutoSize = true;
            this.radioButtonSeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonSeri.Location = new System.Drawing.Point(329, 90);
            this.radioButtonSeri.Name = "radioButtonSeri";
            this.radioButtonSeri.Size = new System.Drawing.Size(64, 22);
            this.radioButtonSeri.TabIndex = 3;
            this.radioButtonSeri.TabStop = true;
            this.radioButtonSeri.Text = "SERİ";
            this.radioButtonSeri.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(152, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(460, 339);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonSeri);
            this.Controls.Add(this.radioButtonParalel);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.textBoxR2);
            this.Controls.Add(this.textBoxR1);
            this.Controls.Add(this.labelR2);
            this.Controls.Add(this.labelR1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelR1;
        private System.Windows.Forms.Label labelR2;
        private System.Windows.Forms.TextBox textBoxR1;
        private System.Windows.Forms.TextBox textBoxR2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.RadioButton radioButtonParalel;
        private System.Windows.Forms.RadioButton radioButtonSeri;
        private System.Windows.Forms.Label label3;
    }
}

