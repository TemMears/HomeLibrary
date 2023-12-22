using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace п2
{
    class WorkingFiles
    {
        public string ChekTheFile()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Kurs";
            bool isCreat = File.Exists(path + "\\data.txt");
            if (!isCreat)
            {
                Directory.CreateDirectory(path);
                path += "\\data.txt";
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine("nevvZqM+JdenLq9X7t+lddi91CP51g96eEW3KSdtg7Y="); // Пароль DAD
                    MessageBox.Show("Файлы данных были повреждены, информация утерена, пароль сброшен");
                }
            }
            else
            {
                if (File.ReadAllLines(path + "\\data.txt").Length == 0)
                {
                    using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.UTF8))
                    {
                        sw.WriteLine("nevvZqM+JdenLq9X7t+lddi91CP51g96eEW3KSdtg7Y="); // Пароль DAD
                        MessageBox.Show("Файлы данных были повреждены, информация утерена, пароль сброшен");
                    }
                }
                return path + "\\data.txt";
            }
            return path;
        }
        public void ToFile(string message)
        {
            string path = ChekTheFile();
            string password;
            using (var passRead = new StreamReader(path))
            {
                password = passRead.ReadLine();  // записываем в переменную
            }
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.UTF8))
            {
                sw.WriteLine(password + Environment.NewLine + message);
            }
        }

        public string FromFiles()
        {
            string path = ChekTheFile(); //Получение пути к файлу
            try
            {
                string output = File.ReadAllText(path).Split('\n')[1/*количество пропускаемых строк*/];
                return output.Remove(output.Length - 1);
            }
            catch
            {
                MessageBox.Show("У вас нет сохранёного сообщения");
                return null;
            }
        }

        public string PassFromFiles()
        {
            string path = ChekTheFile(); //Получение пути к файлу
            string output = File.ReadAllText(path).Split('\n')[0/*количество пропускаемых строк*/];
            return output.Remove(output.Length - 1);
        }

        public void PassToFile(string input)
        {
            string path = ChekTheFile();
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.UTF8))
            {
                sw.WriteLine(input);
            }
        }
    }
}
