using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SiksMembers.Pages.Member
{
	[BindProperties(SupportsGet = true)]
	public class MemberModel : PageModel
	{
		public string ImageTitle { get; set; }
		public string Name { get; set; }
		public int Batch { get; set; }
		public string Department { get; set; }
		public double PhoneNumber { get; set; }
		public void OnGet()
		{
		}
	}
}
