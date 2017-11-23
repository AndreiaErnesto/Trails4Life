﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTrails4Health.Models.ViewModel
{
    public class AgendarTrilho
    {
        public int IdTurista { get; set; }
        public int IdTrilho { get; set; }
        public int dataReserva { get; set; }
        public int dataPrevInicTrilho { get; set; }
        public string estadoAgend { get; set; }
        public int tempGasto { get; set; }
        public ICollection<AgendarTrilho> AgendarTrilhos { get; set; }
    }
}