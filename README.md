# HOCAYA CEVAPLAR: TEKNİK NOTLAR

Hoca soru sorduğunda bu basit benzetmeleri ve tanımları kullanarak projeyi çok profesyonelce savunabilirsiniz.

## 1. N-Tier (Katmanlı Mimari) Nedir? Neden Kullandınız?
**Cevap:** "Hocam, projemizin düzenli olması ve ileride büyümesi için Katmanlı Mimari kullandık. Bu yapıyı bir pastaya benzetebiliriz:
- **EntityLayer:** Malzemeler (Tablolarımızın tasarımı).
- **DataAccessLayer:** Mutfağımız (Veritabanına bağlanıp veri kaydettiğimiz yer).
- **BusinessLayer:** Tarifimiz (Hesaplamalar ve kurallar).
- **WebMvcLayer:** Vitrinimiz (Kullanıcının gördüğü tasarım)."

## 2. Entity Framework Core Nedir?
**Cevap:** "Veritabanıyla bizim yerimize konuşan bir aracıdır. Biz SQL kodu yazmak yerine C# nesneleriyle çalışıyoruz, o arka planda tablo işlemlerini hallediyor."

## 3. Migration (Göç) Nedir?
**Cevap:** "Veritabanımızın planıdır. Biz C# tarafında tabloları güncellediğimizde, 'Add-Migration' komutuyla bu değişikliklerin veritabanına nasıl yansıyacağını sisteme öğretiyoruz."

## 4. Dosya Yapısındaki "Concrete" Klasörü Nedir?
**Cevap:** "Hocam, 'Concrete' (Somut) klasörü içine projemizin gerçek iş yapacak, somut sınıflarını koyuyoruz. Bu, kodun daha düzenli ve okunabilir olmasını sağlıyor."

## 5. Seed Data (Örnek Veri) Neden Var?
**Cevap:** "Sistemi ilk kez çalıştırdığımızda dükkanın (veritabanının) boş kalmaması için; temel kategorileri (Pasta, Kuruvasan) ve malzemeleri otomatik olarak yüklüyoruz. Böylece testimizi hemen yapabiliyoruz."

## 6. Projenin Mevcut Durumu Nedir? (Hoca Neyi Görecek?)
**Cevap:** "Hocam şu an projemizin omurgasını (Katmanları), veritabanı şemasını (Entities) ve modern arayüzümüzü (Frontend) tamamladık. Bir sonraki aşamada tasarım sihirbazını (Wizard) ve canlı kalori hesaplama motorunu kodlayacağız."

---

## 🚀 Projeyi Çalıştırma Komutu

Projeyi başlatmak için terminalde projenin ana dizinindeyken şu komutu çalıştırmanız yeterlidir:

```powershell
dotnet run --project Pastimza.WebMvcLayer
```

Uygulama ayağa kalktığında tarayıcınızdan **http://localhost:5190** adresine gidebilirsiniz.
