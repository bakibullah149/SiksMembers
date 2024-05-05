using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SiksMembers.Pages
{
	public class MembersModel : PageModel
	{
		public List<MemberListModel> SIKSMembers18 = new List<MemberListModel>()
		{
			new MemberListModel() {ImageTitle="tanzim_18", Name="Tanzim Afdol", Batch=2018, Department="EEE", PhoneNumber=01914227001},
			new MemberListModel() {ImageTitle="abdullah_18", Name="Muhammad Abu Abdullah", Batch=2018, Department="EEE", PhoneNumber=01849483998},
			new MemberListModel() {ImageTitle="Ali_18", Name="Ali Alnaeem", Batch=2018, Department="EEE", PhoneNumber=01824484712},
			new MemberListModel() {ImageTitle="Riyad_18", Name="Tawsif Ahmed Riyad", Batch=2018, Department="BTM", PhoneNumber=01521335275},
			new MemberListModel() {ImageTitle="shuvo_18", Name="Riaz Mahmud Shuvo", Batch=2018, Department="BTM", PhoneNumber=01864220847},
			new MemberListModel() {ImageTitle="Sakib_18", Name="Mohammad Sadman Sakib", Batch=2018, Department="EEE", PhoneNumber=01781464286},
			new MemberListModel() {ImageTitle="Nahin_18", Name="AK Nahin", Batch=2018, Department="EEE", PhoneNumber=01837505893},
			new MemberListModel() {ImageTitle="farshid_18", Name="Farshid Khan", Batch=2018, Department="CEE", PhoneNumber=01879838829},
			new MemberListModel() {ImageTitle="nss_18", Name="Nurus Salamat Siam", Batch=2018, Department="ME", PhoneNumber=01782643060},
		};
		public List<MemberListModel> SIKSMembers19 = new List<MemberListModel>() 
		{
			new MemberListModel() {ImageTitle="bari_19", Name="Redwanul Bari", Batch=2019, Department="EEE", PhoneNumber=01313994050},
			new MemberListModel() {ImageTitle="fahim_faisal", Name="Fahim Faisal", Batch=2019, Department="CEE", PhoneNumber=01310515675},
			new MemberListModel() {ImageTitle="Aiman_19", Name="Aiman Bhuiyan", Batch=2019, Department="BTM", PhoneNumber=01616364110},
			new MemberListModel() {ImageTitle="Rakin_19", Name="A. K. M. Rakinuzzaman", Batch=2019, Department="CSE", PhoneNumber=01785232326},
			new MemberListModel() {ImageTitle="spondon_19", Name="Fazle Rabbi Spondon", Batch=2019, Department="CSE", PhoneNumber=01791073847},
			new MemberListModel() {ImageTitle="Sakib_19", Name="Sadman Sakib", Batch=2019, Department="SWE", PhoneNumber=01724764925},
			new MemberListModel() {ImageTitle="Nabil_19", Name="Abdullah Al Nabil", Batch=2019, Department="IPE", PhoneNumber=01744157066},
			new MemberListModel() {ImageTitle="auyon_19", Name="MD Omum Siddique Auyon", Batch=2019, Department="BTM", PhoneNumber=01533834688},
			new MemberListModel() {ImageTitle="Arafat_19", Name="Arafat Khan", Batch=2019, Department="BTM", PhoneNumber=01306990701},
			new MemberListModel() {ImageTitle="Asif_Adib_19", Name="Asif Ur Rahman Adib", Batch=2019, Department="EEE", PhoneNumber=01774449918},
			new MemberListModel() {ImageTitle="jin_19", Name="Jawadul Islam Naveed", Batch=2019, Department="BTM", PhoneNumber=01831010970},
			new MemberListModel() {ImageTitle="Keats_19", Name="Aseer Imad Keats", Batch=2019, Department="EEE", PhoneNumber=01984966474},
			new MemberListModel() {ImageTitle="abrar_19", Name="Abrar Kabir", Batch=2019, Department="EEE", PhoneNumber=01707835803},
		};
		public List<MemberListModel> SIKSMembers20 = new List<MemberListModel>() { };
		public List<MemberListModel> SIKSMembers21 = new List<MemberListModel>() { };


		public void OnGet()
		{
			ViewData["SIKSMembers18"] = SIKSMembers18;
			ViewData["SIKSMembers19"] = SIKSMembers19;
			ViewData["SIKSMembers20"] = SIKSMembers20;
			ViewData["SIKSMembers21"] = SIKSMembers21;
		}
	}
}
