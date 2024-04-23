using UnityEngine;

namespace ResourceLoading
{
    public class ResourceLoaderService : IResourceLoaderService
    {
        public ResourceLoaderService()
        {
            Debug.Log("ResourceLoaderService created");
        }
        
        public GameObject LoadPrefab(string path)
        {
            return Resources.Load<GameObject>(path);
        }
    }
}