using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2108M_UWP.Models;
using T2108M_UWP.Helpers;
using SQLitePCL;

namespace T2108M_UWP.Services
{
    interface IStudentService
    {
        List<Student> All();

        void Create(Student s);

        void Update(Student s);

        void Delete(Student s);
    }

    class StudentService : IStudentService
    {
        public List<Student> All()
        {
            string sql_txt = "select * from Student;";
            SQLiteHelper helper = SQLiteHelper.GetInstance();
            var statement = helper.SQLiteConnection.Prepare(sql_txt);
            var list = new List<Student>();
            while (SQLiteResult.ROW == statement.Step())
            {
                Student s = new Student()
                {
                    Id = Convert.ToInt32(statement[0]),
                    Name = statement[1] as string,
                    Age = Convert.ToInt32(statement[2]),
                    Address = statement[3] as string,
                };
                list.Add(s);
            }
            return list;
        }

        public void Create(Student s)
        {
            string sql_txt = "insert into Student(Id,Name,Age,Address) values(?,?,?,?)";
            SQLiteHelper helper = SQLiteHelper.GetInstance();
            var statement = helper.SQLiteConnection.Prepare(sql_txt);
            statement.Bind(1, s.Id);
            statement.Bind(2, s.Name);
            statement.Bind(3, s.Age);
            statement.Bind(4, s.Address);
            statement.Step();
       
        }

        public void Update(Student s)
        {
            string sql_txt = "update Student set Name=?, Age=?, Address=? where Id=?";
            SQLiteHelper helper = SQLiteHelper.GetInstance();
            var statement = helper.SQLiteConnection.Prepare(sql_txt);
            statement.Bind(1, s.Name);
            statement.Bind(2, s.Age);
            statement.Bind(3, s.Address);
            statement.Bind(4, s.Id);
            statement.Step();

        }

        public void Delete(Student s)
        {
            string sql_txt = "delete from Student where Id=?";
            SQLiteHelper helper = SQLiteHelper.GetInstance();
            var statement = helper.SQLiteConnection.Prepare(sql_txt);
            statement.Bind(1, s.Id);
            statement.Step();

        }
    }
}
