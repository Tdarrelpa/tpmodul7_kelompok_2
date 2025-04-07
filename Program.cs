// See https://aka.ms/new-console-template for more information
using cobaJSON1;

public class Program
{
    public static void Main(string[] args)
    {
        string jsonFilePath = "C:\\Users\\darrel\\Documents\\tpmodul7_kelompok_2\\tp7_1_103022300082.json"; // Specify path to JSON1
        DataMahasiswa_103022300082 mahasiswa = DataMahasiswa_103022300082.ReadJSON(jsonFilePath);
        mahasiswa.PrintMahasiswa();
    }
}