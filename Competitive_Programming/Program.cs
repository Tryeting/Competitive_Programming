using System;

namespace Competitive_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            var sw = new System.Diagnostics.Stopwatch();

            // ---------- Input ----------//
            // 標準入力 スペースのない文字列を入力
            Console.WriteLine("スペースのない数字(int)を入力してください");
            a = int.Parse(Console.ReadLine());
            // 2つ以上のスペース区切り入力の取得
            Console.WriteLine("スペースのある数字(int)を入力してください");
            string[] str = Console.ReadLine().Split(' ');

            // ---------- Compute ----------//
            // 処理時間計測開始
            sw.Start();

            b = int.Parse(str[0]);
            c = int.Parse(str[1]);
            int gcd = Lcm_and_Gcd.Gcd(b, c);

            // 処理時間計測開始
            sw.Stop();
            TimeSpan ts = sw.Elapsed;

            // ---------- Output ----------//
            // 改行なし出力
            Console.Write("改行なし a = {0}, b = {1}, c = {2} \n", a, b, c);
            // 改行あり出力
            Console.WriteLine("改行あり a = {0}, b = {1}, c = {2}", a, b, c);
            Console.WriteLine("bとcの最大公約数:{0}", gcd);

            Console.WriteLine("◆処理にかかった時間:{0}", ts);
        }
    }
}
