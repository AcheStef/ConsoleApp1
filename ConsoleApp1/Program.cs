using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");
//Console.ReadKey();

//ova e single line comment

/*ova e 
 * multiline
 * comment
 */

//String a = "nekoja recenica"; //string koga e text
//int b = 30; //int e koga e cel broj
//double c = 0.2; //double koga e decimalen broj //var koga ne znaeme koj tip na varijabla(vrednost) kje korisitme

//int a = 1;
//int b = 2;
//int c = 3;
//int d = (a + c);
//                                                //0   //1  //2  //3  //4
//Console.WriteLine("rezultatot na 1 + 3 = {4}", "SMX",   1,   2,   3,   4);
//Console.WriteLine(36 - 6);
//Console.WriteLine(36 / 6);
//Console.WriteLine(5 * 10);

//var text = Console.ReadLine();
//Console.WriteLine("Ova e tekstot koj sto e vnesen od stana na user: {0}", text);

Console.WriteLine("Vnesete gi posledovatelno 4te varijabli a, b, c, d");

Console.WriteLine("Vnesete go prviot broj"); 

int a = int.Parse (Console.ReadLine() );  //se sto e vneseno vo readline mora da e string
int b = int.Parse (Console.ReadLine() );
int c = int.Parse (Console.ReadLine() );
int d = int.Parse (Console.ReadLine() );
//int space = " ";

int result = a + b + c + d;

if (a == 1)
{
	Console.WriteLine("True");
}
else
{
	Console.WriteLine("False");
}

Console.WriteLine(result);


