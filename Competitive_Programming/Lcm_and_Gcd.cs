using System;
using System.Collections.Generic;
using System.Text;

namespace Competitive_Programming
{
    /*
    // 最大公約数(Greatest Common Divisor), 最小公倍数(Least Common Multiple)
    // 二つの整数x, yがあるとき以下の関係が成り立つ
    //   x * y = gcd(x, y) * lcm(x, y)
    // ※ gcd(x, y) : xとyの最大公約数, lcm(x, y) : xとyの最小公倍数
    */
    class Lcm_and_Gcd
    {
        // 最小公倍数を求める
        public static int Lcm(int x, int y)
        {
            return x * y / Gcd(x, y);
        }

        // ユークリッドの互除法から最大公約数を求める
        // ユークリッドの互除法の解説：https://www.studyplus.jp/412
        public static int Gcd(int x, int y)
        {
            if (x < y)
            {
                return Gcd(y, x);
            }
            while (y != 0)
            {
                var remainder = y % x;
                x = y;
                y = remainder;
            }
            return x;
        }
    }
}
