namespace NucleoCompartilhado.Nucleo.Core
{
    /// <summary>
    /// Objeto de Valor Nome
    /// </summary>
    public class NomeCompleto
    {        
        public string PrimeiroNome { get; private set; }
        public string Sobrenome { get; private set; }

        public NomeCompleto(string primeiroNome, string sobrenome)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
        }   

        public string EscreverNome()
        {
            return $"{PrimeiroNome} {Sobrenome}";
        }
    }    
}