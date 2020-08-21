using System;
using System.Collections.Generic;
using System.Text;

namespace SuperLogs.Transport.DTOs
{
    public class ListarLogDto
    {
        public int IdLog { get; set; }
        public int IdTipoLog { get; set; }
        public string Descricao { get; set; }
        public int Eventos { get; set; }
        public int IdStatus { get; set; }
    }
}
