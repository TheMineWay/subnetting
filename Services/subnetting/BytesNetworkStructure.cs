namespace subnetting
{
    public class BytesNetworkStructure(byte[] bns, byte length = 4)
    {
        public static BytesNetworkStructure CreateFromInt(int[] bns)
        {
            List<byte> processedBNSValue = (from num in bns select (num.CompareTo(default) < 0 ? (byte)0 : num.CompareTo(default) > 255 ? (byte)255 : (byte)num)).ToList();

            while (processedBNSValue.Count() != 4)
            {
                var count = processedBNSValue.Count();
                if (count > 4) processedBNSValue.RemoveAt(0);
                else if (count < 4) processedBNSValue.Add(0);
            }

            return new BytesNetworkStructure([.. processedBNSValue]);
        }

        public readonly byte[] bns = bns;
        public readonly byte lenght = length;

        public override string ToString() => String.Join(".", bns);
    }
}