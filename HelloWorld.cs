using System;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;

public partial class HelloWorld : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DisplayDeviceLogs_1_2025();
        }
    }

    private void DisplayDeviceLogs_1_2025()
    {
        // Retrieve the connection string from web.config
        string connectionString = ConfigurationManager.ConnectionStrings["EmployeeDBConnectionString"].ConnectionString;

        // Query to fetch employees
        string query = "SELECT DeviceId, UserId FROM DeviceLogs_1_2025";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // Build HTML table for the employee list
                StringBuilder html = new StringBuilder();
                html.Append("<table border='1'>");
                html.Append("<tr><th>DeviceId</th><th>UserId</th></tr>");

                while (reader.Read())
                {
                    html.Append("<tr>");
                    html.Append(string.Format("<td>{0}</td>", reader["DeviceId"]));
                    html.Append(string.Format("<td>{0}</td>", reader["UserId"]));
                    html.Append("</tr>");
                }

                html.Append("</table>");
                reader.Close();

                // Display the HTML table on the page
                Label1.Text = html.ToString();
            }
        }
        catch (Exception ex)
        {
            Label1.Text = "Error: " + ex.Message;
        }
    }
}
