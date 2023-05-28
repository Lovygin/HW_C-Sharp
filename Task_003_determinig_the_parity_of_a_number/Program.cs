//determining - определение; the parity - четность
Console.Clear();
Console.WriteLine("Please, enter the number");
int num = int.Parse(Console.ReadLine());
if(num % 2 == 0){
    Console.WriteLine(num + " - parity number");}
else{
    Console.WriteLine(num + " - not even number");}      //even - четный