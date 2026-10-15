using System;

namespace DPM235503_LeThiKimYen_Refactoring60_DuplicateObservedData
{
    // Lớp Model quản lý dữ liệu xuất kho Nông Dược
    public class XuatKhoNongDuocModel
    {
        public event Action<double> OnTongTienChanged;
        private double _tongTien;

        public double TongTien
        {
            get => _tongTien;
            set
            {
                _tongTien = value;
                OnTongTienChanged?.Invoke(_tongTien);
            }
        }
    }

    public class ManHinhXuatKhoForm
    {
        private readonly XuatKhoNongDuocModel _model = new XuatKhoNongDuocModel();

        public ManHinhXuatKhoForm()
        {
            _model.OnTongTienChanged += (val) =>
            {
                Console.WriteLine($"[GIAO DIỆN UI NÔNG DƯỢC] Cập nhật tổng tiền hiển thị: {val:N0} VNĐ");
            };
        }

        public void NhapGiaTriMoi(double giaTri)
        {
            _model.TongTien = giaTri;
        }
    }
}