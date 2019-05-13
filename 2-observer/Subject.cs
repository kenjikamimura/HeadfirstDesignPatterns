namespace _2_observer
{
    public interface Subject
    {
        void registerObserver(IObserver o);
        void removeObserver(IObserver o);
        void notifyObservers();
              
    }
}