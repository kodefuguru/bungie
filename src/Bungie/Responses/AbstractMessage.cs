namespace Bungie.Responses
{
    internal abstract class AbstractMessage<T>
    {
        public T Response { get; set; }
        public int ErrorCode { get; set; }
        public int ThrottleSeconds { get; set; }
        public string ErrorStatus { get; set; }
        public string Message { get; set; }
        public object MessageData { get; set; }
    }
}