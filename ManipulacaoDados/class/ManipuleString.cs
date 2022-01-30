namespace ManipulacaoDados
{
    public class ManipuleString
    {
        // s.Where takes each letter as a individual char
        /* 
            "aeiou".Contains() verify if the letter is a vowel so we use the 
            ! to not receive the vowel
        */
        // l.ToString().ToLower() makes the code consider AEIOU

        public string deleteVowels(string s) => new string(s.Where(l => !"aeiou".Contains(l.ToString().ToLower())).ToArray());

        // Count is another LINQ method
        public int quantityLetter(string s, char find) => s.Count(l => l == find);
        
        // to-do: fix
        public string? invertString(string s) => s.Reverse().ToString();  
        
        public string deleteLetter(string s, char l) => new string(s.Where(x => !x.Equals(l)).ToArray());
        public string deleteAfterLetter(string s, char l) => new string(s.TakeWhile(x => x != l).ToArray());
        // to-do: fix
        public string deleteBeforeLetter(string s, char l) => new string(s.SkipWhile(x => x != l).ToArray());
       
        //to -do : fix
        public string toUpperSomeLetters(string s, string toUpperL) => new string(s.Where(x => toUpperL.Contains(x)).Select(l => l.ToString().ToUpper()).ToString());
        public string deleteEveryOtherLetter(string s) => s;
        
        // finds unique letters and it quantitty
        public Dictionary<char, int> findUniqueLetters(string s){
            return new Dictionary<char, int>();
        }

        public string overrideLetter(string s, char baseLetter, char toOverride) => string.Empty;
    }
}