using System;

namespace Competitive_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            // 標準入力 スペースのない文字列を入力
            Console.WriteLine("スペースのない数字(int)を入力してください");
            a = int.Parse(Console.ReadLine());
            // 2つ以上のスペース区切り入力の取得
            Console.WriteLine("スペースのある数字(int)を入力してください");
            string[] str = Console.ReadLine().Split(' ');
            b = int.Parse(str[0]);
            c = int.Parse(str[1]);
            // 改行なし出力
            Console.Write("改行なし a = {0}, b = {1}, c = {2} \n", a, b, c);
            // 改行あり出力
            Console.WriteLine("改行あり a = {0}, b = {1}, c = {2}", a, b, c);
        }
    }
}
