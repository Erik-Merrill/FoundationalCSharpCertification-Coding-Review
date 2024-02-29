/*
This program takes a literal sentence, reverses it, 
and counts the number of times the letter 'o' appears.
*/

string sentence = "The quick brown fox jumps over the lazy dog.";

char[] sentenceArray = sentence.ToCharArray();

Array.Reverse(sentenceArray);

int letterCount = 0;
foreach (char letter in sentenceArray)
 {
     if (letter == 'o') { letterCount++; }
 }

string rebuiltSentence = new String(sentenceArray);

Console.WriteLine(rebuiltSentence);
Console.WriteLine($"'o' appears {letterCount} times.");