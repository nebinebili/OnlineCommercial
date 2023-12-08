using System.ComponentModel.DataAnnotations;

namespace MvcOnlineCommercialAutomation.Models.Entities
{
    public class SalesTransaction
    {
        [Key]
        public int SalesId { get; set; }

        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }


        public Product Product { get; set; }
        public Client Client { get; set; }
        public Employee Employee { get; set; }
    }
}
