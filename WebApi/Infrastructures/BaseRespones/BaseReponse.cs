using System.Collections.Generic;

namespace WebApi.Infrastructures.BaseRespones
{
    public class BaseReponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public List<string> ValidationErrors { get; set; }
    }
}