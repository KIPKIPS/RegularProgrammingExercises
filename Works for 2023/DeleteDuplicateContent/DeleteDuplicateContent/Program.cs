using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Program {
    static void Main(string[] args) {
        DeleteDuplicateContent();
    }

    private static void DeleteDuplicateContent() {
        // Console.WriteLine("\u1F34E");
        List<string> list = new List<string>();
        FileStream fs = new FileStream(@"C:\Users\admin\Desktop\CSV\copy.csv", FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(fs, Encoding.Default);
        string strLine;
        List<string> regexList = new List<string>();
        Regex regExp = new Regex("[^0-9a-zA-Z\u4e00-\u9fa5]");
        while ((strLine = reader.ReadLine()) != null) {
            var type = strLine.Substring(strLine.Length - 1);
            var content = strLine.Substring(0, strLine.Length - (type == "," ? 1 : 2));
            if (type == "1" || !regExp.IsMatch(content)) {
                list.Add(content);
            } else {
                regexList.Add(content);
            }
        }
        fs.Dispose();
        fs.Close();
        reader.Dispose();
        reader.Close();
        var arr = list.ToArray();
        Array.Sort(arr, (x, y) => x.Length.CompareTo(y.Length));
        list = arr.ToList();
        // List<string> newList = new List<string>();
        Hashtable map = new Hashtable();
        for (int i = 0; i < list.Count; i++) {
            if (!Match(list[i], map)) {
                //构建新树
                Hashtable tempMap = map;
                for (int j = 0; j < list[i].Length; j++) {
                    char c = list[i][j];
                    if (tempMap[c] == null) {
                        Hashtable tab = new Hashtable();
                        tab.Add("Char", c);
                        tempMap.Add(c, tab);
                        tempMap = tab;
                    } else {
                        tempMap = (Hashtable) tempMap[c];
                    }
                    if (j == list[i].Length - 1) {
                        if (tempMap.ContainsKey("IsEnd")) {
                            tempMap["IsEnd"] = 1;
                        } else {
                            tempMap.Add("IsEnd", 1);
                        }
                    }
                }
            }
        }
        CreateFilterList(map);
        string stringPath = @"C:\Users\admin\Desktop\CSV\dirtyWordFilterString.csv";
        string regexPath = @"C:\Users\admin\Desktop\CSV\dirtyWordFilterRegex.csv";
        if (File.Exists(stringPath)) {
            File.Delete(stringPath);
        }
        FileStream fs1 = new FileStream(stringPath, FileMode.Create, FileAccess.Write);
        StreamWriter writer = new StreamWriter(fs1, Encoding.UTF8);
        for (int i = 0; i < filters.Count; i++) {
            if (!string.IsNullOrEmpty(filters[i])) {
                writer.WriteLine(filters[i]);
            }
        }
        if (File.Exists(regexPath)) {
            File.Delete(regexPath);
        }
        FileStream fs2 = new FileStream(regexPath, FileMode.Create, FileAccess.Write);
        StreamWriter writer2 = new StreamWriter(fs2, Encoding.UTF8);
        string p;
        for (int i = 0; i < regexList.Count; i++) {
            p = ConvertToCsharpRegular(regexList[i]);
            if (!string.IsNullOrEmpty(p)) {
                writer2.WriteLine(p);
                m_regexList.Add(p);
            }
        }
        Console.WriteLine($"剔除重复后剩余普通串数量:{filters.Count}");
        Console.WriteLine($"正则串数量:{m_regexList.Count}");
        
        m_filterRoot = new Node();
        for (int i = 0; i < filters.Count; i++) {
            var curNode = m_filterRoot;
            var str = filters[i];
            for (int j = 0; j < str.Length; j++) {
                char c = str[j];
                if (!curNode.ContainsKey(c)) {
                    Node n = new Node();
                    curNode.Add(c, n);
                    curNode = n;
                } else {
                    curNode = curNode.GetNode(c);
                }
                if (j == str.Length - 1) {
                    curNode.IsEnd = true;
                }
            }
        }
        
        // Console.WriteLine(Regex.IsMatch("连任事大百姓命贱","连任事大*百姓命贱"));
        // Console.WriteLine(CheckDirty("反\x1F33组织"));
        try {
            fs1.Dispose();
            writer.Dispose();
            fs1.Close();
            writer.Close();
            fs2.Close();
            writer2.Close();
        } catch (Exception e) {
        }
    }
    public static bool CheckDirty(string word) {
        if (MatchWord(word)) {
            return true;
        }
        return MatchRegex(word);
    }
    public static bool MatchWord(string word) {
        Node curNode = m_filterRoot;
        for (int j = 0; j < word.Length; j++) {
            char c = word[j];
            Node tempMap = curNode.GetNode(c);
            if (tempMap != null) {
                curNode = tempMap;
            }
        }
        if (curNode.IsEnd) {
            return true;
        }
        return false;
    }

    public static bool MatchRegex(string word) {
        bool match = false;
        for (int i = 0; i < m_regexList.Count; i++) {
            match = Regex.IsMatch(word, m_regexList[i]);
            if (match) {
                return true;
            }
        }
        return match;
    }
    private static List<string> filters = new List<string>();
    private static Node m_filterRoot;
    private static List<string> m_regexList = new List<string>();

    private class Node {
        private Dictionary<char, Node> m_dict;
        private Dictionary<char, Node> Map {
            get {
                if (m_dict == null) {
                    m_dict = new Dictionary<char, Node>();
                }
                return m_dict;
            }
        }
        public bool ContainsKey(char key) {
            return Map.ContainsKey(key);
        }
        public void Add(char key, Node value) {
            Map.Add(key, value);
        }
        public Node GetNode(char key) {
            if (ContainsKey(key)) {
                return Map[key];
            }
            return null;
        }
        public bool IsEnd = false;
    }

    static void CreateFilterList(Hashtable tab, string parent = "") {
        bool isEnd = true;
        string content = "";
        if (tab.ContainsKey("Char")) {
            content = tab["Char"].ToString();
        }
        foreach (var v in tab.Values) {
            if (v is Hashtable) {
                isEnd = false;
                CreateFilterList((Hashtable) v, parent + content);
            }
        }
        if (isEnd) {
            filters.Add(parent + content);
        }
    }
    public static bool Match(string str, Hashtable map) {
        for (int i = 0; i < str.Length; i++) {
            Hashtable tab = map;
            for (int j = i; j < str.Length; j++) {
                char c = str[j];
                Hashtable tempMap = (Hashtable) tab[c];
                if (tempMap != null) {
                    tab = tempMap;
                }
            }
            if (tab.ContainsKey("IsEnd")) {
                char s = (char) tab["Char"];
                tab.Clear();
                tab.Add("Char", s);
                tab.Add("IsEnd", 1);
                return true;
            }
        }
        return false;
    }
    public static string ConvertToCsharpRegular(string pattern) {
        if (string.IsNullOrEmpty(pattern)) {
            return pattern;
        }
        string patternConv = @pattern;
        // \pP => \p{P}
        MatchCollection mc1 = Regex.Matches(@pattern, @"\\pP");
        if (mc1.Count > 0) {
            foreach (Match m in mc1) {
                patternConv = Regex.Replace(patternConv, @"\\pP", @"\p{P}");
            }
        }

        // \x{15F3E}* => *
        MatchCollection mc2 = Regex.Matches(@pattern, @"\\x\{[a-zA-Z0-9]*\}");
        if (mc2.Count > 0) {
            // foreach (Match m in mc2) {
            //     patternConv = patternConv.Replace(m.ToString(),"");
            // }
            return "";
        }
        // 两个中文之间的\ => \\
        MatchCollection mc4 = Regex.Matches(@pattern, @"[\u4e00-\u9fa5]\\[\u4e00-\u9fa5]");
        if (mc4.Count > 0) {
            foreach (Match m in mc4) {
                string s = m.ToString();
                patternConv = m.ToString().Replace(s, s[0] + @"\\" + s[2]);
            }
        }
        MatchCollection mc5 = Regex.Matches(@pattern, @"\\p\{Han\}");
        if (mc5.Count > 0) {
            foreach (Match m in mc5) {
                patternConv = m.ToString().Replace( @"\p{Han}", @"\\p{Han}");
            }
        }
        // // \nwsdbx.*+? => \nwsdbx.*+?
        // MatchCollection mc3 = Regex.Matches(@pattern, @"/[n|w|W|s|S|d|D|b|B|x|X|p|P|.|*|+|?]");
        // if (mc3.Count > 0) {
        //     Console.WriteLine(mc3.Count);
        //     foreach (Match m in mc3) {
        //         string ms = m.ToString();
        //         string rp = m.ToString();
        //         rp = rp.Replace("/", "");
        //         if (Regex.Matches(ms[1].ToString(), "[.|*|+|?]").Count > 0) {
        //             ms = "/\\" + ms[1];
        //         }
        //         patternConv = Regex.Replace(patternConv, @ms, @"\" + rp);
        //     }
        // }
        return patternConv;
    }
}