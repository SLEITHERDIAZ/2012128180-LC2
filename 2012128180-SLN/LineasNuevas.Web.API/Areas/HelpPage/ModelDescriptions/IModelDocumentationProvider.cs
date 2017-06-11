using System;
using System.Reflection;

namespace LineasNuevas.Web.API.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvIder
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}