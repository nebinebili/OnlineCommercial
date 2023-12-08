using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineCommercialAutomation.Models.Entities
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Name { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Surname { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(13)]
        public string City { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Mail { get; set; }

        public ICollection<SalesTransaction> SalesTransactions { get; set; }

    }
}
