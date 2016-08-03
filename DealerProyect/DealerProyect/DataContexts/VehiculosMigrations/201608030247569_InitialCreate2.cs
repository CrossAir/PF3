namespace DealerProyect.DataContexts.VehiculosMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehiculos", "Brand", c => c.String(nullable: false));
            AddColumn("dbo.Vehiculos", "Model", c => c.String(nullable: false));
            AddColumn("dbo.Vehiculos", "Year", c => c.Int(nullable: false));
            AddColumn("dbo.Vehiculos", "Status", c => c.Int(nullable: false));
            DropColumn("dbo.Vehiculos", "Marca");
            DropColumn("dbo.Vehiculos", "Modelo");
            DropColumn("dbo.Vehiculos", "Ano");
            DropColumn("dbo.Vehiculos", "Estado");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vehiculos", "Estado", c => c.Int(nullable: false));
            AddColumn("dbo.Vehiculos", "Ano", c => c.Int(nullable: false));
            AddColumn("dbo.Vehiculos", "Modelo", c => c.String(nullable: false));
            AddColumn("dbo.Vehiculos", "Marca", c => c.String(nullable: false));
            DropColumn("dbo.Vehiculos", "Status");
            DropColumn("dbo.Vehiculos", "Year");
            DropColumn("dbo.Vehiculos", "Model");
            DropColumn("dbo.Vehiculos", "Brand");
        }
    }
}
