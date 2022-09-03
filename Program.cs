int size =4;
int [ ] array = new int [size];
int minvalue = 100;
int maxvalue = 1000;
int count = 0;
for (int i = 0; i < array.Length;i++)
{
    array[i] = new Random().Next(minvalue,maxvalue);
    

if(array[i] %2 == 0)

count ++;}
Console.Write("[");
Console.Write(string.Join("," , array));
Console.Write("]=>");

 Console.WriteLine( count);  
