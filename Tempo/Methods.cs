using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Tempo
{
    public static class Methods
    {
        public static Weather GetWeather(int json)
        {
            var weather = new Weather();
            
            try
            {
                var request = WebRequest.Create("http://api.ipma.pt/open-data/forecast/meteorology/cities/daily/"+ json +".json");
                var response = request.GetResponse();
                var reader = new StreamReader(response.GetResponseStream());

                var strJson = reader.ReadToEnd();
                
                weather = JsonConvert.DeserializeObject<Weather>(strJson);
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return weather;
        }

        public static Districts GetRegion()
        {
            var regions = new Districts();
            
            try
            {
                var request = WebRequest.Create("https://api.ipma.pt/open-data/distrits-islands.json");
                var response = request.GetResponse();
                var reader = new StreamReader(response.GetResponseStream());

                var strJson = reader.ReadToEnd();
                
                regions = JsonConvert.DeserializeObject<Districts>(strJson);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return regions;
        }
        
        public static WindClass GetWindClass()
        {
            var wind = new WindClass();
            
            try
            {
                var request = WebRequest.Create("https://api.ipma.pt/open-data/wind-speed-daily-classe.json");
                var response = request.GetResponse();
                var reader = new StreamReader(response.GetResponseStream());

                var strJson = reader.ReadToEnd();
                
                wind = JsonConvert.DeserializeObject<WindClass>(strJson);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return wind;
        }
        
        public static WeatherType GetWeatherType()
        {
            var weatherType = new WeatherType();
            
            try
            {
                var request = WebRequest.Create("https://api.ipma.pt/open-data/weather-type-classe.json");
                var response = request.GetResponse();
                var reader = new StreamReader(response.GetResponseStream());

                var strJson = reader.ReadToEnd();
                
                weatherType = JsonConvert.DeserializeObject<WeatherType>(strJson);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return weatherType;
        }
    }
}