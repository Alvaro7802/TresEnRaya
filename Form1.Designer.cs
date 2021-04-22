namespace TresEnRaya
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cerrarBTO = new FontAwesome.Sharp.IconButton();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.textplayer1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textplayer2 = new System.Windows.Forms.TextBox();
            this.playBto = new FontAwesome.Sharp.IconButton();
            this.tres_Raya = new System.Windows.Forms.PictureBox();
            this.A1 = new System.Windows.Forms.PictureBox();
            this.A2 = new System.Windows.Forms.PictureBox();
            this.A3 = new System.Windows.Forms.PictureBox();
            this.B2 = new System.Windows.Forms.PictureBox();
            this.B3 = new System.Windows.Forms.PictureBox();
            this.C2 = new System.Windows.Forms.PictureBox();
            this.C3 = new System.Windows.Forms.PictureBox();
            this.B1 = new System.Windows.Forms.PictureBox();
            this.C1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tres_Raya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C1)).BeginInit();
            this.SuspendLayout();
            // 
            // cerrarBTO
            // 
            this.cerrarBTO.BackColor = System.Drawing.Color.Transparent;
            this.cerrarBTO.FlatAppearance.BorderSize = 0;
            this.cerrarBTO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cerrarBTO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cerrarBTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarBTO.ForeColor = System.Drawing.Color.Transparent;
            this.cerrarBTO.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.cerrarBTO.IconColor = System.Drawing.Color.Black;
            this.cerrarBTO.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cerrarBTO.Location = new System.Drawing.Point(980, 12);
            this.cerrarBTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cerrarBTO.Name = "cerrarBTO";
            this.cerrarBTO.Size = new System.Drawing.Size(75, 49);
            this.cerrarBTO.TabIndex = 0;
            this.cerrarBTO.UseVisualStyleBackColor = false;
            this.cerrarBTO.Click += new System.EventHandler(this.cerrarBTO_Click_1);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Noto Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(27, 68);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(312, 28);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre del Jugador 1";
            // 
            // textplayer1
            // 
            this.textplayer1.Font = new System.Drawing.Font("Noto Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textplayer1.Location = new System.Drawing.Point(32, 110);
            this.textplayer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textplayer1.Name = "textplayer1";
            this.textplayer1.Size = new System.Drawing.Size(176, 23);
            this.textplayer1.TabIndex = 2;
            this.textplayer1.TextChanged += new System.EventHandler(this.textplayer1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Noto Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del Jugador 2";
            // 
            // textplayer2
            // 
            this.textplayer2.Font = new System.Drawing.Font("Noto Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textplayer2.Location = new System.Drawing.Point(32, 203);
            this.textplayer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textplayer2.Name = "textplayer2";
            this.textplayer2.Size = new System.Drawing.Size(176, 23);
            this.textplayer2.TabIndex = 4;
            this.textplayer2.TextChanged += new System.EventHandler(this.textplayer2_TextChanged);
            // 
            // playBto
            // 
            this.playBto.BackColor = System.Drawing.Color.Transparent;
            this.playBto.FlatAppearance.BorderSize = 0;
            this.playBto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playBto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playBto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playBto.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.playBto.IconColor = System.Drawing.Color.Black;
            this.playBto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.playBto.Location = new System.Drawing.Point(99, 282);
            this.playBto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playBto.Name = "playBto";
            this.playBto.Size = new System.Drawing.Size(119, 80);
            this.playBto.TabIndex = 5;
            this.playBto.UseVisualStyleBackColor = false;
            this.playBto.Click += new System.EventHandler(this.playBto_Click);
            // 
            // tres_Raya
            // 
            this.tres_Raya.BackColor = System.Drawing.Color.Transparent;
            this.tres_Raya.Image = global::TresEnRaya.Properties.Resources.ttt_board;
            this.tres_Raya.Location = new System.Drawing.Point(455, 46);
            this.tres_Raya.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tres_Raya.Name = "tres_Raya";
            this.tres_Raya.Size = new System.Drawing.Size(520, 444);
            this.tres_Raya.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tres_Raya.TabIndex = 6;
            this.tres_Raya.TabStop = false;
            this.tres_Raya.Click += new System.EventHandler(this.tres_Raya_Click);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.Transparent;
            this.A1.Location = new System.Drawing.Point(471, 68);
            this.A1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(133, 90);
            this.A1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A1.TabIndex = 13;
            this.A1.TabStop = false;
            this.A1.Click += new System.EventHandler(this.A1_Click);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.Transparent;
            this.A2.Location = new System.Drawing.Point(471, 218);
            this.A2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(133, 84);
            this.A2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A2.TabIndex = 14;
            this.A2.TabStop = false;
            this.A2.Click += new System.EventHandler(this.A2_Click);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.Transparent;
            this.A3.Location = new System.Drawing.Point(471, 368);
            this.A3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(133, 86);
            this.A3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A3.TabIndex = 15;
            this.A3.TabStop = false;
            this.A3.Click += new System.EventHandler(this.A3_Click);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.Transparent;
            this.B2.Location = new System.Drawing.Point(649, 218);
            this.B2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(133, 84);
            this.B2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.B2.TabIndex = 17;
            this.B2.TabStop = false;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.Transparent;
            this.B3.Location = new System.Drawing.Point(649, 368);
            this.B3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(133, 86);
            this.B3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.B3.TabIndex = 18;
            this.B3.TabStop = false;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.Transparent;
            this.C2.Location = new System.Drawing.Point(827, 218);
            this.C2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(133, 84);
            this.C2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C2.TabIndex = 20;
            this.C2.TabStop = false;
            this.C2.Click += new System.EventHandler(this.C2_Click);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.Transparent;
            this.C3.Location = new System.Drawing.Point(827, 368);
            this.C3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(133, 86);
            this.C3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C3.TabIndex = 21;
            this.C3.TabStop = false;
            this.C3.Click += new System.EventHandler(this.C3_Click);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.Transparent;
            this.B1.Location = new System.Drawing.Point(649, 68);
            this.B1.Margin = new System.Windows.Forms.Padding(4);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(133, 90);
            this.B1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.B1.TabIndex = 22;
            this.B1.TabStop = false;
            this.B1.Click += new System.EventHandler(this.B1_Click_1);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.Transparent;
            this.C1.Location = new System.Drawing.Point(827, 68);
            this.C1.Margin = new System.Windows.Forms.Padding(4);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(133, 90);
            this.C1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C1.TabIndex = 23;
            this.C1.TabStop = false;
            this.C1.Click += new System.EventHandler(this.C1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TresEnRaya.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.tres_Raya);
            this.Controls.Add(this.playBto);
            this.Controls.Add(this.textplayer2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textplayer1);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.cerrarBTO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tres_Raya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FontAwesome.Sharp.IconButton cerrarBTO;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox textplayer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textplayer2;
        private FontAwesome.Sharp.IconButton playBto;
        private System.Windows.Forms.PictureBox tres_Raya;
        private System.Windows.Forms.PictureBox A1;
        private System.Windows.Forms.PictureBox A2;
        private System.Windows.Forms.PictureBox A3;
        private System.Windows.Forms.PictureBox B2;
        private System.Windows.Forms.PictureBox B3;
        private System.Windows.Forms.PictureBox C2;
        private System.Windows.Forms.PictureBox C3;
        private System.Windows.Forms.PictureBox B1;
        private System.Windows.Forms.PictureBox C1;
    }
}

