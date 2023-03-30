using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConceptos
{
    public class CommissionEmployee : Employee
    {
        public float CommissionPercentaje { get; set; }

        public decimal Sales { get; set; }
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentaje;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t Porcentaje de Comision: {$"{CommissionPercentaje:P2}",18}" +
                $"\n\t Ventas................: {$"{Sales:C2}",18}" +
                $"\n\t Sueldo a pagar........: {$"{GetValueToPay():C2}",18}";
        }
    }
}
