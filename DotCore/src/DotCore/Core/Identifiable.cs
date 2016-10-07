using System;
using System.Collections.Generic;
using System.Linq;

namespace DotCore.Core
{
    public interface IIdentifiable
    {
        ulong Id
        {
            get;
        }
    }
    public interface IIdentified
    {
        uint Id
        {
            get;
        }
    }
}
