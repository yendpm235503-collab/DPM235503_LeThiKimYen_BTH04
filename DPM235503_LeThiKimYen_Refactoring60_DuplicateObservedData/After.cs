using System;

namespace DPM235503_LeThiKimYen_Refactoring60_DuplicateObservedData
{
    // Lớp Domain riêng biệt quản lý dữ liệu
    public class IntervalDomain
    {
        public event EventHandler DataChanged;
        private int _start;

        public int Start
        {
            get => _start;
            set
            {
                _start = value;
                DataChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }

    public class FormUIAfter
    {
        private readonly IntervalDomain _domain = new IntervalDomain();

        public FormUIAfter()
        {
            _domain.DataChanged += (s, e) => Console.WriteLine($"UI Synced with Domain Start: {_domain.Start}");
        }

        public void SetStart(int val) => _domain.Start = val;
    }
}