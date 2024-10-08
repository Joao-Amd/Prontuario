namespace Prontuario.Repositorio.UnitOfWorks
{
    public interface IUnitOfWork
    {
        void Commit();
        void Roolback();
    }
}
