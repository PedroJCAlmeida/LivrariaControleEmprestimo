using LivrariaControleEmprestimo.Data.Interfaces;
using LivrariaControleEmprestimo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.Data.Repositories
{
    public class RepositoryLivro : RepositoryBase<Livro>, IRepositoryLivro   
    {
        public RepositoryLivro(bool SaveChanges = true) : base(SaveChanges)
        {
        }
    }
}
