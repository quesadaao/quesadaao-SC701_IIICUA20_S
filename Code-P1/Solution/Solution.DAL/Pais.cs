using Solution.DAL.EF;
using Solution.DAL.Repository;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.DAL
{
    public class Pais : ICRUD<data.Pais>
    {
        private Repository<data.Pais> _repo = null;
        public Pais(SolutionDBContext solutionDBContext) {
            _repo = new Repository<data.Pais>(solutionDBContext);        
        }
        public void Delete(data.Pais t)
        {
            _repo.Delete(t);
            _repo.Commit();
        }

        public IEnumerable<data.Pais> GetAll()
        {
            return _repo.GetAll();
        }

        public data.Pais GetOneById(int id)
        {
            return _repo.GetOneById(id);
        }

        public void Insert(data.Pais t)
        {
            _repo.Insert(t);
            _repo.Commit();
        }

        public void Update(data.Pais t)
        {
            _repo.Update(t);
            _repo.Commit();
        }
    }
}
