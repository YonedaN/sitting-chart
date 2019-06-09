using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace sitting_chart
{
    class Class1
    {
        static SQLiteConnection _conn = null;

        static void Main(string[] args) {

        }

        /// データベースに接続
        private static void ConnectionOpen()
        {
            _conn = new SQLiteConnection();
            _conn.ConnectionString = "Data Source=testdb.db;Version=3;";
            _conn.Open();
        }


        /// テーブルの作成
        private static void CreateTable(){
            SQLiteCommand command = _conn.CreateCommand();
            command.CommandText = "CREATE TABLE Teacher (id AUTOINCREMENT, name char(15), lank int, ability int, secility int, weak int, workdays int)";
            command.CommandText = "CREATE TABLE Student (id AUTOINCREMENT, name char(15))";
            command.CommandText = "CREATE TABLE Class (students.id int, subject.id int,classhours int)";
            command.ExecuteNonQuery();
        }

        /// レコードを登録・挿入
        private static void InsertRecord()
        {
            for (int i = 0; i < 10; i++)
            {
                SQLiteCommand command = _conn.CreateCommand();
                command.CommandText = "INSERT INTO Test (text) VALUES (@1)";
                SQLiteParameter parameter = command.CreateParameter();
                parameter.ParameterName = "@1";
                parameter.Value = "this is " + i.ToString() + " text";
                command.Parameters.Add(parameter);
                command.ExecuteNonQuery();
            }
        }

        /// レコードを取得
        private static void SelectRecord(){
            // 全データの取得
            SQLiteCommand command = _conn.CreateCommand();
            command.CommandText = "SELECT * FROM Test";
            var reader = command.ExecuteReader();

            while (reader.Read()){
                 Console.WriteLine(string.Format("ID = {0}, Name = {1}",
                    reader.GetInt32(0),
                    reader.GetString(1))); 
            }
        }

        /// データベース接続を閉じる
        private static void ConnectionClose(){
            _conn.Close();
        }
}
}