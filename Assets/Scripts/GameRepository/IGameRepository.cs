﻿namespace Assets.Code
{
    public interface IGameRepository
    {
        void SetData<T>(T data);
        bool TryGetData<T>(out T data);
    }
}
