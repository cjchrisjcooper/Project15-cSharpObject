﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_cSharpObject
{
    public static class ListUtils
    {
        public static T GetRandomItem<T>(this List<T> list)
        {
            var random = new Random();
            return list[random.Next(0, list.Count)];
        }
    }
}
