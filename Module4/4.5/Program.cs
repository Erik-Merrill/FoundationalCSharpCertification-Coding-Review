const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
const string spanOpen = "<span>";
const string spanClose = "</span>";
const string divOpen = "<div>";
const string divClose = "</div>";
const string trade = "&trade;";
const string reg = "&reg;";

int openingPositionSpan = input.IndexOf(spanOpen) + spanOpen.Length;
int closingPositionSpan = input.IndexOf(spanClose);
int lengthOfSpan = closingPositionSpan - openingPositionSpan;

quantity = "Quantity: " + input.Substring(openingPositionSpan, lengthOfSpan);

int openingPositionDiv = input.IndexOf(divOpen) + divOpen.Length;
int closingPositionDiv = input.IndexOf(divClose);
int lengthOfDiv = closingPositionDiv - openingPositionDiv;

output = "Output: " + input.Substring(openingPositionDiv, lengthOfDiv);

output = output.Replace(trade, reg);


Console.WriteLine(quantity);
Console.WriteLine(output);

