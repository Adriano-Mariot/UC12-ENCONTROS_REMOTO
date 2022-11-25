using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ENCONTRO_REMOTO_2.interfaces
{
    public interface IPessoaJuridica
    {
       bool ValidarCnpj (string cnpj);
    }
}