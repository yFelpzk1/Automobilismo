namespace MotoGP
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
                int corridas = Convert.ToInt32(txtCorridas.Text);
                double pontosPiloto = Convert.ToDouble(txtPilotoPoints.Text);
                double pontosEquipe = Convert.ToDouble(txtEquipePoints.Text);

                Calculadora calc = new Calculadora(piloto, equipe, corridas, pontosPiloto, pontosEquipe);

                double totalPontosPiloto = calc.CalcularPontosPiloto();
                double totalPontosEquipe = calc.CalcularPontosEquipe();

                MessageBox.Show($"Piloto: {piloto} pode alcançar {totalPontosPiloto} Pontos\n\n " +
                    $"Equipe: {equipe} pode alcançar {totalPontosEquipe} Pontos");
            }
            catch(FormatException)
            {
                MessageBox.Show("Digite apenas números nos campos de corridas e pontos.");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}
