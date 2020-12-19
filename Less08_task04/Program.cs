using System;

namespace Less08_task04
{
    enum MyEnum : ushort
    {
        zero,
        one,
        two
    }
    class Program
    {
        static void Main(string[] args)
        {
            ushort u1 = 1;
            ushort u2 = 2;
            ushort u3 = 3;

            Console.WriteLine(isEnumValueDefined(u1));
            Console.WriteLine(isEnumValueDefined(u2));
            Console.WriteLine(isEnumValueDefined(u3));

            Console.ReadKey();
        }

        static bool isEnumValueDefined(ushort u)
        {
            bool flag = Enum.IsDefined(typeof(MyEnum), u);
            return flag;
        }
    }
}
