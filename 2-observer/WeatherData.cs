using System;
using System.Collections.Generic;

namespace _2_observer
{
    public class WeatherData : Subject
    {
        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;
        public WeatherData() => observers = new List<IObserver>();
        public void registerObserver(IObserver o) => observers.Add(o);
        public void removeObserver(IObserver o){
            int indexOfObserverToRemove = observers.IndexOf(o);
            if(indexOfObserverToRemove != -1) observers.RemoveAt(indexOfObserverToRemove);
        }
        public void notifyObservers() {
            foreach(var observer in observers){
                observer.update(temperature, humidity, pressure);
            }
        }

        public void measurementsChanged() {
            notifyObservers();
        }
        public void setMeasurements(float temperature, float humidity, float pressure){
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }
    }
}