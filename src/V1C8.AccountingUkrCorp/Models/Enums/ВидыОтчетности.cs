using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОтчетности", Comment = "(Общ)", Synonym = "Виды отчетности")]
    public class ВидыОтчетности:EnumItem
    {
        public static readonly ВидыОтчетности РегламентированнаяОтчетность = new ВидыОтчетности{Name= "РегламентированнаяОтчетность",Synonym="Регламентированная отчетность",Comment="(Регл)"};
        public static readonly ВидыОтчетности ОтчетностьПоМСФО = new ВидыОтчетности{Name= "ОтчетностьПоМСФО",Synonym="Отчетность по МСФО",Comment="(Упр)"};
    }
}
