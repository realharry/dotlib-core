using DotCore.Core;
using DotCore.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DotCore.Base
{
    public abstract class IdentifiableBase : IIdentifiable
    {
        private readonly ulong id;
        public IdentifiableBase()
            : this(IdUtil.GetNextUniqueId())
        {
        }
        public IdentifiableBase(ulong id)
        {
            this.id = id;
        }

        public ulong Id
        {
            get
            {
                return id;
            }
        }


    }
}
