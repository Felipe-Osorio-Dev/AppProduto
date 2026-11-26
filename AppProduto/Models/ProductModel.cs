using SQLite;
using System.ComponentModel;

namespace AppProduto.Models
{
    [Table("Produtos")]
    internal class ProductModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(50), NotNull]
        public string Name { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? Description { get; set; }

        [NotNull, DefaultValue(0)]
        public decimal Price { get; set; }

        [NotNull, DefaultValue(0)]
        public int Stock { get; set; }
    }
}
