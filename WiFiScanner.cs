
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Net.NetworkInformation;
using System;
using Assets;
 
public class WiFiScanner : MonoBehaviour
{
 
    public Text Display;    // Text UI to display the network information.
#if !UNITY_EDITOR && UNITY_METRO
    private IWiFiAdapter WiFiAdapter;
    // Use this for initialization
    void Start()
    {
        WiFiAdapter = new UniversalWiFi();
    }
 
    // This method is being called every frame.
    void Update()
    {
        Scan();
    }
    private void Scan()
    {
        if (WiFiAdapter != null)
        {
            var ssid = "RMSLab"; // The desired SSID to scan.
            var signal = WiFiAdapter.GetSignal(ssid);
            var report = WiFiAdapter.GetNetworkReport();
            Debug.Log(string.Format("{0} signal:{1}{2}", ssid, signal, report));
            Display.text = string.Format("{0} signal:{1}{2}", ssid, signal, report);
        }
    }
#endif
}
