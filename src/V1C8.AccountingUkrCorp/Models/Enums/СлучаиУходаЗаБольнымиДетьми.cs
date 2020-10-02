using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СлучаиУходаЗаБольнымиДетьми", Comment = "", Synonym = "Случаи ухода за больными детьми")]
    public class СлучаиУходаЗаБольнымиДетьми:EnumItem
    {
        public static readonly СлучаиУходаЗаБольнымиДетьми ПоУходуДо7миЛетАмбулаторно = new СлучаиУходаЗаБольнымиДетьми{Name= "ПоУходуДо7миЛетАмбулаторно",Synonym="(09) До 7-ми лет, амбулаторно",Comment="с 1.1.2007"};
        public static readonly СлучаиУходаЗаБольнымиДетьми ПоУходуДо7миЛетВСтационаре = new СлучаиУходаЗаБольнымиДетьми{Name= "ПоУходуДо7миЛетВСтационаре",Synonym="(09) До 7-ми лет, в стационаре",Comment="с 1.1.2007"};
        public static readonly СлучаиУходаЗаБольнымиДетьми ПоУходуДо7миЛетПриОсобомЗаболеванииАмбулаторно = new СлучаиУходаЗаБольнымиДетьми{Name= "ПоУходуДо7миЛетПриОсобомЗаболеванииАмбулаторно",Synonym="(12) До 7-ми лет, амбулаторно, заболевание включено в Перечень",Comment=""};
        public static readonly СлучаиУходаЗаБольнымиДетьми ПоУходуДо7миЛетПриОсобомЗаболеванииВСтационаре = new СлучаиУходаЗаБольнымиДетьми{Name= "ПоУходуДо7миЛетПриОсобомЗаболеванииВСтационаре",Synonym="(12) До 7-ми лет, в стационаре, при заболевании, включенном в Перечень",Comment=""};
        public static readonly СлучаиУходаЗаБольнымиДетьми ПоУходуДо15тиЛетАмбулаторно = new СлучаиУходаЗаБольнымиДетьми{Name= "ПоУходуДо15тиЛетАмбулаторно",Synonym="(09) От 7 до 15-ти лет, амбулаторно",Comment=""};
        public static readonly СлучаиУходаЗаБольнымиДетьми ПоУходуДо15тиЛетВСтационаре = new СлучаиУходаЗаБольнымиДетьми{Name= "ПоУходуДо15тиЛетВСтационаре",Synonym="(09) От 7 до 15-ти лет, в стационаре",Comment=""};
        public static readonly СлучаиУходаЗаБольнымиДетьми ПоУходуЗаРебенкомИнвалидомАмбулаторно = new СлучаиУходаЗаБольнымиДетьми{Name= "ПоУходуЗаРебенкомИнвалидомАмбулаторно",Synonym="(13) Инвалидом до 18-ти лет, амбулаторно (до 2015 года - до 15-ти лет)",Comment=""};
        public static readonly СлучаиУходаЗаБольнымиДетьми ПоУходуЗаРебенкомИнвалидомВСтационаре = new СлучаиУходаЗаБольнымиДетьми{Name= "ПоУходуЗаРебенкомИнвалидомВСтационаре",Synonym="(13) Инвалидом до 18-ти лет, в стационаре (до 2015 года - до 15-ти лет)",Comment=""};
        public static readonly СлучаиУходаЗаБольнымиДетьми ПоУходуДо15тиЛетПриПоствакцинальномОсложненииАмбулаторно = new СлучаиУходаЗаБольнымиДетьми{Name= "ПоУходуДо15тиЛетПриПоствакцинальномОсложненииАмбулаторно",Synonym="(14) До 18-ти лет при поствакцинальном осложнении, амбулаторно (до 2015 года - до 15-ти лет)",Comment=""};
        public static readonly СлучаиУходаЗаБольнымиДетьми ПоУходуДо15тиЛетПриПоствакцинальномОсложненииВСтационаре = new СлучаиУходаЗаБольнымиДетьми{Name= "ПоУходуДо15тиЛетПриПоствакцинальномОсложненииВСтационаре",Synonym="(14) До 18-ти лет при поствакцинальном осложнении, в стационаре (до 2015 года - до 15-ти лет)",Comment=""};
        public static readonly СлучаиУходаЗаБольнымиДетьми ПоУходуДо15тиЛетПриВИЧ = new СлучаиУходаЗаБольнымиДетьми{Name= "ПоУходуДо15тиЛетПриВИЧ",Synonym="(15) До 18-ти лет, ВИЧ-инфицированным, в стационаре (до 2015 года - до 15-ти лет)",Comment=""};
    }
}
