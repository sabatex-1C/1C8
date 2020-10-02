using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ФорматыХраненияОдностраничныхФайлов", Comment = "", Synonym = "Форматы хранения одностраничных файлов")]
    public class ФорматыХраненияОдностраничныхФайлов:EnumItem
    {
        public static readonly ФорматыХраненияОдностраничныхФайлов BMP = new ФорматыХраненияОдностраничныхФайлов{Name= "BMP",Synonym="BMP",Comment=""};
        public static readonly ФорматыХраненияОдностраничныхФайлов GIF = new ФорматыХраненияОдностраничныхФайлов{Name= "GIF",Synonym="GIF",Comment=""};
        public static readonly ФорматыХраненияОдностраничныхФайлов JPG = new ФорматыХраненияОдностраничныхФайлов{Name= "JPG",Synonym="JPG",Comment=""};
        public static readonly ФорматыХраненияОдностраничныхФайлов PDF = new ФорматыХраненияОдностраничныхФайлов{Name= "PDF",Synonym="PDF",Comment=""};
        public static readonly ФорматыХраненияОдностраничныхФайлов PNG = new ФорматыХраненияОдностраничныхФайлов{Name= "PNG",Synonym="PNG",Comment=""};
        public static readonly ФорматыХраненияОдностраничныхФайлов TIF = new ФорматыХраненияОдностраничныхФайлов{Name= "TIF",Synonym="TIF",Comment=""};
    }
}
