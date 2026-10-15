using System.Collections.Generic;

namespace DPM235503_LeThiKimYen_Refactoring54_ReplaceInheritanceWithDelegation
{
    // Kế thừa List<object> chỉ để dùng làm Stack (Lộ toàn bộ API của List)
    public class MyStackBefore : List<object>
    {
        public void Push(object element) => Add(element);
        public object Pop()
        {
            var result = this[Count - 1];
            RemoveAt(Count - 1);
            return result;
        }
    }
}