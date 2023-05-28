Console.Clear();
Console.WriteLine("Please, enter 1-st number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Please, enter 2-nd number");
int b = int.Parse(Console.ReadLine());
if(a > b){
    Console.WriteLine(a + " - maximest number and " + b + " minimest number");}
else{
    Console.WriteLine(b + " - maximest number and " + a + " minimest number");}//text conclusion - текстовый вывод или вывод текта
