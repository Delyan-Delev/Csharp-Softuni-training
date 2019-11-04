﻿using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05_GreedyTimes
{
    public class Cash
    {
        public Cash()
        {
            this.Items = new Dictionary<string, long>();
        }

        public Dictionary<string, long> Items { get; set; }

        public void AddCash(string name, long value)
        {
            if (!this.Items.ContainsKey(name))
            {
                this.Items[name] = 0;
            }
            this.Items[name] += value;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"<Cash> ${this.Items.Values.Sum()}");

            foreach (var item in this.Items.OrderByDescending(i => i.Key).ThenBy(i => i.Value))
            {
                sb.AppendLine($"##{item.Key} - {item.Value}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
