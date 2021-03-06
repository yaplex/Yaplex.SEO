﻿using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Yaplex.SEO.Models;

namespace Yaplex.SEO.Handlers {
    public class SeoOverrideHandler : ContentHandler{
        public SeoOverrideHandler(IRepository<SeoOverrideRecord> repository) {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}