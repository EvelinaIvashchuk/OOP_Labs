using _03;
public interface ISoldier
{
    int ID { get; }
    string name {  get; }
    string surname { get; }
}

public interface IPrivate : ISoldier
{
    double Salary { get; }
}

interface ILeutenantGeneral : ISoldier
{
    List<Private> privateers {  get; }
}

public interface ISpecialisedSoldier : ISoldier
{
    string Corps { get; }  
}

public interface IEngineer : ISpecialisedSoldier
{
    List<Repair> Repairs { get; }
}

public interface ICommando : ISpecialisedSoldier
{
    List<Mission> Missions { get; }
}

public interface ISpy : ISoldier
{
    int SpyNumber { get; }
}
