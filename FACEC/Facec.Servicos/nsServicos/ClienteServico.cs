﻿using Facec.Dominio.nsEntidades;
using Facec.Dominio.nsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Servicos.nsServicos
{
    public class ClienteServico : IClienteServico
    {
        private List<Cliente> _cliente = new List<Cliente>();
        public void Excluir(Guid id)
        {
            var cliente = _cliente.FirstOrDefault(x => x.Id == id)
                ?? throw new ApplicationException("Cliente não existe!");
            _cliente.Remove(cliente);
        }

        public void Gravar(Cliente cliente)
        {
            _cliente.Add(cliente);
        }

        public IEnumerable<Cliente> Obter()
        {
            return _cliente;
        }
    }
}
