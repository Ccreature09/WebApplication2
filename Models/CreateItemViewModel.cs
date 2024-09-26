using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public class CreateItemViewModel
    {
        public Item Item { get; set; } = new Item(); // Initialize to avoid null reference
        public string ItemType { get; set; } = string.Empty; // For user input
        public List<SelectListItem> ItemTypes { get; set; } = new List<SelectListItem>(); // Add this property
    }
}
