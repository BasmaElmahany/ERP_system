using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_system.Data
{
    public class Village
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }


        [ForeignKey("Center")]
        public Guid CenterId { get; set; }


        public Center? Center { get; set; }

        public ICollection<Proceed>? Proceeds { get; set; }
    }
}
