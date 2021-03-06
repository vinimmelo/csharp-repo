﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankConsole.Sistemas;

namespace BankConsole.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor (string cpf) : base(5000, cpf) { }

        public override double GetBonificacao ()
        {
            return Salario * 1.15;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

    }
}
