public class Solution
{
    public uint reverseBits(uint n)
    {
        uint reversed = 0;
        int numBits = sizeof(uint) * 8;

        for (int i = 0; i < numBits; i++)
        {
            reversed <<= 1;
            reversed |= n & 1;
            n >>= 1;
        }

        return reversed;
    }
}