using System.Linq.Expressions;

namespace Prontuario.Repositorio.RepPatterns
{
    public interface IRep<T>
    {
        T GetById(int id);
        T GetById(Guid id);
        List<T> Get();
        void Inserir(T t);
        void Delete(int id);
        void Delete(Guid id);
        bool Any();
        bool Any(Expression<Func<T, bool>> exp);
    }
}
