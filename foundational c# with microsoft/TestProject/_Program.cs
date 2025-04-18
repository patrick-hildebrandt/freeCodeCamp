﻿// Console.WriteLine("Hello, C#!");

// Random dice = new();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);
// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// int firstValue = 500;
// int secondValue = 600;
// int largerValue = Math.Max(firstValue, secondValue);
// Console.WriteLine(largerValue);

// Random dice = new();
// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);
// int total = roll1 + roll2 + roll3;
// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
// if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
// {
//     if (roll1 == roll2 && roll2 == roll3)
//     {
//         Console.WriteLine("You rolled triples! +6 bonus to total!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("your rolled doubles! +2 bonus to total!");
//         total += 2;
//     }
//     Console.WriteLine($"Your total including the bonus: {total}");
// }
// if (total >= 16)
// {
//     Console.WriteLine("You win a new car!");
// }
// else if (total >= 10)
// {
//     Console.WriteLine("You win a new Laptop!");
// }
// else if (total == 7)
// {
//     Console.WriteLine("You win a trip for two!");
// }
// else
// {
//     Console.WriteLine("You win a kitten!");
// }

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;
// if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiration == 1)
// {
//     Console.WriteLine("Your subscription expires within a day!");
//     discountPercentage = 20;
// }
// else if (daysUntilExpiration <= 5)
// {
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//     discountPercentage = 10;
// }
// else if (daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }
// if (discountPercentage > 0)
// {
//     Console.WriteLine($"Renew now and save {discountPercentage}%.");
// }

// string[] fraudulentOrderIDs = new string[3];
// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
//// ältere Syntax, weiterhin gültig
// string[] fraudulentOrderIDs = { "A123", "B456", "C789" };
// string[] fraudulentOrderIDs = ["A123", "B456", "C789"];
// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
// fraudulentOrderIDs[0] = "F000";
// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// int[] inventory = { 200, 450, 700, 175, 250 };
// int sum = 0;
// int bin = 0;
// foreach (int items in inventory) {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }
// Console.WriteLine($"We have {sum} items in inventory.");

// string[] orders = [
// "B123",
// "C234",
// "A345",
// "C15",
// "B177",
// "G3003",
// "C235",
// "B179",
// ];
// foreach (string order in orders) {
//     if (order.StartsWith("B")) {
//         Console.WriteLine(order);
//     }
// }

// /*
// The following code creates five random orderIDs
// to test the fraud detection process. OrderIDs
// consist of a letter form A to E, and a three
// digit number. Ex. A123.
// */
// Random random = new Random();
// string[] orderIDs = new string[5];
// for (int i = 0; i < orderIDs.Length; i++)
// {
//     int prefixValue = random.Next(65, 70);
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     string suffix = random.Next(1, 1000).ToString("000");
//     orderIDs[i] = prefix + suffix;
// }
// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }

// // Example 1:
// Console
// .
// WriteLine
// (
// "Hello Example 1!"
// )
// ;
// // Example 2:
// string fristWord = "Hello"; string lastWord = "Example 2"; Console.WriteLine(fristWord + " " + lastWord + "!");
//
// Random dice = new Random();
//
// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);
//
// int total = roll1 + roll2 + roll3;
// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
//
// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
//     {
//         Console.WriteLine("You rolled triples!  +6 bonus to total!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//         total += 2;
//     }
// }

// /*
//    This code reverses a message, counts the number of times 
//    a particular character appears, then prints the results
//    to the console window.
//  */
// string originalMessage = "The quick brown fox jumps over the lazy dog.";
// char[] message = originalMessage.ToCharArray();
// Array.Reverse(message);
// int letterCount = 0;
// foreach (char letter in message)
// {
//     if (letter == 'o')
//     {
//         letterCount++;
//     }
// }
// string newMessage = new String(message);
// Console.WriteLine(newMessage);
// Console.WriteLine($"'o' appears {letterCount} times.");

// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);
// string myValue = "a";
// Console.WriteLine(myValue == "a");
// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);
// string myValue1 = "a";
// Console.WriteLine(myValue1 != "a");
// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);
// // StartsWith()
// // EndsWith()
// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));
// Console.WriteLine(pangram.Contains("fox") == false);
// Console.WriteLine(!pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));
// int a = 7;
// int b = 6;
// Console.WriteLine(a != b);
// string s1 = "Hello";
// string s2 = "Hello";
// Console.WriteLine(s1 != s2);
// int saleAmount = 1001;
// // int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
// Random random = new();
// Console.WriteLine(random.Next(0, 2) == 0 ? "heads" : "tails");
// string permission = "Admin|Manager";
// int level = 55;
// if (permission.Contains("Admin") && level > 55)
// {
//     Console.WriteLine("Welcome, Super Admin user.");
// }
// else if (permission.Contains("Admin"))
// {
//     Console.WriteLine("Welcome, Admin user.");
// }
// else if (permission.Contains("Manager") && level >= 20)
// {
//     Console.WriteLine("Contact an Admin for access.");
// }
// else if (permission.Contains("Manager"))
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }
// else
// {
//     Console.WriteLine("You do not have usfficient privileges.");
// }

// bool flag = true;
// int value = 0;
// if (flag)
// {
//     Console.WriteLine($"Inside the code block: {value}");
// }
// value = 10;
// Console.WriteLine($"Outside the code block: {value}");
// // if (flag)
// //     Console.WriteLine(flag);
// if (flag) Console.WriteLine(flag);
// // string name = "steve";
// // if (name == "bob") Console.WriteLine("Found Bob");
// // else if (name == "steve") Console.WriteLine("Found Steve");
// // else Console.WriteLine("Found Chuck");
// string name = "steve";
// if (name == "bob")
//     Console.WriteLine("Found Bob");
// else if (name == "steve")
//     Console.WriteLine("Found Steve");
// else
//     Console.WriteLine("Found Chuck");

// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0;
// bool found = false;
//
// foreach (int number in numbers)
// {
//     total += number;
//     if (number == 42)
//         found = true;
// }
//
// if (found)
//     Console.WriteLine("Set contains 42");
//
// Console.WriteLine($"Total: {total}");

// int employeeLevel = 100;
// string employeeName = "John Smith";
// string title = "";
// switch (employeeLevel)
// {
//     case 100:
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }
// Console.WriteLine($"{employeeName}, {title}");

// // SKU = Stock Keeping Unit. 
// // SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";
// string[] product = sku.Split('-');
// string type = "";
// string color = "";
// string size = "";
// switch (product[0])
// {
//     case "01":
//         type = "Sweat shirt";
//         break;
//     case "02":
//         type = "T-Shirt";
//         break;
//     case "03":
//         type = "Sweat pants";
//         break;
//     default:
//         type = "Other";
//         break;
// }
// switch (product[1]) {
//     case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maroon";
//         break;
//     default:
//         color = "White";
//         break;
// }
// switch (product[2]) {
//     case "S":
//         size = "Small";
//         break;
//     case "M":
//         size = "Medium";
//         break;
//     case "L":
//         size = "Large";
//         break;
//     default:
//         size = "One Size Fits All";
//         break;
// }
// Console.WriteLine($"Product: {size} {color} {type}");

// // Initialisierer, Bedingung, Iterator, Hauptteil
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }
// for (int i = 10; i > 0; i--)
// {
//     Console.WriteLine(i);
// }
// for (int i = 0; i < 10; i += 3) {
//     Console.WriteLine(i);
// }
// for (int i = 0; i < 10; i++) {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--) {
//     Console.WriteLine(names[i]);
// }
// for (int i = 0; i < names.Length; i++) {
//     Console.WriteLine(names[i]);
// }
// foreach (var name in names) {
//     // Foreach-Iterationsvariable ist schreibgeschützt
//     // if (name == "David") name = "Sammy";
// }
// for (int i = 0; i < names.Length; i++) {
//     if (names[i] == "David") names[i] = "Sammy";
// }
// foreach (var name in names) Console.WriteLine(name);

// for (int i = 1; i <= 100; i++) {
//     string line = i.ToString();
//     if (i % 3 == 0 || i % 5 == 0) line += " - ";
//     if (i % 3 == 0) line += "Fizz";
//     if (i % 5 == 0) line += "Buzz";
//     Console.WriteLine(line);
// }

// Random random = new();
// int current = random.Next(1, 11);
// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);
// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");
// do {
//     current = random.Next(1, 11);

//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);

// Random random = new();
// int attack()
// {
//     return random.Next(1, 11);
// }
// int hero = 10;
// int monster = 10;
// do
// {
//     int heroAttack = attack();
//     monster -= heroAttack;
//     Console.WriteLine($"Monster was damaged, lost {heroAttack} health and now has {monster} health.");
//     // if (monster <= 0) continue/break;
//     if (monster > 0)
//     {
//         int monsterAttack = attack();
//         hero -= monsterAttack;
//         Console.WriteLine($"Hero was damaged, lost {monsterAttack} health and now has {hero} health.");
//     }
// } while (hero > 0 && monster > 0);
// // Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
// if (hero > 0)
// {
//     Console.WriteLine("Hero wins!");
// }
// else if (monster > 0)
// {
//     Console.WriteLine("Monster wins!");
// }
// else
// {
//     Console.WriteLine("Both hero and monster died.");
// }

// nullable type
// string? readResult;
// bool validEntry = false;
// Console.WriteLine("Enter a string containing at least three characters:");
// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         if (readResult.Length >= 3)
//         {
//             validEntry = true;
//         }
//         else
//         {
//             Console.WriteLine("Your input is invalid, please try again.");
//         }
//     }
// } while (validEntry == false);
// int numericValue = 0;
// bool validNumber = false;
// validNumber = int.TryParse(readResult, out numericValue);
// Console.WriteLine($"Entered: {readResult}");
// Console.WriteLine($"Valid number: {validNumber}");
// Console.WriteLine($"Numeric value: {numericValue}");

// Console.WriteLine("Enter an integer value between 5 and 10");
// string? input;
// bool valid = false;
// int number = 0;
// do
// {
//     input = Console.ReadLine();
//     valid = int.TryParse(input, out number);
//     if (!valid)
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//     else if (number < 5 || number > 10)
//     {
//         Console.WriteLine($"You entered {number}. Please enter a number between 5 and 10.");
//         valid = false;
//     }
// } while (!valid);
// Console.WriteLine($"Your input value ({number}) has been accepted.");

// Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
// string role = "";
// while (role == "")
// {
//     string check = Console.ReadLine().Trim();
//     switch (check.ToLower())
//     {
//         case "administrator":
//             role = "Administrator";
//             break;
//         case "manager":
//             role = "Manager";
//             break;
//         case "user":
//             role = "User";
//             break;
//         default:
//             Console.WriteLine($"The role name that you entered, \"{check}\" is not valid. Enter your role name (Administrator, Manager, or User)");
//             break;
//     }
// }
// Console.WriteLine($"Your input value ({role}) has been accepted.");

// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
// foreach (string myString in myStrings)
// {
//     int periodLocation = myString.IndexOf(".");
//     string sentence = myString;
//     while (periodLocation != -1)
//     {
//         Console.WriteLine(sentence.Substring(0, periodLocation).TrimStart());
//         sentence = sentence.Remove(0, periodLocation + 1);
//         periodLocation = sentence.IndexOf(".");
//     }
//     if (sentence.Length > 0)
//         Console.WriteLine(sentence.TrimStart());
// }

// Console.WriteLine("Signed integral types:");
// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
// Console.WriteLine();
// Console.WriteLine("Unsigned integral types:");
// Console.WriteLine($"byte : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong : {ulong.MinValue} to {ulong.MaxValue}");
// Console.WriteLine();
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal : {decimal.MinValue} to {decimal.MaxValue} (with ~28-29 digits of precision)");
// // int[] data;
// // data = new int[3];
// int[] data = new int[3];
// Console.WriteLine("\nStringtest");
// // string = verweistyp / implementiert als wertttyp
// string string1 = "string";
// string string2 = string1;
// Console.WriteLine(string1);
// Console.WriteLine(string2);
// string2 += 2;
// Console.WriteLine(string1);
// Console.WriteLine(string2);
// Console.WriteLine("\nDecimaltest");
// decimal test1 = 1m;
// int test2 = 2;
// var test3 = test1 + test2;
// Console.WriteLine(test3);
// Console.WriteLine(test3.GetType().Name);
// decimal test4 = 4.44m;
// test3 += test4;
// Console.WriteLine(test3);
// Console.WriteLine(test3.GetType().Name);

// int first = 2;
// string second = "4";
// // int result = first + second;
// string result = first + second;
// Console.WriteLine(result);
// // int myInt = 3;
// // Console.WriteLine($"int: {myInt}");
// // decimal myDecimal = myInt;
// // Console.WriteLine($"decimal: {myDecimal}");
// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");
// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");
// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;
// Console.WriteLine($"Decimal : {myDecimal}");
// Console.WriteLine($"Float   : {myFloat}");
// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);
// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);
// using System.Globalization;
// CultureInfo.CurrentCulture = new CultureInfo("en-US");
// string value1 = "5";
// string value2 = "7";
// // Convert rundet arithmetisch/kaufmännisch
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);
// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value);
// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2);

// // string value = "102";
// string value = "bad";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }
// if (result > 0)
//     Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// string[] values = { "12,3", "45", "ABC", "11", "DEF" };
// string message = "";
// decimal total = 0.00m;
// foreach (var value in values)
// {
//     decimal result;
//     if (decimal.TryParse(value, out result))
//         total += result;
//     else
//         message += value;
// }
// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");

// int value1 = 11;
// decimal value2 = 6.2m;
// float value3 = 4.3f;
// int result1 = Convert.ToInt32(value1 / value2);
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");
// decimal result2 = value2 / (decimal)value3;
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");
// float result3 = value3 / value1;
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine();
// Console.WriteLine("sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
// Console.WriteLine();
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
// Console.WriteLine();
// Console.WriteLine($"Before: {pallets[0].ToLower()}");
// Array.Clear(pallets, 0, 2);
// if (pallets[0] != null)
//     Console.WriteLine($"After: {pallets[0].ToLower()}");
// Console.WriteLine();
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     if (pallet == null)
//         // Console.WriteLine($"-- null");
//         Console.WriteLine($"-- {pallet}");
//     else
//         Console.WriteLine($"-- {pallet}");
// }
// Console.WriteLine();
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");
// pallets[4] = "C01";
// pallets[5] = "C02";
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
// Console.WriteLine();
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
// Console.WriteLine();
// int notNull = 0;
// foreach (var pallet in pallets)
//     if (pallet != null)
//         notNull++;
// string[] newPallets = new string[notNull];
// Console.WriteLine($"Removing nulls ... count: {newPallets.Length}");
// foreach (var pallet in pallets)
// {
//     if (pallet == null)
//         continue;
//     newPallets[newPallets.Length - notNull--] = pallet;
// }
// foreach (var pallet in newPallets)
//     Console.WriteLine($"-- {pallet}");

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);
// string[] items = result.Split(',');
// foreach (string item in items)
//     Console.WriteLine(item);

// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] words = pangram.Split(' ');
// string reversedPangram = "";
// foreach (string word in words)
// {
//     char[] letters = word.ToCharArray();
//     Array.Reverse(letters);
//     reversedPangram += new string(letters) + " ";
// }
// Console.WriteLine(reversedPangram.Trim());

// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// string[] orders = orderStream.Split(',');
// Array.Sort(orders);
// for (int i = 0; i < orders.Length; i++)
// {
//     if (orders[i].Length != 4)
//         orders[i] += "\t- Error";
// }
// foreach (string order in orders)
//     Console.WriteLine(order);

// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine(result);
// Console.WriteLine("{1} {0}!", first, second);
// Console.WriteLine("{0} {0} {0}!", first, second);
// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");
// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");
// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N4} units");
// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");
// decimal price = 67.55m;
// decimal salePrice = 59.99m;
// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ",
//     (price - salePrice), price );
// Console.WriteLine($"A discount of {((price - salePrice)/price)}!");
// yourDiscount += $"A discount of {((price - salePrice)/price):P2}!";
// Console.WriteLine(yourDiscount);

// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;
// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"   Shares: {productShares:N3} Product");
// Console.WriteLine($"     Sub Total: {subtotal:C}");
// Console.WriteLine($"           Tax: {taxPercentage:P2}");
// Console.WriteLine($"     Total Billed: {total:C}");

// // String-Methoden
// // PadLeft()
// // PadRight()
// // Trim()
// // TrimStart()
// // TrimEnd()
// // GetHashcode()
// // Contains()
// // StartsWith()
// // EndsWith()
// // Substring()
// // Replace()
// // Insert()
// // Remove()
// // Split()
// // ToCharArray()
// char[] chars = "das ist ein Beispiel".ToArray();
// foreach (char ch in chars)
//     Console.WriteLine($"{ch} {((byte)ch).ToString().PadLeft(4)}");

// string input = "Pad this";
// Console.WriteLine(input.PadLeft(12));
// Console.WriteLine(input.PadRight(12) + "|");
// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));
// string paymentId = "769C";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";
// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);
// Console.WriteLine("1234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);

// using System.Globalization;
// CultureInfo.CurrentCulture = new CultureInfo("en-US");
// string customerName = "Ms. Barros";
// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;
// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;
// Console.WriteLine($"Dear {customerName},");
// Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new"
//     + $" financial product that would dramatically increase your return.\n");
// Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n");
// Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current"
//     + $" volumne, your potential profit would be {newProfit:C}.\n");
// Console.WriteLine("Here's a quick comparison:\n");
// string comparisonMessage = "";
// comparisonMessage += $"{currentProduct.PadRight(20)}";
// comparisonMessage += $"{currentReturn:P2}".PadRight(9);
// comparisonMessage += $"{currentProfit:C}";
// comparisonMessage += "\n";
// comparisonMessage += $"{newProduct.PadRight(20)}";
// comparisonMessage += $"{newReturn:P2}".PadRight(9);
// comparisonMessage += $"{newProfit:C}";
// Console.WriteLine(comparisonMessage);

// string message = "Find what is (inside the parentheses)";
// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');
// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition + 1, length - 1));
// string message = "What is the value <span>between the tags</span>?";
// const string openSpan = "<span>";
// const string closeSpan = "</span>";
// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);
// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "(What if) I am (only interested) int the last (set of parentheses)?";
// int openingPosition = message.LastIndexOf('(');
// openingPosition += 1;
// int closingPosition = message.LastIndexOf(')');
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));
// string message = "(What if) there are (more than) one (set of parentheses)?";
// Console.WriteLine(message);
// while (true)
// {
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;
//     openingPosition += 1;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
//     message = message.Substring(closingPosition + 1);
// }
// string message = "Help (find) the {opening symbols}";
// Console.WriteLine($"Searching THIS Message: {message}");
// char[] openSymbols = { '[', '{', '(' };
// int startPosition = 5;
// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");
// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition {startPosition}: {message.Substring(openingPosition)}");

// string message = "(What if) I have [dirreferent symbols] but every {open symbol} needs a [matching closing symbol]?";
// char[] openSymbols = { '[', '{', '(' };
// int closingPosition = 0;
// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
//     if (openingPosition == -1) break;
//     string currentSymbol = message.Substring(openingPosition, 1);
//     char matchingSymbol = ' ';
//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;
//     }
//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
// }

// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);
// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);

// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
// string quantity = "";
// string output = "";
// string tag1 = "<span>";
// string tag2 = "</span>";
// quantity = input.Substring(input.IndexOf(tag1) + tag1.Length,
//     input.IndexOf(tag2) - (input.IndexOf(tag1) + tag1.Length));
// // Console.WriteLine(input.IndexOf(tag2) - input.IndexOf(tag1) + tag1.Length);
// // Console.WriteLine($"{input.IndexOf(tag2)} - {input.IndexOf(tag1)} + {tag1.Length}");
// // Console.WriteLine(input.IndexOf(tag2) - (input.IndexOf(tag1) + tag1.Length));
// // Console.WriteLine($"{input.IndexOf(tag2)} - {input.IndexOf(tag1) + tag1.Length}");
// output = input;
// output = output.Replace("<div>", "");
// output = output.Replace("</div>", "");
// output = output.Replace("&trade;", "&reg;");
// Console.WriteLine($"Quantity: {quantity}");
// Console.WriteLine($"Output: {output}");