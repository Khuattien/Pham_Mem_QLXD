using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLCuaHangBanXeMayDien.QuanLy_DAO
{
    public class DataProvider
    {
        // design patern singleton
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set => instance = value;
        }
        private DataProvider() { }

        //Server Path
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DaiLyXeMayDien;Integrated Security=True";


        /// <summary>
        /// Phương thức lấy ra dữ liệu để hiển thi lên form
        /// </summary>
        /// <param name="query">Câu truy vấn </param>
        /// <param name="parameters"> Các tham số truyền vào(có hoặc không) </param>
        /// <returns>Một bảng dữ liệu được lấy ra</returns>
        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    string[] listParams = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParams)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        /// <summary>
        /// Phương thức thực hiện truy vấn dữ liệu
        /// </summary>
        /// <param name="query">Câu lệnh truy vấn</param>
        /// <param name="parameters"> Các tham số truyền vào(có hoặc không) </param>
        /// <returns>Số dòng thực hiện thành công</returns>
        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    string[] listParams = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParams)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        /// <summary>
        /// Phương thức lấy ra một giá trị từ database (tổng , trung bình , só lượng ,...)
        /// </summary>
        /// <param name="query"> Câu lệnh truy vấn</param>
        /// <param name="parameters"> Các tham số truyền vào(có hoặc không) </param>
        /// <returns> kết quả trả gia giá trị cần lấy</returns>
        public object ExecuteScalar(string query, object[] parameters = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    string[] listParams = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParams)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }

    }
}
