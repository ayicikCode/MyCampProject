using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{     //static yaparsak new yapmaya gerek kalmaz...
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem Bakımda.";
        public static string ProductsListed = "Ürünler Listelendi.";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Bu isimde başka bir ürün zaten bulunmaktadır.";
        public static string CategoryLimitExceded = "KAtegori limit aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
