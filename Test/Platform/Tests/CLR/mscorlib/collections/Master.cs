////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Microsoft Corporation.  All rights reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using Microsoft.SPOT.Platform.Test;

namespace Microsoft.SPOT.Platform.Tests
{
    public class Master
    {
        public static void Main()
        {
            string[] args =
            {
                "HashtableTests",  
                "ArrayListTests",  
                "QueueTests",
                "StackTests",
            };

            MFTestRunner runner = new MFTestRunner(args);
        }
    }
}
