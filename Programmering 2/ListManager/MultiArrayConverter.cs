using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesLib
{
    public class MultiArrayConverter<Type>
    {
        public Type[][] ConvertToArray(Type[,] twoDArray)
        {
            Type[] singleArray = new Type[twoDArray.GetLength(0) * twoDArray.GetLength(1)];

            for (int i = 0; i < twoDArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDArray.GetLength(1); j++)
                {
                    singleArray;
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
