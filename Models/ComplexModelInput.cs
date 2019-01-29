using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models
{
	//[DataContract(Name = "CheckRequestData ", Namespace = "http://gucmp.ru/services/smev/pvk/resolutions/1.0.7")]
 //   [Serializable]
 //   //[XmlType(AnonymousType = true, Namespace = "http://gucmp.ru/services/smev/pvk/resolutions/1.0.7")]
 //   [XmlRoot("CheckRequestData", Namespace = "http://gucmp.ru/services/smev/pvk/resolutions/1.0.7", IsNullable = false)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public class complexModel /*: Container*/
    {
        //private int channelNumberField;
        [DataMember(Name = "ID")]
        [XmlElement("ID")]
        public string ID { get; set; }

        [DataMember(Name = "CreatedBy")]
        [XmlElement("CreatedBy", Type = typeof(CreatedByKL))]
        public CreatedByKL CreatedBy { get; set; }

        [DataMember(Name = "Created")]
        [XmlElement("Created")]
        public string Created { get; set; }

        [DataMember(Name = "Captions")]
        [XmlArray("Captions")]
        [XmlArrayItem("Captions", Type = typeof(CaptionsKL))]
        public CaptionsKL[] Captions { get; set; }
        //[XmlElement("Captions", Type = typeof(CaptionsKL))]
        //public CaptionsKL Captions { get; set; }

        [DataMember(Name = "Binaries")]
        //[XmlArray("Binaries")]
        //[XmlArrayItem("Binaries", Type = typeof(BinariesKL))]
        //public BinariesKL[] Binaries { get; set; }
        [XmlElement("Binaries", Type = typeof(BinariesKL))]
        public List<BinariesKL> Binaries { get; set; }
        //public BinariesKL Binaries { get; set; }

        [DataMember(Name = "ChannelNumber")]
        [XmlElement("ChannelNumber")]
        public int ChannelNumber { get; set; }

        [DataMember(Name = "LaneNumber")]
        [XmlElement("LaneNumber")]
        public int LaneNumber { get; set; }

        [DataMember(Name = "Direction")]
        [XmlElement("Direction")]
        public string Direction { get; set; }

        [DataMember(Name = "Credence")]
        [XmlElement("Credence")]
        public string Credence { get; set; }

        [DataMember(Name = "CredenceExceeded")]
        [XmlElement("CredenceExceeded")]
        public string CredenceExceeded { get; set; }

        [DataMember(Name = "Heading")]
        [XmlElement("Heading")]
        public string Heading { get; set; }

        [DataMember(Name = "Gap")]
        [XmlElement("Gap")]
        public string Gap { get; set; }

        [DataMember(Name = "Speed")]
        [XmlElement("Speed")]
        public double Speed { get; set; }

        [DataMember(Name = "SpeedDifference")]
        [XmlElement("SpeedDifference")]
        public double SpeedDifference { get; set; }

        [DataMember(Name = "Length")]
        [XmlElement("Length")]
        public int Length { get; set; }

        [DataMember(Name = "Width")]
        [XmlElement("Width")]
        public int Width { get; set; }

        [DataMember(Name = "Height")]
        [XmlElement("Height")]
        public int Height { get; set; }

        [DataMember(Name = "PositionLeft")]
        [XmlElement("PositionLeft")]
        public int PositionLeft { get; set; }

        [DataMember(Name = "PositionRight")]
        [XmlElement("PositionRight")]
        public int PositionRight { get; set; }

        [DataMember(Name = "Classification")]
        [XmlElement("Classification", Type = typeof(ClassificationKL))]
        public ClassificationKL Classification { get; set; }

        [DataMember(Name = "VehicleTypeName")]
        [XmlElement("VehicleTypeName")]
        public string VehicleTypeName { get; set; }

        [DataMember(Name = "Units")]
        [XmlElement("Units")]
        public int Units { get; set; }

        [DataMember(Name = "WheelBase")]
        [XmlElement("WheelBase")]
        public int WheelBase { get; set; }

        [DataMember(Name = "Weight")]
        [XmlElement("Weight")]
        public int Weight { get; set; }

        [DataMember(Name = "WeightLimit")]
        [XmlElement("WeightLimit")]
        public int WeightLimit { get; set; }

        [DataMember(Name = "Overweight")]
        [XmlElement("Overweight")]
        public int Overweight { get; set; }

        [DataMember(Name = "AxleCount")]
        [XmlElement("AxleCount")]
        public int AxleCount { get; set; }

        [DataMember(Name = "Axles")]
        [XmlElement("Axles", Type = typeof(Axleskl))]
        public List<Axleskl> Axles { get; set; }

        [DataMember(Name = "Plate")]
        [XmlElement("Plate")]
        public string Plate { get; set; }

        [DataMember(Name = "PlateConfidence")]
        [XmlElement("PlateConfidence")]
        public double PlateConfidence { get; set; }

        [DataMember(Name = "PlateValid")]
        [XmlElement("PlateValid")]
        public string PlateValid { get; set; }

        [DataMember(Name = "PlateRear")]
        [XmlElement("PlateRear")]
        public string PlateRear { get; set; }

        [DataMember(Name = "PlateRearConfidence")]
        [XmlElement("PlateRearConfidence")]
        public int PlateRearConfidence { get; set; }

        [DataMember(Name = "PlateRearValid")]
        [XmlElement("PlateRearValid")]
        public string PlateRearValid { get; set; }

        [DataMember(Name = "CountryCode")]
        [XmlElement("CountryCode")]
        public string CountryCode { get; set; }

        [DataMember(Name = "CountrySubdivisionCode")]
        [XmlElement("CountrySubdivisionCode")]
        public string CountrySubdivisionCode { get; set; }

        [DataMember(Name = "CountryConfidence")]
        [XmlElement("CountryConfidence")]
        public double CountryConfidence { get; set; }

        [DataMember(Name = "AdrFrontEmpty")]
        [XmlElement("AdrFrontEmpty")]
        public string AdrFrontEmpty { get; set; }

        [DataMember(Name = "AdrFrontKemler")]
        [XmlElement("AdrFrontKemler")]
        public string AdrFrontKemler { get; set; }

        [DataMember(Name = "AdrFrontUn")]
        [XmlElement("AdrFrontUn")]
        public string AdrFrontUn { get; set; }

        [DataMember(Name = "AdrFrontConfidence")]
        [XmlElement("AdrFrontConfidence")]
        public double AdrFrontConfidence { get; set; }

        [DataMember(Name = "AdrRearEmpty")]
        [XmlElement("AdrRearEmpty")]
        public string AdrRearEmpty { get; set; }

        [DataMember(Name = "AdrRearKemler")]
        [XmlElement("AdrRearKemler")]
        public string AdrRearKemler { get; set; }

        [DataMember(Name = "AdrRearUn")]
        [XmlElement("AdrRearUn")]
        public string AdrRearUn { get; set; }

        [DataMember(Name = "AdrRearConfidence")]
        [XmlElement("AdrRearConfidence")]
        public double AdrRearConfidence { get; set; }

        [DataMember(Name = "IsOverweightPartial")]
        [XmlElement("IsOverweightPartial")]
        public string IsOverweightPartial { get; set; }

        [DataMember(Name = "IsOverweightGross")]
        [XmlElement("IsOverweightGross")]
        public string IsOverweightGross { get; set; }

        [DataMember(Name = "IsExceededLength")]
        [XmlElement("IsExceededLength")]
        public string IsExceededLength { get; set; }

        [DataMember(Name = "IsExceededWidth")]
        [XmlElement("IsExceededWidth")]
        public string IsExceededWidth { get; set; }

        [DataMember(Name = "IsExceededHeight")]
        [XmlElement("IsExceededHeight")]
        public string IsExceededHeight { get; set; }

        [DataMember(Name = "IsOverspeed")]
        [XmlElement("IsOverspeed")]
        public string IsOverspeed { get; set; }

        [DataMember(Name = "IsWrongDirection")]
        [XmlElement("IsWrongDirection")]
        public string IsWrongDirection { get; set; }

        [DataMember(Name = "IsNonStandard")]
        [XmlElement("IsNonStandard")]
        public string IsNonStandard { get; set; }

        [DataMember(Name = "OperatingRangeExceededSpeed")]
        [XmlElement("OperatingRangeExceededSpeed")]
        public string OperatingRangeExceededSpeed { get; set; }

        [DataMember(Name = "OperatingRangeExceededWeight")]
        [XmlElement("OperatingRangeExceededWeight")]
        public string OperatingRangeExceededWeight { get; set; }

        [DataMember(Name = "Divert")]
        [XmlElement("Divert")]
        public string Divert { get; set; }

        [DataMember(Name = "Diverted")]
        [XmlElement("Diverted")]
        public string Diverted { get; set; }

        [DataMember(Name = "Checksum")]
        [XmlElement("Checksum")]
        public string Checksum { get; set; }
    }

    [Serializable()]
    //[XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2001/XMLSchema")]
    public partial class CreatedByKL
    {
        [DataMember(Name = "PlatformId")]
        [XmlElement("PlatformId")]
        public string PlatformId { get; set; }

        [DataMember(Name = "BGuidType")]
        [XmlElement("BGuidType")]
        public int BGuidType { get; set; }

        [DataMember(Name = "KeyMark")]
        [XmlElement("KeyMark")]
        public int KeyMark { get; set; }

        [DataMember(Name = "ID")]
        [XmlElement("ID")]
        public string ID { get; set; }

    }

    [Serializable()]
    //[XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2001/XMLSchema")]
    public partial class CaptionsKL
    {
        [DataMember(Name = "string")]
        [XmlElement("string")]
        public string String { get; set; }

    }

    [Serializable()]
    //[XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2001/XMLSchema")]
    public partial class BinariesKL
    {
        [DataMember(Name = "BinaryContainer")]
        //[XmlArray("BinaryContainer")]
        //[XmlArrayItem("BinaryContainer", Type = typeof(BinaryContainerKLCL))]
        //public BinaryContainerKLCL[] BinaryContainer { get; set; }
        //[DataMember(Name = "BinaryContainer")]
        [XmlElement("BinaryContainer", Type = typeof(BinaryContainerKLCL))]
        public List<BinaryContainerKLCL> BinaryContainer { get; set; }
        //public BinaryContainerKLCL BinaryContainer { get; set; }
    }

    [Serializable()]
    //[XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2001/XMLSchema")]
    public partial class BinaryContainerKLCL
    {
        [DataMember(Name = "ID")]
        [XmlElement("ID")]
        public string ID { get; set; }

        [DataMember(Name = "CreatedBy")]
        [XmlElement("CreatedBy", Type = typeof(CreatedByBinKLCL))]
        public CreatedByBinKLCL CreatedBy { get; set; }

        [DataMember(Name = "Created")]
        [XmlElement("Created")]
        public string Created { get; set; }

        [DataMember(Name = "Captions")]
        [XmlElement("Captions")]
        public string Captions { get; set; }

        [DataMember(Name = "BinaryType")]
        [XmlElement("BinaryType")]
        public string BinaryType { get; set; }

        [DataMember(Name = "Name")]
        [XmlElement("Name")]
        public string Name { get; set; }

        [DataMember(Name = "Length")]
        [XmlElement("Length")]
        public int Length { get; set; }

        [DataMember(Name = "Data")]
        [XmlElement("Data")]
        public string Data { get; set; }

        [DataMember(Name = "Hash")]
        [XmlElement("Hash")]
        public string Hash { get; set; }
    }

    [Serializable()]
    //[XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2001/XMLSchema")]
    public partial class CreatedByBinKLCL
    {
        [DataMember(Name = "PlatformId")]
        [XmlElement("PlatformId")]
        public string PlatformId { get; set; }

        [DataMember(Name = "BGuidType")]
        [XmlElement("BGuidType")]
        public int BGuidType { get; set; }

        [DataMember(Name = "KeyMark")]
        [XmlElement("KeyMark")]
        public int KeyMark { get; set; }

        [DataMember(Name = "ID")]
        [XmlElement("ID")]
        public string ID { get; set; }
    }

    [Serializable()]
    //[XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2001/XMLSchema" )]
    public partial class ClassificationKL
    {
        [DataMember(Name = "Classification")]
        [XmlElement("Classification", Type = typeof(ClassificationKLCL))]
        public List<ClassificationKLCL> Classification { get; set; }
        //public ClassificationKLCL Classification { get; set; }

        //[DataMember(Name = "Classification")]
        //[XmlElement("Classification", Type = typeof(ClassificationKLCL))]
        //public ClassificationKLCL Index { get; set; }
    }

    [Serializable()]
    //[XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2001/XMLSchema" )]
    public partial class Axleskl
    {
        [DataMember(Name = "AxleContainer")]
        [XmlElement("AxleContainer", Type = typeof(Axlesk))]
        public List<Axlesk> AxleContainer { get; set; }

    }
    [Serializable()]

    public partial class Axlesk
    {
        [DataMember(Name = "ID")]
        [XmlElement("ID")]
        public string ID { get; set; }

        [DataMember(Name = "CreatedBy")]
        [XmlElement("CreatedBy", Type = typeof(CreatedByAxCL))]
        public CreatedByAxCL CreatedBy { get; set; }

        [DataMember(Name = "Created")]
        [XmlElement("Created")]
        public string Created { get; set; }

        [DataMember(Name = "Captions")]
        [XmlElement("Captions")]
        public string Captions { get; set; }

        [DataMember(Name = "Index")]
        [XmlElement("Index")]
        public int Index { get; set; }

        [DataMember(Name = "Unit")]
        [XmlElement("Unit")]
        public int Unit { get; set; }

        [DataMember(Name = "Group")]
        [XmlElement("Group")]
        public int Group { get; set; }

        [DataMember(Name = "Position")]
        [XmlElement("Position")]
        public int Position { get; set; }

        [DataMember(Name = "Weight")]
        [XmlElement("Weight")]
        public int Weight { get; set; }

        [DataMember(Name = "WeightLeft")]
        [XmlElement("WeightLeft")]
        public int WeightLeft { get; set; }

        [DataMember(Name = "WeightRight")]
        [XmlElement("WeightRight")]
        public int WeightRight { get; set; }

        [DataMember(Name = "WeightLimit")]
        [XmlElement("WeightLimit")]
        public int WeightLimit { get; set; }

        [DataMember(Name = "WheelCount")]
        [XmlElement("WheelCount")]
        public int WheelCount { get; set; }

        [DataMember(Name = "FootprintWidthLeft")]
        [XmlElement("FootprintWidthLeft")]
        public int FootprintWidthLeft { get; set; }

        [DataMember(Name = "FootprintWidthRight")]
        [XmlElement("FootprintWidthRight")]
        public int FootprintWidthRight { get; set; }

        [DataMember(Name = "IsOverweight")]
        [XmlElement("IsOverweight")]
        public string IsOverweight { get; set; }

        [DataMember(Name = "Speed")]
        [XmlElement("Speed")]
        public double Speed { get; set; }

        [DataMember(Name = "Credence")]
        [XmlElement("Credence")]
        public int Credence { get; set; }

        [DataMember(Name = "MeasurementStatus")]
        [XmlElement("MeasurementStatus")]
        public string MeasurementStatus { get; set; }

        [DataMember(Name = "WheelPairing")]
        [XmlElement("WheelPairing")]
        public string WheelPairing { get; set; }
    }

    [Serializable()]
    //[XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2001/XMLSchema")]
    public partial class CreatedByAxCL
    {
        [DataMember(Name = "PlatformId")]
        [XmlElement("PlatformId")]
        public string PlatformId { get; set; }

        [DataMember(Name = "BGuidType")]
        [XmlElement("BGuidType")]
        public int BGuidType { get; set; }

        [DataMember(Name = "KeyMark")]
        [XmlElement("KeyMark")]
        public int KeyMark { get; set; }

        [DataMember(Name = "ID")]
        [XmlElement("ID")]
        public string ID { get; set; }
    }

    [Serializable()]
    //[XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2001/XMLSchema")]
    public partial class ClassificationKLCL
    {
        [DataMember(Name = "Schema")]
        [XmlElement("Schema")]
        public string Schema { get; set; }

        [DataMember(Name = "Index")]
        [XmlElement("Index")]
        public int Index { get; set; }
    }


    //public enum AxleMeasurementStatus
    //{

    //    /// <remarks/>
    //    Unknown,

    //    /// <remarks/>
    //    Correct,

    //    /// <remarks/>
    //    WeightLimitUnder,

    //    /// <remarks/>
    //    WeightLimitOver,

    //    /// <remarks/>
    //    SpeedLimitUnder,

    //    /// <remarks/>
    //    SpeedLimitOver,

    //    /// <remarks/>
    //    Error,
    //}

    ///// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    //[System.SerializableAttribute()]
    //public enum Direction
    //{

    //    /// <remarks/>
    //    Unknown,

    //    /// <remarks/>
    //    Ahead,

    //    /// <remarks/>
    //    Back,
    //}
}
