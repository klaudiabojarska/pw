using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    [Serializable]
    class Samochod
    {
        private string _marka;
        private int _rokProdukcji;
        private float _cena;

        public void saveToFile(FileStream data)
        {
            BinaryFormatter bifoter = new BinaryFormatter();
            bifoter.Serialize(data, this);
        }

        // File jest abstrakcyjnyyyy //  data = File.OpenRead("Radio.dat");
        public Samochod(File data)
        {
            BinaryFormatter bifoter = new BinaryFormatter();
            Samochod v = (Samochod)bifoter.Deserialize(data);
            Marka = v.Marka;
            RokProdukcji = v.RokProdukcji;
            Cena = v.Cena;
        }

        public string Marka
        {
            get { return _marka; }
            set { _marka = value; }
        }
        public int RokProdukcji
        {
            get { return _rokProdukcji; }
            set { _rokProdukcji = value; }
        }
        public float Cena
        {
            get { return _cena; }
            set { _cena = value; }
        }

        public Samochod(string marka, int rok, float cena)
        {
            Marka = marka;
            RokProdukcji = rok;
            Cena = cena;
        }
    }
}
