// See https://aka.ms/new-console-template for more information
using BNR.Core;

string rule = "{CN:出库}{S:WORLD}{D:yyyyMMddHHmmssfff}{N:{S:ORDER}/00000000000}"; //用户手填

for (int i = 0; i < 1012; i++)
{
    string value = BNRFactory.Default.Create(rule);
    Console.WriteLine(value);

}
Console.Read();