namespace DPM235503_LeThiKimYen_Refactoring38_ReplaceSubclassWithFields
{
    public class QuyCachDongGoiNongDuoc
    {
        public double DungTichVang { get; private set; }
        public string DonViTinh { get; private set; }

        public QuyCachDongGoiNongDuoc(double dungTich, string donVi)
        {
            DungTichVang = dungTich;
            DonViTinh = donVi;
        }

        public static QuyCachDongGoiNongDuoc Chai500ml() => new QuyCachDongGoiNongDuoc(500, "ml");
        public static QuyCachDongGoiNongDuoc Can5Lit() => new QuyCachDongGoiNongDuoc(5, "Lít");
    }
}