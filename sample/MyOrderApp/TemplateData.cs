using LiteDB;
using MyOrderApp.Context;

namespace MyOrderApp;

public class TemplateData
{
    MyContext _context = new MyContext();

    public ILiteCollection<Category> TableCategory => _context.GetLiteDB().GetCollection<Category>();
    public ILiteCollection<SubCategory> TableSubCategory => _context.GetLiteDB().GetCollection<SubCategory>();
    public ILiteCollection<Product> TableProduct => _context.GetLiteDB().GetCollection<Product>();

    public TemplateData()
    {
        if (TableCategory.Count() <= 0)
            TableCategory.InsertBulk(Categories);
        if (TableSubCategory.Count() <= 0)
            TableSubCategory.InsertBulk(SubCategories);
        if (TableProduct.Count() <= 0)
            TableProduct.InsertBulk(Products);
    }

    private static Guid YemeklerId = Guid.Parse("b4741a98-e9da-4495-94b1-02127ad5cc25");
    private static Guid IceceklerId = Guid.Parse("e5e9b18d-99f2-49eb-901a-217e957f0bb8");
    private static Guid TatlilarId = Guid.Parse("d90022a3-6e8d-494d-ab8b-c99e05f6f2e4");
    private static Guid KurabiyelerId = Guid.Parse("8906736e-75e3-4618-8a58-3e087a8e3fe7");
    private static Guid KahveId = Guid.Parse("a07bfec7-1cd1-4373-be0b-e1adc74c4278");
    private static Guid DondurmaId = Guid.Parse("01b1a836-5f3f-44fa-8d14-ed376bc1dad3");
    private static Guid TatliTabagiId = Guid.Parse("53d857b1-cbac-4318-a234-b3e15432eed7");
    private static Guid GazliIceceklerId = Guid.Parse("a309e8b3-29bb-4c66-9c46-08636f260dae");
    private static Guid SicakIceceklerId = Guid.Parse("9789fbc6-86bd-49e5-873e-4a39ae005832");
    private static Guid SogukIceceklerId = Guid.Parse("4d97ea9b-0855-4c20-9bf0-2a07a8fecbca");
    private static Guid SalatalarId = Guid.Parse("8deb2967-ac6f-4081-bc77-35c142edd876");
    private static Guid AnaYemeklerId = Guid.Parse("ed445bea-d731-4468-b816-24ed2e994e94");
    private static Guid BaslangiclarId = Guid.Parse("67c975fc-ef21-4282-813d-cf898b386016");
    private static Guid CorbalarId = Guid.Parse("215a9e7e-3c2d-42ac-a3f6-437d8b2b562e");

    public static List<Category> Categories = new List<Category>()
    {
        new Category { Id = YemeklerId, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, Name = "Yemekler" },
        new Category { Id = IceceklerId, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, Name = "İçecekler" },
        new Category { Id = TatlilarId, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, Name = "Tatlılar" },
    };

    public static List<SubCategory> SubCategories = new List<SubCategory>()
    {
        new SubCategory { Id = CorbalarId, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, CategoryId = YemeklerId, Name = "Çorbalar" },
        new SubCategory { Id = BaslangiclarId, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, CategoryId = YemeklerId, Name = "Başlangıçlar" },
        new SubCategory { Id = AnaYemeklerId, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, CategoryId = YemeklerId, Name = "Ana Yemekler" },
        new SubCategory { Id = SalatalarId, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, CategoryId = YemeklerId, Name = "Salatalar" },
        new SubCategory { Id = SogukIceceklerId, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, CategoryId = IceceklerId, Name = "Soğuk İçecekler" },
        new SubCategory { Id = SicakIceceklerId, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, CategoryId = IceceklerId, Name = "Sıcak İçecekler" },
        new SubCategory { Id = GazliIceceklerId, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, CategoryId = IceceklerId, Name = "Gazlı İçecekler" },
        new SubCategory { Id = TatliTabagiId, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, CategoryId = TatlilarId, Name = "Tatlı Tabağı" },
        new SubCategory { Id = DondurmaId, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, CategoryId = TatlilarId, Name = "Dondurma" },
        new SubCategory { Id = KahveId, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, CategoryId = TatlilarId, Name = "Kahve" },
        new SubCategory { Id = KurabiyelerId, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, CategoryId = TatlilarId, Name = "Kurabiyeler" },
    };

    public static List<Product> Products = new List<Product>()
    {
        // Çorbalar
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = CorbalarId, Name = "Domates Çorbası", Description = "Taze domateslerle hazırlanan nefis bir çorba.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 40, Unit = "Kase" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = CorbalarId, Name = "Yoğurtlu Yayla Çorbası", Description = "Yoğurt ve nane ile lezzetlendirilmiş yayla çorbası.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 45, Unit = "Kase" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = CorbalarId, Name = "Ezogelin Çorbası", Description = "Kırmızı mercimek ve bulgurun birleşimiyle yapılan geleneksel bir çorba.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 35, Unit = "Kase" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = CorbalarId, Name = "Mercimek Çorbası", Description = "Geleneksel Türk mutfağının vazgeçilmez lezzeti mercimek çorbası.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 40, Unit = "Kase" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = CorbalarId, Name = "Tarator Çorbası", Description = "Yoğurtlu ve salatalıklı hafif bir soğuk çorba.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 38, Unit = "Kase" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = CorbalarId, Name = "Tavuklu Noodle Çorbası", Description = "Noodle ve tavuk parçaları ile zenginleştirilmiş lezzetli bir çorba.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 45, Unit = "Kase" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = CorbalarId, Name = "Sebzeli Bulgur Pilavı", Description = "Sebzeler ve baharatlarla tatlandırılmış nefis bir bulgur pilavı.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 42, Unit = "Kase" },
        
        // Başlangıçlar
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = BaslangiclarId, Name = "Humus", Description = "Nohut püresi ve tahin ile yapılan geleneksel bir Ortadoğu mezeti.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 25, Unit = "Tabak" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = BaslangiclarId, Name = "Sigara Böreği", Description = "İnce hamur içinde peynir ve maydanoz karışımı ile hazırlanan kıyır kıyır bir börek.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 30, Unit = "Adet" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = BaslangiclarId, Name = "Mantar Sote", Description = "Taze mantarlarla hazırlanan hafif bir sote.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 28, Unit = "Tabak" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = BaslangiclarId, Name = "Zeytinyağlı Yaprak Sarma", Description = "Üzüm yaprağı içinde pirinç, soğan ve baharatlarla hazırlanan geleneksel bir lezzet.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 28, Unit = "Porsiyon" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = BaslangiclarId, Name = "Patlıcan Ezme", Description = "Biber, sarımsak ve zeytinyağı ile karıştırılmış közlenmiş patlıcan ezmesi.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 25, Unit = "Tabak" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = BaslangiclarId, Name = "Cevizli Humus", Description = "Nohut püresi, tahin ve ceviz ile yapılmış nefis bir humus.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 30, Unit = "Tabak" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = BaslangiclarId, Name = "Ispanaklı Yumurta Rulosu", Description = "Ispanak ve yumurta ile hazırlanan rulo şeklinde bir başlangıç.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 32, Unit = "Adet" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = BaslangiclarId, Name = "Humus", Description = "Nohut püresi, tahin, ve zeytinyağı ile yapılmış humus.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 18, Unit = "Porsiyon" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = BaslangiclarId, Name = "Mozzarella Stick", Description = "Mozzarella peyniri içeren çıtır çıtır stickler.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 22, Unit = "Porsiyon" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = BaslangiclarId, Name = "Ahtapot Salatası", Description = "Izgara ahtapot dilimleri ile hazırlanmış ferahlatıcı salata.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 28, Unit = "Porsiyon" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = BaslangiclarId, Name = "Mini Pide Çeşitleri", Description = "Farklı iç harçlar ile hazırlanmış mini pideler.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 25, Unit = "Porsiyon" },
        
        // Ana Yemekler
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = AnaYemeklerId, Name = "Tavuk Şiş", Description = "Marine edilmiş tavuk parçalarının şişe dizilip ızgarada pişirildiği lezzetli bir ana yemek.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 65, Unit = "Porsiyon" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = AnaYemeklerId, Name = "Ispanaklı Börek", Description = "Taze ıspanak ve peynirle doldurulmuş nefis bir börek.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 45, Unit = "Porsiyon" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = AnaYemeklerId, Name = "Izgara Somon", Description = "Taze somon filetosunun ızgarada pişirilmiş hali.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 75, Unit = "Porsiyon" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = AnaYemeklerId, Name = "Fırın Tavuk", Description = "Baharatlarla marine edilmiş ve fırında pişirilmiş lezzetli tavuk.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 60, Unit = "Porsiyon" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = AnaYemeklerId, Name = "Mantarlı Risotto", Description = "Mantar ve parmesan peyniri ile zenginleştirilmiş nefis bir risotto.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 55, Unit = "Porsiyon" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = AnaYemeklerId, Name = "Fırın Alabalık", Description = "Fırında pişirilmiş taze alabalık balığı.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 65, Unit = "Porsiyon" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = AnaYemeklerId, Name = "Sebzeli Kuzu Güveç", Description = "Kuzu eti ve taze sebzelerle hazırlanan güveç.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 70, Unit = "Porsiyon" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = AnaYemeklerId, Name = "Fırın Karnabahar", Description = "Baharatlar ve zeytinyağı ile marine edilmiş fırın karnabahar.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 35, Unit = "Porsiyon" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = AnaYemeklerId, Name = "Karides Güveç", Description = "Taze karides ve sebzelerle hazırlanan güveç.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 80, Unit = "Porsiyon" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = AnaYemeklerId, Name = "Tavuk Kızartma", Description = "Çıtır dış, yumuşak iç tavuk kızartması.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 55, Unit = "Porsiyon" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = AnaYemeklerId, Name = "Izgara Dana Bonfile", Description = "Özel marine sosu ile marine edilmiş dana bonfile.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 90, Unit = "Porsiyon" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = AnaYemeklerId, Name = "Sebzeli Kuzu Tandır", Description = "Sebzelerle birlikte pişirilmiş nefis kuzu tandır.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 75, Unit = "Porsiyon" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = AnaYemeklerId, Name = "Mantarlı Risotto", Description = "Taze mantarlar ile yapılmış lezzetli bir risotto.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 40, Unit = "Porsiyon" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = AnaYemeklerId, Name = "Kıymalı Karnabahar", Description = "Kıyma ve baharatlarla harmanlanmış karnabahar yemeği.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 45, Unit = "Porsiyon" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = AnaYemeklerId, Name = "Balık Tava", Description = "Taze deniz balığı tavada pişirilmiş hafif bir ana yemek.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 65, Unit = "Porsiyon" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = AnaYemeklerId, Name = "Karnabahar Köfte", Description = "Karnabahar püresi ve baharatlarla yapılmış nefis köfte.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 50, Unit = "Porsiyon" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = AnaYemeklerId, Name = "Karides Güveç", Description = "Taze karides ve sebzelerle hazırlanan güveç.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 70, Unit = "Porsiyon" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = AnaYemeklerId, Name = "Kuzu Kleftiko", Description = "Kuzu eti, patates ve baharatlarla pişirilmiş geleneksel bir Yunan yemeği.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 80, Unit = "Porsiyon" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = AnaYemeklerId, Name = "Enginarlı Tavuk", Description = "Enginar ile zenginleştirilmiş tavuk yemeği.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 65, Unit = "Porsiyon" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = AnaYemeklerId, Name = "Köri Soslu Makarna", Description = "Tavuklu makarna üzerine lezzetli köri sosu.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 55, Unit = "Porsiyon" },

        // Soğuk İçecekler
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = SogukIceceklerId, Name = "Limonata", Description = "Taze sıkılmış limon suyu ile yapılan serinletici bir içecek.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 15, Unit = "Bardak" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = SogukIceceklerId, Name = "Meyve Suyu", Description = "Çeşitli meyvelerin karışımından elde edilen doğal meyve suyu.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 18, Unit = "Bardak" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = SogukIceceklerId, Name = "Milkshake", Description = "Süt, dondurma ve çeşitli lezzetlerle hazırlanan nefis bir içecek.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 20, Unit = "Bardak" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = SogukIceceklerId, Name = "Ayran", Description = "Yoğurt ve su karışımından yapılan serinletici bir içecek.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 10, Unit = "Bardak" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = SogukIceceklerId, Name = "Naneli Limonata", Description = "Taze sıkılmış limon suyu ve nane ile aromalandırılmış serinletici içecek.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 12, Unit = "Bardak" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = SogukIceceklerId, Name = "Mango Smoothie", Description = "Taze mango ve yoğurt ile hazırlanan sağlıklı bir smoothie.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 15, Unit = "Bardak" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = SogukIceceklerId, Name = "Portakal Suyu", Description = "Doğal taze sıkılmış portakal suyu.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 14, Unit = "Bardak" },

        // Sıcak İçecekler
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = SicakIceceklerId, Name = "Espresso", Description = "Koyu kahve çekirdeklerinden yapılan yoğun ve kısa bir kahve içkisi.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 18, Unit = "Fincan" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = SicakIceceklerId, Name = "Latte", Description = "Espresso üzerine süt köpüğü eklenmiş sıcak bir kahve içkisi.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 22, Unit = "Bardak" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = SicakIceceklerId, Name = "Salep", Description = "Salep tozu ve süt ile yapılan geleneksel bir Türk içkisi.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 25, Unit = "Fincan" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = SicakIceceklerId, Name = "Türk Kahvesi", Description = "Geleneksel Türk kahvesi, demlenmiş ve köpüklü.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 18, Unit = "Fincan" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = SicakIceceklerId, Name = "Chai Latte", Description = "Siyah çay, baharatlar ve sütün birleşimiyle yapılan sıcak içecek.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 20, Unit = "Bardak" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = SicakIceceklerId, Name = "Salep", Description = "Salep tozu ve süt ile hazırlanan geleneksel bir Türk içkisi.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 25, Unit = "Fincan" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = SicakIceceklerId, Name = "Mint Çikolata Sıcak İçecek", Description = "Taze nane ve çikolata ile aromalandırılmış sıcak içecek.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 22, Unit = "Bardak" },

        // Gazlı İçecekler
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = GazliIceceklerId, Name = "Cola", Description = "Ünlü kola markasının ferahlatıcı içkisi.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 12, Unit = "Şişe" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = GazliIceceklerId, Name = "Fanta", Description = "Portakal aromalı gazlı içecek.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 12, Unit = "Şişe" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = GazliIceceklerId, Name = "Sprite", Description = "Limon aromalı gazlı içecek.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 12, Unit = "Şişe" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = GazliIceceklerId, Name = "Pepsi", Description = "Ünlü kola markasının ferahlatıcı içkisi.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 12, Unit = "Şişe" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = GazliIceceklerId, Name = "Gazoz", Description = "Geleneksel gazoz içkisi.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 10, Unit = "Şişe" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = GazliIceceklerId, Name = "Perrier", Description = "Doğal mineralli su içeren lüks maden suyu.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 15, Unit = "Şişe" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = GazliIceceklerId, Name = "Red Bull", Description = "Enerji içeceği.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 18, Unit = "Şişe" },

        // Tatlı Tabağı
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = TatliTabagiId, Name = "Mixed Dessert Plate", Description = "Farklı tatlıların küçük porsiyonlarını içeren lezzetli bir tatlı tabağı.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 50, Unit = "Tabak" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = TatliTabagiId, Name = "Cheesecake Dilimleri", Description = "Çeşitli cheesecake çeşitlerinden oluşan bir tatlı tabağı.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 55, Unit = "Tabak" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = TatliTabagiId, Name = "Çikolatalı Profiterol", Description = "Çıtır profiterol topları içerisinde çikolata sosu ile servis edilen tatlı tabağı.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 60, Unit = "Tabak" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = TatliTabagiId, Name = "Assorted Mini Desserts", Description = "Farklı tatlıların minik porsiyonlarından oluşan tatlı tabağı.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 55, Unit = "Tabak" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = TatliTabagiId, Name = "Çilekli Waffle", Description = "Çilek dilimleri ve çikolata sos ile süslenmiş nefis bir waffle.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 48, Unit = "Tabak" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = TatliTabagiId, Name = "Fındıklı Baklava Dilimleri", Description = "Antep fıstığı ve fındıklı baklava dilimleri.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 50, Unit = "Tabak" },

        // Dondurma
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = DondurmaId, Name = "Vanilya Dondurma", Description = "Sade ve enfes vanilya lezzeti ile yapılmış dondurma.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 8, Unit = "Top" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = DondurmaId, Name = "Çikolatalı Fudge Dondurma", Description = "Yoğun çikolata parçacıkları ve fudge sos içeren lezzetli bir dondurma.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 10, Unit = "Top" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = DondurmaId, Name = "Meyve Şöleni Dondurma", Description = "Çeşitli meyve parçaları içeren ferahlatıcı bir meyve dondurması.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 12, Unit = "Top" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = DondurmaId, Name = "Çilek-Peynir Dondurması", Description = "Taze çilek ve peynirle yapılan sıra dışı bir dondurma lezzeti.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 12, Unit = "Top" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = DondurmaId, Name = "Karamel Kıtır Dondurma", Description = "Yoğun karamel sos ve kıtır parçacıklar içeren enfes bir dondurma.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 14, Unit = "Top" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = DondurmaId, Name = "Limonlu Yoğurt Dondurması", Description = "Taze limon ve yoğurt ile yapılmış hafif bir dondurma.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 10, Unit = "Top" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = DondurmaId, Name = "Antep Fıstıklı Dondurma", Description = "Antep fıstığı içeren geleneksel bir dondurma çeşidi.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 15, Unit = "Top" },


        // Kahve
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = KahveId, Name = "Cappuccino", Description = "Espresso, süt buharı ve süt köpüğünün birleşiminden oluşan İtalyan kahve içkisi.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 20, Unit = "Fincan" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = KahveId, Name = "Mocha", Description = "Espresso, sıcak çikolata ve sütün birleşimiyle yapılan tatlı bir kahve içkisi.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 22, Unit = "Bardak" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = KahveId, Name = "Türk Kahvesi", Description = "İnce çekilmiş kahve çekirdekleriyle demlenmiş geleneksel Türk kahvesi.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 18, Unit = "Fincan" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = KahveId, Name = "Macchiato", Description = "Espresso üzerine bir miktar süt köpüğü eklenmiş kahve içkisi.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 15, Unit = "Fincan" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = KahveId, Name = "Flat White", Description = "Espresso üzerine süt köpüğü eklenmiş kremalı kahve içkisi.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 18, Unit = "Bardak" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = KahveId, Name = "Turkish Delight Coffee", Description = "Geleneksel Türk lokumu aromalı kahve içkisi.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 20, Unit = "Fincan" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = KahveId, Name = "Hazelnut Mocha", Description = "Fındık aromalı çikolatalı kahve içkisi.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 22, Unit = "Bardak" },


        // Kurabiyeler
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = KurabiyelerId, Name = "Çikolatalı Kurabiye", Description = "Yoğun çikolata parçacıkları içeren nefis bir kurabiye.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 5, Unit = "Adet" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = KurabiyelerId, Name = "Bademli Kurabiye", Description = "İnce dövülmüş badem içeren hafif ve gevrek bir kurabiye.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 6, Unit = "Adet" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = KurabiyelerId, Name = "Limonlu Kurabiye", Description = "Taze limon kabuğu rendesi içeren ferahlatıcı bir kurabiye.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 4, Unit = "Adet" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = KurabiyelerId, Name = "Fındıklı Brownie Kurabiye", Description = "Fındık parçacıkları içeren yoğun çikolatalı brownie tadında bir kurabiye.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 6, Unit = "Adet" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = KurabiyelerId, Name = "Çikolata Chip Kurabiye", Description = "Bol çikolata chip içeren klasik bir kurabiye.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 5, Unit = "Adet" },
        new Product { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, IsActive = true, SubCategoryId = KurabiyelerId, Name = "Badem Ezmesi Kurabiye", Description = "Badem ezmesi ile yapılmış lezzetli bir kurabiye.", DiscountRate = 0, IsDiscount = false, IsFavorite = false, Price = 7, Unit = "Adet" }

    };
}
