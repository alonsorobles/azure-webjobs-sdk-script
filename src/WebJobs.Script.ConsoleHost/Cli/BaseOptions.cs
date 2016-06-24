﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using CommandLine;

namespace WebJobs.Script.ConsoleHost.Cli
{
    public class BaseOptions
    {
        [Option("logFile", HelpText = "")]
        public string LogFile { get; set; }
    }
}