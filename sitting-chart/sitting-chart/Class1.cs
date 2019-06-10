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
        static SQLiteConnection con = null;


        /// データベースに接続
        private static void ConnectionOpen()
        {
            con = new SQLiteConnection();
            con.ConnectionString = "Data Source=testdb.db;Version=3;";
            con.Open();
        }


        /// テーブルの作成
        private static void CreateTable(){
            SQLiteCommand command = con.CreateCommand();
            command.CommandText = "CREATE TABLE Teacher (id AUTOINCREMENT, name char(15), lank int, ability int, secility int, weak int, workdays int)";
            command.CommandText = "CREATE TABLE Student (id AUTOINCREMENT, name char(15))";
            command.CommandText = "CREATE TABLE Hours (students.id int, subject.id int,classhours int)";
            command.CommandText = "CREATE TABLE Subject(id AUTOINCREMENT)";
            command.CommandText = "CREATE TABLE Timetable(id AUTOINCREMENT,time datatime)";
            command.CommandText = "CREATE TABLE Class(id AUTOINCREMENT,teachers.id int, students.id int, subject.id int, timetable.id int)";
            command.ExecuteNonQuery();
        }

        /// レコードを登録・挿入
        private static void InsertRecord()
        {
            for (int i = 0; i < 10; i++)
            {
                SQLiteCommand command = con.CreateCommand();
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
            SQLiteCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM ";
            var reader = command.ExecuteReader();

            while (reader.Read()){
                 Console.WriteLine(string.Format("ID = {0}, Name = {1}",
                    reader.GetInt32(0),
                    reader.GetString(1))); 
            }
        }

        /// データベース接続を閉じる
        private static void ConnectionClose(){
            con.Close();
        }
}
}