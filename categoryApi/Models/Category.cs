using System.Collections.Generic;

namespace categoryApi.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }


        
        public static List<Category> GetCategories()
        {
           
            List<Category> categories = new List<Category>();

           
            categories.Add(new Category { Id = 1, Name = "Premie League",  });
            categories.Add(new Category { Id = 2, Name = "ChampionsLeague", });
            categories.Add(new Category { Id = 3, Name = "Spanish League",  });
            categories.Add(new Category { Id = 4, Name = "EuroCup" });

          
            return categories;
        }
    }
}
