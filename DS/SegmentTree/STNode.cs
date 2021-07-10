using System;
using System.Collections.Generic;
using System.Text;

namespace DS.SegmentTree
{
    public class STNode
    {
        public int value { get; set; }
        public Range range { get; set; }

        public int absDiff { get; set; }

        public STNode left { get; set; }
        public STNode right { get; set; }

        public STNode(Range range)
        {
            this.range = range;
            this.absDiff = Math.Abs(range.end - range.start);
            this.left = null;
            this.right = null;
            this.value = -1;
        }
    }
}
