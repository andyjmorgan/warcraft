﻿using System.ComponentModel.DataAnnotations;

namespace ArgentSquire
{
    /// <summary>
    /// Factions.
    /// </summary>
    public enum Faction
    {
        /// <summary>
        /// Alliance.
        /// </summary>
        [Display(Name = "Alliance")]
        Alliance = 0,

        /// <summary>
        /// Horde.
        /// </summary>
        [Display(Name = "Horde")]
        Horde = 1
    }
}
