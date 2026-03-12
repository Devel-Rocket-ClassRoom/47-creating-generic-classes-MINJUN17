using System;

Converter<string, int> converter = new Converter<string, int>(s => s.Length);
Console.WriteLine("=== 문자열 → 길이 변환 ===");
Console.WriteLine($"Hello -> {converter.Convert("Hello")}");
string[] text = { "Hello", "World", "C#" };
converter.ConvertAll(text);
Console.Write("전체 변환: ");
for(int i = 0; i < text.Length; i++)
{
    if(i != 0)
    {
        Console.Write(",");
    }
    Console.Write($" {converter.ConvertAll(text)[i]}");
}
Console.WriteLine("\n");
Console.WriteLine("=== 정수 → 문자열 변환 ===");
Converter<int, string>  converter2 = new Converter<int, string>(n => $"{n}번");
Console.WriteLine($"1 -> {converter2.Convert(1)}");
Console.Write("전체 변환: ");
int[] numbers = { 1, 2, 3 };
for (int i = 0; i < text.Length; i++)
{
    if (i != 0)
    {
        Console.Write(",");
    }
    Console.Write($" {converter2.ConvertAll(numbers)[i]}");
}
Console.WriteLine("\n");
Console.WriteLine("=== 실수 → 정수 변환 ===");
Converter<double, int> converter3 = new Converter<double, int>(d => (int)d);
Console.WriteLine($"3.7 -> {converter3.Convert(3.7)}");
Console.Write("전체 변환: ");
double[] dnumbers = { 3.7, 1.2, 9.9 };
for (int i = 0; i < text.Length; i++)
{
    if (i != 0)
    {
        Console.Write(",");
    }
    Console.Write($" {converter3.ConvertAll(dnumbers)[i]}");
}
Console.WriteLine("\n");

