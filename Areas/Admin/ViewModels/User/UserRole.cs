﻿using System.ComponentModel;

namespace Bonsai.Areas.Admin.ViewModels.User
{
    /// <summary>
    /// Known account roles.
    /// </summary>
    public enum UserRole
    {
        /// <summary>
        /// Basic user.
        /// </summary>
        [Description("Пользователь")]
        User,

        /// <summary>
        /// Page editor.
        /// </summary>
        [Description("Редактор")]
        Editor,

        /// <summary>
        /// Almighty administator
        /// </summary>
        [Description("Администратор")]
        Admin
    }
}
