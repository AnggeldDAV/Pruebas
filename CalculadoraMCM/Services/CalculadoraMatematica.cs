namespace CalculadoraMCM.Services
{
    public class CalculadoraMatematica : ICalculadora
    {
        public int MCD(int numero1, int numero2)
        {
            int mcd = 0;
            int a = Math.Max(numero1, numero2);
            int b = Math.Min(numero1, numero2);

            while (b != 0) {
                mcd = b;
                b = a % b;
                a = mcd;
            }
            return mcd;

        }

        public int MCM(int numero1, int numero2)
        {
            int a = Math.Max(numero1, numero2);
            int b = Math.Min(numero1, numero2);
            int mcm = (a / this.MCD(numero1, numero2)) * b;
            return mcm;
        }
    }
}
