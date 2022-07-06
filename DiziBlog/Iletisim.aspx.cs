using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziBlog.Entity;
namespace DiziBlog
{
    public partial class Iletisim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DiziBlogEntities db = new DiziBlogEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {

            TBLILETISIM t = new TBLILETISIM();
            t.ADSOYAD = TextBox1.Text;
            t.KONU = TextBox2.Text;
            t.MAIL = TextBox3.Text;
            t.TELEFON = TextBox4.Text;
            t.MESAJ = TextBox5.Text;
            db.TBLILETISIM.Add(t);
            db.SaveChanges();
            Response.Redirect("Iletisim.aspx");

        }
    }
}