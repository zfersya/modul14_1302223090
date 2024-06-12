using System.Numerics;


namespace modul14_1302223090
{
    /// <summary>
    /// class ini digunakan untuk melakukan kalkulasi penjumlahan
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Penjumlahan<T>
    {
        public static T JumlahTigaAngka<T>(T number1, T number2, T number3) where T : IAdditionOperators<T, T, T>
        {
            //melakukan return dengan menambah semua variabel number 
            return number1 + number2 + number3;
        }

    }

    /// <summary>
    /// class ini untuk membuat database sederhana
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class SimpleDataBase<T>
    {
        //inilisiasi variabel menyimpan data dan tanggal
        private List<T> _storedData;
        private List<DateTime> _inputDates;

        //membuat database sederhana dari list
        public SimpleDataBase()
        {
            this._storedData = new List<T>();
            this._inputDates = new List<DateTime>();
        }
       
        public static SimpleDataBase<T> createNewDatabase()
        {
            return new SimpleDataBase<T>();
        }
        public void getNewData(T input)
        {
            //input data ke variabel
            _storedData.Add(input);
            _inputDates.Add(DateTime.Now);
        }
        
        //print hasil data tersimpan pada database
        public void printAllData()
        {
            //melakukan loop untuk print semua data pada _storedData dan _inputDates untuk waktu simpan data pada database 
            for(int i = 0; i < _storedData.Count; i++)
            {
                Console.WriteLine("Data " + i + " berisi : " + _storedData[i] + "yang disimpan pada waktu UTC: " + _inputDates[i]);
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            //Soal A
            //inialisasi variabel long 
            long number1 = 12;
            long number2 = 34;
            long number3 = 56;

            //memanggil JumlahTigaAngka untuk mendapatkan hasil perjumlahan
            long hasil = Penjumlahan<long>.JumlahTigaAngka(number1, number2, number3);

            //Untuk Print hasil pada terminal
            Console.WriteLine(hasil);
            

            //Soal B
            //inialisasi list untuk menyimpan data int
            SimpleDataBase<int> data = SimpleDataBase<int>.createNewDatabase();

            //input data berupa int ke list
            data.getNewData(12);
            data.getNewData(34);
            data.getNewData(56);
            //print semua data agar muncul diterminal
            data.printAllData();
        }
    }
}