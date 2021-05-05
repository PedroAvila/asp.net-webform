using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateLess001
{
    public partial class _Default : Page
    {
        private int _conteo = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Verificamos que no sea un posback del webform
            if (!IsPostBack)
            {
                txtConteo.Text = "0";
            }
        }

        protected void btnIncrementa_Click(object sender, EventArgs e)
        {
            _conteo++;
            txtConteo.Text = _conteo.ToString();
        }
    }
}