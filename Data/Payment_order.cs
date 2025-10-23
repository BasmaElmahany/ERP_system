using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_system.Data
{
    public class Payment_order
    {
        public Guid Id { get; set; }


        [ForeignKey("center")]
        public Guid centerId { get; set; }

        public Center? center { get; set; }

        public DateOnly Date {  get; set; }


        [ForeignKey("serveying")]
        public Guid serveyingID { get; set; }
        public Item? serveying { get; set; }
        public decimal serveying_amount { get; set; } = 0;
        public string? payment_image_serveying { get; set; }


        [ForeignKey("level")]
        public Guid levelID { get; set; }
        public Item? level { get; set; }
        public decimal level_amount { get; set; } = 0;
        public string? payment_image_level { get; set; }




        [ForeignKey("facilities")]
        public Guid facilitiesID { get; set; }
        public Item? facilities { get; set; }
        public decimal facilities_amount { get; set; } = 0;
        public string? payment_image_facilities { get; set; }


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
