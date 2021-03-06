﻿namespace GalaxyStorm.Data.Models.PlayerObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class PlayerObject
    {
        private ICollection<Report> reports;

        public PlayerObject()
        {
            this.Id = Guid.NewGuid();
            this.reports = new HashSet<Report>();
        }

        [Key, ForeignKey("ApplicationUser")]
        public Guid Id { get; set; }

        public Points Points { get; set; }

        public Resources Resources { get; set; }

        public virtual ICollection<Report> Reports { get { return this.reports; } set { this.reports = value; } }

        public int BuildingsId { get; set; }

        [ForeignKey("BuildingsId")]
        public virtual Buildings Buildings { get; set; }

        public int TechnologiesId { get; set; }

        [ForeignKey("TechnologiesId")]
        public virtual Technologies Technologies { get; set; }

        public int UnitsId { get; set; }

        [ForeignKey("UnitsId")]
        public virtual Units Units { get; set; }

        public int? PlanetId { get; set; }

        [ForeignKey("PlanetId")]
        public virtual Planet Planet { get; set; }

        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
