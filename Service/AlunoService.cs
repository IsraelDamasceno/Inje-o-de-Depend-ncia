using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISP.Model;

namespace ISP.Service
{
    public class AlunoService : ICarga
    {
        public  IEnumerable<Pessoa> Get()
        {
            List<Pessoa> alunos = new List<Pessoa>();

            alunos.Add(new Pessoa() { ID = Guid.NewGuid(), Nome = "Israel", Score = 100 });
            alunos.Add(new Pessoa() { ID =Guid.NewGuid() , Nome = "Alvaro", Score = 100 });

            return alunos;
        }
    }
}
