using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_system.Data
{
    //اجمالي التوريد + المستحق
    public class Budget
    {
        [Key]
        public Guid id { get; set; }

        public int year { get; set; }


        public Center? Center { get; set; }

        [ForeignKey("Center")]
        public Guid centerId { get; set; }

        [ForeignKey("serveying")]
        public Guid serveyingID { get; set; }
        public Item? serveying { get; set; }
        public decimal serveying_amount { get; set; } = 0;


        [ForeignKey("level")]
        public Guid levelID { get; set; }
        public Item? level { get; set; }
        public decimal level_amount { get; set; } = 0;


        [ForeignKey("facilities")]
        public Guid facilitiesID { get; set; }
        public Item? facilities { get; set; }
        public decimal facilities_amount { get; set; } = 0;


        public decimal Total { get; set; }

        public decimal CalcTotal()
        {
            return Total = facilities_amount + level_amount + serveying_amount;
        }

        public void UpdateTotal()
        {
            Total = CalcTotal();
        }

    }
}
