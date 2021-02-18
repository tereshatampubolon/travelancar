using System.Web;
using System.Web.Optimization;

namespace Travelancar
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

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/Bootstrap/css").Include(
                      "~/Style/assets/vendor/bootstrap/css/bootstrap.min.css",
                      "~/Style/assets/vendor/ionicons/css/ionicons.min.css",
                      "~/Style/assets/vendor/animate.css/animate.min.css",
                      "~/Style/assets/vendor/font-awesome/css/font-awesome.min.css",
                      "~/Style/assets/vendor/owl.carousel/assets/owl.carousel.min.css",
                      "~/Style/assets/css/style.css"));

            bundles.Add(new ScriptBundle("~/bundles/Javascript/bootstrap").Include(
                      "~/Style/assets/vendor/jquery/jquery.min.js",
                      "~/Style/assets/vendor/bootstrap/js/bootstrap.bundle.min.js",
                      "~/Style/assets/vendor/jquery.easing/jquery.easing.min.js",
                      "~/Style/assets/vendor/php-email-form/validate.js",
                      "~/Style/assets/vendor/owl.carousel/owl.carousel.min.js",
                      "~/Style/assets/vendor/scrollreveal/scrollreveal.min.js",
                      "~/Style/assets/js/main.js"));
        }
    }
}
