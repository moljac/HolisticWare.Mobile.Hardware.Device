using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.UIKit;

namespace Xamarin.Device
{
	/// <summary>
	/// Information about Device (PhoneNumber Imei
	/// </summary>
	/// TODO:
	///		Check availalbity
	///			Mono.Unix.Native.Utsname in Mono.Posix.dll
	///			http://docs.go-mono.com/?link=T%3aMono.Unix.Native.Utsname%2f*
	///		
	public partial class Information
	{
		public string Device()
		{
			string device = null;

			if (UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone)
			{
				device = "Phone (iPhone or iPod)";
			}
			if (UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Pad)
			{
				device = "Pad";
			}

			// UIDevice.CurrentDevice.Battery
			// UIDeviceBatteryState
			
			string description = UIDevice.CurrentDevice.Description;
			string description_debug = UIDevice.CurrentDevice.DebugDescription;
			MonoTouch.Foundation.NSUuid identifier_for_vendor = UIDevice.CurrentDevice.IdentifierForVendor;
			string model = UIDevice.CurrentDevice.Model;
			string model_localized = UIDevice.CurrentDevice.LocalizedModel;
			string name = UIDevice.CurrentDevice.Name;
			string systemname = UIDevice.CurrentDevice.SystemName;
			string system_version = UIDevice.CurrentDevice.SystemVersion;

			return device;
		}

		public string Manufacturer()
		{
			string manufcturer = "Apple"; // he he or??
			
			return manufcturer;
		}

		public string Brand()
		{
			string brand = "Apple"; // he he or??

			return brand;
		}

		public string Product()
		{
			string product = null;

			return product;
		}

		public string Model()
		{
			string model = null;

			return model;
		}

		public string Serial()
		{
			string model = null;

			return model;
		}

		public string UDID()
		{
			string model = null;

			return model;
		}

		public string PhoneNumber()
		{
			string model = null;

			return model;
		}

		public string DeviceIdIMEI()
		{
			string model = null;

			return model;
		}

		public string ISerial()
		{
			string model = null;

			return model;
		}

		public string MACAddress()
		{
			string retval = "N/A";
			try
			{
				System.Net.NetworkInformation.NetworkInterface[] nics;
				nics = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces();

				String macs = string.Empty;
				foreach (System.Net.NetworkInformation.NetworkInterface adapter in nics)
				{
					if (macs == String.Empty)// only return MAC Address from first card  
					{
						System.Net.NetworkInformation.IPInterfaceProperties properties;

						properties = adapter.GetIPProperties();
						macs = adapter.GetPhysicalAddress().ToString();
					}
				}

				retval = macs;
			}
			catch (System.Exception exc)
			{
				retval = exc.ToString() + " : " + exc.Message;
			}

			return retval;
		}


		public string MACAddressWiFi()
		{
			string model = null;

			return model;
		}

		public string MACAddressBluetooth()
		{
			string model = null;

			return model;
		}

		public string BluetoothLocalName()
		{
			string model = null;

			return model;
		}
	}
}