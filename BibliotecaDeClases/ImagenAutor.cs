using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class ImagenAutor
    {
        public static string ImageToBase64(Image image, ImageFormat formato)
        {
            if (image==null)
                return "";

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, formato);
                byte[] imBytes = ms.ToArray();
                string base64string = Convert.ToBase64String(imBytes);

                return base64string;
            }
        }

        public static Image Base64ToImage(string base64string)
        {
            if (base64string!="")
            {
                byte[] imBytes = Convert.FromBase64String(base64string);
                MemoryStream ms = new MemoryStream(imBytes, 0, imBytes.Length);
                ms.Write(imBytes, 0, imBytes.Length);
                Image imagen = Image.FromStream(ms, true);
                return imagen;
            }
            else
                return null;

            
            
        }


    }
}
