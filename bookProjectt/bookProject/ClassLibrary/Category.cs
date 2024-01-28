using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ClassLibrary
{
    public class Category
    {
        [DisplayName("Kategori Numarası")]
        [Required(ErrorMessage = "Kategori Numarası zorunlu alandır")]
        public int categoryID {  get; set; }

        [DisplayName("Kategori İsmi")]
        [Required(ErrorMessage = "Kategori İsmi zorunlu alandır")]
        public string categoryName { get; set; }

    }
}