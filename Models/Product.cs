using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNETIdentity.Models
{

    [Table("catrgory")]
    public class Product
    {

        public int id { get; set; }

        public string name { get; set; }
    }
}
