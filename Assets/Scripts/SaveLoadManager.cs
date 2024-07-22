using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;

namespace Assets.Code
{
    public sealed class SaveLoadManager : MonoBehaviour
    {
        private GameRepository _gameRepository;
        private ISaveLoader[] _saveLoaders;
        
        [Inject]
        public void Construct(GameRepository gameRepository, ISaveLoader[] saveLoaders)
        { 
            _gameRepository = gameRepository; _saveLoaders = saveLoaders;
        }

        [Button]
        public void Save()
        {

        }

        [Button]
        public void Load()
        {

        }

    }
}
