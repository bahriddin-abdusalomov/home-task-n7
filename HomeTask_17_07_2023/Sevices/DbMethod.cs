using HomeTask_17_07_2023.Models;
using SeedData.Data;

namespace HomeTask_17_07_2023.Sevices
{
    public class DbMethod<Tkey> where Tkey : BaseEntity
    {
        GmDbContext _dbContext  = new GmDbContext();

        public void Add(Tkey val)
        {
            _dbContext.Set<Tkey>().Add(val);
            _dbContext.SaveChanges();
        }

        public void Delete(int val)
        {
            _dbContext.Remove(val);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Tkey> GetAll()
        {
            return _dbContext.Set<Tkey>().ToList();
        }

        public void Update(Tkey val)
        {
            _dbContext.Set<Tkey>().Update(val);
            _dbContext.SaveChanges();
        }
    }
}
