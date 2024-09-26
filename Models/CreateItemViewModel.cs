using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication2.Models;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public class CreateItemViewModel
    {
        public Item Item { get; set; }                       // The item being created
        public IEnumerable<SelectListItem> ItemTypes { get; set; } // Dropdown list for item types
    }
}
