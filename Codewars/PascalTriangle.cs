using System;
using System.Collections.Generic;

namespace Codewars
{
    public class PascalTriangle
    {
        public static List<int> Generate( int value )
        {
            var result = new List<int>();
            var cal = new List<int> { 1, 1 };
            for (int i = 1; i <= value; i++)
            {
                if (i == 1)
                    result.AddRange(new List<int> { 1 });
                else if (i == 2)
                    result.AddRange(new List<int> { 1, 1 });
                else 
                {
                    cal = ComputeNextList(cal);
                    result.AddRange(cal);
                }
            }
            return result;
        }

        private static List<int> ComputeNextList( List<int> previewList)
        {
            List<int> result = new List<int>();
            result.Add(1);
            for (int i = 0; i < previewList.Count - 1 ; i++)
            {
                result.Add( previewList[ i ] + previewList[ i+1 ] );
            }
            result.Add(1);
            return result;
        }
    }
}
