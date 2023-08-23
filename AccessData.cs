using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    internal class AccessData
    {
        public virtual void Read()
        {
            Console.WriteLine("Reading the file");
        }
        public virtual void Write() {
            Console.WriteLine("Writing the file");
        }
    }
    public interface IFileRead
    {
        void Read();
    }
    public interface IFileWrite
    {
        void Write();
    }
    internal class Adminaccess : IFileRead, IFileWrite
    {
        public void Read()
        {
           Console.WriteLine("Reading the file");
        }

        public void Write()
        {
            Console.WriteLine("Writing the file");
        }
    }
    internal class Normalaccess : IFileRead
    {
        public void Read()
        {
            Console.WriteLine("Reading the file");
        }
    }
}
