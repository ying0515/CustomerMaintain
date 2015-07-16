using System.Linq;
using Antlr.Runtime;

namespace CustomerMaintain.Models.Main
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(客戶聯絡人MetaData))]
    public partial class 客戶聯絡人: IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!string.IsNullOrEmpty(Email))
            {
                using (客戶資料Entities db = new 客戶資料Entities())
                {
                    var data = db.客戶聯絡人.FirstOrDefault(p => p.客戶Id == 客戶Id && p.Email == Email);
                    if (data != null)
                        yield return new ValidationResult("此客戶Email不能重複!", new[] { "Email" });
                }
            }
        }
    
    }
    
    public partial class 客戶聯絡人MetaData
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int 客戶Id { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string 職稱 { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string 姓名 { get; set; }
        
        [StringLength(250, ErrorMessage="欄位長度不得大於 250 個字元")]
        [Required]
        [DataType(DataType.EmailAddress)]
        //[Remote("CheckUserMail", "CustContact", AdditionalFields = "客戶Id", ErrorMessage = "此客戶Email不能重複!")]
        public string Email { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [RegularExpression(@"\d{4}-\d{6}", ErrorMessage = "手機格式錯誤")]
        public string 手機 { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        public string 電話 { get; set; }
        public Nullable<bool> 是否已刪除 { get; set; }
    
        public virtual 客戶資料 客戶資料 { get; set; }

    }
}
