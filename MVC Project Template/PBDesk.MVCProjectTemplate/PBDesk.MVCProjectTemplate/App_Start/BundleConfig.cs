using System.Web;
using System.Web.Optimization;

namespace PBDesk.MVCProjectTemplate
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js")
                .Include("~/Scripts/jquery-{version}.js")
                .Include("~/Scripts/bootstrap.js")
                .Include("~/Scripts/toastr.js")
                .Include("~/Scripts/toastr-custom.js")
                .Include("~/Scripts/PBDeskUtils.js")
                .Include("~/Scripts/Custom.js")                
                );

            bundles.Add(new ScriptBundle("~/bundles/angular")
                .Include("~/scripts/angular.js")
                .Include("~/scripts/angular-*")
                
                );
           

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.cerulean.css",                      
                      "~/Content/font-awesome.css",
                      "~/Content/toastr.css",
                      "~/Content/site.css"
                      ));



            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));



        }
    }
}
