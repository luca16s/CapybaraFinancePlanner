namespace CapyFinPlan.Domain.Model.Modelos.Usuario
{
    public class Salario
    {
        public UsuarioEntity Usuario { get; set; }

        public decimal SalarioBase { get; set; }
        public decimal DescontoInss => CalculaDescontoInss();
        public decimal DescontoIrrf => CalculaDescontoIrrf();

        private decimal CalculaDescontoInss()
        {
            return default;
        }

        private decimal CalculaDescontoIrrf()
        {
            var baseDeCalculo = SalarioBase - DescontoInss;

            return baseDeCalculo;
        }
    }
}
