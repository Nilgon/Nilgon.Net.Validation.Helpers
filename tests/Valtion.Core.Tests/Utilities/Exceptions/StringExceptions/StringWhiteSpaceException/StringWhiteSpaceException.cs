﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valtion.Core.Utilities.Exceptions.StringExceptions;
using Xunit;

namespace Valtion.Core.Tests.Utilities.Exceptions.StringExceptions
{
    public class StringWhiteSpaceException_Tests
    {
        [Fact]
        public void Throw_StringWhiteSpaceException_Without_Parameters()
        {
            Action Throw = () => throw new StringWhiteSpaceException();

            Assert.Throws<StringNullReferenceException>(Throw);
        }
    }
}
