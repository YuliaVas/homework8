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
            RtfParser rtf = new RtfParser(fileName);
            XmlParser xml = new XmlParser(fileName);
            HtmlParser html = new HtmlParser(fileName);

            if (fileName.Contains(xml.ParserFormat))
            {
                
                xml.Parse();
                return xml;
            }

            if (fileName.Contains(rtf.ParserFormat))
            {  
                rtf.Parse();
                    return rtf;
            }

            if (fileName.Contains(html.ParserFormat))
            {
               
                html.Parse();
                return html;
            }

            else
                Console.WriteLine("Формат не найден, попробуйте ещё раз");
              return null;
                   
            
        }

        

        

    }
}
