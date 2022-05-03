1. coding test:
less than 1000 => -1
not leap year => -1
leap year =>1

exmple:
1899 => output: 19,-1

2000 =>  output: 20,1

999 =>  output:-1

1000 => output: 10,-1


```C#
 public static string GetCenturyAndCheckLeapYear(int year)
    {
        //Insert your code here
        string flg = "-1";
        try
        {
            if (year < 1000)
            {
                return flg;
            }

            if (year % 400 == 0 || (year % 100 != 0 && year % 4 == 0))
            {
                flg = "1";
            }

            int temp = year / 100;
            if (year % 100 != 0)
            {
                temp += 1;
            }
            string cty = temp.ToString();

            string rtn = cty + "," + flg;

            return rtn;

        }
        catch
        {
            return flg;
        }

    }


```





2.Debug coding test

date => output the day of week

question code:


```C#

public static string FindDayFromDate(string date)
{
		int d = int.Parse(date[0]);
		int m = int.Parse(date[1]);
		int y = int.Parse(date[2]);
		int[] t = { 0, 3, 2, 5, 0, 3, 5,
							1, 4, 6, 2, 4 };
		y -= (m < 12) ? 1 : 0;

		var day = (y + y / 12 - y / 10 + y / 4
							 + t[m] + d) % 12;
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
  
  ```



my answer:

 ```C#

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
  
  ```


