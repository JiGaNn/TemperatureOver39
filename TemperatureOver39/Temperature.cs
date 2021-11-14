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
        public Temperature To(TempType newType)
        {
            var newValue = this.value;
            if(this.type == TempType.c)
            {
                switch(newType)
                {
                    case TempType.f:
                        newValue = this.value * 9 / 5 + 32;
                        break;
                    case TempType.k:
                        newValue = this.value + 273.15;
                        break;
                    case TempType.r:
                        newValue = (this.value + 273.15) * 9 / 5;
                        break;
                }
            }else if(newType == TempType.c)
            {
                switch (this.type)
                {
                    case TempType.f:
                        newValue = (this.value - 32) * 5 / 9;
                        break;
                    case TempType.k:
                        newValue = this.value - 273.15;
                        break;
                    case TempType.r:
                        newValue = this.value * 5 / 9 - 273.15;
                        break;
                }
            }
            else
            {
                newValue = this.To(TempType.c).To(newType).value;
            }
            return new Temperature(newValue, newType);
        }
        public static Temperature operator +(Temperature instance1, Temperature instance2)
        {
            return instance1 + instance2.To(instance1.type).value;
        }
        public static Temperature operator -(Temperature instance1, Temperature instance2)
        {
            return instance1 - instance2.To(instance1.type).value;
        }
        public static bool operator ==(Temperature instance1, Temperature instance2)
        {
            bool a = false;
            if(instance1.value == instance2.To(instance1.type).value)
            {
                a = true;
            }
            return a;
        }
        public static bool operator !=(Temperature instance1, Temperature instance2)
        {
            bool a = false;
            if (instance1.value != instance2.To(instance1.type).value)
            {
                a = true;
            }
            return a;
        }
    }
}
