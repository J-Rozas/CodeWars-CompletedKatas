namespace environmentForCodeWars
{
    using System;

    public static class Kata
    {
        public static string? Array(string s)
        {
            var arrS = s.Split(",");
            return arrS.Length < 3 ? null : string.Join(",", arrS[1..arrS.Length]);
        }
    }
}