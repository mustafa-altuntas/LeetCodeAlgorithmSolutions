

var works1 = new string[] { "abc", "ab", "abcd" };
var works2 = new string[] { "pqr", "pqrs", "pq" };
var outputs = new string[] { "apbqcr", "apbqrs", "apbqcd" };

for (int i = 0; i < works1.Length; i++)
{
    Console.WriteLine(
        string.Equals(outputs[i], MergeAlternately(works1[i], works2[i]))
        ? $"{i}. test başarılı  {outputs[i]} = {MergeAlternately(works1[i], works2[i])}"
        : $"{i}. test başarısız {outputs[i]} = {MergeAlternately(works1[i], works2[i])}"
    );

}


string MergeAlternately(string word1, string word2)
{
    var w1Size = word1.Length;
    var w2Size = word2.Length;
    var n = Math.Min(w1Size, w2Size);

    var w1Q = new Queue<char>(word1);
    var w2Q = new Queue<char>(word2);

    var merge = new Queue<char>();
    var result = "";

    for (int i = 0; i < n; i++)
    {
        merge.Enqueue(w1Q.Dequeue());
        merge.Enqueue(w2Q.Dequeue());
    }

    result = string.Join("", merge.ToArray());
    result += w1Q.Count > 0
     ? string.Join("", w1Q.ToArray())
     : string.Join("", w2Q.ToArray());


    return result;
}



Console.ReadLine();






