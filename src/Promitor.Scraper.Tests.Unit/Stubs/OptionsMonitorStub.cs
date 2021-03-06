﻿using System;
using Microsoft.Extensions.Options;

namespace Promitor.Scraper.Tests.Unit.Stubs
{
    public class OptionsMonitorStub<TConfig> : IOptionsMonitor<TConfig>
    {
        public TConfig Get(string name)
        {
            return CurrentValue;
        }

        public IDisposable OnChange(Action<TConfig, string> listener)
        {
            return null;
        }

        public TConfig CurrentValue { get; set; }
    }
}