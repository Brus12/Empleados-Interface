﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsEmpleadosInterfaz
{
    public class EmpleadoAsalariado : Empleado
    {
        public double SalarioSemanal;
        public double SueldoXHoras;
        public double Sueldo;
        public double SueldoBase;
        public double VentasBrutas;
        public void CalculaSalario(double SA, double SH, int HT)
        {
            // SA = Salario
            // SH = 0
            // HT = 0
            Sueldo = SA;
        }
    }
}