﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace ExcelTest1
{
    public partial class FontsTests
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void FontChange()
        {
        	repo.Book16Excel.CellB3.Click();
        	repo.Book16Excel.FontTests.Open.Click();
        	FontValue = "Cascadia Mono";
        	var fontList = repo.Book16Excel.Self.FindSingle<Ranorex.List>("//list[@name='Font']");
        	var listItem = fontList.FindSingle<Ranorex.ListItem>("//listitem[@name='"+FontValue+"']");
        	listItem.Click();
        	listItem.PressKeys("{Enter}");
        	//repo.Book16Excel.FontTests.ArialBlack.Click();
        	repo.Book16Excel.CellB3.Click();
        	repo.Book16Excel.CellB3.PressKeys("Pup zemli");
        }
    }
}
