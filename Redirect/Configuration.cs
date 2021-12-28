﻿using Dalamud.Configuration;
using Dalamud.Plugin;
using System;
using System.Collections.Generic;

namespace Redirect
{
    [Serializable]
    public class Configuration : IPluginConfiguration
    {
        public int Version { get; set; } = 0;

        public bool DisplayPVP { get; set; } = false;

        public string DefaultRedirection { get; set; } = "UI Mouseover";

        public Dictionary<uint, Redirection> Redirections { get; set; } = new();

        public void Save()
        {
            Services.Interface.SavePluginConfig(this);
        }
    }
}