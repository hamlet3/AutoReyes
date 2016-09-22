using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace AutoReyes.app
{
    public partial class Site1 : System.Web.UI.MasterPage
    {

            Mensajes mensaje = new Mensajes();
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EmailTxt_TextChanged(object sender, EventArgs e)
        {

        }

        protected void EnviarBtn_Click(object sender, EventArgs e)
        {
            mensaje.Email=EmailTxt.Text;
            mensaje.Asunto=AsuntoTxt.Text;
            mensaje.Mensaje= mensajetxt.Text;
            mensaje.Insertar();
        }

        protected void MenjaseTxt_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}