namespace MotoGP
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnCalcular = new Button();
            txtPiloto = new TextBox();
            txtEquipe = new TextBox();
            txtCorridas = new TextBox();
            txtPilotoPoints = new TextBox();
            txtEquipePoints = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 44);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do Piloto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 122);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome da Equipe:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 200);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 2;
            label3.Text = "Corridas Restantes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 284);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 3;
            label4.Text = "Pontuação Piloto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 370);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 4;
            label5.Text = "Pontuação Equipe:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(40, 428);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(185, 51);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtPiloto
            // 
            txtPiloto.Location = new Point(140, 36);
            txtPiloto.Name = "txtPiloto";
            txtPiloto.Size = new Size(154, 23);
            txtPiloto.TabIndex = 6;
            // 
            // txtEquipe
            // 
            txtEquipe.Location = new Point(144, 114);
            txtEquipe.Name = "txtEquipe";
            txtEquipe.Size = new Size(154, 23);
            txtEquipe.TabIndex = 7;
            // 
            // txtCorridas
            // 
            txtCorridas.Location = new Point(153, 192);
            txtCorridas.Name = "txtCorridas";
            txtCorridas.Size = new Size(86, 23);
            txtCorridas.TabIndex = 8;
            // 
            // txtPilotoPoints
            // 
            txtPilotoPoints.Location = new Point(147, 276);
            txtPilotoPoints.Name = "txtPilotoPoints";
            txtPilotoPoints.Size = new Size(92, 23);
            txtPilotoPoints.TabIndex = 9;
            // 
            // txtEquipePoints
            // 
            txtEquipePoints.Location = new Point(153, 362);
            txtEquipePoints.Name = "txtEquipePoints";
            txtEquipePoints.Size = new Size(86, 23);
            txtEquipePoints.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 514);
            Controls.Add(txtEquipePoints);
            Controls.Add(txtPilotoPoints);
            Controls.Add(txtCorridas);
            Controls.Add(txtEquipe);
            Controls.Add(txtPiloto);
            Controls.Add(btnCalcular);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "MotoGP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCalcular;
        private TextBox txtPiloto;
        private TextBox txtEquipe;
        private TextBox txtCorridas;
        private TextBox txtPilotoPoints;
        private TextBox txtEquipePoints;
    }
}
