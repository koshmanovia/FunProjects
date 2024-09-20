using System;

//Объявить тип делегата для события.
delegate void MyEventHandler();

// Объявить класс, содержащий событие.
class MyEvent
{
    public event MyEventHandler SomeEvent;
    // Этот метод вызывается для запуска события.
    public void OnSomeEvent()
    {
        Console.WriteLine("Запущен обработчик события");
        if (SomeEvent != null)
        {
            SomeEvent();
        }
        else
        {
            Console.WriteLine("");
        }
    }
}
class EventDemo
{   
    // Обработчик события.
    static void Handler()
    {
        Console.WriteLine("Произошло событие");
    }
    static void Main()
    {
        MyEvent evt = new MyEvent();
        // Добавить метод Handler() в список событий.
        evt.SomeEvent += Handler;
        // Запустить событие.
        evt.OnSomeEvent();
        Console.ReadLine();
    }    
}

