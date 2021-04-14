using System;
using System.Collections.Generic;


namespace BizDaysCalc
{
    public class Calculator
    {
        private readonly List<IRule> rules = new();
        public void AddRule(IRule rule)
        {
            rules.Add(rule);
        }
        public bool IsBusinessDay(DateTime date)
        {
            foreach (var rule in rules) if (!rule.CheckIsBusinessDay(date))
                    return false; return true;
        }
    }
}
