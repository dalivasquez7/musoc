﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Musoc
{

    public partial class FormFin : System.Web.UI.Page
    {
        public static String correo;

        protected void Page_Load(object sender, EventArgs e)
        {
            labelCorreo.Text = correo;

        }
    }
}