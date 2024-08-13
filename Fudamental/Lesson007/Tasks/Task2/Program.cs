#region Mesele1
//1.Verilmiş "integer" tipli n ədədinin 5-ə tam bölünüb-bölünməməsini yoxlayın. 
//    Əgər n ədədi 5-ə tam bölünürsə, ekrana "5-ə tam bölünür" mesajını çap edin. 
//    Əks halda, qalıqı ekranda göstərin.

//n = 250 olduqda, ekranda "5-ə tam bölünür" yazısını çap edirik.
//n = 253 olduqda isə, ekranda "Qalıq 3" yazısını çap edirik.
//using System.Text;

//Console.OutputEncoding = Encoding.UTF8;
//int n = 55;
//int qaliq = n % 5;
//if (qaliq == 0)
//{
//    Console.WriteLine("5-ə tam bölünür");
//}
//else
//{

//    Console.WriteLine("Qalıq {0}", qaliq);
//}
#endregion

#region Mesele2
//using System.Text;

//Console.OutputEncoding = Encoding.UTF8;

//2.Verilmiş "integer" tipli n ədədinin tək və ya cüt olduğunu yoxlayın. 
//    Əgər n ədədi cütdürsə, ekrana "Cüt ədəddir" mesajını çap edin.
//    Əks halda, "Tək ədəddir" mesajını göstərin.

//Məsələn:
//n = 8 olduqda, ekranda "Cüt ədəddir" yazısını çap edirik.
//n = 15 olduqda isə, ekranda "Tək ədəddir" yazısını çap edirik.

//int n = 45;

//if(n % 2 == 0)
//{
//    Console.WriteLine("Cüt ədəddir");
//}
//else
//{
//    Console.WriteLine("Tək ədəddir");
//}
#endregion

#region Mesele3
//3.Verilmiş "integer" tipli n ədədinin müsbət, 
//    mənfi və ya sıfır olduğunu yoxlayın. 
//    Əgər n ədədi müsbətdirsə, ekrana "Müsbət ədəddir" mesajını çap edin. 
//    Əgər n ədədi mənfidirsə, "Mənfi ədəddir" mesajını göstərin. 
//    Əgər n ədədi sıfırdırsa, "Sıfırdır" mesajını göstərin.
//Məsələn:
//n = 5 olduqda, ekranda "Müsbət ədəddir" yazısını çap edirik.
//n = -3 olduqda isə, ekranda "Mənfi ədəddir" yazısını çap edirik.
//n = 0 olduqda isə, ekranda "Sıfırdır" yazısını çap edirik.

//...-3 -2 -1 0 1 2 3 4 ....
//using System.Text;

//Console.OutputEncoding = Encoding.UTF8;
//int n = -2;
//if(n > 0)
//{
//    Console.WriteLine("Müsbət ədəddir");
//}
//else if(n < 0)
//{
//    Console.WriteLine("Mənfi ədəddir");
//}
//else
//{
//    Console.WriteLine("Sıfırdır");
//}
#endregion

#region Mesele6

//7.Verilmiş "integer" tipli n ədədinin 3-ə və 7-yə eyni anda bölünüb-bölünməməsini yoxlayın. 
//Əgər n ədədi həm 3-ə, həm də 7-yə bölünürsə, ekrana "Həm 3-ə, həm də 7-yə bölünür" mesajını çap edin. 
//Əks halda, "Həm 3-ə, həm də 7-yə bölünmür" mesajını göstərin.
//Məsələn:
//n = 21 olduqda, ekranda "Həm 3-ə, həm də 7-yə bölünür" yazısını çap edirik.
//n = 20 olduqda isə, ekranda "Həm 3-ə, həm də 7-yə bölünmür" yazısını çap edirik.
//using System.Text;

//Console.OutputEncoding = Encoding.UTF8;

//int n = 85;
//if (n % 3 == 0 && n % 7 == 0)
//{
//    Console.WriteLine("Həm 3-ə, həm də 7-yə bölünür");
//}
//else if (n % 3 > 0 && n% 7 >0)
//{
//    Console.WriteLine("Həm 3-ə, həm də 7-yə bölünmür");
//}
//else
//{
//    Console.WriteLine("Ya 3-ə, ya da 7-yə bölünür");
//}
#endregion