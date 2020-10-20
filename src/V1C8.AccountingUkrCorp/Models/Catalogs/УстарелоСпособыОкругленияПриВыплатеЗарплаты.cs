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
    [Table("UstareloSposobyOkruhlenyiaPryVyplateZarplaty")]
    [Description1C8(Name = "УстарелоСпособыОкругленияПриВыплатеЗарплаты", Comment = "", Synonym = "ѳ(устарело) Способы округления при выплате")]
    public class УстарелоСпособыОкругленияПриВыплатеЗарплаты:CatalogItem
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
    [Description1C8(Name = "Точность", Comment = "", Synonym = "Точность")]
    // Format 7.2
    public decimal Точность {get; set;}
    #endregion реквізити
    }
}
