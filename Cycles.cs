using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Cycles
    {
        public enum Time
        {
            Time = '⌛',
        }

        public Dictionary<string, dynamic> TimeCycle { get; set; } // Time cycle dictionary

        class Cycle // Time cycle class
        {
            public Dictionary<string, int> TimeCycle = new Dictionary<string, int>() // Time cycle
            {
                { "Year", 360 }, // Days of the year
                { "Seasons", 4 }, // Spring, Summer, Autumn, Winter
                { "Months", 30 }, // Days of the month
                { "Weeks", 5 }, // Days of the week
                { "Day", 36 }, // Total hours in a day
                { "Daytime", 18 }, // Hours of the daylight
                { "Nighttime", 18 }, // Hours of the night
                { "Hours", 60 }, // Minutes per hour
                { "Minutes", 60 }, // Seconds per minute
                { "Seconds", 1000 } // Milliseconds per second
            };
        }

        public class Weather
        {
            public enum CurrentWeather
            {
                Freezing = '⛄',
                Overcast = '⛅',
                Storm = '⛆',
                Rain = '⛈'
            }

            private string[] weatherTypes = { "Scorching", "Drought", "Hot", "Sunny", "Clear", "Overcast", "Drizzle", "Rain", "Snow", "Storm", "Tornado", "Blizzard" };
            private string[] seasons = { "Spring", "Summer", "Autumn", "Winter" };
            private string[] moonPhases = { "New Moon", "Waxing Crescent", "First Quarter", "Waxing Gibbous", "Full Moon", "Waning Gibbous", "Last Quarter", "Waning Crescent" };

            public string currentWeather { get; private set; } = "Hot"; // Assume hot as default
            public string CurrentSeason { get; private set; } = "Spring"; // Assume spring as default
            public string CurrentMoonPhase { get; private set; } = "New Moon"; // Assume new moon as default
            public string TimeOfDay { get; private set; } = "Early Morning"; // Assume day as default
            public int Temperature { get; private set; }
            public int Humidity { get; private set; }
            public int WindSpeed { get; private set; }
            private Random random = new Random();

            public Weather()
            {
                currentWeather = GenerateWeather();
                CurrentSeason = GenerateSeason();
                CurrentMoonPhase = GenerateMoonPhase();
                UpdateWeatherAttributes();                // Initialize additional weather attributes
            }

            private string GenerateWeather()
            {
                int randomIndex = random.Next(0, weatherTypes.Length);                // Randomly select a weather type
                return weatherTypes[randomIndex];
            }

            private string GenerateSeason()
            {
                int randomIndex = random.Next(0, seasons.Length);                // Randomly select a season
                return seasons[randomIndex];
            }

            private string GenerateMoonPhase()
            {
                int randomIndex = random.Next(0, moonPhases.Length);                // Randomly select a moon phase
                return moonPhases[randomIndex];
            }

            public void ChangeWeather()
            {
                if (TimeOfDay == "Day")                // Simulate weather change based on time of day and season
                {
                    currentWeather = GenerateWeather();                    // During the day, weather changes are more frequent
                }
                else
                {
                    // During the night, weather remains relatively stable
                    // Consider adding moon phases for further complexity
                    // For simplicity, weather remains the same during the night
                }
                UpdateWeatherAttributes();                // Update additional weather attributes
            }

            public void ChangeSeason()
            {
                CurrentSeason = GenerateSeason();                // Simulate season change
                UpdateWeatherAttributes();                // Update additional weather attributes
            }

            public void ChangeMoonPhase()
            {
                CurrentMoonPhase = GenerateMoonPhase();                // Simulate moon phase change
            }

            public void SetTimeOfDay(string timeOfDay)            // Implement day/night cycle
            {
                if (timeOfDay.ToLower() == "day" || timeOfDay.ToLower() == "night")
                {
                    TimeOfDay = timeOfDay;
                }
                else if (timeOfDay.ToLower() == "morning" || timeOfDay.ToLower() == "evening")
                {
                    TimeOfDay = "Day";
                }
                else
                {
                    TimeOfDay = "Night";
                }
                UpdateWeatherAttributes();
            }

            public string GetCurrentWeather()
            {
                return currentWeather;
            }

            public string GetCurrentSeason()
            {
                return CurrentSeason;
            }

            public string GetCurrentMoonPhase()
            {
                return CurrentMoonPhase;
            }

            private void UpdateWeatherAttributes()            // Method to update additional weather attributes
            {
                // Example: Assign random values to temperature, humidity, and wind speed
                Temperature = random.Next(-20, 40); // Temperature range: -20°C to 40°C
                Humidity = random.Next(0, 100); // Humidity range: 0% to 100%
                WindSpeed = random.Next(0, 50); // Wind speed range: 0 km/h to 50 km/h
            }
        }

}
}
