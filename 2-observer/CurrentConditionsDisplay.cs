using System;
namespace _2_observer
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
       private float temperature;
       private float humidity;
       private Subject weatherData;

       public CurrentConditionsDisplay(Subject weatherData){
           this.weatherData = weatherData;
           weatherData.registerObserver(this);
       } 

       public void update(float temperature, float humidity, float pressure){
           this.temperature = temperature;
           this.humidity = humidity;
           display();
       }

        public void display() => Console.WriteLine($"Current conditions: {temperature}F degress and {humidity}% humidity");
    }
}