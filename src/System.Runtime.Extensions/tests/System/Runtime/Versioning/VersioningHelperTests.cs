// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Xunit;
using System.Runtime.Versioning;

namespace System.Runtime.Versioning.Tests
{
    public static class VersioningHelperTests
    {
        [Fact]
        [SkipOnTargetFramework(TargetFrameworkMonikers.NetFramework, "r3 suffix is hardcoded in .Net Core and return code is not documented")]
        public static void Test1()
        {
            string str1 = VersioningHelper.MakeVersionSafeName("TestFile", ResourceScope.Process, ResourceScope.AppDomain);
            Assert.Equal($"TestFile_r3_ad{AppDomain.CurrentDomain.Id}", str1);
        }
    }
}
