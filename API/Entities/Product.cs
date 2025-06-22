// A namespace is like a folder that groups related classes together
// to keep code organized and avoid name conflicts.
namespace API.Entities
{
    // 'required' tells the compiler:
    // 👉 "These properties must be set when creating the object."
    // So we don’t need to initialize them with empty strings like "".
    public class Product
    {
        // Shortcut: prop → Tab
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public long Price { get; set; }
        public required string PictureURL { get; set; }
        public required string Type { get; set; }
        public required string Brand { get; set; }
        public int QuantityInStock { get; set; }
    }
}
