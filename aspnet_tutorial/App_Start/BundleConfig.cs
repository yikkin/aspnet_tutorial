using System.Web;
using System.Web.Optimization;

namespace aspnet_tutorial
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Assets/css").Include(
                "~/Assets/css/bootstrap-table.css",
                "~/Assets/css/bootstrap-theme.css",
                "~/Assets/css/bootstrap-theme.css.map",
                "~/Assets/css/bootstrap-theme.min.css",
                "~/Assets/css/bootstrap.css",
                "~/Assets/css/bootstrap.css.map",
                "~/Assets/css/bootstrap.min.css",
                "~/Assets/css/datepicker.css",
                "~/Assets/css/datepicker.css",
                "~/Assets/css/fontawesome.min.css",
                "~/Assets/css/styles.css"
            ));

            bundles.Add(new ScriptBundle("~/Assets/js").Include(
                "~/Assets/js/bootstrap-datepicker.js",
                "~/Assets/js/bootstrap-table.js",
                "~/Assets/js/bootstrap.js",
                "~/Assets/js/bootstrap-min.js",
                "~/Assets/js/chart-data.js",
                "~/Assets/js/chart-min.js",
                "~/Assets/js/easypiechart-data.js",
                "~/Assets/js/easypiechart.js",
                "~/Assets/js/events.js",
                "~/Assets/js/font-awesome.min.js",
                "~/Assets/js/html5shiv.min.js",
                "~/Assets/js/jquery-1.11.1.min.js",
                "~/Assets/js/lumino.glyphs.js",
                "~/Assets/js/respond.min.js"
            ));

            bundles.Add(new Bundle("~/Assets/fonts").Include(
                "~/Assets/fonts/glyphicons-halfings-regular.eot",
                "~/Assets/fonts/glyphicons-halfings-regular.svg",
                "~/Assets/fonts/glyphicons-halfings-regular.ttf",
                "~/Assets/fonts/glyphicons-halfings-regular.woff"
            ));
        }
    }
}
