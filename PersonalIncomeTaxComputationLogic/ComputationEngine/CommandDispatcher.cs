using PersonalIncomeTaxComputationLogic.Cases;
using PersonalIncomeTaxComputationLogic.SystemCommands;


namespace PersonalIncomeTaxComputationLogic.ComputationEngine;

public class CommandDispatcher
{
    public static bool Dispatch(string archType, ComputationEngine computationEngine)
    {
        if(archType == "SeniorCitizen")
        {
           return new SeniorCitizenCommands().Execute(computationEngine);
        }
        if (archType == "OrdinaryCitizenCmmand")
        {
            return new OrdinaryCitizenCommands().Execute(computationEngine);
        }
        else
        {
            return false;
        }
    }

}

public class ComputationEngine
{
    private Dictionary<string, object> symbols = new();

    public void Put(string k, object value)
    {
        symbols.Add(k, value);
    }

    public object Get(string k)
    {
        return symbols[k];
    }
}
