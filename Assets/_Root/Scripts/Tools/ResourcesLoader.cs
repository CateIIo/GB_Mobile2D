using UnityEngine;

namespace _Root.Scripts.Tools
{
    internal static class ResourcesLoader
    {
        public static Sprite LoadSprite(ResourcePath path) => Resources.Load<Sprite>(path.PathResource);

        public static GameObject LoadPrefab(ResourcePath path) => Resources.Load<GameObject>(path.PathResource);
    }
}