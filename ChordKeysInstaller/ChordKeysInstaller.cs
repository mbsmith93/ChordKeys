﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ChordKeysInstaller
{
    [RunInstaller(true)]
    public partial class ChordKeysInstaller : System.Configuration.Install.Installer
    {
        public ChordKeysInstaller()
        {
            InitializeComponent();
        }

        public override void Commit(IDictionary savedState)
        {
            base.Commit(savedState);
            Directory.SetCurrentDirectory(Path.GetDirectoryName
            (Assembly.GetExecutingAssembly().Location));
            Process.Start(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\ChordKeys.exe");
        }
    }
}
