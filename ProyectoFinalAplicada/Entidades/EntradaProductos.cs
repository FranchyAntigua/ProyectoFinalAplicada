﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada.Entidades
{
    public class EntradaProductos
    {

        [Key]
        public int EntradaId { get; set; }
        public DateTime Fecha { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }

        public EntradaProductos()
        {
            EntradaId = 0;
            Fecha = DateTime.Now;
            ProductoId = 0;
            Cantidad = 0;
        }
    }
}
