namespace Custos.Models;

public class CustoPost
{
    public int FilmeId { get; set; }
    public decimal ValorMidiaFisica { get; set; }
    public decimal ValorBilheteCinema { get; set; }
    public decimal ValorProducao { get; set; }
    public decimal ValorBilheteria { get; set; }
    public decimal ValorTotalArecadado { get; set; }
}

public class Custo
{
    public int Id { get; set; }
    public int FilmeId { get; set; }
    public decimal ValorMidiaFisica { get; set; }
    public decimal ValorBilheteCinema { get; set; }
    public decimal ValorProducao{ get; set; }
    public decimal ValorBilheteria { get; set; }
    public decimal ValorTotalArecadado { get; set; }

    public static Custo DtoToCusto(CustoPost dto) 
    {
        return new Custo()
        {
            FilmeId = dto.FilmeId,
            ValorMidiaFisica = dto.ValorMidiaFisica,
            ValorBilheteCinema = dto.ValorBilheteCinema,
            ValorProducao = dto.ValorProducao,
            ValorBilheteria = dto.ValorBilheteria,
            ValorTotalArecadado = dto.ValorTotalArecadado,
        };
    }

    public static void Update(Custo custos, CustoPost dto)
    {
        custos.FilmeId = dto.FilmeId;
        custos.ValorMidiaFisica = dto.ValorMidiaFisica;
        custos.ValorBilheteCinema = dto.ValorBilheteCinema;
        custos.ValorProducao = dto.ValorProducao;
        custos.ValorBilheteria = dto.ValorBilheteria;
        custos.ValorTotalArecadado = dto.ValorTotalArecadado;
    }
}