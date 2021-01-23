﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace ProjectOOP2new.Model
{
    class Students
    {
        public static bool AddStudentMdl(string name, string sid, string password)
        {
            var conn = DataBase.ConnectDB();
            conn.Open();
            string query = String.Format("Insert Into Student Values ('{0}','{1}','{2}')", name, sid, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
            conn.Close();
            if (a > 0)
            {
                return true;
            }
            else
                return false;
        }

        public static ArrayList GetAllStudents()
        {

            var conn = DataBase.ConnectDB();
            conn.Open();
            string query = "Select * from Student";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            ArrayList students = new ArrayList();
            while (reader.Read())
            {
                Student stud = new Student();
                stud.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                stud.Name = reader.GetString(reader.GetOrdinal("Name"));
                stud.SId = reader.GetString(reader.GetOrdinal("SId"));
                stud.Password = reader.GetString(reader.GetOrdinal("Password"));
                students.Add(stud);

            }
            conn.Close();
            return students;
        }

        public static bool RemoveStudent(string name)
        {
            var conn = DataBase.ConnectDB();
            conn.Open();
            string query = String.Format("Delete From Student Where SId =('{0}')", name);
            SqlCommand cmd = new SqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
            conn.Close();
            if (a > 0)
            {
                return true;
            }
            else
                return false;
        }
        public static ArrayList FindStudent(string name)
        {

            var conn = DataBase.ConnectDB();
            conn.Open();
            string query = String.Format("SELECT * FROM Student WHERE Name='{0}'", name);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            ArrayList students = new ArrayList();
            Student b = new Student();
            while (reader.Read())
            {

                b.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                b.Name = reader.GetString(reader.GetOrdinal("Name"));
                b.SId = reader.GetString(reader.GetOrdinal("SId"));
                students.Add(b);

            }
            conn.Close();
            
            return students;

        }
        public static bool UpgradeStudent(string studentid , string name)
        {
            var conn = DataBase.ConnectDB();
            conn.Open();
            string query = String.Format("Update  Student Set Name='{0}' Where SId ='{1}'",name , studentid);
            SqlCommand cmd = new SqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
            conn.Close();
            if (a > 0)
            {
                return true;
            }
            else
                return false;
        }

        public static Student AuthenStudent(string sid , string password)
        {

            var conn = DataBase.ConnectDB();
            conn.Open();
            string query = String.Format("SELECT * FROM Student WHERE SId='{0}'  and Password='{1}'", sid , password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            
            Student b;
            b = null;
            while (reader.Read())
            {
                b= new Student ();
                b.SId = reader.GetString(reader.GetOrdinal("SId"));
                b.Password = reader.GetString(reader.GetOrdinal("Password"));
                
               
            }
            conn.Close();

            return b;

        }

        public static string FindAuthenStudent(string sid, string password)
        {
            string name=null;
            var conn = DataBase.ConnectDB();
            conn.Open();
            string query = String.Format("SELECT * FROM Student WHERE SId='{0}'  and Password='{1}'", sid, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            Student b;
            b = null;
            while (reader.Read())
            {
                b = new Student();
                b.Name = reader.GetString(reader.GetOrdinal("Name"));
                name = b.Name;
            }
            conn.Close();

            return name;

        }


    }
}
