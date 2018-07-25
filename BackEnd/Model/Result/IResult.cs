﻿namespace Model.Result
{
    using Model.Core;

    public interface IResult<T> where T : IEntity
    {
        string Message { get; set; }

        bool Success { get; set; }

        T Data { get; set; }
    }
}
