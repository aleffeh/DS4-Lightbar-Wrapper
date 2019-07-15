namespace Tester
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.bTrack = new System.Windows.Forms.TrackBar();
            this.gTrack = new System.Windows.Forms.TrackBar();
            this.rTrack = new System.Windows.Forms.TrackBar();
            this.rLbl = new System.Windows.Forms.Label();
            this.gLbl = new System.Windows.Forms.Label();
            this.bLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bTrack
            // 
            this.bTrack.LargeChange = 1;
            this.bTrack.Location = new System.Drawing.Point(40, 216);
            this.bTrack.Maximum = 255;
            this.bTrack.Name = "bTrack";
            this.bTrack.Size = new System.Drawing.Size(232, 45);
            this.bTrack.TabIndex = 3;
            this.bTrack.Scroll += new System.EventHandler(this.BTrack_Scroll);
            // 
            // gTrack
            // 
            this.gTrack.LargeChange = 1;
            this.gTrack.Location = new System.Drawing.Point(40, 165);
            this.gTrack.Maximum = 255;
            this.gTrack.Name = "gTrack";
            this.gTrack.Size = new System.Drawing.Size(232, 45);
            this.gTrack.TabIndex = 4;
            this.gTrack.Scroll += new System.EventHandler(this.GTrack_Scroll);
            // 
            // rTrack
            // 
            this.rTrack.LargeChange = 1;
            this.rTrack.Location = new System.Drawing.Point(40, 114);
            this.rTrack.Maximum = 255;
            this.rTrack.Name = "rTrack";
            this.rTrack.Size = new System.Drawing.Size(232, 45);
            this.rTrack.TabIndex = 5;
            this.rTrack.Scroll += new System.EventHandler(this.RTrack_Scroll);
            // 
            // rLbl
            // 
            this.rLbl.AutoSize = true;
            this.rLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLbl.Location = new System.Drawing.Point(311, 118);
            this.rLbl.Name = "rLbl";
            this.rLbl.Size = new System.Drawing.Size(18, 20);
            this.rLbl.TabIndex = 6;
            this.rLbl.Text = "0";
            // 
            // gLbl
            // 
            this.gLbl.AutoSize = true;
            this.gLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gLbl.Location = new System.Drawing.Point(311, 169);
            this.gLbl.Name = "gLbl";
            this.gLbl.Size = new System.Drawing.Size(18, 20);
            this.gLbl.TabIndex = 7;
            this.gLbl.Text = "0";
            // 
            // bLbl
            // 
            this.bLbl.AutoSize = true;
            this.bLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLbl.Location = new System.Drawing.Point(311, 220);
            this.bLbl.Name = "bLbl";
            this.bLbl.Size = new System.Drawing.Size(18, 20);
            this.bLbl.TabIndex = 8;
            this.bLbl.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "G";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "R";
            // 
            // pbResult
            // 
            this.pbResult.BackColor = System.Drawing.Color.Black;
            this.pbResult.Location = new System.Drawing.Point(276, 34);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(53, 50);
            this.pbResult.TabIndex = 12;
            this.pbResult.TabStop = false;
            // 
            // txtHex
            // 
            this.txtHex.Location = new System.Drawing.Point(60, 279);
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(198, 20);
            this.txtHex.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "hex:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 38);
            this.button2.TabIndex = 15;
            this.button2.Text = "Definir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 319);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.pbResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bLbl);
            this.Controls.Add(this.gLbl);
            this.Controls.Add(this.rLbl);
            this.Controls.Add(this.rTrack);
            this.Controls.Add(this.gTrack);
            this.Controls.Add(this.bTrack);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar bTrack;
        private System.Windows.Forms.TrackBar gTrack;
        private System.Windows.Forms.TrackBar rTrack;
        private System.Windows.Forms.Label rLbl;
        private System.Windows.Forms.Label gLbl;
        private System.Windows.Forms.Label bLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

