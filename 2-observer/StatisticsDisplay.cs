using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_observer
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
       private List<float> temperature;
       private Subject weatherData;

       public StatisticsDisplay(Subject weatherData){
           this.weatherData = weatherData;
           weatherData.registerObserver(this);
           temperature = new List<float>();
       } 

       public void update(float temperature, float humidity, float pressure){
           this.temperature.Add(temperature);
           display();
       }

        public void display(){
            var average = this.temperature.Average();
            var max = this.temperature.Max();
            var min = this.temperature.Min();
            Console.WriteLine($"Avg/Max/Min temperature = {average}/{max}/{min}");
        }
    }
}