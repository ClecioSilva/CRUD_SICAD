using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Aluno
    {
        //Declaração dos atributos da classe: Aluno
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Data_Nasc { get; set; }
        public string Idade { get; set; }
        public string Objetivo_Graduacao { get; set; }
        public string Genero { get; set; }

    }
}
