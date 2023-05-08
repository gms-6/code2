using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code22.Model
{
    public  class Trie
    {
        private Trie[] children;
        private bool isEnd;
        public Trie()
        {
            children = new Trie[26];
            isEnd = false;
        }
        public void Insert(string prefix)
        {
            Trie node = this;
            for(int i=0;i<prefix.Length;i++)
            {
                char ch = prefix[i];
                int index = ch - 'a';
                if (node.children[index]==null)
                    node.children[index]=new Trie();
                node = node.children[index];
            }
            isEnd = true;
        }
        public bool Search(string prefix)
        {
            Trie node = SearchPrefix(prefix);
            return node != null && node.isEnd;
        }
        public bool StartWith(string prefix)
        {
            return SearchPrefix(prefix)!=null;
        }
        public Trie SearchPrefix(string prefix)
        {
            Trie node = this;
            for(int i=0;i<prefix.Length;++i)
            {
                char ch = prefix[i];
                int index = ch - 'a';
                if (node.children[index] == null)
                    return null;
                node= node.children[index];
            }
            return node;
        }
        public bool IsEnd()
        {
            return isEnd;
        }
        public Trie[] GetChildren()
        {
            return children;
        }
    }
}
