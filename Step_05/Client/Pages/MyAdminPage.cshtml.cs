namespace Client.Pages;

[Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")]
public class MyAdminPageModel :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public MyAdminPageModel() : base()
	{
	}

	public void OnGet()
	{
	}
}