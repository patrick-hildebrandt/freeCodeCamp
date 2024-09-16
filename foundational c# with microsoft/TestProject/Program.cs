// Console.WriteLine("Hello, C#!");

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