namespace THR_PBO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilih jenis karyawan:");
            Console.WriteLine("1. Tetap");
            Console.WriteLine("2. Kontrak");
            Console.WriteLine("3. Magang");
            Console.Write("Masukkan pilihan (1/2/3): ");
            int pilihan = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("masukan nama anda");
            string nama = Console.ReadLine();
            Console.WriteLine(" masukan id anda");
            string id = Console.ReadLine();
            Console.WriteLine("masukan gaji pokok anda");
            double gaji = Convert.ToDouble(Console.ReadLine());

            kayawan karyawan;

            switch (pilihan)
            {
                case 1:
                    karyawan = new kayawan_tetap(nama,id,gaji);
                    break;
                case 2:
                    karyawan = new kayawan_kontrak(nama, id, gaji);
                    break;
                case 3:
                     karyawan = new kayawan_magang(nama,id ,gaji);
                    break;
                default:
                    Console.WriteLine("mohon pilih sesuai arahan yang tersedia ");
                    return;

            }
            Console.WriteLine("\nInformasi Karyawan:");
            karyawan.info();


        }
    }
    class kayawan
    {
        private string nama;
        private string id;
        private double gaji;

        public kayawan(string nama, string id,double gaji)
        {
            Nama = nama;
            Id = id;
            Gaji = gaji;
        }
       public string Nama
        {
            get
            {
                return nama;
            } 
            set
            {
                nama = value;
            }
        }
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public double Gaji
        {
            get
            {
                return gaji;

            }

            set
            {
                if (value < 0)
                { 
                    gaji = 3000000;
                }
                if (value > 3000000)
                {
                    gaji = 3000000;
                }
                else
                {
                    gaji = value;
                }
            }

                
           
        }
        public virtual double gaji_akhir()
        {
           
            return gaji;
        }
        public  virtual void info()
        {
            Console.WriteLine("nama : " + nama);
            Console.WriteLine("ID : " + id);
            Console.WriteLine("gaji : " + gaji_akhir());
        }

    }

    class kayawan_tetap : kayawan
    {
        public kayawan_tetap(string nama, string id, double gaji) :
            base (nama, id, gaji)
        {

        }
        public double bonus = 500000;
        public override double gaji_akhir()
        {
            return base.gaji_akhir() + bonus;

        }

    }
    class kayawan_kontrak : kayawan
    {
        public kayawan_kontrak(string nama, string id, double gaji) :
            base(nama, id, gaji)
        {

        }
        public double kontrak = 200000;
        public override double gaji_akhir()
        {
            return base.gaji_akhir() - kontrak;

        }

    }
    class kayawan_magang : kayawan
    {
        public kayawan_magang(string nama, string id, double gaji) :
            base(nama, id, gaji)
        {

        }
        
        public override double gaji_akhir()
        {
            return base.gaji_akhir();

        }

    }


}
