using System;
using System.Linq;
using System.Collections.Generic;
	
namespace CustomerMaintain.Models.Main
{   
	public  class 客戶資料狀況Repository : EFRepository<客戶資料狀況>, I客戶資料狀況Repository
	{
	    public override IQueryable<客戶資料狀況> All()
	    {
	        return base.All().Where(p => p.是否已刪除 == false);
	    }
	}

	public  interface I客戶資料狀況Repository : IRepository<客戶資料狀況>
	{

	}
}