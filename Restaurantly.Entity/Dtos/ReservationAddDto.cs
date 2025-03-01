﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Entity.Dtos
{
    public class ReservationAddDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int Count { get; set; }
        public string Message { get; set; }
    }
}
