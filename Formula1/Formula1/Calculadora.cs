using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1
{
    public class Calculadora
    {
        private string piloto;
        private string equipe;
        private int sprints;
        private int corridas;
        private double pontosPiloto;
        private double pontosEquipe;
    
    public Calculadora() { }

        public Calculadora(string piloto, string equipe, int sprints, int corridas)
        {
            this.piloto = piloto;
            this.equipe = equipe;
            this.sprints = sprints;
            this.corridas = corridas;
            this.pontosPiloto = 0;
            this.pontosEquipe = 0;
        }
        public double CalcularPontosPiloto()
        {
            return pontosPiloto + (sprints * 8) + (corridas * 25);
            
        }

        public double CalcularPontosEquipe()
        {
            return pontosEquipe + (43 * corridas) + (15 * sprints);            
        }
    }
}
