using System;

namespace Bai23
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Viết chương trình AC # SHARP để hiển thị mẫu sau bằng bảng chữ cái.";
            Console.WriteLine(str);
            string strLower = str.ToLower();
            Console.WriteLine("LowerCase:" + strLower.ToString());
        }
    }
}
