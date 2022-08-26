using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Tree
    {
        public int x;
        public Tree l;
        public Tree r;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var t0 = default(Tree);

            var t1 = new Tree
            {
                x = 5,
                l = new Tree
                {
                    x = 3,
                    l = new Tree { x = 20 },
                    r = new Tree { x = 21 }
                },
                r = new Tree
                {
                    x = 10,
                    r = new Tree { x = 1 }
                }
            };

            var t2 = new Tree
            {
                x = 8,
                l = new Tree
                {
                    x = 2,
                    l = new Tree { x = 8 },
                    r = new Tree { x = 7 }
                },
                r = new Tree { x = 3 }
            };

            var testEngine = new Func<string, Tree, int, string>
            (
                (name, tree, expexted) =>
                {
                    var count = Solution(tree);
                    return string.Format("Solution({0}) equals {1,2} {2}",
                        name, count, count == expexted ? "PASS" : "FAIL");
                }
            );

            Console.WriteLine(testEngine("t0", t0, -1));
            Console.WriteLine(testEngine("t1", t1, 4));
            Console.WriteLine(testEngine("t2", t2, 2));
            Console.ReadKey(true);
        }

        private static int Solution(Tree T)
        {
            if (T == null)
            {
                return -1;
            }

            var count = 0;

            var stack = new Stack<Tuple<int, Tree>>();
            stack.Push(new Tuple<int, Tree>(T.x, T)); //Push->get the value and insert to top Stack

            while (stack.Count > 0)
            {
                var n = stack.Pop(); //Pop->get the value of top Stack and remove it from the Stack
                if (n.Item1 <= n.Item2.x)
                {
                    ++count;
                }
                var max = Math.Max(n.Item1, n.Item2.x);
                if (n.Item2.l != null)
                {
                    stack.Push(new Tuple<int, Tree>(max, n.Item2.l));
                }
                if (n.Item2.r != null)
                {
                    stack.Push(new Tuple<int, Tree>(max, n.Item2.r));
                }
            }

            return count;
        }
    }
}
