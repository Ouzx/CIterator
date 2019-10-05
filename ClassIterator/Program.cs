using System;
using System.Reflection;

namespace ClassIterator
{
    /*
     * http://www.idlebundle.com/c-class-functional-class-iteration-generic/
     */
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A(); //Örnek sınıfımız A olsun
            a.aaa = 10; //A sınıfının elemanlarına rastgele değerler verelim.
            a.bbb = 11;
            a.ccc = 12;
            a.ddd = 13;
            a.eee = 14;
            //Oluşturduğumuz sınıfın tüm elemanlarını
            // gezmek için yazdığımız sınıfın kurucu metoduna gönderiyoruz.
            CIterator<A> c = new CIterator<A>(a);
            Console.Read(); //Konsol ekranının kapanmaması için.
        }
    }
    class A
    {
        //Rastgele propertyler
        public int aaa { get; set; }
        public int bbb { get; set; }
        public int ccc { get; set; }
        public int ddd { get; set; }
        public int eee { get; set; }
    }
    class CIterator<T>
    //Generic ifade alacağını belirttik,
    // bize sadece T nin tipi lazım olduğu için T için herhangi bir koşul koymadık.
    {
        public CIterator(T t)//T türünden türetilmiş bir parametre istedik.
        {
            Type type = typeof(T); //T'nin türünü bulduk
                                   //Tanımladığımız PropertyInfo[] dizisine
                                   //T sınıfının tüm propertylerini(özelliklerini/elemanlarını) atadık. 
            PropertyInfo[] properties = type.GetProperties();
            //Foreach döngüsü ile ilgili sınıfın tüm elemanlarını gezdik
            foreach (PropertyInfo property in properties)
            {
                //property.Name = değişkenin kendi adı
                //propert.GetValue() değişkenin değeri
                Console.WriteLine("{0} = {1}", property.Name, property.GetValue(t, null));
            }
            foreach (PropertyInfo property in properties)
            {
                /*
                 * propert.SetValue(t,10); kodu şu haliyle çok tehlikelidir
                 * basit bir şekilde çalışma mantığını göstermek için böyle koydum.
                 * Doğru kullanım için atanacak değişkenin
                 * türü belirlenmeli ve 
                 * yazmaya karşı herhangi bir
                 * erişim kısıtlayıcısının bulunmadığını kontrol etmeliyiz.
                  
                 if(null != property && property.CanWrite)
                 {
                     property.SetValue(t, 10);
                 }
                 
                 */
                property.SetValue(t, 10);
                //property.Name = değişkenin kendi adı
                //propert.GetValue() değişkenin değeri
                Console.WriteLine("{0} = {1}", property.Name, property.GetValue(t));
            }
        }
    }
}