using Day14_DataStructures;
Console.WriteLine("Welcome To the Dat Structures Linked list");
UC7_SearchNode list = new UC7_SearchNode();
list.Add(56);
list.Add(30);
list.Add(70);
Console.WriteLine("enter the data which you want to search in Linked List ");
int data = int.Parse(Console.ReadLine());
Console.WriteLine(list.Search(data));