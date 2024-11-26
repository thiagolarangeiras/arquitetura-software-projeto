namespace Custos.Models;

public class AtoresPost
{
   
}

public class Atores
{
    

    public static Atores DtoToCusto(CustoPost dto) 
    {
        return new Atores()
        {
            FilmeId = dto.FilmeId,
            ValorMidiaFisica = dto.ValorMidiaFisica,
            ValorBilheteCinema = dto.ValorBilheteCinema,
            ValorProducao = dto.ValorProducao,
            ValorBilheteria = dto.ValorBilheteria,
            ValorTotalArecadado = dto.ValorTotalArecadado,
        };
    }

    public static void Update(Atores custos, CustoPost dto)
    {
        custos.FilmeId = dto.FilmeId;
        custos.ValorMidiaFisica = dto.ValorMidiaFisica;
        custos.ValorBilheteCinema = dto.ValorBilheteCinema;
        custos.ValorProducao = dto.ValorProducao;
        custos.ValorBilheteria = dto.ValorBilheteria;
        custos.ValorTotalArecadado = dto.ValorTotalArecadado;
    }
}