using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISP.Model;

namespace ISP.Service
{
    public class ProfessorService : ICarga
    {
        public IEnumerable<Pessoa> Get()
        {
            List<Pessoa> professores = new List<Pessoa>();

            professores.Add(new Pessoa() { ID = Guid.NewGuid(), Nome = "Professor 1", Score = 100 });
            professores.Add(new Pessoa() { ID = Guid.NewGuid(), Nome = "Professor 2", Score = 100 });

            return professores;
        }
    }
}
