using Facec.Dominio.nsInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Repositorio.nsClasses
{
    
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        private readonly IClienteRepositorio _clienteRepositorio;
        public IClienteRepositorio ClienteRepositorio => _clienteRepositorio;
        public UnitOfWork(DbContext context, IClienteRepositorio clienteRepositorio)
        {
            _context = context;
            _clienteRepositorio = clienteRepositorio;
        }
        public void SaveChanges() => _context.SaveChanges();
    }
}
