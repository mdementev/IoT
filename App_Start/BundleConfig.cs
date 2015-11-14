using System.Web;
using System.Web.Optimization;

namespace IoT
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/common").Include(
                "~/Scripts/Common/Common.js"));

            bundles.Add(new ScriptBundle("~/bundles/login").Include(
                "~/Scripts/login/index.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css"));



            // bower 
            bundles.Add(new ScriptBundle("~/bundles/bower_components/angular").Include(
                "~/Content/bower_components/angular/angular.js",
                "~/Content/bower_components/angular-aria/angular-aria.js",
                "~/Content/bower_components/angular-animate/angular-animate.js",
                "~/Content/bower_components/angular-material/angular-material.js"));

            bundles.Add(new StyleBundle("~/Content/bower_components/styles").Include(
                "~/Content/bower_components/angular/angular.css",
                "~/Content/bower_components/angular-material/angular-material.css"));
        }
    }
}
