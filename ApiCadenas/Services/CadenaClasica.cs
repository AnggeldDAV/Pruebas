namespace ApiCadenas.Services
{
    public class CadenaClasica : ICadenas
    {
        public string Concatena(string cadena1, string cadena2)
        {
            return cadena1+cadena2;
        }

        public int Cuenta(string cadena1, string cadena2)
        {
            return cadena1.Length - cadena2.Length;
        }
    }
}
