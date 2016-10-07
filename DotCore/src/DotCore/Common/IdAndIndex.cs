using System;
using System.Collections.Generic;
using System.Linq;

namespace DotCore.Common
{
    // Just use Tuple?
    public struct IdAndIndex
    {
        public static readonly IdAndIndex Null = new IdAndIndex(0U);

        private uint id;
        private int index;

        public IdAndIndex(uint id, int index = -1)
        {
            this.id = id;
            this.index = index;
        }

        public uint Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        public override string ToString()
        {
            return $"id:{Id};index:{Index}";
        }
    }
}
