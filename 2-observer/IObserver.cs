namespace _2_observer
{
    public interface IObserver
    {
        void update(float temp, float humidity, float pressure);
    }
}