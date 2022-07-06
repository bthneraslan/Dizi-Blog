using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziBlog.Entity;
namespace DiziBlog.AdminSayfalar
{
    public partial class BlogEkle : System.Web.UI.Page
    {
        DiziBlogEntities db = new DiziBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var turler = (from x in db.TBLTUR
                              select new
                              {
                                  x.TURAD,
                                  x.TURID
                              }).ToList();
                DropDownList1.DataSource = turler;
                DropDownList1.DataBind();

                var ktg = (from y in db.TBLKATEGORI
                           select new
                           {
                               y.KATEGORIAD,
                               y.KATEGORIID
                           }).ToList();
                DropDownList2.DataSource = ktg;
                DropDownList2.DataBind();

            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            TBLBLOG t = new TBLBLOG();
            t.BLOGBASLIK = TxtBaslik.Text;
            t.BLOGGORSEL = TxtGorsel.Text;
            t.BLOGICERIK = Txtİcerik.Text;
            t.BLOGTARIH = DateTime.Parse(TxtTarih.Text);
            t.BLOGTUR = byte.Parse(DropDownList1.SelectedValue);
            t.BLOGKATEGORI = byte.Parse(DropDownList2.SelectedValue);
            db.TBLBLOG.Add(t);
            db.SaveChanges();
            Response.Redirect("Bloglar.aspx");
        }
    }
}