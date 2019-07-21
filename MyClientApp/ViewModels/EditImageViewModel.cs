using ImageGallery.Model;
using System;
using System.ComponentModel.DataAnnotations;

namespace MyClient.ViewModels
{
    public class EditImageViewModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public Guid Id { get; set; }  
    }
}
