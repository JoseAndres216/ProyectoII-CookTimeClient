﻿using CookTime.Model__Logic_.Data_Structures;
using Newtonsoft.Json;
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
        [JsonProperty] public string name { get; set; }
        [JsonProperty] public string author { get; set; }
        [JsonProperty] public string type { get; set; }
        [JsonProperty] public int servings { get; set; }
        [JsonProperty] public float duration { get; set; }
        [JsonProperty] public string timing { get; set; }
        [JsonProperty] public int difficulty { get; set; }
        [JsonProperty] public string tags { get; set; }
        [JsonProperty] public string ingredients { get; set; }
        [JsonProperty] public string steps { get; set; }
        [JsonProperty] public int price { get; set; }
        [JsonProperty] public float rating { get; set; }
        [JsonProperty] public int likes { get; set; }
        [JsonProperty] public SimpleList<String> comments { get; set; }
        [JsonProperty] public string Image { get; set; } //esto tambien se deberia cambiar por una imagen como tal y no como un string
    
        public Recipe()
        {
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void setUser(string user)
        {
            this.author = user;
        }

        public string getUser()
        {
            return this.author;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public string getType()
        {
            return this.type;
        }

        public void setServings(int servings)
        {
            this.servings = servings;
        }

        public int getServings()
        {
            return this.servings;
        }

        public void setDuration(int duration)
        {
            this.duration = duration;
        }

        public float getDuration()
        {
            return this.duration;
        }

        public void setTiming(string timing)
        {
            this.timing = timing;
        }

        public string getTiming()
        {
            return this.timing;
        }

        public void setDifficulty(int difficulty)
        {
            this.difficulty = difficulty;
        }

        public int getDifficulty()
        {
            return this.difficulty;
        }

        public void setTags(string tags)
        {
            this.tags = tags;
        }

        public string getTags()
        {
            return this.tags;
        }

        public void setIngredients(string ingredients)
        {
            this.ingredients = ingredients;
        }

        public string getIngredients()
        {
            return this.ingredients;
        }

        public void setSteps(string steps)
        {
            this.steps = steps;
        }

        public string getSteps()
        {
            return this.steps;
        }

        public void setPrice(int price)
        {
            this.price = price;
        }

        public int getPrice()
        {
            return this.price;
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