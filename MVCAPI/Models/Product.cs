using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCAPI.Models
{
    public class Product
    {
        private int Id;
        private string? Name;
        private float Price;
        private int Quantity;
        private int Cat_id;
    }
}
