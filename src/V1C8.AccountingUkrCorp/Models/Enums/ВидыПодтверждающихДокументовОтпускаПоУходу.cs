using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыПодтверждающихДокументовОтпускаПоУходу", Comment = "", Synonym = "Виды подтверждающих документов отпуска по уходу")]
    public class ВидыПодтверждающихДокументовОтпускаПоУходу:EnumItem
    {
        public static readonly ВидыПодтверждающихДокументовОтпускаПоУходу СвидетельствоОРождении = new ВидыПодтверждающихДокументовОтпускаПоУходу{Name= "СвидетельствоОРождении",Synonym="Свидетельство о рождении",Comment=""};
        public static readonly ВидыПодтверждающихДокументовОтпускаПоУходу РешениеОбУстановленииОпеки = new ВидыПодтверждающихДокументовОтпускаПоУходу{Name= "РешениеОбУстановленииОпеки",Synonym="Решение об установлении опеки",Comment=""};
        public static readonly ВидыПодтверждающихДокументовОтпускаПоУходу ИнойДокументПодтверждающийРождениеРебенка = new ВидыПодтверждающихДокументовОтпускаПоУходу{Name= "ИнойДокументПодтверждающийРождениеРебенка",Synonym="Иной документ подтверждающий рождение ребенка",Comment=""};
        public static readonly ВидыПодтверждающихДокументовОтпускаПоУходу СвидетельствоОСмерти = new ВидыПодтверждающихДокументовОтпускаПоУходу{Name= "СвидетельствоОСмерти",Synonym="Свидетельство о смерти",Comment=""};
    }
}
