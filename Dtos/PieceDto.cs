namespace PrometheusSuite.Shared.Dtos;

public class PieceDto
{
    public required int Index {get; set;}
    public double? Height {get; set;}
    public double? Length {get; set;}
    public double? Width {get; set;}
    
    public int? Weight {get; set;}
    public int? VolumetricWeight {get; set;}
    
}