namespace FDMC.Models
{
    using System.ComponentModel.DataAnnotations;

    namespace FDMC.Models
    {
        public class Cat
        {
            public int Id { get; set; }

            [Required(ErrorMessage = "The name field is required.")]
            public string Name { get; set; }

            [Required(ErrorMessage = "The age field is required.")]
            [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid age.")]
            public int Age { get; set; }

            [Required(ErrorMessage = "The breed field is required.")]
            public string Breed { get; set; }

            [Required(ErrorMessage = "The imageUrl field is required.")]
            [Url(ErrorMessage = "Please enter a valid URL.")]
            public string ImageUrl { get; set; }
        }
    }

}
