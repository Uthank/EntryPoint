using UnityEngine;

namespace ResourceLoading
{
    public interface IResourceLoaderService
    {
        public GameObject LoadPrefab(string path);
    }
}