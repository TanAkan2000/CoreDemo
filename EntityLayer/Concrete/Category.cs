using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key] 
        //erişim belirleyici türü-değişken türü-isim{get set}
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; } //categoryi silmek yerine aktif yada pasife çevircez
        public List<Blog> Blogs { get; set; }

    } 


}
// migration ile amaç codefirst yaklaşımı ile veri tabanını inşaa etmek
// db setleri veri tabanı üzerinden yansıtmak
//context sınıfı dataacces katmanında o yüzden onu seçmek gerek
