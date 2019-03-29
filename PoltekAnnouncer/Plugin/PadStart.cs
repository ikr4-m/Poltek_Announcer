namespace PoltekAnnouncer.Plugin
{
    public class PadStart
    {
        public static string Pad(int number)
        {
            string num = number.ToString();
            return num.Length == 1 ? "0" + num : num;
        }
    }
}
