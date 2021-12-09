namespace Core.Abstract
{
    public interface IVeri
    {
        //bu interfaceden kalıtım alarak oluşturulan tüm classlar veritabanı için kullanılmaktadır.
        bool SilindiMi { get; set; }

    }
}
