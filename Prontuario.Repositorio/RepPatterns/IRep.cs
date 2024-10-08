using System.Linq.Expressions;

namespace Prontuario.Repositorio.RepPatterns
{
    public interface IRep<T>
    {
        T GetById(int id);
        List<T> Get();
        void Inserir(T t);
        void Delete(int id);
        bool Any();
        bool Any(Expression<Func<T, bool>> exp);
    }
}
