namespace Formula1
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
            label6 = new Label();
            txtPiloto = new TextBox();
            txtEquipe = new TextBox();
            txtSprints = new TextBox();
            txtCorridas = new TextBox();
            txtPilotoPoints = new TextBox();
            txtEquipePoints = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 52);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do Piloto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 154);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 1;
            label2.Text = "Sprints Restantes:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 208);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 2;
            label3.Text = "Corridas Restantes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 260);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 3;
            label4.Text = "Pontuação do Piloto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 98);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 4;
            label5.Text = "Nome da Equipe:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 318);
            label6.Name = "label6";
            label6.Size = new Size(122, 15);
            label6.TabIndex = 5;
            label6.Text = "Pontuação da Equipe:";
            // 
            // txtPiloto
            // 
            txtPiloto.Location = new Point(156, 44);
            txtPiloto.Name = "txtPiloto";
            txtPiloto.Size = new Size(158, 23);
            txtPiloto.TabIndex = 6;
            // 
            // txtEquipe
            // 
            txtEquipe.Location = new Point(160, 90);
            txtEquipe.Name = "txtEquipe";
            txtEquipe.Size = new Size(154, 23);
            txtEquipe.TabIndex = 7;
            // 
            // txtSprints
            // 
            txtSprints.Location = new Point(161, 146);
            txtSprints.Name = "txtSprints";
            txtSprints.Size = new Size(74, 23);
            txtSprints.TabIndex = 8;
            // 
            // txtCorridas
            // 
            txtCorridas.Location = new Point(169, 200);
            txtCorridas.Name = "txtCorridas";
            txtCorridas.Size = new Size(74, 23);
            txtCorridas.TabIndex = 9;
            // 
            // txtPilotoPoints
            // 
            txtPilotoPoints.Location = new Point(180, 252);
            txtPilotoPoints.Name = "txtPilotoPoints";
            txtPilotoPoints.Size = new Size(74, 23);
            txtPilotoPoints.TabIndex = 10;
            // 
            // txtEquipePoints
            // 
            txtEquipePoints.Location = new Point(184, 310);
            txtEquipePoints.Name = "txtEquipePoints";
            txtEquipePoints.Size = new Size(74, 23);
            txtEquipePoints.TabIndex = 11;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(56, 374);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(202, 36);
            btnCalcular.TabIndex = 12;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtEquipePoints);
            Controls.Add(txtPilotoPoints);
            Controls.Add(txtCorridas);
            Controls.Add(txtSprints);
            Controls.Add(txtEquipe);
            Controls.Add(txtPiloto);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Formula 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtPiloto;
        private TextBox txtEquipe;
        private TextBox txtSprints;
        private TextBox txtCorridas;
        private TextBox txtPilotoPoints;
        private TextBox txtEquipePoints;
        private Button btnCalcular;
    }
}
