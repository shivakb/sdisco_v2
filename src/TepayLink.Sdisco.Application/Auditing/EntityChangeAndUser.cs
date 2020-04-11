﻿using Abp.EntityHistory;
using TepayLink.Sdisco.Authorization.Users;

namespace TepayLink.Sdisco.Auditing
{
    /// <summary>
    /// A helper class to store an <see cref="EntityChange"/> and a <see cref="User"/> object.
    /// </summary>
    public class EntityChangeAndUser
    {
        public EntityChange EntityChange { get; set; }

        public User User { get; set; }
    }
}