using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotCore.Common
{
    // Just use Tuple?
    public struct IndexAndId
    {
        public static readonly IndexAndId Null = new IndexAndId(-1);

        private int index;
        private uint id;

        public IndexAndId(int index, uint id = 0U)
        {
            this.index = index;
            this.id = id;
        }

        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        public uint Id
        {
            get { return id; }
            set { id = value; }
        }

        public override string ToString()
        {
            return $"index:{Index};id:{Id}";
        }
    }
}
