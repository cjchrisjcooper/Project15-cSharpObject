using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryGenericMethods
{
    public static class ListUtils<T> 
    {
        public static T GetRandomItem(this List<T> list)
        {
            var random = new Random();
            return list[random.Next(0, list.Count)];
        }
    }
}
