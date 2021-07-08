using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace PersonelMVCUI.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //request sayısını teke indirmek ve minify ediyoruz.
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/Scripts/jquery-3.5.1.min.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/jquery.unobtrusive-ajax.min.js",
                "~/Scripts/custom.js",
                "~/Scripts/bootbox.min.js",
                "~/Scripts/DataTables/jquery.dataTables.min.js",
                "~/Scripts/DataTables/dataTables.bootstrap4.js"
                ));
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/sitecss.css",
                "~/Content/DataTables/css/dataTables.bootstrap4.css"
                ));
        }
    }
}