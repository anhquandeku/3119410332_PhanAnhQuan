using System.ComponentModel.DataAnnotations;

namespace PayMent.Entity
{
    public class TaxYear
    {
        [Key]
        public int Id { get; set; }
        public string YearOfTax { get; set; }
    }
}