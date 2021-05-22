using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsEmpleadosInterfaz
{
    public class EmpleadoBaseMasComision : Empleado
    {
        public double SalarioSemanal;
        public double SueldoXHoras;
        public double Sueldo;
        public double SueldoBase;
        public double VentasBrutas;
        public void CalculaSalario(double SA, double SH, int HT)
        {
            //SA = Tarifas de Comision
            //SH = Salario Base
            //HT = Ventas Brutas
            Sueldo = (SA * HT) + SH;
        }
    }
}