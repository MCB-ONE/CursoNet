using Newtonsoft.Json;

namespace UniversityApiBE.Error
{
    public class CodeErrorResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this);

        public CodeErrorResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageStatusCode(statusCode);
        }

        private string GetDefaultMessageStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "Request enviado con errores",
                401 => "No tiene autorización para acceder este recurso",
                404 => "Recurso no encontrado",
                500 => "Se han producido errores en el servidor",_=> null
            };

        }
    }
}
