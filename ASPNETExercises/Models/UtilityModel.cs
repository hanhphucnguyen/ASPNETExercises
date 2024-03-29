﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetExercises.Models
{
    public class UtilityModel
    {
        private AppDbContext _db;
        public UtilityModel(AppDbContext context) // will be sent by controller
        {
            _db = context;
        }
        public bool loadNutritionTables(string stringJson)
        {
            bool categoriesLoaded = false;
            bool menuItemsLoaded = false;
            try
            {
                dynamic objectJson = Newtonsoft.Json.JsonConvert.DeserializeObject(stringJson);
                categoriesLoaded = loadCategories(objectJson);
                menuItemsLoaded = loadMenuItems(objectJson);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return categoriesLoaded && menuItemsLoaded;
        }
        private bool loadCategories(dynamic objectJson)
        {
            bool loadedCategories = false;
            try
            {
                // clear out the old rows
                _db.Categories.RemoveRange(_db.Categories);
                _db.SaveChanges();
                List<String> allCategories = new List<String>();
                foreach (var node in objectJson)
                {
                    allCategories.Add(Convert.ToString(node["CATEGORY"]));
                }
                // distinct will remove duplicates before we insert them into the db
                IEnumerable<String> categories = allCategories.Distinct<String>();
                foreach (string catname in categories)
                {
                    Category cat = new Category();
                    cat.Name = catname;
                    _db.Categories.Add(cat);
                    _db.SaveChanges();
                }
                loadedCategories = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error - " + ex.Message);
            }
            return loadedCategories;
        }
        private bool loadMenuItems(dynamic objectJson)
        {
            bool loadedItems = false;
            try
            {
                List<Category> categories = _db.Categories.ToList();
                // clear out the old
                _db.MenuItems.RemoveRange(_db.MenuItems);
                _db.SaveChanges();
                foreach (var node in objectJson)
                {
                    MenuItem item = new MenuItem();
                    item.Calories = Convert.ToInt32(node["CAL"].Value);
                    item.Carbs = Convert.ToInt32(node["CARB"].Value);
                    item.Cholesterol = Convert.ToInt32(node["CHOL"].Value);
                    item.Fat = Convert.ToSingle(node["FAT"].Value);
                    item.Fibre = Convert.ToInt32(node["FBR"].Value);
                    item.Protein = Convert.ToInt32(node["PRO"].Value);
                    item.Salt = Convert.ToInt32(node["SALT"].Value);
                    item.Description = Convert.ToString(node["ITEM"]);
                    string cat = Convert.ToString(node["CATEGORY"].Value);
                    // add the FK here
                    foreach (Category category in categories)
                    {
                        if (category.Name == cat)
                            item.Category = category;
                    }
                    _db.MenuItems.Add(item);
                    _db.SaveChanges();
                }
                loadedItems = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error - " + ex.Message);
            }
            return loadedItems;
        }
    }
}
