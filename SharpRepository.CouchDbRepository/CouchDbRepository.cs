
namespace SharpRepository.CouchDbRepository
{
    public class CouchDbRepository<T> : CouchDbRepositoryBase<T> where T : class, new()
    {
        public CouchDbRepository()
        {
        }

        public CouchDbRepository(string url, string database = null)
            : base(url, database)
        {
        }
    }
}
