using Project.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lib.Repositories
{
    public class CategoryRepository
    {
        public List<Category> GetAll()
        {
            return new List<Category>
            {
                new Category {Id = 1 , Name = "dairy"},
                new Category {Id = 2 , Name = "vegetable"},
                new Category {Id = 3 , Name = "houseHold"},
            };
        }

        public void Add(Category category)
        {

        }
    }
}
