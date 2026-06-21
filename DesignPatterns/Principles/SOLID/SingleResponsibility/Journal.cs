using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Principles.SOLID.SingleResponsibility
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count;
        }

        public void RemoveEntry(int idx)
        {
            entries.RemoveAt(idx);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

    }
}
