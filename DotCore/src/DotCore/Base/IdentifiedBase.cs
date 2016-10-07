using DotCore.Core;
using DotCore.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotCore.Base
{
    public abstract class IdentifiedBase : IIdentified
    {
        private uint id;
        // private readonly uint id;
        public IdentifiedBase()
            : this(IdUtil.GetUniqueId())
        // : this(0U)   // ????  
        // --> Probably, we cannot change this behavior at this point since a lot of apps may use/reply on this bebavior.
        //     By default, the id is always set to a non-zero value.
        //     If the zero default value is needed, set it explicitly in the app.....
        {
        }
        public IdentifiedBase(uint id)
        {
            this.id = id;
        }

        public uint Id
        {
            get
            {
                return id;
            }
            // ????
            set
            {
                id = value;
            }
        }

    }
}
