// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("The current time is " + DateTime.Now);

var beginningDate = DateOnly.FromDateTime(new DateTime(0001, 1, 1));

System.Console.WriteLine(beginningDate);

var difference = DateTime.Now - (new DateTime(0001, 1, 1));
System.Console.WriteLine(difference.Days);
System.Console.WriteLine(DateOnly.FromDayNumber(1000000));

/* Hello, World!
The current time is 11/10/2022 2:24:35 PM
1/1/0001
738468
11/29/2738
PS C:\TryDotNet
 2738-2022
716 */


