using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bliblioteca.Dalc;

namespace Biblioteca.Entidades
{
    public class Sexo
    {
        public int IdSexo { get; set; }
        public string Decripcion { get; set; }

        private Bliblioteca.Dalc.BeLifeEntities contexto = new BeLifeEntities();
        public Sexo()
        {
            
        }
    }
}
