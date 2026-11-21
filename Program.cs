
//1.
// List<int> ints = [1,2,3,4,5];
// int sum =ints.Sum();
// System.Console.WriteLine(sum);


//2.
// List<string> strings = ["abubakr", "umar","abdulaziz"];

// strings.Sort((a,b)=> b.Length.CompareTo(a.Length));

// foreach (var item in strings)
// {
//     System.Console.Write(item+", ");
// }


//3.
// List<string> strings = ["abubakr", "umar","abdulaziz"];

// foreach (var item in strings)
// {
//     Console.WriteLine(new string(item.ToLower().Distinct().ToArray()));
// }




//4.
// List<Person> people = new List<Person>
// {
//     new Person{Name="abdulaziz", Age=16},
//     new Person{Name="Yusuf", Age=15},
//     new Person{Name="idris", Age=17}
// };
// people.Sort((a, b) => a.Age.CompareTo(b.Age));

// foreach (var item in people)
// {
//     System.Console.WriteLine($"{item.Name} {item.Age}");
// }

// class Person
// {
//     public string? Name { get; set; }
//     public int Age { get; set; }
// }





//5.
// List<string> strings = ["hello", "world", "idris"];

// foreach (var item in strings)
// {
//     System.Console.Write(item.ToUpper()+" ");
// }





//6.
// List<int> ints = [12, 5, 89, 3, 45, 17];

// int max = ints.Max();
// int min = ints.Min();

// System.Console.WriteLine($"Max = {max}");
// System.Console.WriteLine($"Min = {min}");






//7.
// List<string> strings = ["cat", "apple", "array", "idris"];

// List<string> strings2 = [];

// List<bool> bools = [];
// bool isbool = false;

// foreach (var item in strings)
// {
//     string s = new string(item.Distinct().ToArray());
//     strings2.Add(s);
//     if (item.Length == s.Length)
//     {
//         isbool = true;
//     }
//     else
//     {
//         isbool = false;
//     }
//     bools.Add(isbool);
// }


// for(int i=0; i<strings.Count; i++)
// {
//     System.Console.WriteLine($"{strings[i]} - {bools[i]}");
// }







//8.
// List<Person> people = new List<Person>
// {
//     new Person{Name="abdulaziz", Age=16},
//     new Person{Name="Yusuf", Age=15},
//     new Person{Name="idris", Age=17}
// };


// List<int> ints = [];

// foreach (var item in people)
// {
//     ints.Add(item.Age);
// }

// double avg = ints.Average();
// System.Console.WriteLine(avg);

// class Person
// {
//     public string? Name{get; set;}
//     public int Age{get; set;}
// }







//9.
// List<int> ints = [1, 2, 3, 2, 4, 1, 5, 3];
// List<int> n = ints.Distinct().ToList();

// foreach (var item in n)
// {
//     System.Console.WriteLine(item + " ");
// }







//10.
// List<string> words = ["level", "hello", "madam", "apple", "radar"];


// List<string> strings = [];

// foreach (var item in words)
// {
//     string s = new string(item.Reverse().ToArray());
//     strings.Add(s);
// }

// List<bool> bools = [];

// for (int i = 0; i < strings.Count; i++)
// {
//     bool isbool = false;
//     if (strings[i] == words[i])
//     {
//         isbool = true;
//     }
//     else
//     {
//         isbool = false;
//     }
//     bools.Add(isbool);
// }

// for (int i = 0; i < words.Count; i++)
// {
//     System.Console.WriteLine($"{words[i]} - {strings[i]} - {bools[i]}");
// }






//11.
// List<Product> products = new List<Product>
// {
//     new Product { Id = 1, Name = "iPhone 15", Category = "Phone", Price = 900 },
//     new Product { Id = 2, Name = "Samsung S24", Category = "Phone", Price = 850 },
//     new Product { Id = 3, Name = "Lenovo Legion", Category = "Laptop", Price = 1500 },
//     new Product { Id = 4, Name = "HP Pavilion", Category = "Laptop", Price = 750 },
//     new Product { Id = 5, Name = "Xiaomi 14", Category = "Phone", Price = 600 },
//     new Product { Id = 6, Name = "Logitech G102", Category = "Mouse", Price = 25 },
//     new Product { Id = 7, Name = "MacBook Air", Category = "Laptop", Price = 1200 },
//     new Product { Id = 8, Name = "Redmi Note 13", Category = "Phone", Price = 250 },
//     new Product { Id = 9, Name = "Razer Viper", Category = "Mouse", Price = 70 },
//     new Product { Id = 10, Name = "Asus ROG", Category = "Laptop", Price = 1800 }
// };


// System.Console.Write("enter the category : ");
// string n = Console.ReadLine();


// List<Product> n1 = products.FindAll(a => a.Category == n);

// foreach (var item in n1)
// {
//     System.Console.WriteLine($"{item.Name} - {item.Category} - {item.Price}");
// }


// public class Product
// {
//     public int Id { get; set; }
//     public string? Name { get; set; }
//     public string? Category { get; set; }
//     public double Price { get; set; }
// }




//12.
// List<string> words = ["apple", "banana", "cherry", "orange", "mango"];

// string res = string.Join(", ", words);
// System.Console.WriteLine(res);






//13.
// List<int> numbers = [10, 25, 30, 45, 50, 65, 70];

// List<int> ints = numbers.FindAll(n=> n%2!=0);

// int sum =  ints.Sum();
// System.Console.WriteLine(sum);







//14.
// List<string> words = ["cat", "elephant", "dog", "computer", "hi", "programming"];
// words.Sort((a, b) => b.Length.CompareTo(a.Length));
// System.Console.WriteLine(words[0]);






//15.
// List<Person> people = new List<Person>
// {
//     new Person { Name = "Muhammad", Age = 20 },
//     new Person { Name = "Idris", Age = 17 },
//     new Person { Name = "Ahmad", Age = 25 },
//     new Person { Name = "Abdullo", Age = 18 },
//     new Person { Name = "Yusuf", Age = 16 },
//     new Person { Name = "Ali", Age = 19 }
// };


// people.Sort((a,b)=> a.Name.CompareTo(b.Name));

// foreach (var item in people)
// {
//     System.Console.WriteLine($"{item.Name} - {item.Age}");
// }

// public class Person
// {
//     public string Name { get; set; } = "";
//     public int Age { get; set; }
// }






//16.
// List<int> numbers = [2, 4, 6, 8, 3, 7, 1, 9];

// int res = 10;
// numbers.Where((a,b) => a+b==res);





//17.
