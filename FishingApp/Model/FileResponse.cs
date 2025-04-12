namespace FishingApp.Model
{
    public class FileResponse
    {
        public Status Status { get; set; }
        public string Message { get; set; }
    }

     public enum Status
    {
        Success,
        Failed
    }
}
