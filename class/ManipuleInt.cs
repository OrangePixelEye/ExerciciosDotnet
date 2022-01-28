namespace ManipulacaoDados
{
    public class ManipuleInt
    {
        public void arrBetweenTwoN(int start, int end) {
            IEnumerable<int> n = Enumerable.Range(start, end);
            // c# can convert a IEnumerble<int> to an int[] just by using an ToArray()
            int[] arr = n.ToArray();
        }

        public void invertArray(int[] arr) {
            Array.Reverse(arr);
        }
        public void findPairs(int[] arr) {
            var r = arr.Where(x => x % 2 == 0);
        }
        public void uniqueGreaterThan(int[] arr, int ref_value) {
            arr.Distinct().Where(x => x > ref_value);
        }
        public void organize(int[] arr) {
            Array.Sort(arr);
        }
        public void findMultiples(int[] arr, int n)
        {
            var l = arr.Where(x => x % n == 0);
            printEnurable(l);
        }

        public void printEnurable(IEnumerable<int> origin)
        {
            foreach(int n in origin)
            {
                System.Console.WriteLine(n);
            }
        }

        public void squareAllPairs(int start, int end) => printEnurable( Enumerable.Range(start, end).Where(x => x % 2 == 0).Select(x => x * x));
        

    }
}