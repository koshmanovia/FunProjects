using System;
class MyEventArgs : EventArgs
{
    public int EventNum;
}
//объявить тип делегата для события
delegate void MyEventHandler(object source, MyEventArgs args);
class MyEvent 
{
    static int count = 0;
    public event MyEventHandler SomeEvent;
    public void OnSomeEvent()
    {
        MyEventArgs arg = new MyEventArgs();
        if (SomeEvent != null)
        {
            arg.EventNum = ++count;
            SomeEvent(this, arg);
        }
    }
}
class X
{
    public void Handler(object source, MyEventArgs arg)
    {
        Console.WriteLine($"Событие {arg.EventNum} получено объектом класса Х.");
        Console.WriteLine("Источник: {0}\n", source);
    }
}
class Y
{    public void Handler(object source, MyEventArgs arg)
    {
        Console.WriteLine($"Событие  {arg.EventNum} получено объектом класса Y.");
        Console.WriteLine("Источник: {0}\n" ,source);
    }
}

class EventDemo6
{
    static void Main(string[] args)
    {
        X object1 = new X();
        Y object2 = new Y();
        MyEvent myEvent = new MyEvent();

        myEvent.SomeEvent += object1.Handler;
        myEvent.SomeEvent += object2.Handler;

        myEvent.OnSomeEvent();
        myEvent.OnSomeEvent();

        Console.ReadLine();
    }
}
