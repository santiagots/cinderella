namespace Common.Data.Repository
{
    public abstract class BaseRepository<T>
    {
        protected readonly T _context;

        public BaseRepository(T context)
        {
            _context = context;
        }
    }
}
