using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIRTUAL_PET
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            VIRTUALPET virtualPetForm = new VIRTUALPET();

            try
            {
                DialogResult result = virtualPetForm.ShowDialog();

                if (!virtualPetForm.IsDisposed && result == DialogResult.OK)
                {
                    Application.Run(virtualPetForm);
                }
                else
                {
                    // Pastikan untuk melepaskan sumber daya form jika dibatalkan
                    virtualPetForm.Dispose();
                }
            }
            catch (ObjectDisposedException)
            {
                // Jika terjadi ObjectDisposedException, tidak perlu melakukan apapun
                // Karena form telah di-dispose sebelumnya
            }
        }
    }
}
