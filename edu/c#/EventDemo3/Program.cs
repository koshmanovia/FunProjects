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
    public void Xhandler()
    {
        Console.WriteLine("Событие получено объектом " + id);
    }
}

class EventDemo3
{
    static void Main()
    {
        MyEvent evt = new MyEvent();
        X o1 = new X(1);
        X o2 = new X(2);
        X o3 = new X(3);
        evt.SomeEvent += o1.Xhandler;
        evt.SomeEvent += o2.Xhandler;
        evt.SomeEvent += o3.Xhandler;
        // Запустить событие.
        evt.OnSomeEvent();
        Console.ReadKey();
    }
}

