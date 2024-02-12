/*
for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"i = {i + 1}");
}
*/
/*
for (int i = 10; i > 0; i--) //i-- = i - 1
{
    Console.WriteLine($"i = {i}");
}
*/
//liitmine
int sum = 0;

for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"current total: {sum}");
    sum = sum + i; //sum += i;
}

//Console.WriteLine($"Final total: {sum}");