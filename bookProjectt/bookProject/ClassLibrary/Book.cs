using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Book
    {

        [DisplayName("Kitap Numarası")]
        [Required(ErrorMessage = "Id zorunlu alandır")]
        public int id {  get; set; }


        [DisplayName("Adı")]
        [Required(ErrorMessage = "Kitap İsmi zorunlu alandır")]
        public string bookName {  get; set; }



        [DisplayName("Sayfa Sayısı")]
        [Required(ErrorMessage = "Sayfa Sayısı zorunlu alandır")]
        public int bookPage { get; set; }


        [DisplayName("Kitap Ücreti")]
        [Required(ErrorMessage = "Kitap Ücreti zorunlu alandır")]
        public decimal bookPrice { get; set; }


        [DisplayName("Kitap Resmi")]
        public string ImageUrl { get; set; }





    }
}
