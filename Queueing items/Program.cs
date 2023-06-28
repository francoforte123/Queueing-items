Console.WriteLine("scegli le varie opzioni: \n1)Queue;\n2)Dequeue;\n3)Peek.");

int Option = int.Parse(Console.ReadLine());

Queue<string> ListOfNames = new();
ListOfNames.Enqueue("Marco");
ListOfNames.Enqueue("Luca");
ListOfNames.Enqueue("Anna");

if(Option == 1)    
{   
    Console.Write("inserisci un nuovo nome: ");
    string NewName = Console.ReadLine();

    ListOfNames.Enqueue(NewName);

    Console.WriteLine("lista completa con il nuovo nome:");
    foreach (string names in ListOfNames)
    {
        Console.WriteLine(names);
    }
}
else if(Option == 2)      
{
    string restOfList = ListOfNames.Dequeue();
    Console.WriteLine("sto rimuovendo il primo nome dalla lista " + restOfList);
}
else if(Option == 3)  
{
    string name = ListOfNames.Peek();           
    Console.WriteLine("sto prendendo il primo nome della lista " + name);
}





