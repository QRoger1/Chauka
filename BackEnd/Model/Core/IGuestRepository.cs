﻿namespace Model.Core
{
    using System.Collections.Generic;

    public interface IGuestRepository<T> : IRepository<T> where T : IEntity
    {
        bool Create(T entity);

        IEnumerable<T> GetGuestsByEventId(int eventId);

        IEnumerable<T> GetGuestsByUserId(int userId);

        bool UpdateStatusGuest(T entity);

        bool Exist(T entity);
    }
}
