using System;
using System.Collections.Generic;
using System.Text;

namespace Competitive_Programming
{
    class Modulo
    {
        // 掛け算を行う
        // Bigmulを使用することで、オーバーフローを抑える
        // 引数はint32, 戻り値はint64となる
        public long Mult(int a, int b)
        {
            return Math.BigMul(a, b);
        }
    }
}
