using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Marcelo.Leiloes.Repository
{
    [Serializable]
    public abstract class AbstractRepository<T> : List<T>
    {
        protected virtual string fileName { get; set; }

        public void RemoveFromFile()
        {
            File.Delete(fileName);
        }

        public void LoadFromFile()
        {
            this.Clear();

            try
            {
                using (Stream stream = File.Open(fileName, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    var opened = (List<T>)bin.Deserialize(stream);
                    foreach (T item in opened)
                    {
                        this.Add(item);
                    }
                }
            }
            catch (IOException ex)
            {
            }
        }

        public void SaveToFile()
        {
            try
            {
                using (Stream stream = File.Open(fileName, FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, this);
                }
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }
    }
}
