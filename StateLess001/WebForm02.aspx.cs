using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateLess001
{
    public partial class WebForm02 : System.Web.UI.Page
    {
        /// <summary>
        /// ViewState nos permite preservar los datos entre requests
        /// El ViewState viaja con la petición y la respuesta, de esa manera se conserva el dato
        /// Tenemos que colocar el nombre de la variable para el ViewState
        /// Si no se ha usado previamente tiene el valor null
        /// Cuando lo leamos es importante hacer el typecast correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private int _conteo = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtConteo.Text = "0";
            }
        }

        protected void btnIncrementa_Click(object sender, EventArgs e)
        {
            if (ViewState["click"]!= null)
            {
                _conteo = (int)ViewState["click"] + 1;
            }
            txtConteo.Text = _conteo.ToString();
            ViewState["click"] = _conteo;
        }
    }
}