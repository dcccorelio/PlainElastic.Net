using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlainElastic.Net.Utils
{
#if !NET40
  public static  class StringBuilderExtensions
    {
      public static void Clear(this StringBuilder builder)
      {
          builder.Length = 0;
      }

    }

#endif
}
