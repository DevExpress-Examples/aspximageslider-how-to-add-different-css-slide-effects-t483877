﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Init(object sender, EventArgs e)
    {
        imageSlider.CssClass = comboSelectEffect.Value.ToString();
       
    }

    protected void comboSelectEffect_SelectedIndexChanged(object sender, EventArgs e) {

        imageSlider.CssClass = comboSelectEffect.Value.ToString();
    }
}