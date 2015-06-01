using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1.Clases
{
      public class DayOfWeekConverter 
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // DayOfWeek => string
            if (value != null && value is DayOfWeek)
            {
                switch ((DayOfWeek)value)
                {
                    case DayOfWeek.Sunday:
                        return "Domingo";

                    case DayOfWeek.Monday:
                        return "Lunes";

                    case DayOfWeek.Tuesday:
                        return "Martes";

                    case DayOfWeek.Wednesday:
                        return "Miercoles";

                    case DayOfWeek.Thursday:
                        return "Jueves";

                    case DayOfWeek.Friday:
                        return "Viernes";

                    case DayOfWeek.Saturday:
                        return "Sabado";

                    default:
                        break;
                }
            }

            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // string => DayOfWeek
            if (value != null && value is string)
            {
                switch ((string)value)
                {
                    case "Domingo":
                        return DayOfWeek.Sunday;

                    case "Lunes":
                        return DayOfWeek.Monday;

                    case "Martes":
                        return DayOfWeek.Tuesday;

                    case "Miercoles":
                        return DayOfWeek.Wednesday;

                    case "Jueves":
                        return DayOfWeek.Thursday;

                    case "Viernes":
                        return DayOfWeek.Friday;

                    case "Sabado":
                        return DayOfWeek.Saturday;

                    default:
                        break;
                }
            }

            return DayOfWeek.Sunday;
        }
    }
}
