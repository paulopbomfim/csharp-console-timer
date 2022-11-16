using System;
using System.Threading;

namespace Counter;

public class Counter
{
    public int hour { get; set; }
    public int minute { get; set; }
    public int second { get; set; }

    public Counter(string time)
    {
        var TimeArray = time.Split(':');
        
        this.hour = Convert.ToInt32(TimeArray[0]);
        this.minute = Convert.ToInt32(TimeArray[1]);
        this.second = Convert.ToInt32(TimeArray[2]);
    }

    public void Format()
    {
        Console.WriteLine($"{hour:D2}:{minute:D2}:{second:D2}");
    }

    public void HourCounter() {
        this.hour -= 1;
    }
    public void MinuteCounter() {
        if(minute < 0)
        {
            this.minute = 59;
            this.HourCounter();
        }

        this.minute -= 1;

    }
    public void SecondCounter() {
        if (second == 0 && minute == 0 && hour == 0)
            return;

        this.second -= 1;

        if (second < 0)
        {
            this.second = 59;
            this.MinuteCounter();
        }

        this.Format();
        Thread.Sleep(990);

        this.SecondCounter();
    }
}