using ISP.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISP.Service
{
    public interface ICarga
    {
        IEnumerable<Pessoa> Get();
       
    }
}
