// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace TestOutput
{
    using System;
    using System.Threading.Tasks;

    public class FunctionsBlock
    {
        private static object @__o;
#line 1 "FunctionsBlock.cshtml"



#line default
#line hidden
#line 5 "FunctionsBlock.cshtml"

    Random _rand = new Random();
    private int RandomInt() {
        return _rand.Next();
    }

#line default
#line hidden
        private void @__RazorDesignTimeHelpers__()
        {
            #pragma warning disable 219
            #pragma warning restore 219
        }
        #line hidden
        public FunctionsBlock()
        {
        }

        public override async Task ExecuteAsync()
        {
#line 12 "FunctionsBlock.cshtml"
				   __o = RandomInt();

#line default
#line hidden
        }
    }
}
