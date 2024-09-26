using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication2.Models
{
    public class Item
    {
        public int Id { get; set; }               // Unique identifier
        public string Name { get; set; }          // Name of the item
        public string Recipient { get; set; }     // Recipient of the item
        public string Supplier { get; set; }      // Supplier of the item
        public decimal Price { get; set; }        // Price of the item

        // Enum to classify item importance
        public ImportanceType ItemType { get; set; }
    }

    // Enum to represent the type of the item
    public enum ImportanceType
    {
        Necessary,        // Item is necessary
        GoodToHave,       // Item is good to have
        NotNecessary      // Item is not necessary
    }


}
