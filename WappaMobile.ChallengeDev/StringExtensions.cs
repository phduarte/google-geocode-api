﻿namespace WappaMobile.ChallengeDev
{
    public static class StringExtensions
    {
        public static bool IsEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }
    }
}
