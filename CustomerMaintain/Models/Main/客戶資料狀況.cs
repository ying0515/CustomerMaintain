//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomerMaintain.Models.Main
{
    using System;
    using System.Collections.Generic;
    
    public partial class 客戶資料狀況
    {
        public int Id { get; set; }
        public string 客戶名稱 { get; set; }
        public Nullable<int> 聯絡人數量 { get; set; }
        public Nullable<int> 銀行帳戶數量 { get; set; }
        public Nullable<bool> 是否已刪除 { get; set; }
    }
}
