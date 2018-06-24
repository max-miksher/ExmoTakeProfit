using System;
using System.IO;

namespace ExmoTakeProfit
{
    /// <summary>
    ////класс провеки, создания и работы файлов с данными
    /// </summary>
    class WorkWithLocalFiles
    {
        /// <summary>
        /// проверяет наличие файла с данными
        /// </summary>
        /// <returns></returns>
        public static bool CheckingFile()
        {
            string dir = @"C:\Users\\" + Environment.UserName + "\\AppData\\Roaming\\ExmoTakeProfit";
            if (Directory.Exists(dir))
            {
                if (File.Exists(@"C:\Users\\" + Environment.UserName + "\\AppData\\Roaming\\ExmoTakeProfit\\keys.dat"))
                    return true;
                else return false;
            }
            else return false;
        }
        /// <summary>
        /// создает файл с данными
        /// </summary>
        /// <returns></returns>
        public static int FileCreation()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming");
            try
            {
                if (!Directory.Exists(@"C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\ExmoTakeProfit"))
                    dir.CreateSubdirectory("ExmoTakeProfit");
                try
                {
                    string path = @"C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\ExmoTakeProfit\\keys.dat";

                    //Создадим обьект класса XmlSerializer, для выполнения сериализации обьекта(в скобачках тип сеарилизованых данных)
                    System.Xml.Serialization.XmlSerializer writerRw = new System.Xml.Serialization.XmlSerializer(typeof(Keys));
                    //создадим обьект класса StreamWriter, для того, что бы записать в файл данные
                    System.IO.StreamWriter fileRw = new System.IO.StreamWriter(/*"@" + */path);
                    Keys n = new Keys();
                    writerRw.Serialize(fileRw, n);
                    //кеп)) закроем файл
                    fileRw.Close();

                    return 0;//файл успешно создан
                }
                catch (IOException e)
                {
                    return 1;//нельзя создать файл
                }
            }
            catch (IOException e)
            {
                return 2;//нельзя создать папку
            }
        }
        /// <summary>
        ////читает файл с данными
        /// </summary>
        public static Keys ReadFile()
        {
            string path = @"C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\ExmoTakeProfit\\keys.dat";
            try
            {
                //создадим обьект класса XmlSerializer, в скобачках тип данных, который необходимо записать в ХМЛ файл
                System.Xml.Serialization.XmlSerializer readerRr = new System.Xml.Serialization.XmlSerializer(typeof(Keys));
                //создадим обьект класса StreamReader, для того, что бы открыть файл
                System.IO.StreamReader fileRr = new System.IO.StreamReader(path);
                //Считаем из файла в набор данных(массив, к нему же явное преобразование), или просто "Десириализация"
                Keys rr = (Keys)readerRr.Deserialize(fileRr);
                //По хорошему надо бы закрыть файл(для повторной операции)
                fileRr.Close();
                return rr;
            }
            catch (IOException e)
            {
                Keys a = new Keys();
                return a;
            }
        }

        public static bool WriteFile(Keys str)
        {
            string path = @"C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\ExmoTakeProfit\\keys.dat";
            try
            {
                //Создадим обьект класса XmlSerializer, для выполнения сериализации обьекта(в скобачках тип сеарилизованых данных)
                System.Xml.Serialization.XmlSerializer writerRw = new System.Xml.Serialization.XmlSerializer(typeof(Keys));
                //создадим обьект класса StreamWriter, для того, что бы записать в файл данные
                System.IO.StreamWriter fileRw = new System.IO.StreamWriter(/*"@" + */path);
                //Выполним сериализацию
                writerRw.Serialize(fileRw, str);
                //кеп)) закроем файл
                fileRw.Close();
                return true;
            }
            catch (IOException e)
            {
                return false;
            }
        }
    }
}
