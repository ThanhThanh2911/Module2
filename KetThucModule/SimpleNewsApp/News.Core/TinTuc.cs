namespace News.Core
{
    public partial class TinTuc
    {
        public int Id { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public string AnhDaiDien { get; set; }
        public TheLoai TheLoais { get; set; }
    }
}
