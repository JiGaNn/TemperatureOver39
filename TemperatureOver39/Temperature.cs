using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureOver39
{
    public enum TempType { c, f, r, k }
    public class Temperature
    {
        private double value;
        private TempType type;
        public Temperature(double value, TempType type)
        {
            this.value = value;
            this.type = type;
        }
        public string Output()
        {
            string typeOut = "";
            switch (this.type)
            {
                case TempType.c:
                    typeOut = "°C";
                    break;
                case TempType.f:
                    typeOut = "°F";
                    break;
                case TempType.r:
                    typeOut = "°Ra";
                    break;
                case TempType.k:
                    typeOut = "K";
                    break;
            }
            return String.Format("{0} {1}", this.value, typeOut);
        }
        public static Temperature operator+(Temperature instance, double number)
        {
            var newValue = instance.value + number;
            var temp = new Temperature(newValue, instance.type);
            return temp;
        }
        public static Temperature operator+(double number, Temperature instance)
        {
            return instance + number;
        }
        public static Temperature operator -(Temperature instance, double number)
        {
            var newValue = instance.value - number;
            var temp = new Temperature(newValue, instance.type);
            return temp;
        }
        public static Temperature operator -(double number, Temperature instance)
        {
            var newValue = number - instance.value;
            var temp = new Temperature(newValue, instance.type);
            return temp;
        }
        public static Temperature operator *(Temperature instance, double number)
        {
            var newValue = instance.value * number;
            var temp = new Temperature(newValue, instance.type);
            return temp;
        }
        public static Temperature operator *(double number, Temperature instance)
        {
            return instance * number;
        }
    }
}
