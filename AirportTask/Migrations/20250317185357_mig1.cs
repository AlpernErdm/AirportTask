using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirportTask.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Runway19",
                columns: table => new
                {
                    AirportIcaoIdentifier = table.Column<string>(type: "char(4)", nullable: false),
                    RecordType = table.Column<string>(type: "char(1)", nullable: false),
                    SectionCode = table.Column<string>(type: "char(1)", nullable: false),
                    IcaoCode = table.Column<string>(type: "char(2)", nullable: false),
                    SubSectionCode = table.Column<string>(type: "char(1)", nullable: false),
                    RunwayIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContinuationNumber = table.Column<string>(type: "char(1)", nullable: false),
                    RunwayLength = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunwayMagneticBearing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunwayLatitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunwayLongitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunwayGradient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LtpEllipsoidHeight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplacedThresholdDistance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThresholdCrossingHeight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunwayWidth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TchValueIndicator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalizerRefIdent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalizerCatClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stopway = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondLocalizerRefIdent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondLocalizerCatClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunwayDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cycle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerAreaCode = table.Column<string>(type: "char(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Runway19", x => x.AirportIcaoIdentifier);
                });

            migrationBuilder.CreateTable(
                name: "Runway22",
                columns: table => new
                {
                    AirportIcaoIdentifier = table.Column<string>(type: "char(4)", nullable: false),
                    RecordType = table.Column<string>(type: "char(1)", nullable: false),
                    SectionCode = table.Column<string>(type: "char(1)", nullable: false),
                    IcaoCode = table.Column<string>(type: "char(2)", nullable: false),
                    SubSectionCode = table.Column<string>(type: "char(1)", nullable: false),
                    RunwayIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContinuationNumber = table.Column<string>(type: "char(1)", nullable: false),
                    RunwayLength = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunwayMagneticBearing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunwayLatitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunwayLongitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunwayGradient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LtpEllipsoidHeight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplacedThresholdDistance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThresholdCrossingHeight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunwayWidth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TchValueIndicator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalizerRefIdent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalizerCatClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stopway = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondLocalizerRefIdent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondLocalizerCatClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunwayDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cycle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerAreaCode = table.Column<string>(type: "char(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Runway22", x => x.AirportIcaoIdentifier);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Runway19");

            migrationBuilder.DropTable(
                name: "Runway22");
        }
    }
}
