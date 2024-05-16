using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesLib
{
    public class MultiArrayConverter<Type>
    {
        public Type[] ConvertToArray(Type[,] twoDArray)
        {
            Type[] singleArray = new Type[twoDArray.GetLength(0) * twoDArray.GetLength(1)];

            for (int i = 0; i < twoDArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDArray.GetLength(1); j++)
                {
                    singleArray.Append(twoDArray[i, j]);
                }
            }

            return singleArray;
        }
        public Type[,] ConvertToTwoD(Type[] singleArray)
        {
            int dim = (int)Math.Sqrt(singleArray.Length);
            Type[,] twoDArray = new Type[dim, dim];
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    twoDArray[i, j] = singleArray[10*i+j];
                }
            }
            return twoDArray;
        }
    }
}
