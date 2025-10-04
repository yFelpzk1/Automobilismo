using System.Linq.Expressions;

namespace Formula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string piloto = txtPiloto.Text;
                string equipe = txtEquipe.Text;
                int sprints = Convert.ToInt32(txtSprints.Text);
                int corridas = Convert.ToInt32(txtCorridas.Text);
                double pontosPiloto = Convert.ToInt32(txtPilotoPoints.Text);
                double pontosEquipe = Convert.ToInt32(txtEquipePoints.Text);

                Calculadora calc = new Calculadora(piloto, equipe, sprints, corridas);
                double totalPontosPiloto = calc.CalcularPontosPiloto() + pontosPiloto;
                double totalPontosEquipe = calc.CalcularPontosEquipe() + pontosEquipe;

                MessageBox.Show($"Piloto:  {piloto} pode alcan�ar: {totalPontosPiloto} \n\n " +
                    $"Equipe: {equipe} pode alcan�ar: {totalPontosEquipe}");
            }
            catch(FormatException)
            {
                MessageBox.Show("Por favor, insira valores num�ricos v�lidos para Sprints e Corridas.");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}
