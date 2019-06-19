﻿using System;
using System.Collections.Generic;
using Orchard.MediaLibrary.WebSearch.Settings;
using Orchard.MediaLibrary.WebSearch.ViewModels;

namespace Orchard.MediaLibrary.WebSearch.Providers {
    public abstract class WebSearchProviderBase : IWebSearchProvider {
        public abstract string Name { get; }

        public bool IsValid => !String.IsNullOrEmpty(ApiKey);

        public string ApiKey => Settings.ApiKey;

        public abstract IWebSearchSettings Settings { get; }

        public abstract List<WebSearchResult> GetImages(string query);
    }
}