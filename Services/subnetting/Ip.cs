namespace subnetting
{
    public class Ip(byte[] ip)
    {
        // Static
        public static Ip CreateFromInt<T>(int[] ip)
        {
            byte[] processedIp = (from num in ip select (num.CompareTo(default) < 0 ? (byte)0 : num.CompareTo(default) > 255 ? (byte)255 : (byte)num)).ToArray();

            return new Ip(processedIp);
        }
        public readonly byte[] ip = ip;

        public override string ToString() => $"{ip[0]}.{ip[1]}.{ip[2]}.{ip[3]}";
    }
}