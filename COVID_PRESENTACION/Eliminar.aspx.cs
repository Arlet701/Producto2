using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COVID_PRESENTACION
{
    public partial class Eliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Add("Selecciona para eliminar");
                DropDownList1.Items.Add("Alumno");
                DropDownList1.Items.Add("Profesor");
                DropDownList1.Items.Add("Cuatrimestre");
                DropDownList1.Items.Add("Grupo Cuatrimestre");
                DropDownList1.Items.Add("Alumno Grupo");
                DropDownList1.Items.Add("Profe Grupo");
                DropDownList1.Items.Add("positivo Profe");
                DropDownList1.Items.Add("positivo Alumno");
                DropDownList1.Items.Add("Seguimiento PRO");
                DropDownList1.Items.Add("Seguimiento AL");
                DropDownList1.Items.Add("Medico");
<<<<<<< HEAD
                DropDownList1.Items.Add("Incapacidad");
=======
>>>>>>> 2109f26 (Elimina datos)
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem.Text == "Alumno")
            {
<<<<<<< HEAD
                Response.Redirect("EliminarAlumno.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Profesor")
            {
                Response.Redirect("EliminarProfesor.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Cuatrimestre")
            {
                Response.Redirect("EliminarCuatrimestre.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Grupo Cuatrimestre")  
            {
                Response.Redirect("EliminarGrpCuatri.aspx"); 
            }
            else if (DropDownList1.SelectedItem.Text == "Alumno Grupo")
            {
                Response.Redirect("EliminarAlumnoGrupo.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Profe Grupo")
            {
                Response.Redirect("EliminarProfeGrupo.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "positivo Profe")
            {
                Response.Redirect("EliminarposProfe.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "positivo Alumno")
            {
                Response.Redirect("EliminarposAlumno.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Seguimiento PRO")
            {
                Response.Redirect("Eliminarsegprof.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Seguimiento AL")
            {
                Response.Redirect("Eliminarsegalum.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Medico")
            {
                Response.Redirect("Eliminarmedico.aspx");
=======
                Response.Redirect("Alumno.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Profesor")
            {
                Response.Redirect("Profesor.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Cuatrimestre")
            {
                Response.Redirect("Cuatrimestre.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Grupo Cuatrimestre")
            {
                Response.Redirect("GrpCuatri.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Alumno Grupo")
            {
                Response.Redirect("AlumnoGrupo.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Profe Grupo")
            {
                Response.Redirect("ProfeGrupo.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "positivo Profe")
            {
                Response.Redirect("posProfe.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "positivo Alumno")
            {
                Response.Redirect("posAlumno.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Seguimiento PRO")
            {
                Response.Redirect("segprof.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Seguimiento AL")
            {
                Response.Redirect("segalum.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Medico")
            {
                Response.Redirect("medico.aspx");
>>>>>>> 2109f26 (Elimina datos)
            }
        }
    }
}