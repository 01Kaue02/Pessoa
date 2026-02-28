using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO.Models
{
    public class Cursos
    {
        public string Nome{ get; set; } = string.Empty;
        public List<Pessoa> Alunos { get; set; } =new List<Pessoa>();

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public int ObterQuantidade()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa alunos)
        {
            Alunos.Remove(alunos);
            return true;
        }
        public void ListarAlunos()
        {
            for (int count = 0; count < Alunos.Count; count++)
            {   
                string texto = "Nº "+ count + " - " + Alunos[count].Nome;
                Console.WriteLine(texto);
                
            }
        }
    }
}