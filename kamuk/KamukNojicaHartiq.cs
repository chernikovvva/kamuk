const string r = "Rock";
const string p = "Paper";
const string s = "Scissors";

Console.WriteLine("Choose [r]ock, [p]aper, [s]cissors:");
string otg = Console.ReadLine();
if ( otg == "r" )
{
    otg = r;
}
else if ( otg == "p")
{
     otg = p;
}
else if ( otg == "s" )
{
     otg = s;
}
else
{
    Console.WriteLine("try again");
}

Random random = new Random();
int komp =  random.Next(1, 4);
string otgg = "";
switch (komp)
{
    case 1:
        otgg = r;
        break;
    case 2:
        otgg = p;
        break;
    case 3:
        otgg = s;
        break;
}

Console.WriteLine($"My answer is {otgg}.");

if ((otg == r && otgg == s) ||
    (otg == p && otgg == r)  ||
    (otg == s && otgg == p ))
{
    Console.WriteLine("You win");
}
else if ((otg == r && otgg == p) ||
    (otg == p && otgg == s) ||
    (otg == s && otgg == r))
{
    Console.WriteLine("You Lose");
}
else if (((otgg == r && otgg == r) ||
    (otgg == p && otgg == p) ||
    (otgg == s && otgg == s)))
{
    Console.WriteLine("Draww!");
}