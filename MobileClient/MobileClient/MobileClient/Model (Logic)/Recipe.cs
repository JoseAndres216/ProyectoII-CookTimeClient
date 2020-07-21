using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileClient.Model__Logic_
{
    public class Recipe
    {
        /*Name of the recipe, User that created the recipe, Type (Breakfast, lunch, etc), Servings, Duration of preparation
* Timing (Entry, main dish, dessert, drink, etc), Difficulty, Tags by type of diet(vegan, celiac, keto),
* Ingredients, Steps to prepare the dish, Price(estimated), image of the Recipe
*/
        private string Name { get; set; }
        private string User { get; set; }
        private string Type { get; set; }
        private int Servings { get; set; }
        private string Duration { get; set; }
        private string Timing { get; set; }
        private int Difficulty { get; set; }
        private string Tags { get; set; }
        private string Ingredients { get; set; }
        private string Steps { get; set; }
        private int Price { get; set; }
        private string Image { get; set; } //esto tambien se deberia cambiar por una imagen como tal y no como un string

        public Recipe()
        {
        }

        public void setName(string name)
        {
            this.Name = name;
        }

        public string getName()
        {
            return this.Name;
        }

        public void setUser(string user)
        {
            this.User = user;
        }

        public string getUser()
        {
            return this.User;
        }

        public void setType(string type)
        {
            this.Type = type;
        }

        public string getType()
        {
            return this.Type;
        }

        public void setServings(int servings)
        {
            this.Servings = servings;
        }

        public int getServings()
        {
            return this.Servings;
        }

        public void setDuration(string duration)
        {
            this.Duration = duration;
        }

        public string getDuration()
        {
            return this.Duration;
        }

        public void setTiming(string timing)
        {
            this.Timing = timing;
        }

        public string getTiming()
        {
            return this.Timing;
        }

        public void setDifficulty(int difficulty)
        {
            this.Difficulty = difficulty;
        }

        public int getDifficulty()
        {
            return this.Difficulty;
        }

        public void setTags(string tags)
        {
            this.Tags = tags;
        }

        public string getTags()
        {
            return this.Tags;
        }

        public void setIngredients(string ingredients)
        {
            this.Ingredients = ingredients;
        }

        public string getIngredients()
        {
            return this.Ingredients;
        }

        public void setSteps(string steps)
        {
            this.Steps = steps;
        }

        public string getSteps()
        {
            return this.Steps;
        }

        public void setPrice(int price)
        {
            this.Price = price;
        }

        public int getPrice()
        {
            return this.Price;
        }

        public void setImage(string image)
        {
            this.Image = image;
        }

        public string getImage()
        {
            return this.Image;
        }
    }
}