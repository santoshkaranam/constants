// See https://aka.ms/new-console-template for more information

using static System.Console;

WriteLine("Demo Contants");

const string s1 = "This is a const";

var s2 = s1;
var s3 = s1;

WriteLine($"Values of s1={s1}, s2={s2}, s3={s3}");
s2 = s2 + " some text";
WriteLine($"Values of s1={s1}, s2={s2}, s3={s3}");
Read();