using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SessionIDManager manager = new SessionIDManager();

        string newID = manager.CreateSessionID(Context);
        bool redirected = false;
        bool isAdded = false;
        manager.SaveSessionID(Context, newID, out redirected, out isAdded);
    }
}