﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class ModificarIncapacidad : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Periodo = TextBox1.Text;
            string Comprobacion = TextBox2.Text;
            string Extra = TextBox3.Text;
            int F_positivoProfe = Convert.ToInt32(TextBox4.Text);

            op.ModificarIncap(Periodo, Comprobacion, Extra, F_positivoProfe);
            Response.Write("<script>alert('Tipo de incapacidad actualizado exitosamente');</script>");
        }
    }
}