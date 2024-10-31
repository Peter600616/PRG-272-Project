using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_272_Project
{
    internal class FileHandler
    {
        private string path = "students.txt";
        public FileHandler() { }

        public void write(List<Student> students)
        {


            FileStream fs = new FileStream(path, FileMode.Create);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                string text;
                foreach (Student student in students)
                {
                    text = student.StudentID + "," + student.StudentName + "," + student.Age + "," + student.Course;
                    sw.WriteLine(text);
                }
            }

            fs.Close();           
            Console.ReadLine();
        }

        public List<Student> read()
        {
            List<Student> students = new List<Student>();
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string text;
            while ((text = sr.ReadLine()) != null)
            {
                string[] strings = text.Split(',');
                Student newstudent = new Student(int.Parse(strings[0]), strings[1], int.Parse(strings[2]), strings[3]);
                students.Add(newstudent);
            }
            fs.Close();
            sr.Close();

            return students;
        }
    }
}
