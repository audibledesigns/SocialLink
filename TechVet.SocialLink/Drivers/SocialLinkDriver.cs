using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using TechVet.SocialLink.Models;
using TechVet.SocialLink.ViewModels;

namespace TechVet.SocialLink.Drivers
{
    public class SocialLinkDriver : ContentPartDriver<SocialLinkPart>
    {
        protected override DriverResult Display(SocialLinkPart part, string displayType, dynamic shapeHelper)
        {
            return ContentShape("Parts_SocialLink", () =>
                shapeHelper.Parts_SocialLink(SocialLink : new SocialLinkViewModel(part)
                                            ));
        }

        //GET
        protected override DriverResult Editor(SocialLinkPart part, dynamic shapeHelper)
        {

            return ContentShape("Parts_SocialLink_Edit",
                () => shapeHelper.EditorTemplate(
                    TemplateName: "Parts/SocialLink",
                    Model: part,
                    Prefix: Prefix));
        }

        //POST
        protected override DriverResult Editor(
            SocialLinkPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }

    }
}