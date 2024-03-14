using PublicisRS;

PrintNameOrNumber objPrintNameorNumber = new PrintNameOrNumber();

for (int i = 1; i < 100; i++)
{
    if (objPrintNameorNumber.PublicisrOar(i) == "PublicisrOar")
    {
        Console.WriteLine(objPrintNameorNumber.PublicisrOar(i));
    }
    else if (objPrintNameorNumber.Publicis(i) == "Publicis")
    {
        Console.WriteLine(objPrintNameorNumber.Publicis(i));
    }
    else if (objPrintNameorNumber.ROar(i) == "rOar")
    {
        Console.WriteLine(objPrintNameorNumber.ROar(i));
    }
    else
    {
        Console.WriteLine(objPrintNameorNumber.PrintNumber(i));
    }
}

Console.ReadKey();

