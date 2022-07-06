using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziBlog.Entity;
namespace DiziBlog
{
    public partial class Hakkimizda : System.Web.UI.Page
    {
        DiziBlogEntities db = new DiziBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var hakkimizda = db.TBLHAKKIMIZDA.ToList();
            Repeater1.DataSource = hakkimizda;
            Repeater1.DataBind();
        }
    }
}