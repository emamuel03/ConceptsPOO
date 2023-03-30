namespace POOConceptos
{
    public class HourlyEmployee : Employee
    {
        public float Hours { get; set; }
        public decimal HourValue { get; set; }
        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t Horas trabajadas......: {$"{Hours:N2}",18}" +
                $"\n\t Valor de hora.........: {$"{HourValue:C2}",18}" +
                $"\n\t Sueldo a pagar........: {$"{GetValueToPay():C2}",18}";
        }
    }
}
