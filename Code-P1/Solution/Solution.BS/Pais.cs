using Solution.DAL.EF;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.BS
{
    public class Pais : ICRUD<data.Pais>
    {
        private SolutionDBContext _repo = null;
        public Pais(SolutionDBContext solutionDBContext) {
            _repo = solutionDBContext;        
        }
        public void Delete(data.Pais t)
        {
            new Solution.DAL.Pais(_repo).Delete(t);
        }

        public IEnumerable<data.Pais> GetAll()
        {
            return new Solution.DAL.Pais(_repo).GetAll();
        }

        public data.Pais GetOneById(int id)
        {
            return new Solution.DAL.Pais(_repo).GetOneById(id);
        }

        public void Insert(data.Pais t)
        {
            new Solution.DAL.Pais(_repo).Insert(t);
        }

        public void Update(data.Pais t)
        {
            new Solution.DAL.Pais(_repo).Update(t);
        }
    }
}
