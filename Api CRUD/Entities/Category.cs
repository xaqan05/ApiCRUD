using System.ComponentModel.DataAnnotations;

namespace Api_CRUD.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; } = 1;


        [Required]
        public string Name { get; set; } = null!;

        int _id;
        public Category(int id)
        {

            Id = ++_id;

        }
    }
}
