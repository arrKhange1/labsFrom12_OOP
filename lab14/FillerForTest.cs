using System;
using System.Collections.Generic;
using System.Text;
using lab11;

namespace lab14
{
    public class FillerForTest
    {
        public static void Fill(Factory coll, int n)
        {
            Random rand = new Random();
            for (int i = 0; i < n; ++i)
            {
                Ceh cehObj = new Ceh($"Ceh{i + 1}");
                for (int j = i * n + 1; j <= n * (i + 1); ++j)
                {
                    Worker worker = new Worker($"Ben{j}", $"Factory{j}", $"Worker{j}");
                    cehObj.CehElem.Add(worker.BasePerson, worker);
                }
                coll.stack.Push(cehObj);
            }

        }
    }
}
