using System;
//Объявление делегата для события
delegate void MyEventHandler(string s);
class MyEvent
{
    //Объявить делегат, содержащий событие.
    public event MyEventHandler SomeEvent;
    public void OnSomeEvent(string s)
    { 
        if (SomeEvent != null)
        {
            SomeEvent(s);
        }
    }    
}
class X
{
    public void Xhandler(string s)
    {
        Console.WriteLine($"Событие получено объектом класса Х {s}");
    }
}
class Y
{
    public void Yhandler(string s)
    {
        Console.WriteLine($"Событие получено объектом класса Y {s}");
    }
}
class EventDemoGroupAddress
{
    static void Handler(string s)
    {
        Console.WriteLine($"Событие получено объектом класса EventDemoGroupAddress {s}");
    }
    static void Main(string[] args)
    {
        MyEvent evt = new MyEvent();
        X xOb = new X();
        Y yOb = new Y();

        //Добавить обработчики в список событий
        evt.SomeEvent += Handler;
        evt.SomeEvent += xOb.Xhandler;
        evt.SomeEvent += yOb.Yhandler;

        //Запуск события
        evt.OnSomeEvent("из EventDemoGroupAddress");
        Console.WriteLine();

        evt.SomeEvent -= xOb.Xhandler;
        evt.OnSomeEvent("из EventDemoGroupAddress");
        Console.WriteLine();

        Console.ReadLine();
    }
}
