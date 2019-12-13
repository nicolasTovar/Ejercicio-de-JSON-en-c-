using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using Newtonsoft.Json;

namespace practicarJson
{
    public partial class Form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            eventos evento = new eventos
            {
                nombre = txtNombre.Text.ToString(),
                cedula = txtCedula.Text.ToString()

            };
            if(Session["Datos"].ToString() == string.Empty)
            {
                Session["Datos"] = JsonConvert.SerializeObject(evento);
            }
            else
            {
                Session["Datos"] = Session["Datos"].ToString() + JsonConvert.SerializeObject(evento);
            }
            lbDatos.Items.Add("nombre" + " " + evento.nombre + "cedula" + " " + evento.cedula);


        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Server.MapPath("Archivo.json"), "[" + Session["Datos"] + "]");
            Response.Write("<script>alert('Json creado')</script>");
        }

        protected void btnLeer_Click(object sender, EventArgs e)
        {
            string archivo = File.ReadAllText(Server.MapPath("Archivo.json"));
            DataTable data = (DataTable)JsonConvert.DeserializeObject(archivo, typeof(DataTable));
            dgInformacio.DataSource = data;
            dgInformacio.DataBind();

        }
    }
}