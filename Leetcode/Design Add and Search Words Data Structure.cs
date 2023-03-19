public class WordDictionary {
public
    public class TrieNode
    {
        public TrieNode[] Children = new TrieNode[26];
        public bool IsWord;
        
        public static void Insert(TrieNode root, string word)
        {
            TrieNode node = root;
            foreach(char c in word)
            {
                int index = c - 'a';
                if(node.Children[index] == null)
                {
                    node.Children[index] = new TrieNode();
                }
                
                node = node.Children[index];
            }
            
            node.IsWord = true;
        }
    }
    
    private TrieNode root;

    /** Initialize your data structure here. */
    public WordDictionary() 
    {
        root = new TrieNode();
    }
    
    /** Adds a word into the data structure. */
    public void AddWord(string word) 
    {
        TrieNode.Insert(root, word);    
    }
    
    /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
    public bool Search(string word)
    {
        return search(root, word, 0);
    }
    
    
    private bool search(TrieNode root, string word, int index)
    {
        TrieNode node = root;
        
        if(index == word.Length)
        {
            return node.IsWord;
        }
                
        if(word[index] != '.')
        {
            if(node.Children[word[index] - 'a'] == null)
            {
                return false;
            }
            
            node = node.Children[word[index] - 'a'];
            return search(node, word, index + 1);
        }
        
        else
        {
            foreach(var child in node.Children)
            {
                if(child != null)
                {
                    if(search(child, word, index + 1))
                    {
                        return true;
                    }
                }
            }
        }
        
        return false;
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */
