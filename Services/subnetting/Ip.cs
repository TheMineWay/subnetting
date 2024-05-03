namespace subnetting
{
    public class Ip(byte[] ip)
    {
        // Static
        public static Ip CreateFromInt<T>(int[] ip)
        {
            List<byte> processedIp = (from num in ip select (num.CompareTo(default) < 0 ? (byte)0 : num.CompareTo(default) > 255 ? (byte)255 : (byte)num)).ToList();

            while (processedIp.Count() != 4)
            {
                var count = processedIp.Count();
                if (count > 4) processedIp.RemoveAt(0);
                else if (count < 4) processedIp.Add(0);
            }

            return new Ip([.. processedIp]);
        }
        public readonly byte[] ip = ip;

        public override string ToString() => $"{ip[0]}.{ip[1]}.{ip[2]}.{ip[3]}";
    }
}