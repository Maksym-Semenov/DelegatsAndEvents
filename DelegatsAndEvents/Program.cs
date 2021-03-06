// See https://aka.ms/new-console-template for more information
using DelegatsAndEvents;

string testString = "abracadabra";

StringHelper helper = new StringHelper();
CountDelegate d1 = helper.GetCount;
CountDelegate d2 = helper.GetCountSymbol;

Console.WriteLine("Общее кол-во символов {0}", TestMethod (d1, testString));
Console.WriteLine("Общее кол-во символов A {0}", TestMethod(d2, testString)); ;


static int TestMethod(CountDelegate method, string testString)
{
    return method(testString);
}