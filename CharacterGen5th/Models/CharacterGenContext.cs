namespace CharacterGen5th.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CharacterGenContext : DbContext
    {
        public CharacterGenContext()
            : base("name=CharacterGenModel")
        {
        }

        public virtual DbSet<Amunittion> Amunittions { get; set; }
        public virtual DbSet<Armor> Armors { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Feat> Feats { get; set; }
        public virtual DbSet<Focus> Foci { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Race> Races { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<Spell> Spells { get; set; }
        public virtual DbSet<Weapon> Weapons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Amunittion>()
                .Property(e => e.Weight)
                .HasPrecision(7, 3);

            modelBuilder.Entity<Amunittion>()
                .Property(e => e.Cost)
                .HasPrecision(7, 3);

            modelBuilder.Entity<Armor>()
                .Property(e => e.Weight)
                .HasPrecision(7, 2);

            modelBuilder.Entity<Armor>()
                .Property(e => e.Cost)
                .HasPrecision(7, 2);

            modelBuilder.Entity<Focus>()
                .Property(e => e.Weight)
                .HasPrecision(7, 2);

            modelBuilder.Entity<Focus>()
                .Property(e => e.Cost)
                .HasPrecision(7, 2);

            modelBuilder.Entity<Item>()
                .Property(e => e.Weight)
                .HasPrecision(7, 2);

            modelBuilder.Entity<Item>()
                .Property(e => e.Cost)
                .HasPrecision(7, 2);

            modelBuilder.Entity<Skill>()
                .Property(e => e.Skill1)
                .IsUnicode(false);

            modelBuilder.Entity<Spell>()
                .Property(e => e.School)
                .IsFixedLength();

            modelBuilder.Entity<Weapon>()
                .Property(e => e.Weight)
                .HasPrecision(7, 2);

            modelBuilder.Entity<Weapon>()
                .Property(e => e.Cost)
                .HasPrecision(7, 2);
        }
    }
}
