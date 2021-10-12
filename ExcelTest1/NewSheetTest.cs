﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
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
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace ExcelTest1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The NewSheetTest recording.
    /// </summary>
    [TestModule("dda4bb67-c2a3-4af9-ba8e-56794c8dcc6b", ModuleType.Recording, 1)]
    public partial class NewSheetTest : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ExcelTest1Repository repository.
        /// </summary>
        public static ExcelTest1Repository repo = ExcelTest1Repository.Instance;

        static NewSheetTest instance = new NewSheetTest();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NewSheetTest()
        {
            HanNavel = "Pup";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static NewSheetTest Instance
        {
            get { return instance; }
        }

#region Variables

        string _HanNavel;

        /// <summary>
        /// Gets or sets the value of variable HanNavel.
        /// </summary>
        [TestVariable("d60347b9-535b-429f-ac9a-c4f92acdafb8")]
        public string HanNavel
        {
            get { return _HanNavel; }
            set { _HanNavel = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            NewSheet();
            Delay.Milliseconds(0);
            
            CellFill();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
