using System.ComponentModel.DataAnnotations;

namespace ERP_system.Data
{
    public class Center
    {
        [Key]
        public Guid centerId { get; set; }

        public string centerName { get; set; }
        public ICollection<Payment_order>? Payment_orders { get; set; }

    }
}
