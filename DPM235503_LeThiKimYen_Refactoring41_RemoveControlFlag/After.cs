using System;

namespace DPM235503_LeThiKimYen_Refactoring41_RemoveControlFlag
{
    public class AfterExample
    {
        public void CheckSecurity(string[] people)
        {
            foreach (var person in people)
            {
                if (person.Equals("Don"))
                {
                    Console.WriteLine("Cảnh báo: Tìm thấy Don!");
                    break; // Thoát vòng lặp trực tiếp khi tìm thấy
                }
            }
        }
    }
}