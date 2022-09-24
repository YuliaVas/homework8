using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Парсер
{
    public class HtmlParser : FileParser
    {
        public HtmlParser(string name) : base(name)
        { }
        public override void Analize()
        {
            Console.WriteLine($"{nameof(HtmlParser)}:Файл {FileName}, был проанализирован");
        }

        public override void Close()
        {
            Console.WriteLine($"{nameof(HtmlParser)}:Файл {FileName}, закрыт");
        }

        public override void Open()
        {
            Console.WriteLine($"{nameof(HtmlParser)}:Файл {FileName}, был открыт");
        }

        public override void Read()
        {
            Console.WriteLine($"{nameof(HtmlParser)}:Файл {FileName}, был прочитан");

        }

        public override string ParserFormat
        { get => ".html"; }
    }
}
