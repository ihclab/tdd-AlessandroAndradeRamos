using System;
using System.Collections.Generic;
using System.Text;

namespace Ordenamiento{
    public class burbuja {
        public void Ordenar (int[] array){
            int control = 0;
            for (int i = 0; i < array.Length; i++){
                for (int e = 0; e < array.Length - 1; e++){
                    if(array[e] > array[e + 1]){
                        control = array[e + 1];
                        array[e + 1] = array[e];
                        array[e] = control;
                    }
                }
            }
        }
    }
}