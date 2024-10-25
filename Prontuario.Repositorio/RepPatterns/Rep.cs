using Microsoft.EntityFrameworkCore;
using Prontuario.Repositorio.Contextos;
using System.Linq.Expressions;

namespace Prontuario.Repositorio.RepPatterns
{
    public class Rep<T> : IRep<T>, IDisposable where T : class
    {
        protected readonly DbContext Db;
        protected readonly DbSet<T> DbSet;

        public Rep(Contexto contexto)
        {
            Db = contexto;
            DbSet =Db.Set<T>();
        }

        public bool Any()
        {
            return DbSet.Any();
        }
        public void Inserir(T t)
        {
            DbSet.Add(t);
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return DbSet.Any(exp);
        }

        public void Delete(int id)
        {
            var entity = DbSet.Find(id);
            DbSet.Remove(entity);
        }

        public void Delete(Guid id)
        {
            var entity = DbSet.Find(id);
            DbSet.Remove(entity);
        }

        public T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public T GetById(Guid id)
        {
            return DbSet.Find(id);
        }

        public List<T> Get()
        {
            return DbSet.ToList();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
