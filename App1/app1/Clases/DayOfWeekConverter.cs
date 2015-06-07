using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1.Clases
{
    public static class DayOfWeekConverter 
    {
        public static object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
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
                        return "Miércoles";

                    case DayOfWeek.Thursday:
                        return "Jueves";

                    case DayOfWeek.Friday:
                        return "Viernes";

                    case DayOfWeek.Saturday:
                        return "Sábado";

                    default:
                        break;
                }
            }

            return "";
        }

        public static DayOfWeek ConvertBack(string value)
        {
            // string => DayOfWeek
            if (value != null )
            {
                switch (value)
                {
                    case "domingo":
                        return DayOfWeek.Sunday;

                    case "lunes":
                        return DayOfWeek.Monday;

                    case "martes":
                        return DayOfWeek.Tuesday;

                    case "miércoles":
                        return DayOfWeek.Wednesday;

                    case "jueves":
                        return DayOfWeek.Thursday;

                    case "viernes":
                        return DayOfWeek.Friday;

                    case "sábado":
                        return DayOfWeek.Saturday;

                    default:
                        break;
                }
            }

            return DayOfWeek.Sunday;
        }
    }
}
