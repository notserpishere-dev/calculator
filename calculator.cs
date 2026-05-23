bool isrunning = true;

while (isrunning)
{
    Console.WriteLine("Universal calculator made by notserpishere");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");
    Console.WriteLine("5. Exit");
    int input = Convert.ToInt32(Console.ReadLine());
    switch (input)
    {
        case 1:
            Console.Write("First number: ");
            double firstnumberadd = Convert.ToDouble(Console.ReadLine());
            Console.Write("Next number: ");
            double nextnumberadd = Convert.ToDouble(Console.ReadLine());
            double finaladd = firstnumberadd + nextnumberadd;
            Console.WriteLine(finaladd);
            continue;
        case 2:
            Console.Write("First number: ");
            double firstnumbersubtraction = Convert.ToDouble(Console.ReadLine());
            Console.Write("Next number: ");
            double nextnumbersubtraction = Convert.ToDouble(Console.ReadLine());
            double finalsubtraction = firstnumbersubtraction - nextnumbersubtraction;
            Console.WriteLine(finalsubtraction);
            continue;
        case 3:
            Console.Write("First number: ");
            double firstnumbermultiply = Convert.ToDouble(Console.ReadLine());
            Console.Write("Next number: ");
            double nextnumbermultiply = Convert.ToDouble(Console.ReadLine());
            double finalmultiply = firstnumbermultiply * nextnumbermultiply;
            Console.WriteLine(finalmultiply);
            continue;
        case 4:
            Console.Write("First number: ");
            double firstnumberdivide = Convert.ToDouble(Console.ReadLine());
            Console.Write("Next number: ");
            double nextnumberdivide = Convert.ToDouble(Console.ReadLine());
            double finaldivide = firstnumberdivide / nextnumberdivide;
            Console.WriteLine(finaldivide);
            continue;
        case 5:
            isrunning = false;
            break;
    }
}
