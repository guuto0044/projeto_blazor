using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;


namespace augusto
{   
    [Table ("tb_Cliente")]
    public class Cliente
    {
        [Key]  
        public int id_Cliente {get;set;}
        public string nome {get;set;}
        public string CPF {get;set;}
        public string CEP {get;set;}
        public string endereco {get;set;}
        public string bairro {get;set;}
        public string complemento {get;set;}
        public string cidade {get;set;}
        public string UF {get;set;} 
        public DateTime data_hora_Entrada {get;set;}
        public string e_mail {get;set;}
        public string telefone {get;set;}
        public bool ativo {get;set;}

    }

}