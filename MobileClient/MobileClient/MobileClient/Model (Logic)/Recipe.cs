using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileClient.Model__Logic_
{
    public class Recipe
    {
        public string Name { get; set; }
        public string User { get; set; }
        public string Type { get; set; }
        public int Duration { get; set; }
        public int Difficulty { get; set; }
        public string Descripcion { get; set; }
        //public Image Image { get; set; }

        public List<Recipe> GetRecipes()
        {
            List<Recipe> Recipes = new List<Recipe>()
            {
                new Recipe(){ Name = "Maruchan mieo", Difficulty = 300, Duration = 3, Type = "Lunch",
                    User = "El pejelagarto", Descripcion = "un exquisito plato super elaborado"},
                new Recipe(){Name = "Arroz con huevo mieo", Difficulty = 69, Duration = 10, Type = "Lunch",
                    User = "El pejelagarto", Descripcion = "un exquisito plato super elaborado"},
                new Recipe(){Name = "Rice and beans terror", Difficulty = 70000, Duration = 120, Type = "Lunch",
                    User = "El pejelagarto", Descripcion = "un exquisito plato super elaborado"},
                new Recipe(){Name = "Sopa Azteca", Difficulty = 300, Duration = 3, Type = "Lunch",
                    User = "Un chef de verdad", Descripcion = "un exquisito plato super elaborado"}, 
                new Recipe(){Name = "aaaaaaa", Difficulty = 300, Duration = 3, Type = "Lunch",
                    User = "El pejelagarto", Descripcion = "un exquisito plato super elaborado"},
                new Recipe(){ Name = "Maruchan mieo", Difficulty = 300, Duration = 3, Type = "Lunch",
                    User = "El pejelagarto", Descripcion = "un exquisito plato super elaborado"},
                new Recipe(){Name = "Arroz con huevo mieo", Difficulty = 69, Duration = 10, Type = "Lunch",
                    User = "El pejelagarto", Descripcion = "un exquisito plato super elaborado"},
                new Recipe(){Name = "Rice and beans terror", Difficulty = 70000, Duration = 120, Type = "Lunch",
                    User = "El pejelagarto", Descripcion = "un exquisito plato super elaborado"},
                new Recipe(){Name = "Sopa Azteca", Difficulty = 300, Duration = 3, Type = "Lunch",
                    User = "Un chef de verdad", Descripcion = "un exquisito plato super elaborado"},
                new Recipe(){Name = "aaaaaaa", Difficulty = 300, Duration = 3, Type = "Lunch",
                    User = "El pejelagarto", Descripcion = "un exquisito plato super elaborado"},
                new Recipe(){ Name = "Maruchan mieo", Difficulty = 300, Duration = 3, Type = "Lunch",
                    User = "El pejelagarto", Descripcion = "un exquisito plato super elaborado"},
                new Recipe(){Name = "Arroz con huevo mieo", Difficulty = 69, Duration = 10, Type = "Lunch",
                    User = "El pejelagarto", Descripcion = "un exquisito plato super elaborado"},
                new Recipe(){Name = "Rice and beans terror", Difficulty = 70000, Duration = 120, Type = "Lunch",
                    User = "El pejelagarto", Descripcion = "un exquisito plato super elaborado"},
                new Recipe(){Name = "Sopa Azteca", Difficulty = 300, Duration = 3, Type = "Lunch",
                    User = "Un chef de verdad", Descripcion = "un exquisito plato super elaborado"},
                new Recipe(){Name = "aaaaaaa", Difficulty = 300, Duration = 3, Type = "Lunch",
                    User = "El pejelagarto", Descripcion = "un exquisito plato super elaborado"},
                new Recipe(){ Name = "Maruchan mieo", Difficulty = 300, Duration = 3, Type = "Lunch",
                    User = "El pejelagarto", Descripcion = "un exquisito plato super elaborado"},
                new Recipe(){Name = "Arroz con huevo mieo", Difficulty = 69, Duration = 10, Type = "Lunch",
                    User = "El pejelagarto", Descripcion = "un exquisito plato super elaborado"},
                new Recipe(){Name = "Rice and beans terror", Difficulty = 70000, Duration = 120, Type = "Lunch",
                    User = "El pejelagarto", Descripcion = "un exquisito plato super elaborado"},
                new Recipe(){Name = "Sopa Azteca", Difficulty = 300, Duration = 3, Type = "Lunch",
                    User = "Un chef de verdad", Descripcion = "un exquisito plato super elaborado"},
                new Recipe(){Name = "aaaaaaa", Difficulty = 300, Duration = 3, Type = "Lunch",
                    User = "El pejelagarto", Descripcion = "un exquisito plato super elaborado"},
                new Recipe(){ Name = "Maruchan mieo", Difficulty = 300, Duration = 3, Type = "Lunch",
                    User = "El pejelagarto", Descripcion = "un exquisito plato super elaborado"},
                new Recipe(){Name = "Arroz con huevo mieo", Difficulty = 69, Duration = 10, Type = "Lunch",
                    User = "El pejelagarto", Descripcion = "un exquisito plato super elaborado"},
                new Recipe(){Name = "Rice and beans terror", Difficulty = 70000, Duration = 120, Type = "Lunch",
                    User = "El pejelagarto", Descripcion = "un exquisito plato super elaborado"},
                new Recipe(){Name = "Sopa Azteca", Difficulty = 300, Duration = 3, Type = "Lunch",
                    User = "Un chef de verdad", Descripcion = "un exquisito plato super elaborado"},
                new Recipe(){Name = "aaaaaaa", Difficulty = 300, Duration = 3, Type = "Lunch",
                    User = "El pejelagarto", Descripcion = "un exquisito plato super elaborado"}
            };


            return Recipes;
        
        }

    }

}