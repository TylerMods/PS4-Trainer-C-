using Microsoft.Win32;

public class RegistryData
{
    readonly string _path;
    RegistryKey _registryKey;

    public RegistryData(string path)
    {
        _path = path;
        _registryKey = Registry.CurrentUser.OpenSubKey(_path, true) ?? Registry.CurrentUser.CreateSubKey(_path, true);
    }

    public RegistryKey RegistryKey
    {
        get
        {
            return _registryKey;
        }
    }

    public void SetRelativePath(string path)
    {
        _registryKey = _registryKey.OpenSubKey(path, true) ?? Registry.CurrentUser.CreateSubKey($"{_path}\\{path}", true); ;
    }
    public string[] GetSubKeys()
    {
        return _registryKey.GetSubKeyNames();
    }

    public RegistryKey GetSubKey(string subkey)
    {
        return _registryKey.OpenSubKey(subkey, true);
    }

    public void Add(string key, string value)
    {
        _registryKey.SetValue(key, value);
    }

    public void Update(string key, string value)
    {
        Add(key, value);
    }

    public void Delete(string key)
    {
        _registryKey.DeleteValue(key);//So there actually is an issue with the name reading
    }

    public void DeleteSubKey(string subKeyName)
    {
        _registryKey.DeleteSubKey(subKeyName);
    }
    
    public RegistryData CreateSubKey(string subKeyName)
    {
        return new RegistryData($"{_path}\\{subKeyName}");
    }
}