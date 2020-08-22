using QLCuaHangBanXeMayDien.QuanLy_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using QLCuaHangBanXeMayDien.QuanLy_DTO;

namespace QLCuaHangBanXeMayDien.QuanLy_BUS
{
    public class AccountBUS
    {
        private static AccountBUS instance;

        public static AccountBUS Instance 
        {
            get { if (instance == null) instance = new AccountBUS(); return instance; } 
            private set => instance = value; 
        }

        private AccountBUS() { }
        
        public AccountLogin getAccountByUserNameAndPassWord(string username, string password)
        {
            AccountLogin account = new AccountLogin();

            string query = "SELECT * FROM dbo.AccountLogin WHERE UserName = @username AND PassWord = @password";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password});
            if(data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    account = new AccountLogin(item);
                }
            }

            return account;
        }

        public bool InsertAccount(string username , string password , int accountType , string displayName, string phoneNumber , string email)
        {
            int result = 0;
            string query = "EXEC dbo.USP_InsertAcc @username , @password , @accountType , @displayName , @phoneNumber , @email";
            result = DataProvider.Instance.ExecuteNonQuery(query , new object[] { username, password, accountType, displayName, phoneNumber, email});
            return result > 0;
        }

        public bool UpdateAccount(string username, string password, int accountType, string displayName, string phoneNumber, string email)
        {
            int result = 0;
            string query = "EXEC dbo.USP_UpdateAcc @username , @password , @accountType , @displayName , @phoneNumber , @email";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, password, accountType, displayName, phoneNumber, email });
            return result > 0;
        }

        public bool DeleteAccount(string username)
        {

            int result = 0;
            string query = "EXEC dbo.USP_DeleteAcc @username ";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { username });
            return result > 0;
        }

        public bool checkAccount(string username, string password)
        {
            string query = "SELECT * FROM dbo.AccountLogin WHERE UserName = @username AND PassWord = @password";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { username , password} );
            return data.Rows.Count > 0;
        }

    }
}
