using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihanoverloadingmethod
{
    public class Numbers
    {
        public int FindMinimum(int number1, int number2){
            if(number1<number2){
                return number1;
            }else{
                return number2;
            }
        }
        public int FindMinimum(int number1,int number2, float number3){
            if (number1<number2 && number1<(int)number3){
                return number1;
            }else if(number2<number1 && number2<(int)number3){
                return number2;
            }else if ((int)number3<number1 && (int)number3< number2){
                return (int)number3;
            }else{
                return 0;
            }
        }

        public int FindMaximum(int number1, int number2){
            if(number1>number2){
                return number1;
            }else{
                return number2;
            }
        }
        public int FindMaximum(int number1,int number2, float number3){
            if (number1>number2 && number1>(int)number3){
                return number1;
            }else if(number2>number1 && number2>(int)number3){
                return number2;
            }else if ((int)number3>number1 && (int)number3>number2){
                return (int)number3;
            }else{
                return 0;
            }
        }
    }
}