using System;
using System.Linq;
using System.Collections.Generic;
	
namespace CustomerMaintain.Models.Main
{   
	public  class 客戶資料Repository : EFRepository<客戶資料>, I客戶資料Repository
	{
	    public override IQueryable<客戶資料> All()
	    {
	        return base.All().Where(p => p.是否已刪除 == false);
	    }

	    public 客戶資料 Find(int id)
	    {
	        return this.All().FirstOrDefault(p => p.Id == id);
	    }

	    public override void Delete(客戶資料 entity)
	    {
	        entity.是否已刪除 = true;
	        //base.Delete(entity);
	    }

	    public override void Add(客戶資料 entity)
	    {
	        base.Add(entity);
	    }
	}

	public  interface I客戶資料Repository : IRepository<客戶資料>
	{

	}
}