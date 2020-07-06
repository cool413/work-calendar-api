namespace WebApi.Infrastructures.BaseRespones
{
    public class ApiReponse<T> : BaseReponse where T : class
    {
        public ApiReponse()
        {
        }

        public ApiReponse(T data, bool success = true)
        {
            Success = success;
            Data = data;
        }

        public ApiReponse(string meeesge, T data, bool success = true)
        {
            Success = success;
            Data = data;
            Message = meeesge;
        }

        public T Data { get; set; }
    }
}