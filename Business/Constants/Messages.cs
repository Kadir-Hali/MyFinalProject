using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        internal static string ProductNameAlreadyExists = "Aynı isimde başka bir ürün bulunmakta!";
        internal static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemeiyor.";
    }
}
