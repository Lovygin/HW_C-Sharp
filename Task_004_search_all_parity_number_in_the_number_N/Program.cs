Console.Clear();
Console.WriteLine("Please, enter number N");
int N = int.Parse(Console.ReadLine());
int i = 1;
do// Делай (do) это (if()), пока (while) не выполнилось это.
{
    if(i % 2 == 0){
        Console.WriteLine(i);}    
    i++;
}
while(i <= N);
return;