namespace YtsSharpApi.Models
{
    public class Torrent
    {
        public string url { get; set; }
        public string hash { get; set; }
        public string quality { get; set; }
        public int seeds { get; set; }
        public int peers { get; set; }
        public string size { get; set; }
        public object size_bytes { get; set; }
        public string date_uploaded { get; set; }
        public int date_uploaded_unix { get; set; }
    }
}
