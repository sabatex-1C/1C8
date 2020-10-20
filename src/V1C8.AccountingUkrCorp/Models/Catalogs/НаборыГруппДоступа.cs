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
    [Table("NaboryHruppDostupa")]
    [Description1C8(Name = "НаборыГруппДоступа", Comment = "", Synonym = "Наборы групп доступа")]
    public class НаборыГруппДоступа:EnumItem
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
    [Description1C8(Name = "ДляВнешнихПользователей", Comment = "", Synonym = "Для внешних пользователей")]
    public bool ДляВнешнихПользователей {get; set;}
    [Description1C8(Name = "ТипЭлементовНабора", Comment = "", Synonym = "Тип элементов набора")]
    public DBNull ТипЭлементовНабора {get; set;}
    [Description1C8(Name = "НеИспользуетсяС", Comment = "", Synonym = "Не используется с")]
    public DateTime НеИспользуетсяС {get; set;}
    [Description1C8(Name = "Пользователь", Comment = "", Synonym = "Пользователь")]
    public DBNull Пользователь {get; set;}
    [Description1C8(Name = "РазрешенныйНаборГруппДоступа", Comment = "", Synonym = "Разрешенный набор групп доступа")]
    public DBNull РазрешенныйНаборГруппДоступа {get; set;}
    [Description1C8(Name = "РазрешенныйНаборГруппПользователей", Comment = "", Synonym = "Разрешенный набор групп пользователей")]
    public DBNull РазрешенныйНаборГруппПользователей {get; set;}
    [Description1C8(Name = "НовыйНаборГруппДоступа", Comment = "", Synonym = "Новый набор групп доступа")]
    public DBNull НовыйНаборГруппДоступа {get; set;}
    [Description1C8(Name = "НовыйНаборГруппПользователей", Comment = "", Synonym = "Новый набор групп пользователей")]
    public DBNull НовыйНаборГруппПользователей {get; set;}
    #endregion реквізити
    }
}
