using System;

namespace BizDaysCalc
{
    public interface IRule 
    {
       bool CheckIsBusinessDay(DateTime date);
    }
}
