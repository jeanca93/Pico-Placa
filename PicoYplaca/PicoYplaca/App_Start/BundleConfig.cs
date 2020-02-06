using System.Web;
using System.Web.Optimization;

namespace PicoYplaca
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-ajax").Include(
                "~/scripts/jquery.unobtrusive-ajax.js"));

            bundles.Add(new ScriptBundle("~/bundles/popper").Include(
                "~/scripts/umd/popper.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                    "~/scripts/respond.js",
                    "~/scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/mdb").Include(
                "~/scripts/mdb.js"));

            bundles.Add(new ScriptBundle("~/bundles/notify").Include(
                "~/scripts/bootstrap-notify.js"));

            bundles.Add(new ScriptBundle("~/bundles/sweetalert2").Include(
                "~/scripts/sweetalert2.js"));

            var bundle = new StyleBundle("~/Content/bootstrap").Include(
                "~/Content/site.css",
                "~/Content/bootstrap.css");

            bundle.Transforms.Clear();

            bundles.Add(bundle);

            bundles.Add(new StyleBundle("~/Content/fontawesome").Include(
                "~/Content/fontawesome-all.css"));

            bundles.Add(new StyleBundle("~/Content/mdb").Include(
                "~/Content/mdb.css"));

            bundles.Add(new StyleBundle("~/Content/core").Include(
                "~/Content/animate.css",
                "~/Content/sweetalert2.css",
                "~/Content/main.css"));
        }
    }
}
