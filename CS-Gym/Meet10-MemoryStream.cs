using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CS_Gym
{
    internal class Meet10_MemoryStream
    {
        public void Run()
        {
            using (MemoryStream ms = new MemoryStream())
            {

                byte[] buffer = new byte[100];
                buffer[0] = 12;
                buffer[1] = 13;
                buffer[2] = 23;
                buffer[3] = 98;
                buffer[4] = 12;
                buffer[5] = 13;
                buffer[7] = 23;
                buffer[10] = 98;

                ms.Write(buffer, 0, buffer.Length);
                ms.Seek(1, SeekOrigin.Begin);

                using (FileStream fs = new FileStream("output.bin2", FileMode.CreateNew))
                {
                    ms.CopyTo(fs);
                    fs.Flush();
                }

            }

            
            
        }
    }
}
