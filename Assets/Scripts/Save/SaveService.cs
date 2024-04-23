using System;
using UnityEngine;

namespace Save
{
    public class SaveService : ISaveService
    {
        public SaveService()
        {
            Debug.Log("SaveService created");
            
#if UNITY_EDITOR == false
            Agava.YandexGames.Utility.PlayerPrefs.Load();
#endif
        }

        public bool HasKey(string key)
        {
#if UNITY_EDITOR
            return PlayerPrefs.HasKey(key);
#else
            return Agava.YandexGames.Utility.PlayerPrefs.HasKey(key);
#endif
        }
        
        public void SaveString(string key, string value)
        {
#if UNITY_EDITOR
            PlayerPrefs.SetString(key, value);
            PlayerPrefs.Save();
#else
            Agava.YandexGames.Utility.PlayerPrefs.SetString(key, value);
            Agava.YandexGames.Utility.PlayerPrefs.Save();
#endif
        }

        public void SaveFloat(string key, float value)
        {
#if UNITY_EDITOR
            PlayerPrefs.SetFloat(key, value);
            PlayerPrefs.Save();
#else
            Agava.YandexGames.Utility.PlayerPrefs.SetFloat(key, value);
            Agava.YandexGames.Utility.PlayerPrefs.Save();
#endif
        }

        public void SaveInt(string key, int value)
        {
#if UNITY_EDITOR
            PlayerPrefs.SetInt(key, value);
            PlayerPrefs.Save();
#else
            Agava.YandexGames.Utility.PlayerPrefs.SetInt(key, value);
            Agava.YandexGames.Utility.PlayerPrefs.Save();
#endif
        }

        public void SaveObject<T>(string key, T value)
        {
            string json = JsonUtility.ToJson(value);
            
#if UNITY_EDITOR
            PlayerPrefs.SetString(key, json);
            PlayerPrefs.Save();
#else
            Agava.YandexGames.Utility.PlayerPrefs.SetString(key, json);
            Agava.YandexGames.Utility.PlayerPrefs.Save();
#endif
        }

        public string LoadString(string key)
        {
#if UNITY_EDITOR
            if (PlayerPrefs.HasKey(key))
                return PlayerPrefs.GetString(key);
#else
            if (Agava.YandexGames.Utility.PlayerPrefs.HasKey(key))
                return Agava.YandexGames.Utility.PlayerPrefs.GetString(key);
#endif
            else
                return String.Empty;
        }

        public int LoadInt(string key)
        {
#if UNITY_EDITOR
            if (PlayerPrefs.HasKey(key))
                return PlayerPrefs.GetInt(key);
#else
            if (Agava.YandexGames.Utility.PlayerPrefs.HasKey(key))
                return Agava.YandexGames.Utility.PlayerPrefs.GetInt(key);
#endif
            else
                return 0;
        }

        public float LoadFloat(string key)
        {
#if UNITY_EDITOR
            if (PlayerPrefs.HasKey(key))
                return PlayerPrefs.GetFloat(key);
#else
            if (Agava.YandexGames.Utility.PlayerPrefs.HasKey(key))
                return Agava.YandexGames.Utility.PlayerPrefs.GetFloat(key);
#endif
            else
                return 0f;
        }

        public T LoadObject<T>(string key)
        {
#if UNITY_EDITOR
            if (PlayerPrefs.HasKey(key))
                return JsonUtility.FromJson<T>(PlayerPrefs.GetString(key));
#else
            if (Agava.YandexGames.Utility.PlayerPrefs.HasKey(key))
                return JsonUtility.FromJson<T>(Agava.YandexGames.Utility.PlayerPrefs.GetString(key));
#endif
            return default;
        }
    }
}