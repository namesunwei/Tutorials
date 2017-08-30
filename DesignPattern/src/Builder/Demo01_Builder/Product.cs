using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01_Builder
{
    /// <summary>
    /// Product类
    /// <remarks>产品类,由多个部件组成.</remarks>
    /// </summary>
    internal class Product
    {
        readonly IList<string> _parts = new List<string>();

        /// <summary>
        /// 增加产品部件
        /// </summary>
        /// <param name="part"></param>
        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\n 产品 构建 -----");

            foreach (var part in _parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
