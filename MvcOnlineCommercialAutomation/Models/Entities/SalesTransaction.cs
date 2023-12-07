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


        public ICollection<Product> Products { get; set; }
        public ICollection<Client> Clients { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
