using System;
using System.Linq;
using System.Collections.Generic;
	
namespace CustomerMaintain.Models.Main
{   
	public  class 客戶資料狀況Repository : EFRepository<客戶資料狀況>, I客戶資料狀況Repository
	{

	}

	public  interface I客戶資料狀況Repository : IRepository<客戶資料狀況>
	{

	}
}