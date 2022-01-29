namespace ManipulacaoDados
{
    public class ManipuleInt
    {
        public int[] arrBetweenTwoN(int start, int end) {
            IEnumerable<int> n = Enumerable.Range(start, end);
            // c# can convert a IEnumerble<int> to an int[] just by using an ToArray()
            return n.ToArray();
        }

        public int[] invertArray(int[] arr) {
            // Array.Reverse returns void
            Array.Reverse(arr);
            return arr;
        }
        
        public int[] findPairs(int[] arr) => arr.Where(x => x % 2 == 0).ToArray();
        
        public int[] uniqueGreaterThan(int[] arr, int ref_value) => arr.Distinct().Where(x => x > ref_value).ToArray();
     
        public int[] organize(int[] arr) {
            // Array.Sort returns void
            Array.Sort(arr);
            return arr;   
        }
        
        public int[] findMultiples(int[] arr, int n) => arr.Where(x => x % n == 0).ToArray();

        public int[] squareAllPairs(int start, int end) => Enumerable.Range(start, end).Where(x => x % 2 == 0).Select(x => x * x).ToArray();
    }
}