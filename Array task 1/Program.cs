

int inpsize = int.Parse(Console.ReadLine()), odd, even;
even = 0; odd = 0;
int[] array = new int[inpsize];

for (int i = 0; i < inpsize; i++) {
    Console.WriteLine("Please choose a value for index " + i);
    array[i] = int.Parse(Console.ReadLine());    
}

for (int i = 0; i < inpsize; i++) {

    if (i % 2 == 0) { even++;}
    else { odd++; }
};

for (int i = 0; i < inpsize; i++)
{

    if (i % 2 == 0) { Console.WriteLine("An even number is:" + "{" + i +"}"); }
    else { Console.WriteLine("An odd number is:" + "{" + i + "}"); }
};


Console.WriteLine("-------------------------------------------------");
Console.WriteLine("There are: " + even + " even elements");
Console.WriteLine("There are: " + odd + " odd elements");
Console.ReadKey();


