using System;

namespace DateModifier
{
    public class DateModifier
    {

        public int GetDaysDiffrence(string startDataAsString, string ednDataAsString)
        {
            DateTime startDate = DateTime.Parse(startDataAsString);
            DateTime endData = DateTime.Parse(ednDataAsString);

            int totalDays = (int)Math.Abs((startDate - endData).TotalDays);

            return totalDays;
        }

    }
}
