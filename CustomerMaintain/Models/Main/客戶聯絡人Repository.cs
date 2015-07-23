using System;
using System.Linq;
using System.Collections.Generic;
	
namespace CustomerMaintain.Models.Main
{   
	public  class 客戶聯絡人Repository : EFRepository<客戶聯絡人>, I客戶聯絡人Repository
	{
	    public override IQueryable<客戶聯絡人> All()
	    {
	        return base.All().Where(p => p.是否已刪除 == false && p.客戶資料.是否已刪除 == false);
	    }

	    public 客戶聯絡人 Find(int id)
	    {
	        return this.All().FirstOrDefault(p => p.Id == id);
	    }

	    public override void Delete(客戶聯絡人 entity)
	    {
	        entity.是否已刪除 = true;
	        //base.Delete(entity);
	    }

	    public override void Add(客戶聯絡人 entity)
	    {
	        base.Add(entity);
	    }
	}

	public  interface I客戶聯絡人Repository : IRepository<客戶聯絡人>
	{

	}
}