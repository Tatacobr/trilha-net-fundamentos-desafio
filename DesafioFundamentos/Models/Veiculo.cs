using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models{
    public class Veiculo{
        private DateTime entrada;
        private string placa;

        public string Placa{
            get { return placa; }
            set { placa = value; }
        }
        
        public DateTime Entrada{
            get { return entrada; }
            set { entrada = value; }
        }

        public Veiculo(string placa, DateTime entrada){
            this.entrada = entrada;
            this.placa = placa;
        }
    }
}