using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assignmentDotNetPractice.Db_Context;
using assignmentDotNetPractice.Entites;

namespace assignmentDotNetPractice.Repository
{
    
    public class CategoryRepository
    {
        Context context;
        public CategoryRepository(Context c)
        {
            context = c;
        }

        public bool insertCategory(Category c)
        {
            if (c != null)
            {
                context.categories.Add(c);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Category> getAllCategories()
        {
            return context.categories.ToList();
        }
    }
}
