using Newtonsoft.Json;
using System.Collections.Generic;

namespace Assets.Code
{
    public sealed class GameRepository : IGameRepository
    {
        private readonly Dictionary<string, string> _gameState = new();

        public void SetData<T>(T data)
        {
            string key = typeof(T).Name;
            string value = JsonConvert.SerializeObject(data);
            _gameState[key] = value;
        }

        public bool TryGetData<T>(out T data)
        {
            string key = typeof(T).Name;

            if (_gameState.TryGetValue(key, out string value))
            { 
                data = JsonConvert.DeserializeObject<T>(value);
                return true;
            }

            data = default;
            return false;
        }
    }
}
