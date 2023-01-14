Your bundle config has been updated with table-custom.css 

bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/table-custom.css"); 

Also we have updated bootstrap bundle in Bundle.Config File.

If you have any error regarding Newtonsoft.Json Just update all of the packages in nuget.

you can use the Grid after writting below code in controller get method. 

IndexModel model = new IndexModel();
public ActionResult index() 
{ 
	TryUpdateModel(model); 
	//Retrieve data from database 
	var data = GenericGridCall<tableClassName>.ListView(model.PageSize, x => x.CityName, model.Search, model.orderBy, model.orderByAsc, model.page); 
	//in case any customization required make changes in below function or use overloaded version else use default as below 
	PagedData<tblCity>.ReturnCustomizeData(data, model.PageSize); 
	return ! model.IsPostBack ? View((dynamic)data) : PartialView("DataTable", data); 
} 

you can view the Grid after writting below code in view. 

@model dynamic  
<div class="right_col" role="main"> 
	@{ Html.RenderPartial("DataTableView", (object)Model); }  
</div> 

Hope you will enjoye.

Cheers!!!
