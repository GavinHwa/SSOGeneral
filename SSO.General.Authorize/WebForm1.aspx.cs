﻿using SSO.Cross.Domain;
using SSO.Helper;
using SSO.Same.Domain;
using System;

namespace SSO.General.Authorize
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (User.Identity.IsAuthenticated)
                {
                    //string result = SSOGeneralSameDomain.GetCookieValue("CookiesTest", this);
                    SSOCrossDomain cross = new SSOCrossDomain(this);
                    txtUserData.Text = cross.GetUserData("CookiesTest");
                }
            }
        }

        protected void SignOut_Click(object sender, EventArgs e)
        {
            //SSOGeneralSameDomain.LogOut();
            SSOCrossDomain cross = new SSOCrossDomain(this);
            cross.LogOut();
        }
    }
}