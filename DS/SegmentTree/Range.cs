using System;
using System.Collections.Generic;
using System.Text;

namespace DS.SegmentTree
{
   public class Range
    {
        public int start { get; set; }
        public int end { get; set; }

        public Range(int start, int end)
        {
            this.start = start;
            this.end = end;
        }
    }
}
