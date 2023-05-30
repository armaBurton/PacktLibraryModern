namespace Packt.Shared;


public class ImmutablePerson{
  public string? FirstName { get; init; }
  public string? LastName { get; init; }
}

public record ImmutableVehicle{
  public string? Color  { get; init; }
  public string? Brand { get; init; }
}
