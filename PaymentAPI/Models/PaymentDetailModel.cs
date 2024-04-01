using System.ComponentModel.DataAnnotations;

namespace PaymentAPI.Models
{
    public class PaymentDetailModel
    {
        [Key]
        public int Id { get; set; }

        public required string CardOwnerName { get; set; }

        public string CardNumber { get; set; }

        public string ExpirationDate { get; set;}

        public string SecurityCode { get; set;}

    }
}
