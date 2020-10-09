using CapyFinPlan.Domain.Model.Modelos.Usuario;

namespace CapyFinPlan.Domain.Model.Modelos.Empresa.Banco
{
    public class ContaBancaria
    {
        public BancoEntity Banco { get; set; }
        public int Agencia { get; set; }
        public long Conta { get; set; }

        public UsuarioEntity Usuario { get; set; }
    }
}
