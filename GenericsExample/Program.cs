﻿
//By using generic types, we can define the behavior of a type(List etc.),
//once and reuse it for multiple types, reducing the amount of code we need to write

//Data structures are types meant for storing and orginizing data so that it can be accessed and modified efficiently
// arrays, stacks, queues, dictionaries..,

//var numbers = new List<int> { 1, 2, 3, 4, 5 };
//var words = new List<string> { "ime", "prezime", "godina"};
//var dates = new List<DateTime> { new DateTime(day: 12, month: 3, year: 2023)};

var numbers = new SimpleList<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);

numbers.RemoveAt(2);

var words = new SimpleList<string>();
words.Add("aaa");
words.Add("bbb");
words.Add("ccc");

var dates = new SimpleList<DateTime>();
dates.Add(new DateTime(day: 12, month: 3, year: 2023));
dates.Add(new DateTime(day: 21, month: 5, year: 2018));
dates.Add(new DateTime(day: 5, month: 1, year: 1996));



Console.ReadKey();
