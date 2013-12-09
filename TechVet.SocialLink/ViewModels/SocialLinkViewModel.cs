using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechVet.SocialLink.Models;

namespace TechVet.SocialLink.ViewModels
{
    public class SocialLinkViewModel
    {
        SocialLinkPart _part;

        public SocialLinkViewModel(SocialLinkPart part)
        {
            _part = part;

            AddService("twitter", part.TwitterUrl);
            AddService("facebook", part.FacebookUrl);
            AddService("linkedin", part.LinkedInUrl);
            AddService("google", part.GoogleUrl);
            AddService("github", part.GitHubUrl);
            AddService("youtube", part.YouTubeUrl);
        }

        public List<SocialService> _services = new List<SocialService>();

        public List<SocialService> Services
        {
            get { return _services; }
        }

        private void AddService(string name, string url)
        {
            if (!string.IsNullOrWhiteSpace(url))
            {
                _services.Add(new SocialService { Name = name, Image = name, Url = url });
            }
        }

    }
}