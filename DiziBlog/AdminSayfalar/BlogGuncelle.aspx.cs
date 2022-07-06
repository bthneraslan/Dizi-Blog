using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziBlog.Entity;

namespace DiziBlog.AdminSayfalar
{
    public partial class BlogGuncelle : System.Web.UI.Page
    {
        DiziBlogEntities db = new DiziBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int d = int.Parse(Request.QueryString["BLOGID"]);
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

                var deger = db.TBLBLOG.Find(d);
                TxtBaslik.Text = deger.BLOGBASLIK;
                TxtGorsel.Text = deger.BLOGGORSEL;
                TxtID.Text = Convert.ToString(deger.BLOGID);
                TxtTarih.Text = Convert.ToString(deger.BLOGTARIH);
                Txtİcerik.Text = deger.BLOGICERIK;
                DropDownList1.SelectedValue = deger.TBLTUR.ToString();
                DropDownList2.SelectedValue = deger.TBLKATEGORI.ToString();
            }
        }

        
        protected void Button1_Click(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["BLOGID"]);
            var blog = db.TBLBLOG.Find(y);
            blog.BLOGBASLIK = TxtBaslik.Text;
            blog.BLOGGORSEL = TxtGorsel.Text;
            blog.BLOGICERIK = Txtİcerik.Text;
            blog.BLOGTARIH = DateTime.Parse(TxtTarih.Text);
            blog.BLOGTUR = byte.Parse(DropDownList1.SelectedValue);
            blog.BLOGKATEGORI = byte.Parse(DropDownList2.SelectedValue);
            db.SaveChanges();
            Response.Redirect("Bloglar.aspx");

        }
    }
}