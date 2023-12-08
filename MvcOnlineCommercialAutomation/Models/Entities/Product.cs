using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineCommercialAutomation.Models.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string ProductName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Brand { get; set; }
        public short Stock { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SalePrice { get; set; }
        public bool Exhausted { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string Picture { get; set; }

        public Category Category { get; set; }
        public ICollection<SalesTransaction> SalesTransactions { get; set; }

    }
}
