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
    [Table("KlassyfykatorEdynytsYzmerenyia")]
    [Description1C8(Name = "КлассификаторЕдиницИзмерения", Comment = "(Общ)", Synonym = "Классификатор единиц измерения")]
    public class КлассификаторЕдиницИзмерения:CatalogItem
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
    [Description1C8(Name = "НаименованиеПолное", Comment = "(Общ)", Synonym = "Полное наименование")]
    [StringLength(100)]
    public string НаименованиеПолное {get; set;}
    #endregion реквізити
    }
}
