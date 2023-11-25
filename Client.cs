using System;
using System.Collections.Generic;
using System.IO;

namespace CSharp11_11
{
    public class Client
    {
        public static void Test(string file)
        {
            List<Target> targets = new List<Target>();
            using (var reader = new StreamReader(file))
            {
                string[] data;
                int a, b, n = Convert.ToInt32(reader.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    data  = reader.ReadLine().Split();
                    a = Convert.ToInt32(data[1]);
                    b = Convert.ToInt32(data[2]);

                    if (data[0] == "+")
                        targets.Add(new ConcreteTarget(a, b));
                    else
                        targets.Add(new Adapter(a, b));
                }
            }

            foreach (Target target in targets)
                Console.WriteLine($"a={target.GetA()}; b={target.GetB()}; request={target.Request()}");
        }
    }
}