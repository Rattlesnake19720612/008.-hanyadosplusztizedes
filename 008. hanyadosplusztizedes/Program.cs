using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008.hanyadosplusztizedes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot!");
            double szam1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kérek még egy számot!");
            double szam2 = Convert.ToDouble(Console.ReadLine());

            double osztas = szam1 / szam2;
            Console.WriteLine("A két szám hányadosa: " + osztas + "." + "\n");

            Console.ReadKey();
        }
    }
}

/*Két tizedesjegy pontossággal kér be két lebegőpontos számot a felhasználótól, elvégzi az osztást és kiírja az eredményt. Az alábbiakban röviden összefoglalom, hogy a program mit csinál:

A program elindul, és a "using" utasításokkal importálja a szükséges könyvtárakat.

Definiáljuk a "Program" osztályt, amely tartalmazza a "Main" metódust, ami a program belépési pontja.

A "Main" metóduson belül a program egy felugró ablakban megjelenít egy üzenetet, ami arra kéri a felhasználót, hogy írjon be egy számot. A felhasználó által megadott értéket a "Console.ReadLine()" metódus segítségével szövegként olvassuk be, majd a "Convert.ToDouble()" metódussal tizedesjegy pontossággal lebegőpontos számmá alakítjuk.

Az eredményt a "szam1" változóban tároljuk.

A program ugyanazt az eljárást használja a második szám beolvasásához, amelyet a "szam2" változóban tárolunk.

Az első számot a másodikkal osztjuk az "osztas" változóban, majd a "Console.WriteLine()" metódus segítségével kiírjuk a konzolra a két szám hányadosát.

Végül a program várakozik, amíg a felhasználó bármilyen billentyűt meg nem nyom a "Console.ReadKey()" metódus segítségével.

Összességében ez a program egy egyszerű példa arra, hogy hogyan lehet lebegőpontos számokkal dolgozni C# nyelven, és hogyan lehet a felhasználóval a konzolon keresztül kommunikálni.*/
