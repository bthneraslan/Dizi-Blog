using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziBlog.Entity;
namespace DiziBlog
{
    public partial class KategoriDetay : System.Web.UI.Page
    {
        DiziBlogEntities db = new DiziBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
            var bloglar = db.TBLBLOG.Where(x=>x.BLOGKATEGORI==id).ToList();
            Repeater1.DataSource = bloglar;
            Repeater1.DataBind();

            var ktg = db.TBLKATEGORI.ToList();
            Repeater2.DataSource = ktg;
            Repeater2.DataBind();

            var bloglar2 = db.TBLBLOG.ToList();
            Repeater3.DataSource = bloglar2;
            Repeater3.DataBind();

            var yorum = (from x in db.TBLYORUM
                         select new
                         {
                             x.TBLBLOG.BLOGBASLIK,
                             x.YORUMICERIK
                         }).ToList();
            Repeater4.DataSource = yorum;
            Repeater4.DataBind();

        }
    }
}