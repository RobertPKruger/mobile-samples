// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace BluetoothLEExplorer.iOS.UI.Screens.Scanner.DeviceDetails
{
	partial class DeviceDetailsScreen
	{
		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		UIKit.UITableView ServicesTableView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ServicesTableView != null) {
				ServicesTableView.Dispose ();
				ServicesTableView = null;
			}
		}
	}
}
