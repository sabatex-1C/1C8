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
    [Table("PostavliaemyeRasshyrenyia")]
    [Description1C8(Name = "ПоставляемыеРасширения", Comment = "", Synonym = "Поставляемые расширения")]
    public class ПоставляемыеРасширения
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
    [Description1C8(Name = "Имя", Comment = "", Synonym = "Имя")]
    [StringLength(260)]
    public string Имя {get; set;}
    [Description1C8(Name = "Версия", Comment = "", Synonym = "Версия")]
    [StringLength(18)]
    public string Версия {get; set;}
    [Description1C8(Name = "ХранилищеРасширения", Comment = "", Synonym = "Хранилище расширения")]
    // Сховище значень
    public byte[] ХранилищеРасширения {get; set;}
    [Description1C8(Name = "Информация", Comment = "", Synonym = "Информация")]
    [StringLength(1024)]
    public string Информация {get; set;}
    [Description1C8(Name = "ИдентификаторВерсии", Comment = "", Synonym = "Идентификатор версии")]
    public Guid ИдентификаторВерсии {get; set;}
    [Description1C8(Name = "Отключено", Comment = "", Synonym = "Отключено")]
    public bool Отключено {get; set;}
    [Description1C8(Name = "ПричинаОтключения", Comment = "", Synonym = "Причина отключения")]
    public Enums.ПричиныОтключенияРасширенийВМоделиСервиса ПричинаОтключения {get; set;}
    #endregion реквізити
    }
}
