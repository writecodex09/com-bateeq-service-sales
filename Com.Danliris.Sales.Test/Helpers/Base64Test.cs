﻿using Com.Danliris.Service.Sales.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Com.Danliris.Sales.Test.Helpers
{
  public  class Base64Test
    {
        [Fact]
        public void GetBase64Type_Return_Match()
        {
            var img = "data:image/jpeg;base64,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";
            var result = Base64.GetBase64Type(img);
            Assert.Equal("image/jpeg", result);
        }

        [Fact]
        public void GetBase64Type_Return_Empty()
        {
            var img = "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";
            var result = Base64.GetBase64Type(img);
            Assert.Empty( result);
        }

        [Fact]
        public void GetBase64Type_Return_Empty_when_ImageInvalid()
        {
            var img = "";
            var result = Base64.GetBase64Type(img);
            Assert.Empty(result);
        }

        [Fact]
        public void GetBase64File_Return_Success()
        {
            var img = "data:image/jpeg;base64,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";
            var result = Base64.GetBase64File(img);
            Assert.NotEmpty(result);
        }

        
    }
}
