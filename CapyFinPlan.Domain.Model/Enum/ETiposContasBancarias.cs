﻿using System.ComponentModel;

namespace CapyFinPlan.Domain.Model.Enum
{
    public enum ETiposContasBancarias
    {
        [Description("Conta Corrente")]
        Corrente,

        [Description("Conta Poupança")]
        Poupanca,

        [Description("Conta Salário")]
        Salario,

        [Description("Conta Digital")]
        Digital,

        [Description("Conta Universitária")]
        Univesitaria,
    }
}