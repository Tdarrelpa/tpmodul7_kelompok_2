// See https://aka.ms/new-console-template for more information
using cobaJSON1;
using cobaJSON2;

public class Program
{
    public static void Main(string[] args)
    {
        string jsonFilePath = "C:\\Users\\darrel\\Documents\\tpmodul7_kelompok_2\\tp7_1_103022300082.json"; // Specify path to JSON1
        DataMahasiswa_103022300082 mahasiswa = DataMahasiswa_103022300082.ReadJSON(jsonFilePath);
        mahasiswa.PrintMahasiswa();

        KuliahMahasiswa_103022300082 kuliahMahasiswa = new KuliahMahasiswa_103022300082();
        kuliahMahasiswa.ReadJSON("C:\\Users\\darrel\\Documents\\tpmodul7_kelompok_2\\tp7_2_103022300082.json");
    }
}