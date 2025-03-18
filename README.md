### Airport Task - Runway Data Transfer
Bu proje, Runway verilerini bir versiyon (Version 22) tablosundan diğerine (Version 19) aktarmak için geliştirilmiştir. Proje, AutoMapper ve Entity Framework Core (EF Core) kullanarak verilerin güvenli ve verimli bir şekilde aktarılmasını sağlar.

## Proje Özeti
Version 22 tablosundaki veriler, Version 19 tablosuna aktarılacaktır.
Veriler arasındaki bazı farklar göz önünde bulundurularak (örneğin, bazı satırların silinmesi ve verilerin düzenlenmesi) aktarım işlemi yapılır.
RunwayService sınıfı, verileri alır, dönüştürür ve yeni tabloya ekler.
API aracılığıyla bu veri transferi yapılabilir.

## Kullanılan Teknolojiler
AutoMapper: Veritabanı modelleri arasındaki dönüşümleri daha kolay ve temiz bir şekilde yapabilmek için kullanılır.
Entity Framework Core (EF Core): Veritabanı işlemleri için kullanılır.
ASP.NET Core: Web API'yi oluşturmak için kullanılır.

## Proje Yapısı
AirportTask.Context: Veritabanı bağlamını içeren sınıflar.
AirportTask.Model: Veritabanı tablolarını temsil eden model sınıflar.
AirportTask.Business: İş mantığını içeren sınıflar.
AirportTask.Controllers: API endpointlerini içeren denetleyiciler.

## Nasıl Çalışır?
Adım 1: Veritabanı Bağlantısı
Proje, EF Core kullanarak iki farklı versiyon tablosu (Runway22 ve Runway19) üzerinde işlem yapmaktadır. İlgili veritabanı bağlantısı ApplicationDbContext sınıfı aracılığıyla yapılmaktadır.

Adım 2: AutoMapper Kullanımı
AutoMapper, Runway22 verilerini alır ve bunları Runway19 modeline dönüştürür. Dönüştürme işleminde, bazı veri alanları (Threshold Crossing Height) başındaki sıfırlardan arındırılarak aktarılır.

Adım 3: API Endpoints
RunwayController, /api/runway/transfer endpoint'ini kullanarak verilerin transfer edilmesini sağlar. Bu endpoint'e yapılan POST isteği ile veriler Version 22'den Version 19'a aktarılır.

Adım 4: Veri Aktarımı
TransferRunwayDataAsync metodu, Runway22 tablosundaki tüm verileri alır, AutoMapper kullanarak Runway19 modeline dönüştürür ve veritabanına ekler.

## Kullanım
API'yi Çalıştırma
Projeyi kendi bilgisayarınıza klonlayın:

bash
git clone https://github.com/yourusername/airport-task.git

## Gerekli NuGet paketlerini yükleyin:

bash
dotnet restore
Veritabanı bağlantı ayarlarını yapılandırın. appsettings.json dosyasında gerekli ayarları yapın.

## Projeyi başlatın:

bash
dotnet run
API'yı çağırmak için aşağıdaki örnek POST isteğini kullanabilirsiniz:

bash
POST http://localhost:5000/api/runway/transfer
Başarıyla tamamlandığında, aşağıdaki mesaj döndürülecektir:

json
{
    "message": "Veriler başarıyla aktarıldı!"
}

## Runway22 verisi başta bu şekildedir
![image](https://github.com/user-attachments/assets/64962b11-3984-4923-ba61-09edd94abe9b)
## API isteğimizi oluşturduk ve çalıştırdık . 200 status code aldık başarılı.
![image](https://github.com/user-attachments/assets/c4fe1552-42d6-400a-a4ec-5e0fb29bbff3)
## Db'de kontrol ettiğimizde Runway19 tablomuz istedğimiz şekilde güncellenmiş.
![image](https://github.com/user-attachments/assets/a9958d2d-2280-4b55-8d68-57c97ff9d345)


