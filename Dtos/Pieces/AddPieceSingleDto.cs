namespace PrometheusSuite.Shared.Dtos.Pieces;

public class AddPieceSingleDto
{
    public required string SaleId { get; set; }
    public required PieceDto Piece { get; set; }
}