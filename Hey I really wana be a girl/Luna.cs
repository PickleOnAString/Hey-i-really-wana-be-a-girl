namespace Hey_I_really_wana_be_a_girl;

public class Luna : Egg
{
    public override string Name => "Luna";
    public override GenderEnum? Gender => null;
    public override GenderEnum IdealGender => GenderEnum.Female;
    public override GenderEnum AssignedGenderAtBirth => GenderEnum.Male;

    private bool cis;

    public override void IsCis()
    {
        if (cis)
        {
            Console.WriteLine("But i want to be a girl...");
            cis = false;
            IsCis();
        }
        else
        {
            Console.WriteLine("But What if I'm Wrong?!?!?");
            cis = true;
            IsCis();
        }
    }
}

