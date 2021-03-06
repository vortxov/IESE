using Microsoft.AspNetCore.Hosting;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

using MariGold.OpenXHTML;
using Microsoft.AspNetCore.Mvc;

namespace IESE.Service
{
    class WordHelper //Класс для изменение шаблонов в файле ворд
    {
        private FileInfo fileInfo;
        IWebHostEnvironment _appEnvironment;
        public WordHelper(string filename)
        {
            if(File.Exists(filename)) //Проверяем есть ли файл
            {
                fileInfo = new FileInfo(filename); //Создаем класс и заносим туда информацию о файле который будем менять
            }
            else
            {
                throw new ArgumentException("file not found"); //Если нет файла то ошибка 
            }
        }

        public WordHelper(IWebHostEnvironment appEnvironment)
        {
            this._appEnvironment = appEnvironment;
        }


        internal string Process(Dictionary<string,string> items, string path) //Функция для изменения шаблонов 
        {
            Word.Application app = null;
            if (fileInfo != null) //Проверка есть ли данные о файле
            {
                try
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(path);
                    if (!dirInfo.Exists)
                    {
                        dirInfo.Create();
                    }

                    app = new Word.Application(); //Открывае приложение word
                    Object file = fileInfo.FullName;

                    Object missing = Type.Missing;

                    app.Documents.Open(file); //Открываем файл по его пути
                    app.ActiveDocument.SaveAs2(path +  fileInfo.Name);  //Создаем копию файла для его изменения
                    app.ActiveDocument.Close(); //Закрываем прошлый файл 

                    app.Documents.Open(path +  fileInfo.Name); // И открываем копию


                    foreach (var item in items) //Из листа шаблонов по одному меняем меняем все
                    {
                        Word.Find find = app.Selection.Find;
                        find.Text = item.Key;
                        find.Replacement.Text = item.Value;

                        Object wrap = Word.WdFindWrap.wdFindContinue;
                        Object replace = Word.WdReplace.wdReplaceAll;

                        find.Execute(FindText: Type.Missing,
                            MatchCase: false,
                            MatchWholeWord: false,
                            MatchWildcards: false,
                            MatchSoundsLike: missing,
                            MatchAllWordForms: false,
                            Forward: true,
                            Wrap: wrap,
                            Format: false,
                            ReplaceWith: missing, Replace: replace);
                    }

                    string newFileName = path +  fileInfo.Name.Split(".")[0] + ".pdf"; //Пишем путь нового файла в пдф формате
                    app.ActiveDocument.ExportAsFixedFormat(newFileName, WdExportFormat.wdExportFormatPDF); //Сохраняем в новом формате
                    app.ActiveDocument.Close(); //Закрываем файл

                    return newFileName; //Возращаем путь к файлу
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    //System.IO.File.Delete(fileInfo.DirectoryName + "/change.docx"); //Удаляем копию файла из за того что уже не нужен
                    if (app != null)
                        app.Quit(); 
                }
            }
            return null;
        }

        public string CreateDocument(string text, string name)
        {
            using (MemoryStream mem = new MemoryStream())
            {
                WordDocument doc1 = new WordDocument(mem);
                doc1.Process(new MariGold.OpenXHTML.HtmlParser(text));
                doc1.Save();

                var path = _appEnvironment.WebRootPath + "/WordFiles/" + name + DateTime.Now.Year;

                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }

                path += "/" + name + ".docx";

                File.WriteAllBytes(path, mem.ToArray());
                return path;
            }            
        }
    }
}
