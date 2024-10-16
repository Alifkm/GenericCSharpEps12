using System.Reflection;

namespace GenericCSharpEps12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(ConfigurationManager<>);
        }
    }

    internal class ConfigurationManager<T>
    {
        public T LoadedConfiguration { get; set; }
        public ConfigurationManager(T config) 
        { 
            LoadedConfiguration = config;
        }

        public static void SaveConfig(T configToSave)
        {

        }
    }
}