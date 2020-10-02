using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийКомплектацияНоменклатуры", Comment = "", Synonym = "Виды операций документа 'Комплектация нменклатуры'")]
    public class ВидыОперацийКомплектацияНоменклатуры:EnumItem
    {
        public static readonly ВидыОперацийКомплектацияНоменклатуры Комплектация = new ВидыОперацийКомплектацияНоменклатуры{Name= "Комплектация",Synonym="Комплектация",Comment=""};
        public static readonly ВидыОперацийКомплектацияНоменклатуры Разукомплектация = new ВидыОперацийКомплектацияНоменклатуры{Name= "Разукомплектация",Synonym="Разукомплектация",Comment=""};
    }
}
