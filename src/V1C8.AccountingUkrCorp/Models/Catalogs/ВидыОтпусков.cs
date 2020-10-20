using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Catalogs
{
    [Table("VydyOtpuskov")]
    [Description1C8(Name = "ВидыОтпусков", Comment = "", Synonym = "Виды отпусков")]
    public class ВидыОтпусков:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ОтпускЯвляетсяЕжегодным", Comment = "", Synonym = "Отпуск является ежегодным")]
        public bool ОтпускЯвляетсяЕжегодным {get; set;}
        [Description1C8(Name = "СпособРасчетаОтпуска", Comment = "", Synonym = "Способ расчета отпуска")]
        public Enums.СпособыРасчетаОтпуска СпособРасчетаОтпуска {get; set;}
        [Description1C8(Name = "ПредоставлятьОтпускВсемСотрудникам", Comment = "", Synonym = "Предоставлять отпуск всем сотрудникам")]
        public bool ПредоставлятьОтпускВсемСотрудникам {get; set;}
        [Description1C8(Name = "КоличествоДнейВГод", Comment = "", Synonym = "Количество дней в год")]
        // Format 2.0
        public long КоличествоДнейВГод {get; set;}
        [Description1C8(Name = "НаименованиеПолное", Comment = "", Synonym = "Наименование для печати")]
        [StringLength(250)]
        public string НаименованиеПолное {get; set;}
        [Description1C8(Name = "ОтпускБезОплаты", Comment = "", Synonym = "Отпуск без оплаты")]
        public bool ОтпускБезОплаты {get; set;}
        [Description1C8(Name = "УдалитьИдентификаторОбъекта", Comment = "", Synonym = "Удалить идентификатор объекта")]
        [StringLength(256)]
        public string УдалитьИдентификаторОбъекта {get; set;}
        [Description1C8(Name = "Недействителен", Comment = "", Synonym = "Отпуск больше не используется")]
        public bool Недействителен {get; set;}
        [Description1C8(Name = "ОсновнойОтпуск", Comment = "", Synonym = "Основной отпуск")]
        public bool ОсновнойОтпуск {get; set;}
        [Description1C8(Name = "ХарактерЗависимостиДнейОтпуска", Comment = "", Synonym = "зависит от стажа")]
        public Enums.ХарактерЗависимостиКоличестваДнейОтпуска ХарактерЗависимостиДнейОтпуска {get; set;}
        [Description1C8(Name = "ВидСтажа", Comment = "", Synonym = "Вид стажа")]
        public Catalogs.ВидыСтажа ВидСтажа {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ШкалаОценкиСтажа", Comment = "", Synonym = "Шкала оценки стажа")]
        public List<ВидыОтпусков_ШкалаОценкиСтажа> ВидыОтпусковШкалаОценкиСтажа {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ШкалаОценкиСтажа", Comment = "", Synonym = "Шкала оценки стажа")]
    [Table("VydyOtpuskov_ShkalaOtsenkyStazha")]
    public class ВидыОтпусков_ШкалаОценкиСтажа
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ВерхняяГраницаИнтервалаСтажа", Comment = "", Synonym = "Верхняя граница интервала стажа")]
        // Format 3.0
        public long ВерхняяГраницаИнтервалаСтажа {get; set;}
        [Description1C8(Name = "КоличествоДнейВГод", Comment = "", Synonym = "Количество дней в год")]
        // Format 2.0
        public long КоличествоДнейВГод {get; set;}
    }
}
