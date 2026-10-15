using System;

namespace DPM235503_LeThiKimYen_Refactoring41_RemoveControlFlag
{
    public class BeforeExample
    {
        public void CheckSecurity(string[] people)
        {
            bool found = false; // Biến cờ điều khiển
            for (int i = 0; i < people.Length; i++)
            {
                if (!found)
                {
                    if (people[i].Equals("Don"))
                    {
                        Console.WriteLine("Cảnh báo: Tìm thấy Don!");
                        found = true;
                    }
                }
            }
        }
    }
}