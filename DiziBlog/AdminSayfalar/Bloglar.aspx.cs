using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziBlog.Entity;
namespace DiziBlog.AdminSayfalar
{
    public partial class Bloglar : System.Web.UI.Page
    {
        DiziBlogEntities db = new DiziBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KULLANICI"]==null)
            {
                Response.Redirect("/Login.aspx");
            }
            else
            {
                Response.Write("Hoşgeldiniz." + Session["KULLANICI"].ToString());
               
            }
            var bloglar = db.TBLBLOG.ToList();
            Repeater1.DataSource = bloglar;
            Repeater1.DataBind();

        }
    }
}