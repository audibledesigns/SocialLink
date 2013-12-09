using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.ContentManagement.Handlers;
using TechVet.SocialLink.Models;
using Orchard.Data;

namespace TechVet.SocialLink.Handlers
{
    public class SocialLinkHandler : ContentHandler
    {
        public SocialLinkHandler(IRepository<SocialLinkRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}