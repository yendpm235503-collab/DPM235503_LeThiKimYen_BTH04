using System;

namespace DPM235503_LeThiKimYen_Refactoring60_DuplicateObservedData
{
    // Dữ liệu nghiệp vụ bị trộn lẫn trực tiếp trong lớp Giao diện Form
    public class FormUIBefore
    {
        public string StartValueText { get; set; } = "10";
        public string EndValueText { get; set; } = "20";

        public void OnStartValueChanged(string newValue)
        {
            StartValueText = newValue;
            Console.WriteLine($"UI Updated Start: {StartValueText}");
        }
    }
}