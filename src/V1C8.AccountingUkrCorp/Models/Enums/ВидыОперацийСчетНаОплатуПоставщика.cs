using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийСчетНаОплатуПоставщика", Comment = "(Общ)", Synonym = "Виды операций документа 'Счет на оплату поставщика'")]
    public class ВидыОперацийСчетНаОплатуПоставщика:EnumItem
    {
        public static readonly ВидыОперацийСчетНаОплатуПоставщика ПокупкаКомиссия = new ВидыОперацийСчетНаОплатуПоставщика{Name= "ПокупкаКомиссия",Synonym="Покупка, комиссия",Comment="(Общ)"};
        public static readonly ВидыОперацийСчетНаОплатуПоставщика Оборудование = new ВидыОперацийСчетНаОплатуПоставщика{Name= "Оборудование",Synonym="Оборудование",Comment="(Общ)"};
        public static readonly ВидыОперацийСчетНаОплатуПоставщика ОбъектыСтроительства = new ВидыОперацийСчетНаОплатуПоставщика{Name= "ОбъектыСтроительства",Synonym="Объекты строительства",Comment=""};
    }
}
