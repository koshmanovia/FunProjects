using System;

delegate void MyEventHandler(int n);
class MyEvent
{
    public event MyEventHandler SomeEvent;
    // Этот метод вызывается для запуска события.
    public void OnSomeEvent(int n)
    {
        if (SomeEvent != null)
            SomeEvent(n);
    }
}
class LambdaEventDemo
{
    static void Main(string[] args)
    {
        MyEvent evt = new MyEvent();
        evt.SomeEvent += (n) => Console.WriteLine("Событие получено. Значение равно " + n);
        // Запустить событие.
        evt.OnSomeEvent(1);
        evt.OnSomeEvent(2);
        Console.ReadLine();
    }
}

