using System.Text;

static string MergeAlternately(string word1, string word2) {
    StringBuilder result = new StringBuilder();

    for (int i = 0; i<=(Math.Max(word1.Length, word2.Length)); i++){
        if(word1.Length == i && word2.Length ==i){
            return result.ToString();
        }
        if(word1.Length == i){
            result.Append(word2.Substring(i));
            return result.ToString();
        }
        if(word2.Length == i){
            result.Append(word1.Substring(i));
            return result.ToString();
        }

        result.Append(word1[i]);
        result.Append(word2[i]);

    }
    return result.ToString();
}