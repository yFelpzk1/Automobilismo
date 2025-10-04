using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGP
{
    public class Calculadora
    {
        private string piloto;
        private string equipe;
        private int corridas;
        private double pontosPiloto;
        private double pontosEquipe;

        public Calculadora() { }

        public Calculadora(string piloto, string equipe, int corridas, double pontosPiloto, double pontosEquipe)
        {
            this.piloto = piloto;
            this.equipe = equipe;
            this.corridas = corridas;
            this.pontosPiloto = pontosPiloto;
            this.pontosEquipe = pontosEquipe;
        }
        
        public double CalcularPontosPiloto()
        {
            return pontosPiloto + (corridas * 37);
        }

        public double CalcularPontosEquipe()
        {
            return pontosEquipe + (corridas * 66);
        }
    }
}
