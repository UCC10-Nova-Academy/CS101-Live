using _11_AccessModifiers;

internal class Program 
{
    // Access Modifiers : Erişim Belirleyiciler
    // Public - heryerden erişim
    // Private - sadece tanımlandığı sınıf içinden erişilebilir
    // Protected - Tanımlandığı sınıf ve türetilen sınıflardan erişilebilir.
    // Internal - Tanımlandığı assembly içerisinden erişim
    // protected Internal - Tanımlandığı program içersinden veya türetilen sınıflardan erişilebilir.

    private static void Main(string[] args)
    {
        // bir dış class a erişerek ilgili bazı bilgileri güncelle vs vs
        // Bir clsTutorials isimli bir classımız olsun ama ayrı dosya içinde
        // o classın icersinde yazılmış olan bir metoda bulunduğumuz yerden erişip kullanma

        //clsTutorial
        // bunu nasıl örneklerim(nesne haline getiririm ki metotları kullanabileyim)
        //clsTutorials clsTutorials = new clsTutorials(); // nesneyi yarattım

        //clsTutorials.setTutorial(1, "C# dersleri");
        //Console.WriteLine(clsTutorials.getTutorial());



        #region Protected

        //clsBase clsBase = new clsBase();
        //clsBase.ProtectedMethod();



        clsDerived clsDerived = new clsDerived();

        clsDerived.AccessProtectedMethod();
    


        #endregion


    }


}

