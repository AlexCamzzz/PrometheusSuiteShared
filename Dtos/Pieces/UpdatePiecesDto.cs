namespace PrometheusSuite.Shared.Dtos.Pieces;

public class UpdatePiecesDto
{
    public required string Id { get; set; }
    public required List<PieceDto> Pieces { get; set; }
}