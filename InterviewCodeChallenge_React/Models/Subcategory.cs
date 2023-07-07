using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewCodeChallenge_React.Models
{

    public class SubcategoryCollection
    {
        private SubcategoryCollection()
        {

        }
        private static IList<Subcategory> instance = null;
        public static IList<Subcategory> List
        {
            get
            {
                if (instance == null)
                {
                    instance = new List<Subcategory>()
                    {
                        new Subcategory() { Id = 1, Name = "TV" },
                        new Subcategory() { Id = 2, Name = "Mobile" },
                        new Subcategory() { Id = 3, Name = "Refrigerator" },
                        new Subcategory() { Id = 1, Name = "Men’s Cloth" },
                        new Subcategory() { Id = 2, Name = "Women’s cloth" },
                        new Subcategory() { Id = 3, Name = "Men’s Footwear" },
                        new Subcategory() { Id = 3, Name = "kid’s footwears" }
                    };
                }
                return instance;
            }
        }

    }
    public class Subcategory
    {

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
