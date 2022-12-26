// See https://aka.ms/new-console-template for more information
NameRepository namesRepository = new NameRepository();

for (Iterator iter = namesRepository.GetIterator(); iter.HasNext();)
{
    String name = (String)iter.Next();
    Console.WriteLine("Name : " + name);
}

Console.ReadLine();