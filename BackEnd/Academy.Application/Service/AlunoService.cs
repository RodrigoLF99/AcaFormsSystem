using Academy.Domain.Entities;
using Academy.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Application.Service
{
    public class AlunoService : IAlunoService
    {
        public string CreateAluno(Aluno aluno)
        {
            return "Cadastrado com sucesso";
        }

        public List<Aluno> GetAllAluno()
        {
            var listaAluno = new List<Aluno>();

            var objetoAluno = new Aluno();
            objetoAluno.matricula = 12234;
            objetoAluno.Peso = "150 kg";
            objetoAluno.Nome = "Cleytonvilson";

            var objetoAluno2 = new Aluno();
            objetoAluno2.matricula = 1225352234;
            objetoAluno2.Peso = "40 kg";
            objetoAluno2.Nome = "Chinataozinho";

            var objetoAluno3 = new Aluno();
            objetoAluno3.matricula = 32312;
            objetoAluno3.Peso = "240 kg";
            objetoAluno3.Nome = "Chinataozao";

            listaAluno.Add(objetoAluno);
            listaAluno.Add(objetoAluno2);
            listaAluno.Add(objetoAluno3);

            return listaAluno;
        }
    }
}
