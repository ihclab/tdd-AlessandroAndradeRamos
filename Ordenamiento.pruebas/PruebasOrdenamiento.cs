using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ordenamiento.pruebas
{
    [TestClass]
    public class PruebasOrdenamiento
    {
        private class PruebasOrdenamiento{
            private int[] salidaEsperada1 = new int[]{1,2,3,4,5};
            private int[] salidaEsperada2 = new int[]{1, 1, 1, 1};
            private int[] salidaEsperada3 = new int[]{1, 2, 3, 4, 4};
            private Ordenamiento.burbuja ordenar = new Ordenamiento.burbuja();
        }
        [TestMethod]
        public void TestInvertido()
        {
            int[] entrada = new int[]{5, 4, 3, 2, 1};
            ordenar.ordenar(entrada);
            CollectionAssert.areEqual(salida, entrada);
        }
        public void TestOrdenado(){
            int[] entrada = new int[]{1, 2, 3, 4, 5};
            ordenar.ordenar(entrada);
            CollectionAssert.areEqual(salida, entrada);
        }
    }
}
