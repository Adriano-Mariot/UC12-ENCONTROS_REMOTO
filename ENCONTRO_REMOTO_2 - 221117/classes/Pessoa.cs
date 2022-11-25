using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ENCONTRO_REMOTO_2.interfaces;

namespace ENCONTRO_REMOTO_2.classes
{
    public abstract class Pessoa : IPessoa
    {
        //Atributos
        public string ?nome {get;set;} //"get" e "set" são propriendades auto emplementadas

        public string ?endereco {get;set;}

        public float ?rendimento {get;set;}        
        
        //Metodo
        public abstract float PagarImposto(float rendimento);
        
    }
}