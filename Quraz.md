'''C#
    public static string FindDayFromDate(string date)
    {
        var arr = date.Split("-");
        int d = int.Parse(arr[0]);
        int m = int.Parse(arr[1]);
        int y = int.Parse(arr[2]);

        if (m == 1 || m == 2)
        {
            m += 12;
            y--;
        }
        int day = (d + 2 * m + 3 * (m + 1) / 5 + y + y / 4 - y / 100 + y / 400 + 1) % 7;

        var result = string.Empty;
        switch (day)
        {
            case 1:
                result = "Monday";
                break;
            case 2:
                result = "Tuesday";
                break;
            case 3:
                result = "Wednesday";
                break;
            case 4:
                result = "Thursday";
                break;
            case 5:
                result = "Friday";
                break;
            case 6:
                result = "Saturday";
                break;
            case 7:
                result = "Sunday";
                break;
        }

        return result;
    }
    '''

