namespace Onlinemoviesystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class theatre_class
    {
        public int Theatre_ID { get; set; }
        [Required(ErrorMessage = "Theatre name is required")]
        public string Theatre_Name { get; set; }
        [Required(ErrorMessage = "Theatre city is required")]
        public string Theatre_City { get; set; }
        [Required(ErrorMessage = "Movie is required")]
        public string Movie { get; set; }
        [Required(ErrorMessage = "Screen type is required")]
        public string List_Of_Screens { get; set; }
        [Required(ErrorMessage = "Manager name is required")]
        public string Manager_Name { get; set; }
    }
}
