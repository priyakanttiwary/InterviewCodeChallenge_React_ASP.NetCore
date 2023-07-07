using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewCodeChallenge_React.Models
{

    public class CategoryCollection
    {
        private CategoryCollection()
        {

        }
        private static IList<Category> instance = null;
        public static IList<Category> List
        {
            get
            {
                if (instance == null)
                {
                    instance = new List<Category>()
                    { new Category() {Id=1, Name="Electronics" },
                      new Category() {Id=1, Name="Apparel" },
                      new Category() {Id=1, Name="Footwear" }
                    };
                }

                return instance;
            }
        }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
