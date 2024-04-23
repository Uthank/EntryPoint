namespace Save
{
    public interface ISaveService
    {
        public void SaveString(string key, string value);
        public void SaveFloat(string key, float value);
        public void SaveInt(string key, int value);
        public void SaveObject<T>(string key, T value);
        public string LoadString(string key);
        public int LoadInt(string key);
        public float LoadFloat(string key);
        public T LoadObject<T>(string key);
        bool HasKey(string key);
    }
}