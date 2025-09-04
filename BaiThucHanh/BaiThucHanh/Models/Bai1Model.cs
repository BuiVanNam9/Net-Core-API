namespace MvcAppDemo.Models
{
    public class Bai1Model
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public int Tuoi => DateTime.Now.Year - NamSinh;
    }
}
