namespace Hey_I_really_wana_be_a_girl;

public abstract class Egg : Human
{
    public abstract GenderEnum IdealGender { get; }
    public abstract GenderEnum AssignedGenderAtBirth { get; }
    public abstract void IsCis();
}