using System;

//объявить тип делегата для события
delegate void MyEventHandler();

//Объявить класс, содержащий событие
class MyEvent
{
    public event MyEventHandler SomeEvent;
    //Метод для вызова события
    public void OnSomeEvent()
    {
        if (SomeEvent != null)
        {
            SomeEvent();
        }
    }
}
public class X
{
    int id;
    public X(int x) { id = x; }

    // Этот метод экземпляра предназначен в качестве обработчика событий.
    public static void Xhandler()
    {
        Console.WriteLine("Событие получено классом ");
    }
}

class EventDemo4
{
    static void Main()
    {
        MyEvent evt = new MyEvent();
        X o1 = new X(1);
        X o2 = new X(2);
        X o3 = new X(3);
        evt.SomeEvent += X.Xhandler;
        evt.OnSomeEvent();
        Console.ReadKey();
    }
}