﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    internal class Cliente
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public double PagoMaximo { get; set; }
        public override string ToString()
        {
            return "Dni:" +Dni + "Nombre: " + Nombre+ "PrecioAlquiler: " + PagoMaximo;
        }

    }
}