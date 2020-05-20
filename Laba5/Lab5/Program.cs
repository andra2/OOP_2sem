using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Lab5
{

    static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static async public void ReadJson(LinkedList<Plane> list)
        {
            using (FileStream fs = new FileStream("Planes.json", FileMode.OpenOrCreate))
            {
                foreach (Plane i in list)
                {
                    list.AddLast(await JsonSerializer.DeserializeAsync<Plane>(fs));
                }
            }
        }
        static async public void WriteJson(LinkedList<Plane> list)
        {
            using (FileStream fs = new FileStream("Planes.json", FileMode.OpenOrCreate))
            {
                foreach (Plane i in list)
                {
                    await JsonSerializer.SerializeAsync(fs, i);
                }
            }
        }
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Airport());
        }
    }
}
