using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Linq1DataContext dataContext = new Linq1DataContext();

            //In Memory objects
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            GridView1.DataSource = from number in numbers
                                   where (number % 2) == 0
                                   select number;


            //Down Linq To Sql
            //GridView1.DataSource = from student in dataContext.Students
            //                       where student.Gender == "MALE"
            //                       select student;
            GridView1.DataBind();
        }
    }
}