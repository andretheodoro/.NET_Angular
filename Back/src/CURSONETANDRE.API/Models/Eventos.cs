using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CURSONETANDRE.API.Models
{
    public class Eventos
    {
        public int ID { get; set; }
        public int EventoId { get; set; }
        public string Local { get; set; }
        public string  DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string Lote { get; set; }
        public string ImagemURL { get; set; }
    }
}