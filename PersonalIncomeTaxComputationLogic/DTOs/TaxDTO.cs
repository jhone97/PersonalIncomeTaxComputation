using PersonalIncomeTaxComputationLogic.Values;


namespace PersonalIncomeTaxComputationLogic.DTOs;

public class TaxDTO
{
    public int Id { get; set; }
    public TaxParamVO taxparams { get; set; }
}
