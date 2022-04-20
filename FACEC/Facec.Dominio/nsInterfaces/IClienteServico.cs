﻿using Facec.Dominio.nsEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Dominio.nsInterfaces
{
    public interface IClienteServico
    {
        void Excluir(Cliente cliente);
        void Gravar(Cliente cliente);
        IEnumerable<Cliente> Obter();
    }
}
