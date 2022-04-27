﻿using Facec.Dominio.nsEntidades;
using Facec.Dominio.nsInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Repositorio.nsClasses
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly DbContext _context;
        private DbSet<Cliente> Clientes => _context.Set<Cliente>();
        public ClienteRepositorio(DbContext context)
        {
            _context = context;
        }
        public void Excluir(Cliente cliente)
            => Clientes.Remove(cliente);
        
        public void Gravar(Cliente cliente)
            => Clientes.Add(cliente);
        
        public IEnumerable<Cliente> Obter()
            => Clientes.AsEnumerable();
    }
}
