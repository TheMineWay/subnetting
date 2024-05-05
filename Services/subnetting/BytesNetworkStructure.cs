public class BytesNetworkStructure(List<byte?> bns)
{
    public static BytesNetworkStructure CreateFromInt(int[] bns, byte length = 4)
    {
        List<byte> processedBNSValue = (from num in bns select (num.CompareTo(default) < 0 ? (byte)0 : num.CompareTo(default) > 255 ? (byte)255 : (byte)num)).ToList();

        while (processedBNSValue.Count() != length)
        {
            var count = processedBNSValue.Count();
            if (count > length) processedBNSValue.RemoveAt(0);
            else if (count < length) processedBNSValue.Add(0);
        }

        return new BytesNetworkStructure([.. processedBNSValue]);
    }

    public readonly List<byte?> bns = bns;

    public override string ToString() => String.Join(".", bns);

    public bool IsValid() => bns.All(v => v != null);
}