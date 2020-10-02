using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РазделыУчетаДляВводаОстатков", Comment = "", Synonym = "Разделы учета для ввода остатков")]
    public class РазделыУчетаДляВводаОстатков:EnumItem
    {
        public static readonly РазделыУчетаДляВводаОстатков ОсновныеСредства = new РазделыУчетаДляВводаОстатков{Name= "ОсновныеСредства",Synonym="Основные средства (счета 10, 11, 13, 286)",Comment=""};
        public static readonly РазделыУчетаДляВводаОстатков МалоценныеАктивыВЭксплуатации = new РазделыУчетаДляВводаОстатков{Name= "МалоценныеАктивыВЭксплуатации",Synonym="Малоценные активы в эксплуатации (счета 1112, 1122, 1322, МЦ)",Comment=""};
        public static readonly РазделыУчетаДляВводаОстатков НематериальныеАктивы = new РазделыУчетаДляВводаОстатков{Name= "НематериальныеАктивы",Synonym="Нематериальные активы (счета 12, 133)",Comment=""};
        public static readonly РазделыУчетаДляВводаОстатков КапитальныеИнвестиции = new РазделыУчетаДляВводаОстатков{Name= "КапитальныеИнвестиции",Synonym="Капитальные инвестиции (счета 15 (кроме 155))",Comment=""};
        public static readonly РазделыУчетаДляВводаОстатков ЗапасыСебестоимость = new РазделыУчетаДляВводаОстатков{Name= "ЗапасыСебестоимость",Synonym="Запасы по себестоимости (счета 201-205, 207-209, 221, 234, 25, 26, 27, 281, 284, 289, 08)",Comment=""};
        public static readonly РазделыУчетаДляВводаОстатков ТранспортноЗаготовительныеРасходыНаОтдельныхСубсчетах = new РазделыУчетаДляВводаОстатков{Name= "ТранспортноЗаготовительныеРасходыНаОтдельныхСубсчетах",Synonym="Транспортно заготовительные расходы (200, 2801, 2802)",Comment=""};
        public static readonly РазделыУчетаДляВводаОстатков ЗапасыПереданные = new РазделыУчетаДляВводаОстатков{Name= "ЗапасыПереданные",Synonym="Запасы переданные (счета 206, 283)",Comment=""};
        public static readonly РазделыУчетаДляВводаОстатков НезавершенноеПроизводство = new РазделыУчетаДляВводаОстатков{Name= "НезавершенноеПроизводство",Synonym="Незавершенное производство (счета 231 – 233)",Comment=""};
        public static readonly РазделыУчетаДляВводаОстатков ТоварыПоПродажнойЦене = new РазделыУчетаДляВводаОстатков{Name= "ТоварыПоПродажнойЦене",Synonym="Товары по продажной цене (счета 282, 285)",Comment=""};
        public static readonly РазделыУчетаДляВводаОстатков ДенежныеСредства = new РазделыУчетаДляВводаОстатков{Name= "ДенежныеСредства",Synonym="Денежные средства (счета 30, 31, 333, 334)",Comment=""};
        public static readonly РазделыУчетаДляВводаОстатков ВзаиморасчетыСКонтрагентами = new РазделыУчетаДляВводаОстатков{Name= "ВзаиморасчетыСКонтрагентами",Synonym="Взаиморасчеты с контрагентами (счета 36, 371, 3771, 3772, 63, 681, 6851, 6852, 643, 644)",Comment=""};
        public static readonly РазделыУчетаДляВводаОстатков ВзаиморасчетыСПодотчетнымиЛицами = new РазделыУчетаДляВводаОстатков{Name= "ВзаиморасчетыСПодотчетнымиЛицами",Synonym="Взаиморасчеты с подотчетными лицами (счет 372)",Comment=""};
        public static readonly РазделыУчетаДляВводаОстатков РасходыБудущихПериодов = new РазделыУчетаДляВводаОстатков{Name= "РасходыБудущихПериодов",Synonym="Расходы будущих периодов (счет 39)",Comment=""};
        public static readonly РазделыУчетаДляВводаОстатков ЗарплатаИОтчисления = new РазделыУчетаДляВводаОстатков{Name= "ЗарплатаИОтчисления",Synonym="Зарплата и отчисления (счета 65, 66)",Comment=""};
        public static readonly РазделыУчетаДляВводаОстатков ТоварыНаКомиссии = new РазделыУчетаДляВводаОстатков{Name= "ТоварыНаКомиссии",Synonym="Товары, принятые на комиссию (счета 024)",Comment=""};
        public static readonly РазделыУчетаДляВводаОстатков ПрочиеСчетаБухгалтерскогоУчета = new РазделыУчетаДляВводаОстатков{Name= "ПрочиеСчетаБухгалтерскогоУчета",Synonym="Прочие счета бухгалтерского учета",Comment=""};
        public static readonly РазделыУчетаДляВводаОстатков ОтсроченныеНалоговыеАктивыИОбязательства = new РазделыУчетаДляВводаОстатков{Name= "ОтсроченныеНалоговыеАктивыИОбязательства",Synonym="(не используется) ОНА и ОНО (счета 17, 54)",Comment=""};
        public static readonly РазделыУчетаДляВводаОстатков ДанныеНалоговогоУчета = new РазделыУчетаДляВводаОстатков{Name= "ДанныеНалоговогоУчета",Synonym="(не используется) Данные налогового учета (по налогу на прибыль до 01.04.2011) ",Comment=""};
        public static readonly РазделыУчетаДляВводаОстатков ГруппыОСНалоговыйУчет = new РазделыУчетаДляВводаОстатков{Name= "ГруппыОСНалоговыйУчет",Synonym="(не используется) Группы основных средств (налоговый учет до 01.04.2011)",Comment=""};
    }
}
