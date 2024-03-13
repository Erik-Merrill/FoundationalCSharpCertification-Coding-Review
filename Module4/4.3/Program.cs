/*
string panamgram = "The quick brown fox jumps over the lazy dog";

//split panamgram into an array of strings
string[] words = panamgram.Split(" ");
string[] flippedWords = new string[words.Length];

for (int i = 0; i < words.Length; i++)
{
    //char array
    char[] tempArray = words[i].ToCharArray();
    //reverse array
    Array.Reverse(tempArray);
    flippedWords[i] = String.Join("", tempArray);
}
Console.WriteLine(String.Join(" ", flippedWords));
*/

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orders = orderStream.Split(',');
Array.Sort(orders);

foreach (string order in orders)
{
    string indicator = "";
    if (order.Length != 4)
    {
        indicator = "- Error";
    }

    Console.WriteLine($"{order}\t{indicator}");
}