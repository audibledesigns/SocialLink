using Orchard.UI.Resources;

namespace TechVet.SocialLink
{
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            builder.Add().DefineStyle("SocialLink").SetUrl("socialLink.css");
        }
    }
}
