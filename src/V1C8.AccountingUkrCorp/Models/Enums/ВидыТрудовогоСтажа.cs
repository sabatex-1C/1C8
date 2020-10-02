using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыТрудовогоСтажа", Comment = "", Synonym = "Виды трудового стажа")]
    public class ВидыТрудовогоСтажа:EnumItem
    {
        public static readonly ВидыТрудовогоСтажа ОбщийТрудовойСтаж = new ВидыТрудовогоСтажа{Name= "ОбщийТрудовойСтаж",Synonym="Общий трудовой стаж",Comment=""};
        public static readonly ВидыТрудовогоСтажа ТерриториальныеУсловия = new ВидыТрудовогоСтажа{Name= "ТерриториальныеУсловия",Synonym="Территориальные условия",Comment=""};
        public static readonly ВидыТрудовогоСтажа ОсобыеУсловияТруда = new ВидыТрудовогоСтажа{Name= "ОсобыеУсловияТруда",Synonym="Особые условия труда",Comment=""};
        public static readonly ВидыТрудовогоСтажа ВыслугаЛет = new ВидыТрудовогоСтажа{Name= "ВыслугаЛет",Synonym="Выслуга лет",Comment=""};
    }
}
