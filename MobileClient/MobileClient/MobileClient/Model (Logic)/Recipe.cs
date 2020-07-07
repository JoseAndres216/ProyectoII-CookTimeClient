﻿using System;
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
        public string Duration { get; set; }
        public string Difficulty { get; set; }
        public string Ingredients { get; set; }
        public string Steps { get; set; }
        public string Image { get; set; }

        public List<Recipe> GetRecipes()
        {
            List<Recipe> Recipes = new List<Recipe>()
            {
                new Recipe(){ Name = "Maruchan mieo", Difficulty = "300", Duration = "3 thousand years", Type = "Lunch",
                    User = "El pejelagarto", Ingredients = "3 pack of this\n 4 packs of those\n blah blah", Steps = "1.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.", 
                    Image = "https://jumbo.vteximg.com.br/arquivos/ids/337515/Principal-5649.jpg?v=637245668229800000"},
                new Recipe(){Name = "Arroz con huevo mieo", Difficulty = "69", Duration = "3 thousand years", Type = "Lunch",
                    User = "El pejelagarto", Ingredients = "3 pack of this\n 4 packs of those\n blah blah",Steps = "1.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.",
                    Image = "https://cocinararroz.net/wp-content/uploads/2018/05/receta-arroz-chino-con-huevo.jpg"},
                new Recipe(){Name = "Rice and beans terror", Difficulty = "70000", Duration = "120", Type = "Lunch",
                    User = "El pejelagarto", Ingredients = "3 pack of this\n 4 packs of those\n blah blah",Steps = "1.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.", 
                    Image = "https://www.nacion.com/resizer/dja0N-WkL1HD5FxG5xVsLT8-dLA=/600x0/center/middle/filters:quality(100)/arc-anglerfish-arc2-prod-gruponacion.s3.amazonaws.com/public/NSMSIFEOYJCITG52FLDA54EMNM.jpg"},
                new Recipe(){Name = "Sopa Azteca", Difficulty = "300", Duration = "3", Type = "Lunch",
                    User = "Un chef de verdad", Ingredients = "3 pack of this\n 4 packs of those\n blah blah",Steps = "1.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.", 
                    Image = "https://cdn.kiwilimon.com/recetaimagen/12996/th5-640x640-12262.jpg"}, 
                new Recipe(){Name = "aaaaaaa", Difficulty = "300", Duration = "3", Type = "Lunch",
                    User = "El pejelagarto", Ingredients = "3 pack of this\n 4 packs of those\n blah blah",Steps = "1.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRskE1qoSIx_eI-BY5KuQgVUusK6_HWUdf0cA&usqp=CAU"},
                new Recipe(){ Name = "Maruchan mieo", Difficulty = "300", Duration = "3 thousand years", Type = "Lunch",
                    User = "El pejelagarto", Ingredients = "3 pack of this\n 4 packs of those\n blah blah", Steps = "1.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.",
                    Image = "https://jumbo.vteximg.com.br/arquivos/ids/337515/Principal-5649.jpg?v=637245668229800000"},
                new Recipe(){Name = "Arroz con huevo mieo", Difficulty = "69", Duration = "3 thousand years", Type = "Lunch",
                    User = "El pejelagarto", Ingredients = "3 pack of this\n 4 packs of those\n blah blah",Steps = "1.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.",
                    Image = "https://cocinararroz.net/wp-content/uploads/2018/05/receta-arroz-chino-con-huevo.jpg"},
                new Recipe(){Name = "Rice and beans terror", Difficulty = "70000", Duration = "120", Type = "Lunch",
                    User = "El pejelagarto", Ingredients = "3 pack of this\n 4 packs of those\n blah blah",Steps = "1.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.",
                    Image = "https://www.nacion.com/resizer/dja0N-WkL1HD5FxG5xVsLT8-dLA=/600x0/center/middle/filters:quality(100)/arc-anglerfish-arc2-prod-gruponacion.s3.amazonaws.com/public/NSMSIFEOYJCITG52FLDA54EMNM.jpg"},
                new Recipe(){Name = "Sopa Azteca", Difficulty = "300", Duration = "3", Type = "Lunch",
                    User = "Un chef de verdad", Ingredients = "3 pack of this\n 4 packs of those\n blah blah",Steps = "1.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.",
                    Image = "https://cdn.kiwilimon.com/recetaimagen/12996/th5-640x640-12262.jpg"},
                new Recipe(){Name = "aaaaaaa", Difficulty = "300", Duration = "3", Type = "Lunch",
                    User = "El pejelagarto", Ingredients = "3 pack of this\n 4 packs of those\n blah blah",Steps = "1.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRskE1qoSIx_eI-BY5KuQgVUusK6_HWUdf0cA&usqp=CAU"},
                new Recipe(){ Name = "Maruchan mieo", Difficulty = "300", Duration = "3 thousand years", Type = "Lunch",
                    User = "El pejelagarto", Ingredients = "3 pack of this\n 4 packs of those\n blah blah", Steps = "1.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.",
                    Image = "https://jumbo.vteximg.com.br/arquivos/ids/337515/Principal-5649.jpg?v=637245668229800000"},
                new Recipe(){Name = "Arroz con huevo mieo", Difficulty = "69", Duration = "3 thousand years", Type = "Lunch",
                    User = "El pejelagarto", Ingredients = "3 pack of this\n 4 packs of those\n blah blah",Steps = "1.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.",
                    Image = "https://cocinararroz.net/wp-content/uploads/2018/05/receta-arroz-chino-con-huevo.jpg"},
                new Recipe(){Name = "Rice and beans terror", Difficulty = "70000", Duration = "120", Type = "Lunch",
                    User = "El pejelagarto", Ingredients = "3 pack of this\n 4 packs of those\n blah blah",Steps = "1.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.",
                    Image = "https://www.nacion.com/resizer/dja0N-WkL1HD5FxG5xVsLT8-dLA=/600x0/center/middle/filters:quality(100)/arc-anglerfish-arc2-prod-gruponacion.s3.amazonaws.com/public/NSMSIFEOYJCITG52FLDA54EMNM.jpg"},
                new Recipe(){Name = "Sopa Azteca", Difficulty = "300", Duration = "3", Type = "Lunch",
                    User = "Un chef de verdad", Ingredients = "3 pack of this\n 4 packs of those\n blah blah",Steps = "1.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.",
                    Image = "https://cdn.kiwilimon.com/recetaimagen/12996/th5-640x640-12262.jpg"},
                new Recipe(){Name = "aaaaaaa", Difficulty = "300", Duration = "3", Type = "Lunch",
                    User = "El pejelagarto", Ingredients = "3 pack of this\n 4 packs of those\n blah blah",Steps = "1.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRskE1qoSIx_eI-BY5KuQgVUusK6_HWUdf0cA&usqp=CAU"},
                new Recipe(){ Name = "Maruchan mieo", Difficulty = "300", Duration = "3 thousand years", Type = "Lunch",
                    User = "El pejelagarto", Ingredients = "3 pack of this\n 4 packs of those\n blah blah", Steps = "1.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.",
                    Image = "https://jumbo.vteximg.com.br/arquivos/ids/337515/Principal-5649.jpg?v=637245668229800000"},
                new Recipe(){Name = "Arroz con huevo mieo", Difficulty = "69", Duration = "3 thousand years", Type = "Lunch",
                    User = "El pejelagarto", Ingredients = "3 pack of this\n 4 packs of those\n blah blah",Steps = "1.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.",
                    Image = "https://cocinararroz.net/wp-content/uploads/2018/05/receta-arroz-chino-con-huevo.jpg"},
                new Recipe(){Name = "Rice and beans terror", Difficulty = "70000", Duration = "120", Type = "Lunch",
                    User = "El pejelagarto", Ingredients = "3 pack of this\n 4 packs of those\n blah blah",Steps = "1.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.",
                    Image = "https://www.nacion.com/resizer/dja0N-WkL1HD5FxG5xVsLT8-dLA=/600x0/center/middle/filters:quality(100)/arc-anglerfish-arc2-prod-gruponacion.s3.amazonaws.com/public/NSMSIFEOYJCITG52FLDA54EMNM.jpg"},
                new Recipe(){Name = "Sopa Azteca", Difficulty = "300", Duration = "3", Type = "Lunch",
                    User = "Un chef de verdad", Ingredients = "3 pack of this\n 4 packs of those\n blah blah",Steps = "1.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.",
                    Image = "https://cdn.kiwilimon.com/recetaimagen/12996/th5-640x640-12262.jpg"},
                new Recipe(){Name = "aaaaaaa", Difficulty = "300", Duration = "3", Type = "Lunch",
                    User = "El pejelagarto", Ingredients = "3 pack of this\n 4 packs of those\n blah blah",Steps = "1.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.\n2.\n3.\n4.\n5.\n6.",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRskE1qoSIx_eI-BY5KuQgVUusK6_HWUdf0cA&usqp=CAU" }
            };
            return Recipes;
        
        }

    }

}