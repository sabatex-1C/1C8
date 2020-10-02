using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РазделыУчетаДляКорректировкиОстатковНКУна01042011", Comment = "", Synonym = "Разделы учета для корректировки остатков в связи с вступлением в силу норм НКУ (01.04.2011)")]
    public class РазделыУчетаДляКорректировкиОстатковНКУна01042011:EnumItem
    {
        public static readonly РазделыУчетаДляКорректировкиОстатковНКУна01042011 ОсновныеСредства = new РазделыУчетаДляКорректировкиОстатковНКУна01042011{Name= "ОсновныеСредства",Synonym="Основные средства (счета 10, 11, 13)",Comment=""};
        public static readonly РазделыУчетаДляКорректировкиОстатковНКУна01042011 МалоценныеАктивыВЭксплуатации = new РазделыУчетаДляКорректировкиОстатковНКУна01042011{Name= "МалоценныеАктивыВЭксплуатации",Synonym="Малоценные активы в эксплуатации (счета 1112, 1122, 1322, МЦ)",Comment=""};
        public static readonly РазделыУчетаДляКорректировкиОстатковНКУна01042011 НематериальныеАктивы = new РазделыУчетаДляКорректировкиОстатковНКУна01042011{Name= "НематериальныеАктивы",Synonym="Нематериальные активы (счета 12, 133)",Comment=""};
        public static readonly РазделыУчетаДляКорректировкиОстатковНКУна01042011 КапитальныеИнвестиции = new РазделыУчетаДляКорректировкиОстатковНКУна01042011{Name= "КапитальныеИнвестиции",Synonym="Капитальные инвестиции (счета 151-154, 235, кроме 1521, 1531)",Comment=""};
        public static readonly РазделыУчетаДляКорректировкиОстатковНКУна01042011 ЗапасыСебестоимость = new РазделыУчетаДляКорректировкиОстатковНКУна01042011{Name= "ЗапасыСебестоимость",Synonym="Запасы по себестоимости (счета 1521, 1531, 201-205, 207-209, 221, 234, 25, 26, 27, 281, 284, 286, 289)",Comment=""};
        public static readonly РазделыУчетаДляКорректировкиОстатковНКУна01042011 ТранспортноЗаготовительныеРасходыНаОтдельныхСубсчетах = new РазделыУчетаДляКорректировкиОстатковНКУна01042011{Name= "ТранспортноЗаготовительныеРасходыНаОтдельныхСубсчетах",Synonym="Транспортно заготовительные расходы (200, 280)",Comment=""};
        public static readonly РазделыУчетаДляКорректировкиОстатковНКУна01042011 ЗапасыПереданные = new РазделыУчетаДляКорректировкиОстатковНКУна01042011{Name= "ЗапасыПереданные",Synonym="Запасы переданные (счета 206, 283)",Comment=""};
        public static readonly РазделыУчетаДляКорректировкиОстатковНКУна01042011 НезавершенноеПроизводство = new РазделыУчетаДляКорректировкиОстатковНКУна01042011{Name= "НезавершенноеПроизводство",Synonym="Незавершенное производство (счета 231–233, 24)",Comment=""};
        public static readonly РазделыУчетаДляКорректировкиОстатковНКУна01042011 ТоварыПоПродажнойЦене = new РазделыУчетаДляКорректировкиОстатковНКУна01042011{Name= "ТоварыПоПродажнойЦене",Synonym="Товары по продажной цене (счета 282, 285)",Comment=""};
        public static readonly РазделыУчетаДляКорректировкиОстатковНКУна01042011 РасходыБудущихПериодов = new РазделыУчетаДляКорректировкиОстатковНКУна01042011{Name= "РасходыБудущихПериодов",Synonym="Расходы будущих периодов (счет 39)",Comment=""};
    }
}
