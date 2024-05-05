namespace subnetting
{
    public class Ip(BytesNetworkStructure bns)
    {
        public static Ip CreateEmpty() => new(new([null, null, null, null]));
        public readonly BytesNetworkStructure bns = bns;

        public bool IsValid => bns.IsValid;
    }
}