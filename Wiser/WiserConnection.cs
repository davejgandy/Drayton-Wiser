using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.CSharp;
using Wiser.DataObjects;
using System.Threading;
using System.Configuration;
using System.Reflection;

namespace Wiser
{
    public class WiserConnection
    {
        private string _hubIP;
        private string _hubSecret;
        protected HeatHub _hub;

        public WiserConnection()
        {
            var config = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);

            if (config.HasFile)
            {
                _hubIP = config.AppSettings.Settings["HubAddress"].Value;
                _hubSecret = config.AppSettings.Settings["HubSecret"].Value;
            }
        }


        public string GetDataJSON()
        {
            string url = string.Format("http://{0}/data/domain/", _hubIP);
            int i = 0;
            while (i < 3)
            {
                using (var client = new WebClient())
                {
                    try
                    {
                        client.Headers["SECRET"] = _hubSecret;
                        var response = client.DownloadString(url);
                        return response;
                    }
                    catch (Exception ex)
                    {
                        Thread.Sleep(1000);
                    }
                }
            }
            return null;

        }

        public HeatHub GetData()
        {
            string url = string.Format("http://{0}/data/domain/",_hubIP);
            int i = 0;
            while (i < 3)
            {
                using (var client = new WebClient())
                {
                    try
                    {
                        client.Headers["SECRET"] = _hubSecret;
                        var response = client.DownloadString(url);
                        _hub = JsonConvert.DeserializeObject(response, typeof(HeatHub)) as HeatHub;
                        return _hub;
                    }
                    catch (Exception ex)
                    {
                        // TODO: Don't block the UI
                        Thread.Sleep(1000);
                        
                    }
                }
            }
            return null;
        }

        
        private string SendRequestToHub(string urlSuffix, string method, string requestData)
        {
            try
            {
                using (var client = new WebClient())
                {
                    client.Headers["SECRET"] = _hubSecret; 
                    string url = string.Format("http://{0}/data/domain/{1}",_hubIP,urlSuffix);

                    return client.UploadString(url, method, requestData);
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void SetRoomOverride(int id, int temp, int duration = 0)
        {
            string data;
            if (duration > 0)
                data = string.Format("{{\"RequestOverride\":{{ \"Type\":\"Manual\",\"SetPoint\":\"{0}\",\"DurationMinutes\":\"{1}\"}} }}", temp, duration);
            else
                data = string.Format("{{\"RequestOverride\":{{ \"Type\":\"Manual\",\"SetPoint\":\"{0}\"}} }}", temp);
            string response = SendRequestToHub(string.Format("Room/{0}", id), "PATCH", data);
        }

        public void DisableRoomOverride(int id)
        {
            string data = "{{\"RequestOverride\":{{ \"Type\":\"None\"}} }}";
            string response = SendRequestToHub(string.Format("Room/{0}", id), "PATCH", data);
        }

        public void SetHotWaterOverride(int id, bool on, int duration = 0)
        {
            string data;
            if (duration > 0)
                data = string.Format("{{\"RequestOverride\":{{ \"Type\":\"Manual\",\"SetPoint\":\"{0}\",\"DurationMinutes\":\"{1}\"}} }}", on ? 1100 : -200, duration);
            else
                data = string.Format("{{\"RequestOverride\":{{ \"Type\":\"Manual\",\"SetPoint\":\"{0}\"}} }}", on ? 1100 : -200);
            string response = SendRequestToHub(string.Format("HotWater/{0}", id), "PATCH", data);
        }

        public void DisableHotWaterOverride(int id)
        {
            string data = "{{\"RequestOverride\":{{ \"Type\":\"None\"}} }}";
            string response = SendRequestToHub(string.Format("HotWater/{0}", id), "PATCH", data);

        }

        public void EnableAwayMode(bool enable)
        {
            string data = string.Format("{{\"RequestOverride\":{{ \"Type\":\"{0}\"}} }}", enable ? "Away" : "None");
            string response = SendRequestToHub("System\\", "PATCH", data);
        }

        public void EnableEcoMode(bool enable)
        {
            string data = string.Format("{{ \"EcoModeEnabled\":\"{0}\"}} ", enable.ToString().ToLower());
            string response = SendRequestToHub("System", "PATCH", data);
        }

        public void EnableComfortMode(bool enable)
        {
            string data = string.Format("{{ \"ComfortModeEnabled\":\"{0}\"}} ", enable.ToString().ToLower());
            string response = SendRequestToHub("System", "PATCH", data);
        }

        public void RemoveAllOverrides()
        {
            if (_hub == null)
                _hub = GetData();

            foreach (var room in _hub.Room)
                DisableRoomOverride(room.id);

            DisableHotWaterOverride(_hub.HotWater[0].id);
        }


        public SmartValve GetSmartValve(int id)
        {
            if (_hub == null)
                _hub = GetData();

            foreach (var valve in _hub.SmartValve)
            {
                if (valve.id == id)
                    return valve;
            }
            return null;
        }

        public Device GetDevice(int id)
        {
            if (_hub == null)
                _hub = GetData();

            foreach (var device in _hub.Device)
            {
                if (device.id == id)
                    return device;
            }
            return null;
        }

        public bool GetHotWaterRelayState()
        {
            if (_hub == null)
                _hub = GetData();

            return _hub.HotWater[0].HotWaterRelayState == "On";
        }

        public bool GetHeatingRelayState()
        {
            if (_hub == null)
                _hub = GetData();

            return _hub.HeatingChannel[0].HeatingRelayState == "On";
        }

        public bool? GetSmartPlugRelayState(string name)
        {
            if (_hub == null)
                _hub = GetData();

            foreach (var plug in _hub.SmartPlug)
            {
                if (plug.Name == name)
                    return plug.OutputState == "On";
            }

            return null;
        }

        public void SetSmartPlugRelayState(string name, bool enable)
        {
            if (_hub == null)
                _hub = GetData();

            foreach (var plug in _hub.SmartPlug)
            {
                if (plug.Name == name)
                {
                    string data = string.Format("{{ \"RequestOutput\":\"{0}\"}} ", enable ? "On" : "Off");
                    string response = SendRequestToHub(string.Format("SmartPlug/{0}", plug.id), "PATCH", data);

                }
            }
        }


    }
}
