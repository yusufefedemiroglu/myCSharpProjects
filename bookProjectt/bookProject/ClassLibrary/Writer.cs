using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Writer
    {
        [DisplayName("Yazar Numarası")]
        [Required(ErrorMessage = "Yazar Numarası zorunlu alandır")]
        public int writerID {  get; set; }

        [DisplayName("Yazar Adı")]
        [Required(ErrorMessage = "Yazar Adı zorunlu alandır")]
        public string writerName {  get; set; }
    }
}
