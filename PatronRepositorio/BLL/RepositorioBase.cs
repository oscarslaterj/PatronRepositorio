using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronRepositorio.BLL;

namespace PatronRepositorio.BLL
{
    public class RepositorioBase<T> : IDisposable, IRepository<T> where T:class
    {
        internal Contexto _contexto;
    }
}
