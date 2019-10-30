<Query Kind="Statements" />

var array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

array[^2].Dump(); //9
array[^1].Dump(); //10
//array[^0].Dump(); // IndexOutOfRangeException
 
array[..].Dump(); //1, 2, 3, 4, 5, 6, 7, 8, 9, 10
array[0..].Dump(); //1, 2, 3, 4, 5, 6, 7, 8, 9, 10
array[..3].Dump(); //1, 2, 3
array[0..3].Dump(); //1, 2, 3
array[0..^1].Dump(); //1, 2, 3, 4, 5, 6, 7, 8, 9
array[0..^0].Dump();//1, 2, 3, 4, 5, 6, 7, 8, 9, 10
array[^3..^1].Dump(); //8, 9
array[^3..^0].Dump(); //8, 9, 10
//array[^1..^2].Dump(); //ArgumentOutOfRangeException
array[0..0].Dump(); //Empty
array[..^0].Dump(); //1, 2, 3, 4, 5, 6, 7, 8, 9, 10
