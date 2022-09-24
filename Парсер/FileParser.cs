using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Парсер
{
    public abstract class FileParser
    {
        public FileParser(string name)
        {
            FileName = name;
        }
        public abstract void Read();
        public abstract void Open();
        public abstract void Close();
        public abstract void Analize();
        public virtual void Parse()
        {
            Open();
            Read();
            Analize();
            Close();
        }
        
        public virtual string ParserFormat
        {
            get; 
        }

        public string FileName { get; }

        public static FileParser GetParser(string fileName)
        {
            if (fileName.Contains(".xml"))
            {
                XmlParser xml = new XmlParser(fileName);
                xml.Parse();
                return xml;
            }

            if (fileName.Contains(".rtf"))
            {  RtfParser rtf = new RtfParser(fileName);
                rtf.Parse();
                    return rtf;
            }

            if (fileName.Contains(".html"))
            {
                HtmlParser html = new HtmlParser(fileName);
                html.Parse();
                return html;
            }

            else
                Console.WriteLine("Формат не найден, попробуйте ещё раз");
              return null;
                   
            
        }

        

        

    }
}
