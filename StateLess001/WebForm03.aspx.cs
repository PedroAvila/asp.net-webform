using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateLess001
{

    public partial class WebForm03 : System.Web.UI.Page
    {
        /// <summary>
        /// Los controles ASP.NET usan internamente a ViewState para guardar su estado
        /// Pero esto no nos quita de la responsabilidad de guardar los datos
        /// Correctamente en el ViewState
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtConteo.Text = "0";
            }
        }

        protected void btnIncrementa_Click(object sender, EventArgs e)
        {
            int conteo = Convert.ToInt32(txtConteo.Text) + 1;
            txtConteo.Text = conteo.ToString();
        }
    }
}