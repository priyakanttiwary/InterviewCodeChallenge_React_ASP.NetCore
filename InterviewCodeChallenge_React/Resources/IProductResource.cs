using InterviewCodeChallenge_React.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewCodeChallenge_React.Resources
{
    public interface IProductResource
    {
        ProductDetail AddProduct(ProductDetail product);
        ProductCollection List();
        IList<Subcategory> SubCatList();
        IList<Category> CatList();
    }
}
