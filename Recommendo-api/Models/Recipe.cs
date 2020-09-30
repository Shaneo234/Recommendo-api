using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recommendo_api.Models
{
    public class Recipe
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> Method { get; set; }
    }
}
