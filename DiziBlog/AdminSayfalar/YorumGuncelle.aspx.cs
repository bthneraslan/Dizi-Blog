using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziBlog.Entity;
namespace DiziBlog.AdminSayfalar
{
    public partial class YorumGuncelle : System.Web.UI.Page
    {
        DiziBlogEntities db = new DiziBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int d = int.Parse(Request.QueryString["YORUMID"]);
            if (Page.IsPostBack == false)
            {
                var blog = (from x in db.TBLBLOG
                            select new
                            {
                                x.BLOGBASLIK,
                                x.BLOGID
                            }).ToList();
                DropDownList1.DataSource = blog;
                DropDownList1.DataBind();


                var deger = db.TBLYORUM.Find(d);
                TxtKadı.Text = deger.KULLANICIAD;
                TxtMail.Text = deger.MAIL;
                TxtYorum.Text = deger.YORUMICERIK;
                TxtID.Text = deger.YORUMID.ToString();

                DropDownList1.SelectedValue = deger.TBLBLOG.ToString();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["YORUMID"]);
            var yorum = db.TBLYORUM.Find(y);
            yorum.KULLANICIAD = TxtKadı.Text;
            yorum.MAIL = TxtMail.Text;
            yorum.YORUMICERIK = TxtYorum.Text;
            yorum.YORUMBLOG= byte.Parse(DropDownList1.SelectedValue);
            db.SaveChanges();
            Response.Redirect("Yorumlar.aspx");
        }
    }
}