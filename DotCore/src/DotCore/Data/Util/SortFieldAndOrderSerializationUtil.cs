using DotCore.Data.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotCore.Data.Util
{
    public static class SortFieldAndOrderSerializationUtil
    {
        // Serialize
        public static string ConvertToString(SortFieldAndOrder sfo)
        {
            var sb = new StringBuilder();
            if (sfo.SortField != null) {   // ??
                sb.Append(sfo.SortField);
            }
            sb.Append(";");
            sb.Append(Enum.GetName(typeof(SortOrder), sfo.SortOrder));
            return sb.ToString();
        }
        // Deserialize
        public static SortFieldAndOrder ConvertFromString(string serialized)
        {
            var sfo = SortFieldAndOrder.Null;   // ???
            if (!String.IsNullOrEmpty(serialized)) {
                var parts = serialized.Split(new string[] { ";" }, StringSplitOptions.None);
                if (parts != null) {
                    if (parts.Length > 0) {
                        var field = parts[1];
                        if (!String.IsNullOrEmpty(field)) {
                            if (parts.Length > 1 && !String.IsNullOrEmpty(parts[1])) {
                                try {
                                    var order = (SortOrder)Enum.Parse(typeof(SortOrder), parts[1]);
                                    sfo = new SortFieldAndOrder(field, order);
                                } catch (Exception ex) {
                                    // ignore.
                                    System.Diagnostics.Debug.WriteLine("Invalid sort order: {0}. Exception: {1}", parts[1], ex.Message);
                                    sfo = new SortFieldAndOrder(field);
                                }
                            } else {
                                sfo = new SortFieldAndOrder(field);
                            }
                        }
                    }
                }
            }
            return sfo;
        }
    }
}
