﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankConsole.Funcionarios;

namespace BankConsole
{
    
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        public void Registrar (Funcionario funcionaro)
        {
            _totalBonificacao += funcionaro.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
