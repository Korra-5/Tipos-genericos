namespace HilosParaTodos;

public class Wrapper<T>
{
    //Variable T tipo generica:
    public T Value;

    //Constructor de la variable:
    public Wrapper(T value)
    {
        Value = value;
    }
}