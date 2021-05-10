using Microsoft.EntityFrameworkCore.Migrations;

namespace EMR_HSV.Migrations
{
    public partial class status_variables_for_apt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "conditions",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "cpdrODH",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "cpdrODV",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "dilationAgentOptions",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "dilationQuantityOptions",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "dilationTechniqueOptions",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "evaluationToolOptions",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "indications",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "notesOptions",
                table: "EyeTest");

            migrationBuilder.RenameColumn(
                name: "onerve",
                table: "EyeTest",
                newName: "OSSliderVertical");

            migrationBuilder.RenameColumn(
                name: "ondchoices",
                table: "EyeTest",
                newName: "FundusEvaluationOtherString");

            migrationBuilder.RenameColumn(
                name: "nflayer",
                table: "EyeTest",
                newName: "OSSliderHorizontal");

            migrationBuilder.RenameColumn(
                name: "cpdrOSV",
                table: "EyeTest",
                newName: "ODSliderVertical");

            migrationBuilder.RenameColumn(
                name: "cpdrOSH",
                table: "EyeTest",
                newName: "ODSliderHorizontal");

            migrationBuilder.RenameColumn(
                name: "chosenTechnique",
                table: "EyeTest",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "chosenNotes",
                table: "EyeTest",
                newName: "custom3");

            migrationBuilder.RenameColumn(
                name: "chosenEvaluationTool",
                table: "EyeTest",
                newName: "custom2");

            migrationBuilder.RenameColumn(
                name: "chosenDilationQuantity",
                table: "EyeTest",
                newName: "custom1");

            migrationBuilder.RenameColumn(
                name: "chosenDilationAgent",
                table: "EyeTest",
                newName: "Vitreous");

            migrationBuilder.RenameColumn(
                name: "VITR",
                table: "EyeTest",
                newName: "Vasculature");

            migrationBuilder.RenameColumn(
                name: "VASC",
                table: "EyeTest",
                newName: "SpontaneousVenousPulsationOS");

            migrationBuilder.RenameColumn(
                name: "PR",
                table: "EyeTest",
                newName: "SpontaneousVenousPulsationOD");

            migrationBuilder.RenameColumn(
                name: "PP",
                table: "EyeTest",
                newName: "PosteriorPole");

            migrationBuilder.RenameColumn(
                name: "OSSVP",
                table: "EyeTest",
                newName: "PeripheralRetina");

            migrationBuilder.RenameColumn(
                name: "OSFR",
                table: "EyeTest",
                newName: "OpticNerve");

            migrationBuilder.RenameColumn(
                name: "ODSVP",
                table: "EyeTest",
                newName: "NerveFiberLayer");

            migrationBuilder.RenameColumn(
                name: "ODFR",
                table: "EyeTest",
                newName: "MiscRetina");

            migrationBuilder.RenameColumn(
                name: "MR",
                table: "EyeTest",
                newName: "Macula");

            migrationBuilder.RenameColumn(
                name: "MACU",
                table: "EyeTest",
                newName: "HTNEval");

            migrationBuilder.RenameColumn(
                name: "HTN",
                table: "EyeTest",
                newName: "FundusMethod");

            migrationBuilder.RenameColumn(
                name: "DE",
                table: "EyeTest",
                newName: "FundusDilation");

            migrationBuilder.RenameColumn(
                name: "C3",
                table: "EyeTest",
                newName: "FovealReflexOS");

            migrationBuilder.RenameColumn(
                name: "C2",
                table: "EyeTest",
                newName: "FovealReflexOD");

            migrationBuilder.RenameColumn(
                name: "C1",
                table: "EyeTest",
                newName: "DilatingAgent");

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

            migrationBuilder.AddColumn<bool>(
                name: "hasArrived",
                table: "Appointment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "hasBeenCheckedIn",
                table: "Appointment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isFinished",
                table: "Appointment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isWithDoctor",
                table: "Appointment",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "FundusEvaluationPR",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "FundusEvaluationScleral",
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
                name: "MuyelinationOD",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "MuyelinationOS",
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
                name: "PigmentCresentOD",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "PigmentCresentOS",
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
                name: "hasArrived",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "hasBeenCheckedIn",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "isFinished",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "isWithDoctor",
                table: "Appointment");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "EyeTest",
                newName: "chosenTechnique");

            migrationBuilder.RenameColumn(
                name: "custom3",
                table: "EyeTest",
                newName: "chosenNotes");

            migrationBuilder.RenameColumn(
                name: "custom2",
                table: "EyeTest",
                newName: "chosenEvaluationTool");

            migrationBuilder.RenameColumn(
                name: "custom1",
                table: "EyeTest",
                newName: "chosenDilationQuantity");

            migrationBuilder.RenameColumn(
                name: "Vitreous",
                table: "EyeTest",
                newName: "chosenDilationAgent");

            migrationBuilder.RenameColumn(
                name: "Vasculature",
                table: "EyeTest",
                newName: "VITR");

            migrationBuilder.RenameColumn(
                name: "SpontaneousVenousPulsationOS",
                table: "EyeTest",
                newName: "VASC");

            migrationBuilder.RenameColumn(
                name: "SpontaneousVenousPulsationOD",
                table: "EyeTest",
                newName: "PR");

            migrationBuilder.RenameColumn(
                name: "PosteriorPole",
                table: "EyeTest",
                newName: "PP");

            migrationBuilder.RenameColumn(
                name: "PeripheralRetina",
                table: "EyeTest",
                newName: "OSSVP");

            migrationBuilder.RenameColumn(
                name: "OpticNerve",
                table: "EyeTest",
                newName: "OSFR");

            migrationBuilder.RenameColumn(
                name: "OSSliderVertical",
                table: "EyeTest",
                newName: "onerve");

            migrationBuilder.RenameColumn(
                name: "OSSliderHorizontal",
                table: "EyeTest",
                newName: "nflayer");

            migrationBuilder.RenameColumn(
                name: "ODSliderVertical",
                table: "EyeTest",
                newName: "cpdrOSV");

            migrationBuilder.RenameColumn(
                name: "ODSliderHorizontal",
                table: "EyeTest",
                newName: "cpdrOSH");

            migrationBuilder.RenameColumn(
                name: "NerveFiberLayer",
                table: "EyeTest",
                newName: "ODSVP");

            migrationBuilder.RenameColumn(
                name: "MiscRetina",
                table: "EyeTest",
                newName: "ODFR");

            migrationBuilder.RenameColumn(
                name: "Macula",
                table: "EyeTest",
                newName: "MR");

            migrationBuilder.RenameColumn(
                name: "HTNEval",
                table: "EyeTest",
                newName: "MACU");

            migrationBuilder.RenameColumn(
                name: "FundusMethod",
                table: "EyeTest",
                newName: "HTN");

            migrationBuilder.RenameColumn(
                name: "FundusEvaluationOtherString",
                table: "EyeTest",
                newName: "ondchoices");

            migrationBuilder.RenameColumn(
                name: "FundusDilation",
                table: "EyeTest",
                newName: "DE");

            migrationBuilder.RenameColumn(
                name: "FovealReflexOS",
                table: "EyeTest",
                newName: "C3");

            migrationBuilder.RenameColumn(
                name: "FovealReflexOD",
                table: "EyeTest",
                newName: "C2");

            migrationBuilder.RenameColumn(
                name: "DilatingAgent",
                table: "EyeTest",
                newName: "C1");

            migrationBuilder.AddColumn<string>(
                name: "conditions",
                table: "EyeTest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "cpdrODH",
                table: "EyeTest",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "cpdrODV",
                table: "EyeTest",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "dilationAgentOptions",
                table: "EyeTest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "dilationQuantityOptions",
                table: "EyeTest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "dilationTechniqueOptions",
                table: "EyeTest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "evaluationToolOptions",
                table: "EyeTest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "indications",
                table: "EyeTest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "notesOptions",
                table: "EyeTest",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
