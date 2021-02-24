﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages //static = her zaman new' lemen gerekmez
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductnameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed = "Ürünler istelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Böyle bir ürün ismi zaten mevcut";
        public static string CategoryLimitExceded = "Categori limitine ulaşıldı";
    }
}
