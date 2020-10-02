using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыРасчетаНачислений", Comment = "", Synonym = "Способы расчета начислений")]
    public class СпособыРасчетаНачислений:EnumItem
    {
        public static readonly СпособыРасчетаНачислений ПоМесячнойТарифнойСтавкеПоЧасам = new СпособыРасчетаНачислений{Name= "ПоМесячнойТарифнойСтавкеПоЧасам",Synonym="По месячной тарифной ставке по часам",Comment="(Общ)"};
        public static readonly СпособыРасчетаНачислений ПроизвольнаяФормула = new СпособыРасчетаНачислений{Name= "ПроизвольнаяФормула",Synonym="Произвольная формула",Comment=""};
        public static readonly СпособыРасчетаНачислений ПоМесячнойТарифнойСтавкеПоДням = new СпособыРасчетаНачислений{Name= "ПоМесячнойТарифнойСтавкеПоДням",Synonym="По месячной тарифной ставке",Comment="(Общ)"};
        public static readonly СпособыРасчетаНачислений ПоДневнойТарифнойСтавке = new СпособыРасчетаНачислений{Name= "ПоДневнойТарифнойСтавке",Synonym="По дневной тарифной ставке",Comment="(Общ)"};
        public static readonly СпособыРасчетаНачислений ПоЧасовойТарифнойСтавке = new СпособыРасчетаНачислений{Name= "ПоЧасовойТарифнойСтавке",Synonym="По часовой тарифной ставке",Comment="(Общ)"};
        public static readonly СпособыРасчетаНачислений ФиксированнойСуммой = new СпособыРасчетаНачислений{Name= "ФиксированнойСуммой",Synonym="Фиксированной суммой",Comment="(Общ)"};
        public static readonly СпособыРасчетаНачислений Процентом = new СпособыРасчетаНачислений{Name= "Процентом",Synonym="Процентом",Comment="(Общ)"};
        public static readonly СпособыРасчетаНачислений ИндексацияЗарплаты = new СпособыРасчетаНачислений{Name= "ИндексацияЗарплаты",Synonym="Индексация зарплаты",Comment=""};
        public static readonly СпособыРасчетаНачислений ДоплатаДоСреднегоЗаработка = new СпособыРасчетаНачислений{Name= "ДоплатаДоСреднегоЗаработка",Synonym="Доплата до среднего заработка",Comment=""};
        public static readonly СпособыРасчетаНачислений ДоплатаДоСреднегоЗаработкаФСС = new СпособыРасчетаНачислений{Name= "ДоплатаДоСреднегоЗаработкаФСС",Synonym="Доплата до среднего заработка ФСС",Comment=""};
        public static readonly СпособыРасчетаНачислений ОплатаБольничного = new СпособыРасчетаНачислений{Name= "ОплатаБольничного",Synonym="Оплата больничного",Comment=""};
        public static readonly СпособыРасчетаНачислений ОплатаОтпускаПоКалендарнымДням = new СпособыРасчетаНачислений{Name= "ОплатаОтпускаПоКалендарнымДням",Synonym="Оплата отпуска по календарным дням",Comment=""};
        public static readonly СпособыРасчетаНачислений ОплатаОтпускаПоШестидневке = new СпособыРасчетаНачислений{Name= "ОплатаОтпускаПоШестидневке",Synonym="По среднему заработку для отпуска при расчете из рабочих дней",Comment=""};
        public static readonly СпособыРасчетаНачислений ОплатаПростоя = new СпособыРасчетаНачислений{Name= "ОплатаПростоя",Synonym="Оплата простоя",Comment=""};
        public static readonly СпособыРасчетаНачислений ПособиеПоУходуЗаРебенкомДоПолутораЛет = new СпособыРасчетаНачислений{Name= "ПособиеПоУходуЗаРебенкомДоПолутораЛет",Synonym="Пособие по уходу за ребенком до 1.5 лет",Comment=""};
        public static readonly СпособыРасчетаНачислений ДоплатаДоСохраняемогоДенежногоСодержанияЗаДниБолезни = new СпособыРасчетаНачислений{Name= "ДоплатаДоСохраняемогоДенежногоСодержанияЗаДниБолезни",Synonym="Доплата до сохраняемого денежного содержания за дни болезни",Comment=""};
        public static readonly СпособыРасчетаНачислений ДоплатаДоМЗП = new СпособыРасчетаНачислений{Name= "ДоплатаДоМЗП",Synonym="Доплата до МЗП",Comment=""};
        public static readonly СпособыРасчетаНачислений ИндексацияСоциальныхНачислений = new СпособыРасчетаНачислений{Name= "ИндексацияСоциальныхНачислений",Synonym="Индексация социальных начислений",Comment=""};
        public static readonly СпособыРасчетаНачислений НулеваяСумма = new СпособыРасчетаНачислений{Name= "НулеваяСумма",Synonym="Нулевая сумма",Comment=""};
        public static readonly СпособыРасчетаНачислений Индексация = new СпособыРасчетаНачислений{Name= "Индексация",Synonym="Индексация",Comment=""};
    }
}
