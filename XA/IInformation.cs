using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Xamarin.Device
{
	public partial interface IInformation
	{
		// Android
		string Device();

		string Manufacturer();

		string Brand();

		string Product();
		
		string Model();
		
		string Serial();
		
		string UDID();
		
		string PhoneNumber();
		
		string DeviceIdIMEI();
		
		string MACAddress();
		
		string MACAddressWiFi();
		
		string MACAddressBluetooth();
		
		string BluetoothLocalName();
		
	}
}