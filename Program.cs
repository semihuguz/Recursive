//Recursive yinelemeli fonksiyonlar , Kendi kendini cagiran fonksiyonlar


int result = 1;
for (int i = 1; i < 5; i++){
    result = result*3;

}
Console.WriteLine(result);
islemler instance = new();
Console.WriteLine(instance.Expo(3,4));
bool sonuc = ifade.CheckSpaces();
Console.WriteLine(sonuc);
if(sonuc)   
    Console.WriteLine(ifade.RemoveWhiteSpaces());
Console.WriteLine(ifade.MakeUpperCase());
Console.WriteLine(ifade.MakeLowerCase());


int [] sayilar = {3,4,66,7,89,098,123,4567};
dizi.SortArray();
dizi.EkranaYazdir();
int sayi1 = 5;
Console.WriteLine(sayi1.IsEvenNumber());
Console.WriteLine(ifade.GetFirstCharacter());


public class islemler
{
    public void Expo(int sayi, int us)
    {
        if(us<2)
            retun sayi;
        return Expo(sayi , us-1)*sayi;
    }

}


//Extension Metotlar

public static class Extension
{
    public static bool CheckSpaces(string param)
    {
        return param.Contains(" ");

    }
    public static string RemoveWhiteSpaces(this string param)
    {
        string [] dizi  = param.Split(" ");
        return string.Join(" ", dizi);
    }

    public static string MakeUpperCase(this string param)
    {
        string [] dizi  = param.ToUpper();
       
    }
    public static string MakeLowerCase(this string param)
    {
        string [] dizi  = param.ToLower();
       
    }

    public static int[] SortArray(this int [] param)
    {
        Array.Sort(param);
        return param;
    }

    public static void EkranaYazdir(this int[] param )
    {
        foreach (var item in param)
        Console.WriteLine(item);
       
    }

    public static bool IsEvenNumber(this int param)
    {
        return param%2 == 0;
    }


    public static string GetFirstCharacter(this string param)
    {
         return param.Substring(0,1);
    }

}
