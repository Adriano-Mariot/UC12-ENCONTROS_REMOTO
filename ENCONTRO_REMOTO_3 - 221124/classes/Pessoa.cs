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
        public string ?Nome {get;set;} //"get" e "set" são propriendades auto emplementadas

        public Endereco ?Endereco {get;set;}

        public float ?Rendimento {get;set;}        
        
        //Metodo
        public abstract float PagarImposto(float rendimento);
        
    }
}