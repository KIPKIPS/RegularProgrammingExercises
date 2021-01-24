using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DFA敏感词过滤 {
    class Program {
        static void Main(string[] args) {
            List<string> filterMap = new List<string>();
            filterMap.Add("你是谁");
            filterMap.Add("我是你爸爸");
            filterMap.Add("你说什么");
            filterMap.Add("你妈的为什么");
            filterMap.Add("什么破玩意");
            filterMap.Add("垃圾");
            filterMap.Add("哈哈哈");
            filterMap.Add("写的什么垃圾代码");
            InitFilter(filterMap);
            Console.ReadLine();
        }
        private static Hashtable map;
        private static void InitFilter(List<string> words) {
            map = new Hashtable(words.Count);
            for (int i = 0; i < words.Count; i++) {
                string word = words[i];
                Hashtable indexMap = map;
                for (int j = 0; j < word.Length; j++) {
                    char c = word[j];
                    if (indexMap.ContainsKey(c)) {
                        indexMap = (Hashtable)indexMap[c];
                    } else {
                        Hashtable newMap = new Hashtable();
                        newMap.Add("IsEnd", 0);
                        indexMap.Add(c, newMap);
                        indexMap = newMap;
                    }
                    if (j == word.Length - 1) {
                        if (indexMap.ContainsKey("IsEnd")) indexMap["IsEnd"] = 1;
                        else indexMap.Add("IsEnd", 1);
                    }
                }
            }
        }
        private int CheckFilterWord(string txt, int beginIndex) {
            bool flag = false;
            int len = 0;
            Hashtable curMap = map;
            for (int i = beginIndex; i < txt.Length; i++) {
                char c = txt[i];
                Hashtable temp = (Hashtable)curMap[c];
                if (temp != null) {
                    if ((int)temp["IsEnd"] == 1) flag = true;
                    else curMap = temp;
                    len++;
                } else break;
            }
            if (!flag) len = 0;
            return len;
        }
        public string SerachFilterWordAndReplace(string txt) {
            int i = 0;
            StringBuilder sb = new StringBuilder(txt);
            while (i < txt.Length) {
                int len = CheckFilterWord(txt, i);
                if (len > 0) {
                    for (int j = 0; j < len; j++) {
                        sb[i + j] = '*';
                    }
                    i += len;
                } else ++i;
            }
            return sb.ToString();
        }
    }
}
