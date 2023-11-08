using Managers;
using UnityEngine;

namespace Game.Managers
{
    public class ImageLibrary : MonoBehaviour, IProvidable
    {
        public Sprite GreenCubeSprite;
        public Sprite YellowCubeSprite;
        public Sprite BlueCubeSprite;
        public Sprite RedCubeSprite;

        private void Awake()
        {
            ServiceProvider.Register(this);
        }
    }
}