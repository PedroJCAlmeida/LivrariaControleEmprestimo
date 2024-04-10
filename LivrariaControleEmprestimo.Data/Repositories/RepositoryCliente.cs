using LivrariaControleEmprestimo.Data.Interfaces;
using LivrariaControleEmprestimo.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.Data.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        public RepositoryCliente(bool SaveChanges = true):base (SaveChanges) 
        {
        }
    }
}