namespace FuncionariosAPI.Models
{
    //Esse T significa que ele vai receber dados genéricos: produto, funcionário...
    public class ServiceResponse<T>
    {   //T= pode ser qualquer tipo de dado ?=pode ser null
        public T? Dados { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public bool Sucesso { get; set; } = true;
    }
}
