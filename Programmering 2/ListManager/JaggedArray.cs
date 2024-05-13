using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesLib
{
    public class JaggedArray<Type>
    {
        public Type[][] ConvertToJagged(Type[,] twoDArray)
        {
            Type[][] jagged = new Type[twoDArray.GetLength(0)][];

            for (int i = 0; i < twoDArray.GetLength(0); i++)
            {
                Type[] array = new Type[twoDArray.GetLength(1)];

                for (int j = 0; j < twoDArray.GetLength(1); j++)
                {
                    array[j] = twoDArray[i, j];
                }
                jagged[i] = array;
            }

            return jagged;
        }
        public Type[,] ConvertToTwoD(Type[][] jaggedArray)
        {
            Type[,] twoDArray = new Type[jaggedArray.GetLength(0), jaggedArray.GetLength(1)];
            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                for (int j = 0; j < jaggedArray.GetLength(1); j++)
                {
                    twoDArray[i, j] = jaggedArray[i][j];
                }
            }
            return twoDArray;
        }
    }
}
