namespace eleitores
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_votosBrancos = new Label();
            lbl_votosValidos = new Label();
            lbl_votosNulos = new Label();
            lbl_Resultado = new Label();
            txt_votosBrancos = new TextBox();
            txt_votosValidos = new TextBox();
            txt_votosNulos = new TextBox();
            btn_resultado = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_votosBrancos
            // 
            lbl_votosBrancos.BackColor = Color.Transparent;
            lbl_votosBrancos.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            lbl_votosBrancos.ForeColor = Color.FromArgb(239, 222, 214);
            lbl_votosBrancos.Location = new Point(14, 20);
            lbl_votosBrancos.Name = "lbl_votosBrancos";
            lbl_votosBrancos.Size = new Size(85, 55);
            lbl_votosBrancos.TabIndex = 1;
            lbl_votosBrancos.Text = "Votos em Brancos :";
            // 
            // lbl_votosValidos
            // 
            lbl_votosValidos.BackColor = Color.Transparent;
            lbl_votosValidos.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            lbl_votosValidos.ForeColor = Color.FromArgb(239, 222, 214);
            lbl_votosValidos.Location = new Point(15, 75);
            lbl_votosValidos.Name = "lbl_votosValidos";
            lbl_votosValidos.Size = new Size(84, 53);
            lbl_votosValidos.TabIndex = 2;
            lbl_votosValidos.Text = "Votos Validos :";
            // 
            // lbl_votosNulos
            // 
            lbl_votosNulos.BackColor = Color.Transparent;
            lbl_votosNulos.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            lbl_votosNulos.ForeColor = Color.FromArgb(239, 222, 214);
            lbl_votosNulos.Location = new Point(14, 128);
            lbl_votosNulos.Name = "lbl_votosNulos";
            lbl_votosNulos.Size = new Size(72, 52);
            lbl_votosNulos.TabIndex = 3;
            lbl_votosNulos.Text = "Votos Nulos :";
            // 
            // lbl_Resultado
            // 
            lbl_Resultado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Resultado.BackColor = Color.Transparent;
            lbl_Resultado.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            lbl_Resultado.ForeColor = Color.FromArgb(239, 222, 214);
            lbl_Resultado.Location = new Point(194, 65);
            lbl_Resultado.Name = "lbl_Resultado";
            lbl_Resultado.Size = new Size(221, 103);
            lbl_Resultado.TabIndex = 4;
            lbl_Resultado.Text = ".";
            // 
            // txt_votosBrancos
            // 
            txt_votosBrancos.BackColor = Color.FromArgb(64, 64, 64);
            txt_votosBrancos.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            txt_votosBrancos.ForeColor = Color.FromArgb(239, 222, 214);
            txt_votosBrancos.Location = new Point(120, 36);
            txt_votosBrancos.Name = "txt_votosBrancos";
            txt_votosBrancos.Size = new Size(61, 26);
            txt_votosBrancos.TabIndex = 5;
            // 
            // txt_votosValidos
            // 
            txt_votosValidos.BackColor = Color.FromArgb(64, 64, 64);
            txt_votosValidos.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            txt_votosValidos.ForeColor = Color.FromArgb(239, 222, 214);
            txt_votosValidos.Location = new Point(120, 87);
            txt_votosValidos.Name = "txt_votosValidos";
            txt_votosValidos.Size = new Size(61, 26);
            txt_votosValidos.TabIndex = 6;
            // 
            // txt_votosNulos
            // 
            txt_votosNulos.BackColor = Color.FromArgb(64, 64, 64);
            txt_votosNulos.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            txt_votosNulos.ForeColor = Color.FromArgb(239, 222, 214);
            txt_votosNulos.Location = new Point(120, 142);
            txt_votosNulos.Name = "txt_votosNulos";
            txt_votosNulos.Size = new Size(61, 26);
            txt_votosNulos.TabIndex = 7;
            // 
            // btn_resultado
            // 
            btn_resultado.Anchor = AnchorStyles.Bottom;
            btn_resultado.BackColor = Color.FromArgb(64, 64, 64);
            btn_resultado.FlatAppearance.BorderColor = Color.Black;
            btn_resultado.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btn_resultado.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_resultado.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btn_resultado.ForeColor = Color.FromArgb(239, 222, 214);
            btn_resultado.Location = new Point(166, 182);
            btn_resultado.Name = "btn_resultado";
            btn_resultado.Size = new Size(98, 37);
            btn_resultado.TabIndex = 8;
            btn_resultado.Text = "Resultado";
            btn_resultado.UseVisualStyleBackColor = false;
            btn_resultado.Click += btn_resultado_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Vice_City_08_a5c9c85d;
            pictureBox1.InitialImage = Properties.Resources._fbd408a0_5795_4ded_99ed_072decdc182e;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(95, 75, 112);
            panel1.Controls.Add(txt_votosBrancos);
            panel1.Controls.Add(lbl_Resultado);
            panel1.Controls.Add(btn_resultado);
            panel1.Controls.Add(txt_votosValidos);
            panel1.Controls.Add(txt_votosNulos);
            panel1.Controls.Add(lbl_votosNulos);
            panel1.Controls.Add(lbl_votosBrancos);
            panel1.Controls.Add(lbl_votosValidos);
            panel1.Location = new Point(167, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 222);
            panel1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Form1";
            Text = "Votos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_votosBrancos;
        private Label lbl_votosValidos;
        private Label lbl_votosNulos;
        private Label lbl_Resultado;
        private TextBox txt_votosBrancos;
        private TextBox txt_votosValidos;
        private TextBox txt_votosNulos;
        private Button btn_resultado;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
