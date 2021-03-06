﻿using FluentSharp.CoreLib.API;
using FluentSharp.NUnit;
using NUnit.Framework;

namespace FluentSharp.CoreLib.Test
{
    [TestFixture]
    public class Test_KReflection : NUnitTests
    {
        [Test] public void invoke_Ctor_Static()
        {
            var kReflection = new KReflection();
            assert_Is_True(kReflection.invoke_Ctor_Static(typeof(CompileEngine)));
            assert_Not_Null(CompileEngine.LocalReferenceFolders);
            CompileEngine.LocalReferenceFolders = null;
            assert_Is_Null(CompileEngine.LocalReferenceFolders);
            assert_Is_True(kReflection.invoke_Ctor_Static(typeof(CompileEngine)));
            assert_Not_Null(CompileEngine.LocalReferenceFolders);
        }
    }
}
