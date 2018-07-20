﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Auto.Test.Tool.Core;
using Auto.Test.Tool.ActionHelpers;
using Auto.Test.GenericHelpers;

namespace Auto.Test.Domain.AppTests
{
    public class SampleOne : DriverManager
    {
        [Fact]
        public void DoTestOne()
        {
            //string path = Environment.CurrentDirectory + "\\Resource\\AppDataOne.xlsx";
            //ExcelHelper eh = new ExcelHelper();
            //List<Dictionary<string, string>> testData = eh.GetDataRows(path, "TestData");
            Open();
            SetOrSelectHelper.SelectFieldValueById("dcdrLocation", "Chennai");
            //SeleniumJavaScriptActions.Select("#(dcdrLocation)", "Chennai");
        }
    }
}