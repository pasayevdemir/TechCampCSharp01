using CourseProject.Entities.Concret;
using CourseProject.Helpers;
using CourseProject.Helpers.Results.Abstract;
using CourseProject.Helpers.Results.Concret;
using CourseProject.Operations.Abstract;
using System.Data;
using System.Data.SqlClient;

namespace CourseProject.Operations.Concret
{
    public class StudentManager : IStudentOperation
    {
        public IResult Add(Student entity)
        {
            if (entity != null)
            {
                int queryValue = 0;
                using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.AddStudent", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", entity.FirstName);
                        cmd.Parameters.AddWithValue("@Surname", entity.LastName);
                        queryValue = cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                if (queryValue == 1)
                    return new SuccessResult("Məlumat əlavə olundu!");
                else
                    return new ErrorResult("Xəta baş verdi!");
            }
            else
                return new ErrorResult("Məlumat göndərilmiyib!!");
        }
        public IResult Update(Student entity, int id)
        {
            if (entity != null)
            {
                int queryValue = 0;
                using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        string query = $@"exec dbo.UpdateStudent @UpdateID, @Name, @Surname";
                        cmd.Connection = connection;
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@UpdateID", id);
                        cmd.Parameters.AddWithValue("@Name", entity.FirstName);
                        cmd.Parameters.AddWithValue("@Surname", entity.LastName);
                        queryValue = cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                if (queryValue == 1)
                    return new SuccessResult("Məlumat yeniləndi!");
                else
                    return new ErrorResult("Xəta baş verdi!");
            }
            else
                return new ErrorResult("Məlumat göndərilmiyib!!");
        }

        public IResult Deleted(int id)
        {
            if (id > 0)
            {
                int queryValue = 0;
                using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        string query = $@"exec dbo.SoftDeletedStudent @DeletedID";
                        cmd.Connection = connection;
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@DeletedID", id); ;
                        queryValue = cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                if (queryValue == 1)
                    return new SuccessResult("Məlumat silindi!");
                else
                    return new ErrorResult("Xəta baş verdi!");
            }
            else
                return new ErrorResult("Məlumat göndərilmiyib!!");
        }

        public IDataResult<List<Student>> GetAll()
        {
            List<Student> students = new();
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("select * from Students", connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var row = dt.Rows[i];
                        students.Add(new Student
                        {
                            ID = Convert.ToInt32(row["ID"]),
                            FirstName = row["Name"].ToString(),
                            LastName = row["Surname"].ToString(),
                            Deleted = Convert.ToInt32(row["Deleted"])
                        });
                    }
                }
                connection.Close();
            }
            return new SuccessDataResult<List<Student>>(students);
        }

        public IDataResult<Student> GetById(int id)
        {
            Student student = default;
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    string query = $@"select * from Students where ID =@ID";
                    cmd.Connection = connection;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@ID", id);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var row = dt.Rows[i];
                        student = new Student
                        {
                            ID = Convert.ToInt32(row["ID"]),
                            FirstName = row["Name"].ToString(),
                            LastName = row["Surname"].ToString(),
                            Deleted = Convert.ToInt32(row["Deleted"])

                        };
                    }
                }
                connection.Close();
            }
            if (student != null)
                return new SuccessDataResult<Student>(student);

            else
                return new ErrorDataResult<Student>("Məlumat tapəlmadı!");
        }

    }
}
