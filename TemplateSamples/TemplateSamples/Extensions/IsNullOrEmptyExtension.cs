﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateSamples.Extensions
{
    public static class IsNullOrEmptyExtension
    {
        public static bool IsNullOrEmpty(this IEnumerable source)
        {
            if (source != null)
            {
                foreach (object obj in source)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source)
        {
            return (source == null || !source.Any());
        }
    }
}
