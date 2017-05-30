using System.Text.RegularExpressions;

namespace Clock_Kata
{
    public class Kata_V
    {
        private static readonly Regex validIpV4AddressRegex = new Regex(@"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5]).){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$", RegexOptions.IgnoreCase);
        public static Regex ValidIpV4AddressRegex => validIpV4AddressRegex;

        public static bool is_valid_IP(string ipAddress)
        {
            if (!string.IsNullOrWhiteSpace(ipAddress))
            {
                return ValidIpV4AddressRegex.IsMatch(ipAddress.Trim());
            }
            return false;
        }
    }
}
        