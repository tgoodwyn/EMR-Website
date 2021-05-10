using Microsoft.EntityFrameworkCore.Migrations;

namespace EMR_HSV.Migrations
{
    public partial class ocex_on_its_own_now : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ARMD",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "AppointmentID",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "DeepLaminaOD",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "DeepLaminaOS",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "DiabeticEval",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "DilatingAgent",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "FovealReflexOD",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "FovealReflexOS",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "FundusDilation",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "FundusEvaluation20D",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "FundusEvaluation78D",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "FundusEvaluation90D",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "FundusEvaluationDirect",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "FundusEvaluationOther",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "FundusEvaluationOtherString",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "FundusEvaluationPR",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "FundusEvaluationScleral",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "FundusMethod",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "FundusNotesAdvised",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "FundusNotesContraindicated",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "FundusNotesDeclined",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "FundusNotesNotIndicated",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "FundusNotesPerformed",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "FundusNotesRecent",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "FundusNotesRefused",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "FundusNotesRescheduled",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "GlialRemnantsOD",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "GlialRemnantsOS",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "HTNEval",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "Macula",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "MiscRetina",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "MuyelinationOD",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "MuyelinationOS",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "NerveFiberLayer",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "ODSliderHorizontal",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "ODSliderVertical",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "OSSliderHorizontal",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "OSSliderVertical",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "OpticNerve",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "OpticPitOD",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "OpticPitOS",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "OvalOD",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "OvalOS",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "PeripapAtrophyOD",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "PeripapAtrophyOS",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "PeripheralRetina",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "PigmentCresentOD",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "PigmentCresentOS",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "PosteriorPole",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "RoundOD",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "RoundOS",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "ScleralCresentOD",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "ScleralCresentOS",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "ShallowOD",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "ShallowOS",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "SpontaneousVenousPulsationOD",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "SpontaneousVenousPulsationOS",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "TempSlopingOD",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "TempSlopingOS",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "UnderminingOD",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "UnderminingOS",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "Vasculature",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "Vitreous",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "custom1",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "custom2",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "custom3",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "id",
                table: "EyeTest");

            migrationBuilder.CreateTable(
                name: "OcularExam",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vitreous = table.Column<int>(type: "int", nullable: false),
                    Macula = table.Column<int>(type: "int", nullable: false),
                    Vasculature = table.Column<int>(type: "int", nullable: false),
                    PosteriorPole = table.Column<int>(type: "int", nullable: false),
                    PeripheralRetina = table.Column<int>(type: "int", nullable: false),
                    MiscRetina = table.Column<int>(type: "int", nullable: false),
                    DiabeticEval = table.Column<int>(type: "int", nullable: false),
                    HTNEval = table.Column<int>(type: "int", nullable: false),
                    ARMD = table.Column<int>(type: "int", nullable: false),
                    custom1 = table.Column<int>(type: "int", nullable: false),
                    custom2 = table.Column<int>(type: "int", nullable: false),
                    custom3 = table.Column<int>(type: "int", nullable: false),
                    SpontaneousVenousPulsationOD = table.Column<int>(type: "int", nullable: false),
                    SpontaneousVenousPulsationOS = table.Column<int>(type: "int", nullable: false),
                    FovealReflexOD = table.Column<int>(type: "int", nullable: false),
                    FovealReflexOS = table.Column<int>(type: "int", nullable: false),
                    FundusMethod = table.Column<int>(type: "int", nullable: false),
                    FundusDilation = table.Column<int>(type: "int", nullable: false),
                    DilatingAgent = table.Column<int>(type: "int", nullable: false),
                    FundusEvaluation78D = table.Column<bool>(type: "bit", nullable: false),
                    FundusEvaluation90D = table.Column<bool>(type: "bit", nullable: false),
                    FundusEvaluation20D = table.Column<bool>(type: "bit", nullable: false),
                    FundusEvaluationPR = table.Column<bool>(type: "bit", nullable: false),
                    FundusEvaluationScleral = table.Column<bool>(type: "bit", nullable: false),
                    FundusEvaluationDirect = table.Column<bool>(type: "bit", nullable: false),
                    FundusEvaluationOther = table.Column<bool>(type: "bit", nullable: false),
                    FundusEvaluationOtherString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FundusNotesAdvised = table.Column<bool>(type: "bit", nullable: false),
                    FundusNotesRescheduled = table.Column<bool>(type: "bit", nullable: false),
                    FundusNotesDeclined = table.Column<bool>(type: "bit", nullable: false),
                    FundusNotesPerformed = table.Column<bool>(type: "bit", nullable: false),
                    FundusNotesRefused = table.Column<bool>(type: "bit", nullable: false),
                    FundusNotesNotIndicated = table.Column<bool>(type: "bit", nullable: false),
                    FundusNotesContraindicated = table.Column<bool>(type: "bit", nullable: false),
                    FundusNotesRecent = table.Column<bool>(type: "bit", nullable: false),
                    ODSliderHorizontal = table.Column<float>(type: "real", nullable: false),
                    OSSliderHorizontal = table.Column<float>(type: "real", nullable: false),
                    ODSliderVertical = table.Column<float>(type: "real", nullable: false),
                    OSSliderVertical = table.Column<float>(type: "real", nullable: false),
                    OpticNerve = table.Column<int>(type: "int", nullable: false),
                    NerveFiberLayer = table.Column<int>(type: "int", nullable: false),
                    DeepLaminaOD = table.Column<bool>(type: "bit", nullable: false),
                    ShallowOD = table.Column<bool>(type: "bit", nullable: false),
                    RoundOD = table.Column<bool>(type: "bit", nullable: false),
                    OvalOD = table.Column<bool>(type: "bit", nullable: false),
                    TempSlopingOD = table.Column<bool>(type: "bit", nullable: false),
                    UnderminingOD = table.Column<bool>(type: "bit", nullable: false),
                    PeripapAtrophyOD = table.Column<bool>(type: "bit", nullable: false),
                    ScleralCresentOD = table.Column<bool>(type: "bit", nullable: false),
                    PigmentCresentOD = table.Column<bool>(type: "bit", nullable: false),
                    OpticPitOD = table.Column<bool>(type: "bit", nullable: false),
                    MuyelinationOD = table.Column<bool>(type: "bit", nullable: false),
                    GlialRemnantsOD = table.Column<bool>(type: "bit", nullable: false),
                    DeepLaminaOS = table.Column<bool>(type: "bit", nullable: false),
                    ShallowOS = table.Column<bool>(type: "bit", nullable: false),
                    RoundOS = table.Column<bool>(type: "bit", nullable: false),
                    OvalOS = table.Column<bool>(type: "bit", nullable: false),
                    TempSlopingOS = table.Column<bool>(type: "bit", nullable: false),
                    UnderminingOS = table.Column<bool>(type: "bit", nullable: false),
                    PeripapAtrophyOS = table.Column<bool>(type: "bit", nullable: false),
                    ScleralCresentOS = table.Column<bool>(type: "bit", nullable: false),
                    PigmentCresentOS = table.Column<bool>(type: "bit", nullable: false),
                    OpticPitOS = table.Column<bool>(type: "bit", nullable: false),
                    MuyelinationOS = table.Column<bool>(type: "bit", nullable: false),
                    GlialRemnantsOS = table.Column<bool>(type: "bit", nullable: false),
                    AppointmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OcularExam", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OcularExam");

            migrationBuilder.AddColumn<int>(
                name: "ARMD",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentID",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DeepLaminaOD",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DeepLaminaOS",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiabeticEval",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DilatingAgent",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FovealReflexOD",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FovealReflexOS",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FundusDilation",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FundusEvaluation20D",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FundusEvaluation78D",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FundusEvaluation90D",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FundusEvaluationDirect",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FundusEvaluationOther",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FundusEvaluationOtherString",
                table: "EyeTest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FundusEvaluationPR",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FundusEvaluationScleral",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FundusMethod",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FundusNotesAdvised",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FundusNotesContraindicated",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FundusNotesDeclined",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FundusNotesNotIndicated",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FundusNotesPerformed",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FundusNotesRecent",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FundusNotesRefused",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FundusNotesRescheduled",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "GlialRemnantsOD",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "GlialRemnantsOS",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HTNEval",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Macula",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MiscRetina",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MuyelinationOD",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MuyelinationOS",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NerveFiberLayer",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "ODSliderHorizontal",
                table: "EyeTest",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "ODSliderVertical",
                table: "EyeTest",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "OSSliderHorizontal",
                table: "EyeTest",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "OSSliderVertical",
                table: "EyeTest",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OpticNerve",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OpticPitOD",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OpticPitOS",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OvalOD",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OvalOS",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PeripapAtrophyOD",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PeripapAtrophyOS",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PeripheralRetina",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PigmentCresentOD",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PigmentCresentOS",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PosteriorPole",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RoundOD",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RoundOS",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ScleralCresentOD",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ScleralCresentOS",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ShallowOD",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ShallowOS",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpontaneousVenousPulsationOD",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpontaneousVenousPulsationOS",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TempSlopingOD",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TempSlopingOS",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "UnderminingOD",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "UnderminingOS",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Vasculature",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Vitreous",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "custom1",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "custom2",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "custom3",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "EyeTest",
                type: "int",
                nullable: true);
        }
    }
}
