﻿using JetBrains.ReSharper.Daemon;
using JetBrains.ReSharper.Intentions.Test;
using JetBrains.ReSharper.Psi;
using NUnit.Framework;

namespace ReSharper.ReJS.Tests
{
    [TestFixture]
    public class AccessToModifiedClosureWarningAvailabilityTest : QuickFixAvailabilityTestBase
    {
        protected override bool HighlightingPredicate(IHighlighting highlighting, IPsiSourceFile psiSourceFile)
        {
            return highlighting is AccessToModifiedClosureWarning;
        }

        [TestCase("test01.js")]
        [TestCase("test02.js")]
        [TestCase("test03.js")]
        public void Test(string file)
        {
            DoTestFiles(file);
        }
    }
}