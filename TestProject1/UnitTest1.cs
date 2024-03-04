using MaxSubarray;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] {1, -2, 0, 3}, 3)]
        [InlineData(new int[] { 3, -1, -1, 4, 3, -1 }, 8)]
        [InlineData(new int[] { -1, -2, -3, -4 }, -1)]
        [InlineData(new int[] { 1, 2, 3, 4 }, 10)]
        [InlineData(new int[] { 1, -5, 3, 4, -2 }, 7)]
        public void Test1(int[] arr, int expected)
        {
            int result = Program.MaxSubArray(arr);
            Assert.Equal(expected, result);
        }
    }
}