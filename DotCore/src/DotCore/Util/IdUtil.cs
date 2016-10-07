using System;
using System.Collections.Generic;
using System.Linq;

namespace DotCore.Util
{
    public static class IdUtil
    {
        private static readonly Random RNG = new Random();

        // Note: It's preferable to have the same number of digits for ID purposes...
        // Note: We use 9000xx to 9999xx range as "reserved" ids (those manually set in the app).
        private static readonly int MIN_L05_ID = 10000;
        // private static readonly int MAX_L05_ID = 99999;
        private static readonly int MAX_L05_ID = 89999;
        private static readonly int MIN_L06_ID = 100000;
        // private static readonly int MAX_L06_ID = 999999;
        private static readonly int MAX_L06_ID = 899999;
        private static readonly int MIN_L07_ID = 1000000;
        // private static readonly int MAX_L07_ID = 9999999;
        private static readonly int MAX_L07_ID = 8999999;
        private static readonly int MIN_L08_ID = 10000000;
        // private static readonly int MAX_L08_ID = 99999999;
        private static readonly int MAX_L08_ID = 89999999;
        private static readonly int MIN_L09_ID = 100000000;
        // private static readonly int MAX_L09_ID = 999999999;
        private static readonly int MAX_L09_ID = 899999999;
        //private static readonly long MIN_L10_ID = 1000000000L;
        //private static readonly long MAX_L10_ID = 9999999999L;

        // Cannot ensure global uniqueness, but it does the job.
        private static HashSet<ulong> lidCache = new HashSet<ulong>();
        private static HashSet<uint> uidCache = new HashSet<uint>();


        public static string GetNewGuid()
        {
            var guid = Guid.NewGuid();
            var strGuid = guid.ToString();
            return strGuid;
        }


        public static ulong GetNextUniqueId()
        {
            return GetNextUniqueId10();
        }
        public static ulong GetNextUniqueId05()
        {
            var id = 0UL;
            do {
                id = (ulong)RNG.Next(MIN_L05_ID, MAX_L05_ID);
            } while (lidCache.Contains(id) || !lidCache.Add(id) || false);
            return id;
        }
        public static ulong GetNextUniqueId06()
        {
            var id = 0UL;
            do {
                id = (ulong)RNG.Next(MIN_L06_ID, MAX_L06_ID);
            } while (lidCache.Contains(id) || !lidCache.Add(id) || false);
            return id;
        }
        public static ulong GetNextUniqueId07()
        {
            var id = 0UL;
            do {
                id = (ulong)RNG.Next(MIN_L07_ID, MAX_L07_ID);
            } while (lidCache.Contains(id) || !lidCache.Add(id) || false);
            return id;
        }
        public static ulong GetNextUniqueId08()
        {
            var id = 0UL;
            do {
                id = (ulong)RNG.Next(MIN_L08_ID, MAX_L08_ID);
            } while (lidCache.Contains(id) || !lidCache.Add(id) || false);
            return id;
        }
        public static ulong GetNextUniqueId09()
        {
            var id = 0UL;
            do {
                id = (ulong)RNG.Next(MIN_L09_ID, MAX_L09_ID);
            } while (lidCache.Contains(id) || !lidCache.Add(id) || false);
            return id;
        }
        public static ulong GetNextUniqueId10()
        {
            var id = 0UL;
            do {
                id = (ulong)RNG.Next(MIN_L09_ID, MAX_L09_ID) * 10UL + (ulong)RNG.Next(10);
            } while (lidCache.Contains(id) || !lidCache.Add(id) || false);
            return id;
        }
        public static ulong GetNextUniqueId11()
        {
            var id = 0UL;
            do {
                id = (ulong)RNG.Next(MIN_L09_ID, MAX_L09_ID) * 100UL + (ulong)RNG.Next(100);
            } while (lidCache.Contains(id) || !lidCache.Add(id) || false);
            return id;
        }
        public static ulong GetNextUniqueId12()
        {
            var id = 0UL;
            do {
                id = (ulong)RNG.Next(MIN_L09_ID, MAX_L09_ID) * 1000UL + (ulong)RNG.Next(1000);
            } while (lidCache.Contains(id) || !lidCache.Add(id) || false);
            return id;
        }
        // ...


        public static uint GetUniqueId()
        {
            return GetUniqueId08();
        }
        public static uint GetUniqueId05()
        {
            var id = 0U;
            do {
                id = (uint)RNG.Next(MIN_L05_ID, MAX_L05_ID);
            } while (uidCache.Contains(id) || !uidCache.Add(id) || false);
            return id;
        }
        public static uint GetUniqueId06()
        {
            var id = 0U;
            do {
                id = (uint)RNG.Next(MIN_L06_ID, MAX_L06_ID);
            } while (uidCache.Contains(id) || !uidCache.Add(id) || false);
            return id;
        }
        public static uint GetUniqueId07()
        {
            var id = 0U;
            do {
                id = (uint)RNG.Next(MIN_L07_ID, MAX_L07_ID);
            } while (uidCache.Contains(id) || !uidCache.Add(id) || false);
            return id;
        }
        public static uint GetUniqueId08()
        {
            var id = 0U;
            do {
                id = (uint)RNG.Next(MIN_L08_ID, MAX_L08_ID);
            } while (uidCache.Contains(id) || !uidCache.Add(id) || false);
            return id;
        }
        public static uint GetUniqueId09()
        {
            var id = 0U;
            do {
                id = (uint)RNG.Next(MIN_L09_ID, MAX_L09_ID);
            } while (uidCache.Contains(id) || !uidCache.Add(id) || false);
            return id;
        }

    }
}
