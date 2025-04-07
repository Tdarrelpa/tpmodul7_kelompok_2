using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace cobaJSON2 
{
    public class Course
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class KuliahMahasiswa_103022300082
    {
        public List<Course> Courses { get; set; }

        public void ReadJSON(string filePath)
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);
                KuliahMahasiswa_103022300082 kuliahMahasiswa = JsonSerializer.Deserialize<KuliahMahasiswa_103022300082>(jsonString);

                Console.WriteLine("Daftar mata kuliah yang diambil:");
                for (int i = 0; i < kuliahMahasiswa.Courses.Count; i++)
                {
                    Console.WriteLine($"MK {i + 1} {kuliahMahasiswa.Courses[i].Code} - {kuliahMahasiswa.Courses[i].Name}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}