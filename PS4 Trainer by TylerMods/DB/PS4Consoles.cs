using System.Collections.Generic;
using System.Text.RegularExpressions;
public struct PS4
{
    public string Name { get; set; }
    public string Firmware { get; set; }
    public string IPAddress { get; set; }
}
public class PS4Consoles
{
    private RegistryData registryData;
    const string IP_REGEX = @"^([0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3})$";
    public PS4Consoles()
    {
        registryData = new RegistryData("Software\\PS4 Trainer by TylerMods\\PS4Consoles");
    }

    public List<PS4> GetAllPS4s()
    {
        List<PS4> ps4s = new List<PS4>();

        var allSubs = registryData.GetSubKeys();

        if (allSubs == null)
            return ps4s;

        foreach (var ps4 in allSubs)
        {
            PS4 p = new PS4();
            p.Name = ps4;

            var subKey = registryData.GetSubKey(p.Name);

            p.Firmware = subKey.GetValue("Firmware").ToString();
            p.IPAddress = subKey.GetValue("IPAddress").ToString();

            if (Regex.IsMatch(p.IPAddress, IP_REGEX))
                ps4s.Add(p);

        }

        return ps4s;
    }

    public PS4 GetPS4Details(string ps4Name)
    {
        PS4 p = new PS4();
    

        var subKey = registryData.GetSubKey(ps4Name);

        if (subKey == null)
            return default(PS4);

        p.Firmware = subKey.GetValue("Firmware").ToString();
        p.IPAddress = subKey.GetValue("IPAddress").ToString();

        p.Name = ps4Name;
        if (!Regex.IsMatch(p.IPAddress, IP_REGEX))
            return default(PS4);
        return p;
    }

    public void SetIPAddress(string name, string ipaddress)
    {
        if (!Regex.IsMatch(ipaddress, IP_REGEX))
        {
            System.Windows.Forms.MessageBox.Show("Ip Not valid");
            return;
        }
        registryData.GetSubKey(name).SetValue("IPAddress", ipaddress);
    }

    public void SetFirmware(string name, string firmware)
    {
        registryData.GetSubKey(name).SetValue("Firmware", firmware);
    }

    public void AddPS4(PS4 ps4)
    {

        if (!Regex.IsMatch(ps4.IPAddress, IP_REGEX))
        {
            System.Windows.Forms.MessageBox.Show("Ip Not valid");
            return;
        }

        RegistryData rd = registryData.CreateSubKey(ps4.Name);
        
        rd.Add("IPAddress", ps4.IPAddress);

        rd.Add("Firmware", ps4.Firmware);
    }

    public void DeletePS4(string name)
    {
        registryData.DeleteSubKey(name);
    }

    public PS4 DefaultPS4()
    {
        var registry = registryData.RegistryKey?.GetValue(null);
        if (registry == null)
            return default(PS4);

        string defaultPS4 = registry.ToString();

        return GetPS4Details(defaultPS4);
    }

    public void SetDefault(string name)
    {
        registryData.Add(null, name);
    }
}