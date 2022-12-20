using Microsoft.EntityFrameworkCore.Migrations;

namespace Deloitte.Portal.DataAccess.Migrations
{
    public partial class SpecifiedInjuriesModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "bloodStreamInjuries",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bloodStreamLevel",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bloodStreamNameOfPractitioner",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bloodStreamPractitionerType",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "dermatologicalInjuries",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "dermatologicalLevel",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "dermatologicalNameOfPractitioner",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "dermatologicalPractitionerType",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "digestiveHarmHealthPractitionerType",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "digestiveInjuries",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "digestiveLevel",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "digestiveNameOfPractitioner",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "kidneyInjuries",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "kidneyLevel",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "kidneyNameOfPractitioner",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "kidneyPractitionerType",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "liverInjuries",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "liverLevel",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "liverNameOfPractitioner",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "liverPractitionerType",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthAdjustmentDisorder",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthAdjustmentDisorderLevel",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthAdjustmentDisorderNameOfPractitioner",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthAdjustmentDisorderPractitionerType",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthAnxietyDisorder",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthAnxietyDisorderLevel",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthAnxietyDisorderNameOfPractitioner",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthAnxietyDisorderPractitionerType",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthDepression",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthDepressionLevel",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthDepressionNameOfPractitioner",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthDepressionPractitionerType",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthPanicDisorder",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthPanicDisorderLevel",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthPanicDisorderNameOfPractitioner",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthPanicDisorderPractitionerType",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthPostTraumatic",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthPostTraumaticLevel",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthPostTraumaticNameOfPractitioner",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthPostTraumaticPractitionerType",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthSpecificPhobia",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthSpecificPhobiaLevel",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthSpecificPhobiaNameOfPractitioner",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthSpecificPhobiaPractitionerType",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthSubstanceAddiction",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthSubstanceAddictionLevel",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthSubstanceAddictionNameOfPractitioner",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mentalHealthSubstanceAddictionPractitionerType",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "neurologicalInjuries",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "neurologicalLevel",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "neurologicalNameOfPractitioner",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "neurologicalPractitionerType",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "respiratoryInjuries",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "respiratoryLevel",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "respiratoryNameOfPractitioner",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "respiratoryPractitionerType",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tumorOrCancerInjuries",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tumorOrCancerLevel",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tumorOrCancerNameOfPractitioner",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tumorOrCancerPractitionerType",
                table: "Claims",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bloodStreamInjuries",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "bloodStreamLevel",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "bloodStreamNameOfPractitioner",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "bloodStreamPractitionerType",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "dermatologicalInjuries",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "dermatologicalLevel",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "dermatologicalNameOfPractitioner",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "dermatologicalPractitionerType",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "digestiveHarmHealthPractitionerType",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "digestiveInjuries",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "digestiveLevel",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "digestiveNameOfPractitioner",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "kidneyInjuries",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "kidneyLevel",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "kidneyNameOfPractitioner",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "kidneyPractitionerType",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "liverInjuries",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "liverLevel",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "liverNameOfPractitioner",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "liverPractitionerType",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthAdjustmentDisorder",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthAdjustmentDisorderLevel",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthAdjustmentDisorderNameOfPractitioner",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthAdjustmentDisorderPractitionerType",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthAnxietyDisorder",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthAnxietyDisorderLevel",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthAnxietyDisorderNameOfPractitioner",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthAnxietyDisorderPractitionerType",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthDepression",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthDepressionLevel",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthDepressionNameOfPractitioner",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthDepressionPractitionerType",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthPanicDisorder",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthPanicDisorderLevel",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthPanicDisorderNameOfPractitioner",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthPanicDisorderPractitionerType",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthPostTraumatic",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthPostTraumaticLevel",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthPostTraumaticNameOfPractitioner",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthPostTraumaticPractitionerType",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthSpecificPhobia",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthSpecificPhobiaLevel",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthSpecificPhobiaNameOfPractitioner",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthSpecificPhobiaPractitionerType",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthSubstanceAddiction",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthSubstanceAddictionLevel",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthSubstanceAddictionNameOfPractitioner",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "mentalHealthSubstanceAddictionPractitionerType",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "neurologicalInjuries",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "neurologicalLevel",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "neurologicalNameOfPractitioner",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "neurologicalPractitionerType",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "respiratoryInjuries",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "respiratoryLevel",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "respiratoryNameOfPractitioner",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "respiratoryPractitionerType",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "tumorOrCancerInjuries",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "tumorOrCancerLevel",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "tumorOrCancerNameOfPractitioner",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "tumorOrCancerPractitionerType",
                table: "Claims");
        }
    }
}
