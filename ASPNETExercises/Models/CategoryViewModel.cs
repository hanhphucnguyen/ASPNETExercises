using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
namespace ASPNetExercises.Models
{
    public class CategoryViewModel
    {
        private List<Category> _categories;
        public CategoryViewModel() { }
        public string CategoryName { get; set; }
        public int Id { get; set; }
        public IEnumerable<MenuItem> MenuItems { get; set; }
        public IEnumerable<SelectListItem> GetCategories()
        {
            return _categories.Select(category => new SelectListItem { Text = category.Name, Value = category.Id.ToString() });
        }
        public void SetCategories(List<Category> cats)
        {
            _categories = cats;
        }
    }
}