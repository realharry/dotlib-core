using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotCore.Data.Core
{
    public class SortFieldAndOrder
    {
        // ??? No sorting ???
        public static readonly SortFieldAndOrder Null = new SortFieldAndOrder(null, SortOrder.None);
        private const SortOrder DEFAULT_SORTORDER = SortOrder.Ascending;

        // Does it make sense to have here a field name???
        private string sortField;   // Cannot be null/empty...
        private SortOrder sortOrder;

        public SortFieldAndOrder(string sortField)
            : this(sortField, DEFAULT_SORTORDER)   // ascending by default.
        {
        }
        public SortFieldAndOrder(string sortField, SortOrder sortOrder)
        {
            this.sortField = sortField;
            this.sortOrder = sortOrder;
        }

        public string SortField
        {
            get
            {
                return sortField;
            }
        }
        public SortOrder SortOrder
        {
            get
            {
                return sortOrder;
            }
            internal set
            {
                sortOrder = value;
            }
        }

        // tbd:
        // --> This has been already implemented in SortFieldAndOrderSerializationUtil.
        // ....
        public string Serialize()
        {
            return $"{SortField};{(Enum.GetName(typeof(SortOrder), SortOrder))}";
        }
        public static SortFieldAndOrder Deserialize(string serialized)
        {
            var parts = serialized.Split(new string[] { ";" }, StringSplitOptions.None);
            if (parts != null) {
                string sortField = null;
                if (parts.Length > 0) {
                    sortField = parts[0];
                    SortOrder sortOrder = DEFAULT_SORTORDER;
                    if (parts.Length > 1) {
                        try {
                            sortOrder = (SortOrder)Enum.Parse(typeof(SortOrder), parts[1]);
                        } catch (Exception) { }
                    }
                    var sfo = new SortFieldAndOrder(sortField, sortOrder);
                    return sfo;
                }
            }
            return null;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("SortField:").Append(SortField).Append(";");
            sb.Append("SortOrder:").Append(Enum.GetName(typeof(SortOrder), SortOrder));
            return sb.ToString();
        }


        // TBD:
        // is null == null ????
        // (the current implementation return false for null == null comparison,
        //   but either way, this shouldn't really matter in practice.)
        public static bool operator ==(SortFieldAndOrder left, SortFieldAndOrder right)
        {
            return ((object)left != null && (object)right != null && left.SortField == right.SortField && left.SortOrder == right.SortOrder);
        }
        public static bool operator !=(SortFieldAndOrder left, SortFieldAndOrder right)
        {
            return ((object)left == null || (object)right == null || left.SortField != right.SortField || left.SortOrder != right.SortOrder);
        }
        // ...

        public override bool Equals(object obj)
        {
            var right = obj as SortFieldAndOrder;
            if (right == null) {
                return false;
            }
            return (this == right);
        }

        public override int GetHashCode()
        {
            var h = 0;
            if (sortField != null) {
                h = (sortField.GetHashCode() / 10) * 10;
            }
            h += (int)sortOrder;
            return h;
        }

    }
}
