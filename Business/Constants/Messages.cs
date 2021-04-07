using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç Eklendi";
        public static string BrandAdded = "Marka Eklendi";
        public static string ColordAdded = "Renk Eklendi";
        public static string CarNameInvalid = "Araç İsmi Geçersiz";
        public static string BrandNameInvalid = "Marka İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarsListed= "Araçlar Listelendi";
        public static string BrandsListed= "Markalar Listelendi";
        public static string ColorsListed= "Markalar Listelendi";
        public static string UsersListed= "Kullanıcılar Listelendi";
        public static string RentalsListed= "Kiralamalar Listelendi";
        public static string RentalAdded= "Kiralama Eklendi";
        public static string RentalInvalid= "Araç teslim edilmediği için kiralama yapılamıyor";
        public static string CustomersListed= "Kullanıcılar Listelendi";
        public static string CarDeleted= "Araç Silindi";
        public static string BrandDeleted= "Marka Silindi";
        public static string ColorDeleted= "Renk Silindi";
        public static string CarUpdated= "Araç Güncellendi";
        public static string BrandUpdated= "Marka Güncellendi";
        public static string UserMailInvalid = "Email adresi hatalı veya Kullanılıyor.";
        public static string CarImageAdded = "Araç Fotoğrafı Eklendi.";
        public static string CarImageDeleted = "Araç Fotoğrafı Silindi";
        public static string CarImagesListed = "Fotoğraflar Listelendi.";
        public static string CarCheckImageLimited = "Fotoğraf Limiti 5 adet ile sınırlıdır.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt Başarılı";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre Hatalı";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Böyle bir kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
