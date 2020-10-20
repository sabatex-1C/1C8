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
    [Table("ObrazovanyeFyzycheskykhLyts")]
    [Description1C8(Name = "ОбразованиеФизическихЛиц", Comment = "", Synonym = "Образование физических лиц")]
    public class ОбразованиеФизическихЛиц:EnumItem
    {
    #region Стандартні реквізити
    public Guid Id {get; set;}
    public bool IsFolder {get; set;}
    public bool DeletionMark {get; set;}
    public bool Predefined {get; set;}
    public string Code {get; set;}
    public string Description {get; set;}
    public Guid? Parent {get; set;}
    public Guid? Owner {get; set;}
    #endregion Стандартні реквізити
    #region реквізити
    [Description1C8(Name = "ОсновноеОбразование", Comment = "", Synonym = "Основное образование")]
    public bool ОсновноеОбразование {get; set;}
    [Description1C8(Name = "ВидОбразования", Comment = "", Synonym = "Вид образования")]
    public DBNull ВидОбразования {get; set;}
    [Description1C8(Name = "ВидПослевузовскогоОбразования", Comment = "", Synonym = "Вид послевузовского образования")]
    public DBNull ВидПослевузовскогоОбразования {get; set;}
    [Description1C8(Name = "УчебноеЗаведение", Comment = "", Synonym = "Учебное заведение")]
    public DBNull УчебноеЗаведение {get; set;}
    [Description1C8(Name = "Специальность", Comment = "", Synonym = "Специальность")]
    public DBNull Специальность {get; set;}
    [Description1C8(Name = "ВидДокумента", Comment = "", Synonym = "Вид документа")]
    public DBNull ВидДокумента {get; set;}
    [Description1C8(Name = "Серия", Comment = "", Synonym = "Серия")]
    [StringLength(25)]
    public string Серия {get; set;}
    [Description1C8(Name = "Номер", Comment = "", Synonym = "Номер")]
    [StringLength(50)]
    public string Номер {get; set;}
    [Description1C8(Name = "ДатаВыдачи", Comment = "", Synonym = "Дата выдачи")]
    public DateTime ДатаВыдачи {get; set;}
    [Description1C8(Name = "Квалификация", Comment = "", Synonym = "Квалификация")]
    [StringLength(100)]
    public string Квалификация {get; set;}
    [Description1C8(Name = "Начало", Comment = "", Synonym = "Начало")]
    public DateTime Начало {get; set;}
    [Description1C8(Name = "Окончание", Comment = "", Synonym = "Окончание")]
    public DateTime Окончание {get; set;}
    [Description1C8(Name = "НаименованиеКурса", Comment = "", Synonym = "Наименование курса")]
    [StringLength(100)]
    public string НаименованиеКурса {get; set;}
    [Description1C8(Name = "КоличествоЧасов", Comment = "", Synonym = "Количество часов")]
    public DBNull КоличествоЧасов {get; set;}
    [Description1C8(Name = "ВидДополнительногоОбучения", Comment = "", Synonym = "Вид дополнительного обучения")]
    public DBNull ВидДополнительногоОбучения {get; set;}
    [Description1C8(Name = "Основание", Comment = "", Synonym = "Основание")]
    [StringLength(250)]
    public string Основание {get; set;}
    [Description1C8(Name = "УдалитьДокументОснование", Comment = "", Synonym = "(не используется) документ основание")]
    [StringLength(10)]
    public string УдалитьДокументОснование {get; set;}
    [Description1C8(Name = "ФормаОбучения", Comment = "", Synonym = "Форма обучения")]
    public DBNull ФормаОбучения {get; set;}
    #endregion реквізити
    }
}
