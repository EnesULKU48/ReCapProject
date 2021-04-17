using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //Auth
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string UserRegistered = "kayıt oldu";
        public static string UserAlreadyExists = "kullanıcı mevcut";
        //Car
        public static string CarAdded = "Araç başarılı bir şekilde eklendi.";
        public static string CarDeleted = "Araç başarılı bir şekilde silindi.";
        public static string CarUpdated = "Araç başarılı bir şekilde güncellendi.";
        public static string CarListed= "Araçlar listelendi.";
        public static string CarListedByBrand= "Araçlar markaya göre listelendi.";
        public static string CarListedByColor= "Araçlar renge göre listelendi.";
        public static string CarListedByModelYear = "Araçlar model yılına göre listelendi.";
        //Brand
        public static string BrandAdded= "Marka başarılı bir şekilde eklendi.";
        public static string BrandDeleted= "Marka başarılı bir şekilde silindi.";
        public static string BrandUpdated= "Marka başarılı bir şekilde güncellendi.";
        public static string BrandListed= "Marka başarılı bir şekilde listelendi.";
        //Color
        public static string ColorAdded = "Renk başarılı bir şekilde eklendi.";
        public static string ColorDeleted = "Renk başarılı bir şekilde silindi.";
        public static string ColorUpdated = "Renk başarılı bir şekilde güncellendi.";
        public static string ColorListed = "Renk başarılı bir şekilde listelendi.";
        //Rental
        public static string RentalAdded = "Araç kirası eklendi";
        public static string RentalDeleted = "Araç kirası silindi";
        public static string RentalUpdated = "Araç kirası güncellendi";
        public static string RentalListed = "Kira listesi listelendi";

        //Customer
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerListed = "Müşteriler listelendi";

        //User
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserListed = "Kullanıcı listelendi";

        //Errors
        public static string CarNameInvalid = "Araç ismi min 2 karakter ve günlük fiyatı min 1 olmalıdır.";
        public static string CarUpdateInvaild = "Araç ismi min 2 karakter ve günlük fiyatı min 1 olmalıdır.";
        public static string BrandNameInvaild = "Araç markası min 2 karakter olmalıdır";
        public static string ColorNameInvaild = "Geçersiz renk.";
        public static string MaintenanceTime = "Bakım çalışması yapılmaktadır. Teşekkürler.";
        public static string RentalInvalid = "Seçili araç kiralanmıştır.";
        public static string CarImageLimitExceeded = "5'ten fazla resim eklenemez";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string CarImagesAdded = "Araba resmi eklendi";
    }
}
