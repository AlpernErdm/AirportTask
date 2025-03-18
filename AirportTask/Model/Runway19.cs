using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirportTask.Model
{
    public class Runway19
    {
        [Key]
        [Column(TypeName = "char(4)")]
        public string AirportIcaoIdentifier { get; set; } = default!;

        [Column(TypeName = "char(1)")]
        public string RecordType { get; set; } = default!; [Column(TypeName = "char(1)")]
        public string SectionCode { get; set; } = default!;
        [Column(TypeName = "char(2)")]
        public string IcaoCode { get; set; } = default!;
        [Column(TypeName = "char(1)")]
        public string SubSectionCode { get; set; } = default!;
        public string RunwayIdentifier { get; set; } = default!;
        [Column(TypeName = "char(1)")]
        public string ContinuationNumber { get; set; } = default!;
        public string RunwayLength { get; set; } = default!;
        public string RunwayMagneticBearing { get; set; } = default!;
        public string RunwayLatitude { get; set; } = default!;
        public string RunwayLongitude { get; set; } = default!;
        public string RunwayGradient { get; set; } = default!;
        public string LtpEllipsoidHeight { get; set; } = default!;
        public string DisplacedThresholdDistance { get; set; } = default!;
        public string ThresholdCrossingHeight { get; set; } = default!;
        public string RunwayWidth { get; set; } = default!;
        public string TchValueIndicator { get; set; } = default!;
        public string LocalizerRefIdent { get; set; } = default!;
        public string LocalizerCatClass { get; set; } = default!;
        public string Stopway { get; set; } = default!;
        public string SecondLocalizerRefIdent { get; set; } = default!;
        public string SecondLocalizerCatClass { get; set; } = default!;
        public string RunwayDescription { get; set; } = default!;
        public string Cycle { get; set; } = default!;

        [Column(TypeName = "char(3)")]
        public string CustomerAreaCode { get; set; } = default!;
    }
}
