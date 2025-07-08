using System;
using System.Globalization;


namespace SmithChart
{
    public static class FormatExt
    {
        internal static NumberFormatInfo info = new NumberFormatInfo
        {
            NumberDecimalSeparator = ".",
            NegativeInfinitySymbol = "∞",
            PositiveInfinitySymbol = "∞"
        };

        public static string Format(this double x, int d) => x.ToString($"f{d}", info);
        
        public static double Parse(this string image) => Convert.ToDouble(image, info);
    }
}