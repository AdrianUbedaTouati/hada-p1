﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    /// <summary>
    /// Esta calse contiene metodos para convertir de
    /// segundos a minutos y viceversa, 
    /// ademas de un metodo que convierte las horas a minutos
    /// </summary>
    class HadaP1
    {
        public static double Seconds2Minutes(double s)
        {
            if (s == 0)
                return 0;
            return s * 60;
        }
        public static double Minutes2Seconds(double m)
        {
            return m / 60;
        }
        public static double Horas2Minutes(double h)
        {
            return h * 60;
        }
    }
}
