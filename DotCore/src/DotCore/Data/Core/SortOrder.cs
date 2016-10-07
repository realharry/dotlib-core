using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotCore.Data.Core
{
    public enum SortOrder : short
    {
        None = 0,     // ????
        Ascending = 1,
        Descending
    }

    public static class SortOrders
    {
        public static bool IsValid(SortOrder sortOrder)
        {
            if (sortOrder == SortOrder.Ascending || sortOrder == SortOrder.Descending) {
                return true;
            } else {
                return false;
            }
        }

        public static SortOrder ReverseOrder(SortOrder sortOrder)
        {
            switch (sortOrder) {
                case SortOrder.Ascending:
                    return SortOrder.Descending;
                case SortOrder.Descending:
                    return SortOrder.Ascending;
                default:
                    return SortOrder.None;
            }
        }

        public static SortOrder Reverse(this SortOrder me)
        {
            switch (me) {
                case SortOrder.Ascending:
                    return SortOrder.Descending;
                case SortOrder.Descending:
                    return SortOrder.Ascending;
                default:
                    return SortOrder.None;
            }
        }
    }

}
