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
        
      
        public string? invertString(string s) => new string(s.Reverse().ToArray());  
        
        public string deleteLetter(string s, char l) => new string(s.Where(x => !x.Equals(l)).ToArray());
        public string deleteAfterLetter(string s, char l) => new string(s.TakeWhile(x => x != l).ToArray());
        
        public string deleteBeforeLetter(string s, char l) => new string(s.SkipWhile(x => !x.Equals(l)).ToArray());
       
        public string toUpperSomeLetters(string s, string toUpperL) => new string(s.Select(x => toUpperL.ToLower().Contains(x.ToString()) ? char.ToUpper(x) : x ).ToArray());
        
        public string deleteEveryOtherLetter(string s) => s;
        
        // finds unique letters and it quantitty
        public Dictionary<char, int> findUniqueLetters(string s){
            Dictionary<char, int> d = new Dictionary<char, int>();
            
            foreach (var c in s){
               if(d.ContainsKey(c))
                    d[c]++; 
                else 
                    d.Add(c, 1);
            }
            
            return d;
        }

        public string overrideLetter(string s, char baseLetter, char toOverride) => s.Replace(baseLetter, toOverride);
    }
}