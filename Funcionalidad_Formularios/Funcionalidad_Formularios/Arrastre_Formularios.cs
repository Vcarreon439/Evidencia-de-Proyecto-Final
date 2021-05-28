using System.Runtime.InteropServices;

namespace Funcionalidad_Formularios
{
    static public class Arrastre_Formularios
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RelaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        static public void Llama_ReleaseCapture()
        {
            RelaseCapture();
        }

        static public void Llama_SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam)
        {
            SendMessage(hwnd, wmsg, wparam, lparam);
        }
    }
}
