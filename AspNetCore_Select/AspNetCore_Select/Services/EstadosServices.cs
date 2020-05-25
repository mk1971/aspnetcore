using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore_Select.Models;

namespace AspNetCore_Select.Services
{
    public class EstadosServices
    {
        public static List<Estado> GetEstados()
        {
            var listaEstados = new List<Estado>()
            {
                new Estado() { EstadoSigla="AL", EstadoNome="Alagoas"},
                new Estado() { EstadoSigla="BA", EstadoNome="Bahia"},
                new Estado() { EstadoSigla="CE", EstadoNome="Ceará"},
                new Estado() { EstadoSigla="DF", EstadoNome="Distrito Federal"},
                new Estado() { EstadoSigla="ES", EstadoNome="Espírito Santo"},
                new Estado() { EstadoSigla="GO", EstadoNome="Goiás"},
                new Estado() { EstadoSigla="MG", EstadoNome="Minas Gerais"},
                new Estado() { EstadoSigla="PR", EstadoNome="Paraná"},
                new Estado() { EstadoSigla="RS", EstadoNome="Rio Grande do Sul"},
                new Estado() { EstadoSigla="SP", EstadoNome="São Paulo"},
                new Estado() { EstadoSigla="TO", EstadoNome="Tocantins"}
            };
            return listaEstados;
        }
    }
}
