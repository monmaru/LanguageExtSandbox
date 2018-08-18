using System;
using System.Collections.Generic;
using static LanguageExt.Prelude;

namespace LanguageExtSandbox
{
    internal class Program
    {
        private static void Main()
        {
            var optional = Some(123);
            Console.WriteLine(match(optional, v => v * 2, () => 0));
            Console.WriteLine(TestOption1());
            Console.WriteLine(TestOption2());

            var list = List(1, 2, 3, 4, 5);
            Console.Write(PatternMatchList(list));
            Console.WriteLine(SumList(list));
        }

        private static int TestOption1()
        {
            var two = Some(2);
            var four = Some(4);
            var six = Some(6);

            return match(
                from x in two
                from y in four
                from z in six
                select x + y + z,
                v => v * 2,
                () => 0);
        }

        private static int TestOption2()
        {
            var two = Some(2);
            var four = Some(4);
            var six = Some(6);
            var none = None;

            return match(
                from x in two
                from y in four
                from _ in none
                from z in six
                select x + y + z,
                v => v * 2,
                () => 0);
        }

        public static int PatternMatchList(IEnumerable<int> list) =>
            match(list,
                () => 0,
                x => x,
                (x, xs) => x * PatternMatchList(xs));

        public static int SumList(IEnumerable<int> list) =>
            list.Map(x => x* 10)
                .Filter(x => x > 20)
                .Fold(0, (x, s) => s + x);
    }
}
