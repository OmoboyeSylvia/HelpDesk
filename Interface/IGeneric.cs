namespace HelpDesk.Interface
{
    public interface IGeneric
    {
        public interface IGeneric<T> where T : class
        {
            Task<T> Get(int id);
            Task<IEnumerable<T>> GetAll();
            Task Add(T entity);
            void Delete(T entity);
            void Update(T entity);
        }
    }
}
