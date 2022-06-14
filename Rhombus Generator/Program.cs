// *Rhombus Demo* Giuseppe Allocca FullStack Developer at OpenBootcamp 2022 
Console.WriteLine("\n< Rhombus Generator >\nmax width ?: ");
int maxWidth = Convert.ToInt32(Console.ReadLine()),maxHeight = maxWidth;
Console.WriteLine($"Generating Rhombus Value:{maxWidth}\n");
string el1 = "*",space = " ";
int spaceinside=0;
for (int i=maxWidth/2;i>0;i--)
{
        string spaceleft = string.Concat(Enumerable.Repeat(space, i));
        string internalspace = string.Concat(Enumerable.Repeat(space, spaceinside));
    if (spaceinside == 0) { Console.WriteLine(spaceleft +space+ el1); spaceinside += 2; }
    else
    {
        Console.WriteLine(spaceleft + el1 + internalspace +space+ el1 + spaceleft);
        spaceinside += 2;
    }
}
for (int i = 0; i <maxWidth / 2+1 ; i++)
{
    string spaceleft = string.Concat(Enumerable.Repeat(space, i));
    string internalspace = string.Concat(Enumerable.Repeat(space, spaceinside));
    if (spaceinside == 0) { Console.WriteLine(spaceleft + space + el1+"\n"); spaceinside -= 2; }
    else
    {
        Console.WriteLine(spaceleft + el1 + internalspace + space + el1 + spaceleft);
        spaceinside -= 2;
    }
}