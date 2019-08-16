﻿using CommandLine;

namespace FreeLauncher
{
    public class ApplicationArguments
    {
        [Option('d', "working-directory")]
        public string WorkingDirectory { get; set; }

        [Option("offline-mode")]
        public bool OfflineMode { get; set; }
    }
}
