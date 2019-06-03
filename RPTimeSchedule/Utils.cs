using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPTimeSchedule
{
    class Utils
    {
        public static string INVALID_CODE = "Invalid class code, please press ? for more info";
        public static string VALID_CODE = "Valid class code";
        public static string SAVE_TO_LIST_SUCCESS = "Successfully added to the list";
        public static string LIST_EXISTS = "List is already exists";
        public static string SAVE_TO_FILE_SUCCESS = "Successfully saved";
        public static string SAVE_TO_FILE_WHEN_LIST_EMPTY = "Please add class to list to save";
        public static string[] class_to_array(string title)
        {
            string[] code = title.Split('-');
            return code;
        }

        public static DateTime getTimeFromLesson(string s)
        {
            string time = "";
            switch(s[1])
            {
                case 'A':
                    time = "08:00:00";
                    break;
                case 'B':
                    time = "08:30:00";
                    break;
                case 'C':
                    time = "09:00:00";
                    break;
                case 'D':
                    time = "09:15:00";
                    break;
                case 'E':
                    time = "09:30:00";
                    break;
                case 'F':
                    time = "09:45:00";
                    break;
                case 'G':
                    time = "10:00:00";
                    break;
                case 'H':
                    time = "11:15:00";
                    break;
                case 'J':
                    time = "11:30:00";
                    break;
                case 'K':
                    time = "11:45:00";
                    break;
                case 'L':
                    time = "12:00:00";
                    break;
                case 'M':
                    time = "12:15:00";
                    break;
                case 'N':
                    time = "13:00:00";
                    break;
                case 'P':
                    time = "13:15:00";
                    break;
                case 'Q':
                    time = "13:30:00";
                    break;
                case 'R':
                    time = "14:00:00";
                    break;
                case 'S':
                    time = "14:30:00";
                    break;
                case 'T':
                    time = "14:45:00";
                    break;
                case 'U':
                    time = "15:00:00";
                    break;
                case 'V':
                    time = "15:45:00";
                    break;
                case 'W':
                    time = "16:00:00";
                    break;
                case 'X':
                    time = "16:30:00";
                    break;
                case 'Y':
                    time = "17:00:00";
                    break;
                case 'Z':
                    time = "17:30:00";
                    break;
                default:
                    break;
            }
            return DateTime.Parse(time, System.Globalization.CultureInfo.CurrentCulture);
        }

        public static string getDayFromLesson(string s)
        {
            string day = "";
            switch(s[0])
            {
                case '1':
                    day = "Monday";
                    break;
                case '2':
                    day = "Tuesday";
                    break;
                case '3':
                    day = "Wednesday";
                    break;
                case '4':
                    day = "Thursday";
                    break;
                case '5':
                    day = "Friday";
                    break;
                default:
                    break;
            }
            return day;
        }
    }
}
