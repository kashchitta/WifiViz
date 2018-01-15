using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
	public interface IWiFiAdapter
	{
		uint GetSignal(string ssid);
		string GetNetworkReport();
	}
}