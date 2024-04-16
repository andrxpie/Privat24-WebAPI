using Ardalis.Specification;
using Core.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public static class CardSpecs
    {
        public class All : Specification<Card>
        {
            public All() {}
        }
        public class ById : Specification<Card>
        {
            public ById(int id)
            {
                Query.Where(x => x.Id == id);
            }
        }
        public class ByIds : Specification<Card>
        {
            public ByIds(IEnumerable<int> ids)
            {
                Query.Where(x => ids.Contains(x.Id));
            }
        }
    }
}
