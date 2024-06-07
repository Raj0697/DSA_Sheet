public class Solution {
    public string ReplaceWords(IList<string> dictionary, string sentence) {
        IList<string> words = sentence.Split(" ");

    int sentenceLength = words.Count;
    
    //So that the shortest root word gets replaced first
    dictionary = dictionary.OrderBy(x => x.Length).ToList();

    for(int w=0; w<sentenceLength; w++)
    {
        for(int i=0; i< dictionary.Count; i++)
        {
            if (words[w].Contains(dictionary[i]))
            {
                //If the root is a substring and start at position 0
                if(words[w].IndexOf(dictionary[i]) == 0)
                    words[w] = dictionary[i]; 
            }
        }
    }
    return string.Join(" ", words);
    }
}
