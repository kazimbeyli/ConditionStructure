//int num = 68;
//int c = num % 10;
//num = num / 10;
//if (num>c)
//{
//Console.WriteLine($"En boyuk eded:{ num}");

//}
//else
//{
//Console.WriteLine($"En boyuk eded:{c}");
//}


//TASK2:Verilmish 3 mertebeli ededin mertebeleri cemini tapan algorithm 
//using System.Text;
//int cem = 0;
//Console.WriteLine("3 mertebeli eded daxil edin:");
//int num = Convert.ToInt32(Console.ReadLine());
//if(num>=100 && num <= 999)
//{
//    cem = num/100+ (num/10)%10 + num%10;
//    Console.WriteLine(cem);
//}
//else
//{
//    Console.WriteLine("ededi duzgun daxil edin!!!!");
//}



//İstifadəçi char tipindən dəyər daxil edib (input) char 'a' hərfinə bərabərdirsə ekrana "Azərbaycan dili seçildi" yazısı gəlsin(output), 'r' hərfinə bərabərdirsə "Rus dili seçildi" yazısı gəlsin (output). Digər bütün hallarda "Yanlış sorğu" yazısı gəlsin(output).
char value='a';
if (value == 'a' || value == 'A')
{
    Console.WriteLine("Azebaycan dili secildi");
}
else if(value=='r' || value=='R'){
    Console.WriteLine("Rus dili secildi");

}
else
{
    Console.WriteLine("Yanlis sorgu");
}