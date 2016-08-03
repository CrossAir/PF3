namespace DealerProyect.DataContexts.VehiculosMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehiculos", "Marca", c => c.String(nullable: false));
            AddColumn("dbo.Vehiculos", "Modelo", c => c.String(nullable: false));
            AddColumn("dbo.Vehiculos", "Ano", c => c.Int(nullable: false));
            AddColumn("dbo.Vehiculos", "Estado", c => c.Int(nullable: false));
            DropColumn("dbo.Vehiculos", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vehiculos", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Vehiculos", "Estado");
            DropColumn("dbo.Vehiculos", "Ano");
            DropColumn("dbo.Vehiculos", "Modelo");
            DropColumn("dbo.Vehiculos", "Marca");
        }
    }
}
