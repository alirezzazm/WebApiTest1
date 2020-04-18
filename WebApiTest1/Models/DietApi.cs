using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTest1.Models
{
    public class DietApi
    {
        public int Id { get; set; }
        public string NameDiet { get; set; }
        public string ImageDiet { get; set; }
        public string ValueDiet { get; set; }
        public string PropertiesDiet { get; set; }
        public string IngredientDiet { get; set; }
    }
}
