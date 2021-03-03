using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //static verdiğinizde new'lemiyorsunuz!!
    public static class Messages
    {
        public static string AddSuccessMessage = "Eklendi";
        public static string AddErrorMessage = "Ekleme başarısız!";

        public static string UpdateSuccessMessage = "Güncellendi";
        public static string UpdateErrorMessage = "Güncelleme başarısız!";

        public static string DeleteSuccessMessage = "Silindi";
        public static string DeleteErrorMessage = "Silme başarısız!";

        public static string CarNoExist = "Böyle bir araç bulunamadı!";
        public static string CarExist = "Araç bulundu.";

        public static string BrandNoExist = "Böyle bir marka bulunamadı!";
        public static string BrandExist = "Marka bulundu.";

        public static string ColorNoExist = "Böyle bir renk bulunamadı!";
        public static string ColorExist = "Renk bulundu.";

        public static string CustomerNoExist = "Bu müşteri bulunamadı!";
        public static string CustomerExist = "Müşteri bulundu";

        public static string UserNoExist = "Bu kullanıcı bulunamadı!";
        public static string UserExist = "Kullanıcı bulunud.";

        public static string Listed = "Listelendi";
        public static string SuccessMessage = "İşlem başarılı";
        public static string ErrorMessage = "İşlem başarısız";
        public static string MaintenanceTime = "Bakımdayız";
        public static string CarImageLimitExceeded = "Resim limiti doldu";
        public static string AuthorizationDenied = "Yetkin YOK!";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";


    }
}
