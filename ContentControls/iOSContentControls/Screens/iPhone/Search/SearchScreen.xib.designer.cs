// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example_ContentControls.Screens.iPhone.Search {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[Foundation.Register("SearchScreen")]
	public partial class SearchScreen {
		
		private UIKit.UIView __mt_view;
		
		private UIKit.UISearchBar __mt_srchMain;
		
		private UIKit.UITableView __mt_tblMain;
		
		#pragma warning disable 0169
		[Foundation.Connect("view")]
		private UIKit.UIView view {
			get {
				this.__mt_view = ((UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[Foundation.Connect("srchMain")]
		private UIKit.UISearchBar srchMain {
			get {
				this.__mt_srchMain = ((UIKit.UISearchBar)(this.GetNativeField("srchMain")));
				return this.__mt_srchMain;
			}
			set {
				this.__mt_srchMain = value;
				this.SetNativeField("srchMain", value);
			}
		}
		
		[Foundation.Connect("tblMain")]
		private UIKit.UITableView tblMain {
			get {
				this.__mt_tblMain = ((UIKit.UITableView)(this.GetNativeField("tblMain")));
				return this.__mt_tblMain;
			}
			set {
				this.__mt_tblMain = value;
				this.SetNativeField("tblMain", value);
			}
		}
	}
}
