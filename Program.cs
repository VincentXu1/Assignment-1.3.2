namespace Assignment_1._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates a new string array with specified size and values.
            string[] planets = new string[8] {
                "Mercury",
                "Venus",
                "Earth",
                "Mars",
                "Jupiter",
                "Saturn",
                "Neptune",
                "Uranus"
            };
            // Creates a new string array with specified values.
            string[] months = new string[] {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };
            // Creates a new string array with specified values without using the `new` keyword.
            string[] days = {
                "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday"
            };
            // Creates a new string array with specified size without initially specifying values.
            string[] time = new string[2];
            time[0] = "am";
            time[1] = "pm";
        }
    }
}
