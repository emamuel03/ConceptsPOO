namespace POOConceptos
{
    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t Sueldo a pagar........: {$"{GetValueToPay():C2}", 18}";
        }
    }
}
