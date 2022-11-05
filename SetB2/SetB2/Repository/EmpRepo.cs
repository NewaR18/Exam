using SetB2.Models;
using System.Data.SqlClient;

namespace SetB2.Repository
{
    public class EmpRepo
    {
        string constr = "data source=NEWAR-PC; database= PracExam; Integrated Security= SSPI;";
        public void AddEmployee(Employees emp)
        {
            using (SqlConnection conn = new SqlConnection(constr)){
                string query = $"Insert into mytable values('{ emp.name}',{ emp.phone_no})";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    Console.WriteLine("Inserted Succesfully");
                }
                else
                {
                    Console.WriteLine("Insertion not completed");
                }
            }
        }
        public IEnumerable<Employees> FetchData()
        {
            List<Employees> datas = new List<Employees>();
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string query = "Select* from mytable";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        Employees e1 = new Employees();
                        e1.name = rd["Name"].ToString();
                        e1.phone_no = Convert.ToInt64(rd["Phone_No"]);
                        datas.Add(e1);
                    }
                }
            }
            return datas;
        }
    }
}
