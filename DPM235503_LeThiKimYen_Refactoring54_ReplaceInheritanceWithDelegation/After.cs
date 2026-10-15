using System.Collections.Generic;

namespace DPM235503_LeThiKimYen_Refactoring54_ReplaceInheritanceWithDelegation
{
    public class MyStackAfter
    {
        // Thay bằng Ủy quyền (Delegation) tới tập hợp nội bộ
        private readonly List<object> _list = new List<object>();

        public void Push(object element) => _list.Add(element);
        public object Pop()
        {
            var result = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            return result;
        }

        public int Count => _list.Count;
    }
}