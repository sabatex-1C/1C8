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
    [Table("VersyyFailov")]
    [Description1C8(Name = "ВерсииФайлов", Comment = "", Synonym = "Версии файлов")]
    public class ВерсииФайлов:EnumItem
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
    [Description1C8(Name = "Автор", Comment = "", Synonym = "Автор")]
    public DBNull Автор {get; set;}
    [Description1C8(Name = "ДатаМодификацииУниверсальная", Comment = "", Synonym = "Дата изменения (универсальное время)")]
    public DateTime ДатаМодификацииУниверсальная {get; set;}
    [Description1C8(Name = "ДатаМодификацииФайла", Comment = "", Synonym = "Дата изменения (местное время)")]
    public DateTime ДатаМодификацииФайла {get; set;}
    [Description1C8(Name = "ДатаСоздания", Comment = "", Synonym = "Дата создания")]
    public DateTime ДатаСоздания {get; set;}
    [Description1C8(Name = "УдалитьЗашифрован", Comment = "", Synonym = "(не используется) Зашифрована")]
    public bool УдалитьЗашифрован {get; set;}
    [Description1C8(Name = "ИндексКартинки", Comment = "", Synonym = "Индекс значка")]
    public DBNull ИндексКартинки {get; set;}
    [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    [Description1C8(Name = "НомерВерсии", Comment = "", Synonym = "Номер")]
    public DBNull НомерВерсии {get; set;}
    [Description1C8(Name = "УдалитьПодписанЭП", Comment = "", Synonym = "(не используется) Подписана электронно")]
    public bool УдалитьПодписанЭП {get; set;}
    [Description1C8(Name = "ПолноеНаименование", Comment = "", Synonym = "Полное наименование")]
    [StringLength(256)]
    public string ПолноеНаименование {get; set;}
    [Description1C8(Name = "ПутьКФайлу", Comment = "", Synonym = "Путь к файлу")]
    public string ПутьКФайлу {get; set;}
    [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер (байт)")]
    public DBNull Размер {get; set;}
    [Description1C8(Name = "Расширение", Comment = "", Synonym = "Расширение")]
    [StringLength(10)]
    public string Расширение {get; set;}
    [Description1C8(Name = "РодительскаяВерсия", Comment = "", Synonym = "Родительская версия")]
    public DBNull РодительскаяВерсия {get; set;}
    [Description1C8(Name = "СтатусИзвлеченияТекста", Comment = "", Synonym = "Статус извлечения текста")]
    public DBNull СтатусИзвлеченияТекста {get; set;}
    [Description1C8(Name = "ТекстХранилище", Comment = "", Synonym = "Текст")]
    public DBNull ТекстХранилище {get; set;}
    [Description1C8(Name = "ТипХраненияФайла", Comment = "", Synonym = "Тип хранения версии файла")]
    public DBNull ТипХраненияФайла {get; set;}
    [Description1C8(Name = "Том", Comment = "", Synonym = "Том")]
    public DBNull Том {get; set;}
    [Description1C8(Name = "ФайлХранилище", Comment = "", Synonym = "Временное хранилище версии файла")]
    public DBNull ФайлХранилище {get; set;}
    #endregion реквізити
    }
}
