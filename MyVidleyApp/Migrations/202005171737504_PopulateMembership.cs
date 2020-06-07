namespace MyVidleyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembership : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO MembershipTypes (Id, SignUpFee,DurationInMonths,DiscountRate) Values (1,0,0,0)");
            Sql("Insert INTO MembershipTypes (Id, SignUpFee,DurationInMonths,DiscountRate) Values (2,30,1,10)");
            Sql("Insert INTO MembershipTypes (Id, SignUpFee,DurationInMonths,DiscountRate) Values (3,90,3,15)");
            Sql("Insert INTO MembershipTypes (Id, SignUpFee,DurationInMonths,DiscountRate) Values (4,300,12,20)");


        }
        
        public override void Down()
        {
        }
    }
}
