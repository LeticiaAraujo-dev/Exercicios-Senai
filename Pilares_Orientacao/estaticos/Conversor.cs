namespace estaticos
{
    public static class Conversor
    {
        private static float CotocaoDolar = 5.03f;
        public static float RealParaDolar(float valorRS){
            return valorRS / CotocaoDolar;
        }
        public static float DolarParaReal(float valorUS){
            return CotocaoDolar * valorUS;
        }
    }
}