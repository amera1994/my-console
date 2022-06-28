linei:
Console.WriteLine("entre what you need:");
var math = Console.ReadLine();
if (math == "+")
{
    Console.WriteLine("Enter value1");
    var value1 = int.Parse(Console.ReadLine());
    Console.WriteLine("enter value2");
    var value2 = int.Parse(Console.ReadLine());
    var result = value1 + value2;
    Console.WriteLine("value1+value2 =" + result);


}


if (math == "-")
{
    Console.WriteLine("Enter value1");
    var value1 = int.Parse(Console.ReadLine());
    Console.WriteLine("enter value2");
    var value2 = int.Parse(Console.ReadLine());
    var result = value1 + value2;
    Console.WriteLine("value1+value2 =" + result);



}

if (math == "*")
{
    Console.WriteLine("Enter value1");
    var value1 = int.Parse(Console.ReadLine());
    Console.WriteLine("enter value2");
    var value2 = int.Parse(Console.ReadLine());
    var result = value1 + value2;
    Console.WriteLine("value1+value2 =" + result);

}
if (math == "/")
{
    Console.WriteLine("Enter value1");
    var value1 = int.Parse(Console.ReadLine());
    Console.WriteLine("enter value2");
    var value2 = int.Parse(Console.ReadLine());
    var result = value1 + value2;
    Console.WriteLine("value1+value2 =" + result);


}
if (math == "text")
{
    Console.WriteLine("Do you want to read or write");
    var select = Console.ReadLine();
    if (math == "read") ;
        }
        var notetext = System.IO.File.ReadAllText("note.txt");
        Console.WriteLine(notetext);

    }
if (math == "write")
{

    Console.WriteLine("plaese enter your not");
    var enter = Console.ReadLine();
    System.IO file.appendalltext("not.txt", enter + "/n");





}





