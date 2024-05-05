namespace subnetting
{
    public class Mask(BytesNetworkStructure bns)
    {
        public static Mask CreateEmpty() => new(new([null, null, null, null]));
        public readonly BytesNetworkStructure bns = bns;
    }
}