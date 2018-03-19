using System;
using System.IO;

namespace _22.DisposePattern
{
    class Resource : IDisposable
    {
        private IntPtr p = new IntPtr(100);
        private bool disposed = false;
        private StreamWriter w = new StreamWriter("bla.txt");
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void DoWork()
        {
            if (w == null)
                throw new ObjectDisposedException("w");

            w.WriteLine("bla...");
        }

        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // can clean up other managed objects  
                    w.Dispose();
                }
                // clean up unmanaged resources  
                p = IntPtr.Zero;
                disposed = true;
            }
        }
        ~Resource()
        {
            Dispose(false);
        }
    }

    class Resource2 : IDisposable
    {
        bool disposed = false;
        private StreamWriter w = new StreamWriter("bla.txt");
        private IntPtr p = new IntPtr(100);

        public void Dispose()
        {
            Dispose(false);
            
                     
        }
        
        public void Dispose(bool disposing)
        {
            if (!disposed)
            {

                if (disposing)
                {
                    disposed = true;
                    // Release managed Memory
                }

                // Release unmanaged Memory
            }
        }

        ~Resource2()
        {
            Dispose(true);

            // Release managed            
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            DoWork();

            GC.Collect();
        }

        public static void DoWork()
        {
            using (Resource email = new Resource())
            {
                email.DoWork();
            }
        }

    }
}
