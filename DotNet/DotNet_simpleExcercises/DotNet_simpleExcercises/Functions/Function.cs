namespace DotNet_SimpleExcercises
{
    public class Functions
    {
        public static double convrtPesosDolar(double vlrPesos)
        {
            double vlrDolar = vlrPesos / 3939.25;
            return vlrDolar;
        }

        public static double convrtDolarPesos(double vlrDolar)
        {
            double vlrPesos = vlrDolar * 3939.25;
            return vlrPesos;
        }
    }
}