//Algoritma
//Verilen string ifade içerisindeki ilk ve son karakterin yerini değiştirip tekrar ekrana yazdıran console uygulamasını yazınız.

//Örnek: Input: Merhaba Hello Algoritma x

//Output: aerhabM oellH algoritmA x
string ent = Console.ReadLine();
string[] str = ent.Split(' ');
foreach (var chr in str)
{
    char[] chars = chr.ToCharArray();
    char firstChar = chars[0];
    chars[0] = chars[chars.Length - 1];
    chars[chars.Length - 1] = firstChar;

    foreach (var chr2 in chars)
    {
        string newStr = chr2.ToString();
        Console.Write(newStr);
    }
    Console.Write(" ");
}