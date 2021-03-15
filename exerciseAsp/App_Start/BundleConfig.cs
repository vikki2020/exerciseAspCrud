using System.Web;
using System.Web.Optimization;

namespace exerciseAsp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));
            bundles.Add(new ScriptBundle("~/bundles/welcome").Include(
                     "~/js/welcome/bootstrap.bundle.min.js",
                     "~/js/welcome/custom.js",
                     "~/js/welcome/jquery-3.0.0.min.js",
                     "~/js/welcome/jquery.mCustomScrollbar.concat.min.js",
                     "~/js/welcome/jquery.min.js",
                    "~/js/welcome/popper.min.js",
                    "~/js/welcome/jquery.validate.js"));
            bundles.Add(new ScriptBundle("~/bundles/plugin").Include(
                     "~/js/welcome/plugin.js"));


            //"~/js/welcome/plugin.js"-->conflict,


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/Site.css"
                     ));
            bundles.Add(new StyleBundle("~/Content/welcome").Include(
                    
                     "~/css/welcome/bootstrap.min.css",
                     "~/css/welcome/jquery-ui.css",
                     "~/css/welcome/jquery.mCustomScrollbar.min.css",
                     "~/css/welcome/meanmenu.css",
                     "~/css/welcome/nice-select.css",
                     "~/css/welcome/normalize.css",
                     "~/css/welcome/owl.carousel.min.css",
                     "~/css/welcome/responsive.css",
                     "~/css/welcome/slick.css",
                     "~/css/welcome/style.css",
                     "~/css/welcome/animate.min.css"));

           
        }
    }
}
