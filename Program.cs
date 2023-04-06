/ Author: Yanzhi Wang
// Purpose: Define a hierarchy of phone types, including rotary and push-button phones, and a class of the Tardis phone from Doctor Who, which implements IComparable and custom comparison operators.
// Restrictions: None known.

namespace Telephone
{
public abstract class Phone
{
public string PhoneNumber { get; set; }
public string Address { get; set; }
        // Abstract methods for connecting and disconnecting the phone.
    public abstract void Connect();
    public abstract void Disconnect();
}

// Interface defining phone actions.
public interface IPhoneActions
{
    void Answer();
    void MakeCall();
    void HangUp();
}

// Class for rotary phone, inherits from Phone and implements IPhoneActions.
public class RotaryPhone : Phone, IPhoneActions
{
    public void Answer() { }
    public void MakeCall() { }
    public void HangUp() { }

    public override void Connect() { }
    public override void Disconnect() { }
}

// Class for push-button phone, inherits from Phone and implements IPhoneActions.
public class PushButtonPhone : Phone, IPhoneActions
{
    public void Answer() { }
    public void MakeCall() { }
    public void HangUp() { }

    public override void Connect() { }
    public override void Disconnect() { }
}

// Class for Tardis phone, inherits from RotaryPhone and implements IComparable.
public class Tardis : RotaryPhone, IComparable<Tardis>
{
    public byte WhichDrWho { get; }
    public string FemaleSideKick { get; }
    public double ExteriorSurfaceArea { get; }
    public double InteriorVolume { get; }
    public bool SonicScrewdriver { get; }

    // Constructor for Tardis phone.
    public Tardis(byte whichDrWho, string femaleSideKick, double exteriorSurfaceArea, double interiorVolume, bool sonicScrewdriver)
    {
        WhichDrWho = whichDrWho;
        FemaleSideKick = femaleSideKick;
        ExteriorSurfaceArea = exteriorSurfaceArea;
        InteriorVolume = interiorVolume;
        SonicScrewdriver = sonicScrewdriver;
    }

    // Compare Tardis phones based on their WhichDrWho property.
    public int CompareTo(Tardis other)
    {
        return WhichDrWho.CompareTo(other.WhichDrWho);
    }

    // Custom comparison operators for Tardis phones.
    public static bool operator ==(Tardis t1, Tardis t2)
    {
        return t1?.WhichDrWho == t2?.WhichDrWho;
    }

    public static bool operator !=(Tardis t1, Tardis t2)
    {
        return !(t1 == t2);
    }

    public static bool operator <(Tardis t1, Tardis t2)
    {
        if (t1?.WhichDrWho == 10 && t2?.WhichDrWho != 10)
        {
            return false;
        }
        else if (t2?.WhichDrWho == 10 && t1?.WhichDrWho != 10)
        {
            return true;
        }
        else
        {
            return t1?.WhichDrWho < t2?.WhichDrWho;
        }
    }

    public static bool operator >(Tardis t1, Tardis t2)
    {
        if (t1?.WhichDrWho == 10 && t2?.WhichDrWho != 10)
        {
            return true;
        }
        else if (t2?.WhichDrWho == 10 && t1?.WhichDrWho != 10)
{
return false;
}
else
{
return t1?.WhichDrWho > t2?.WhichDrWho;
}
}
}

namespace Telephone
{
class Program
{
static void Main(string[] args)
{
Tardis tardis1 = new Tardis(10, "Rose", 1000, 2000, true);
Tardis tardis2 = new Tardis(11, "Martha", 1100, 2200, false);
            Console.WriteLine(tardis1 == tardis2);  // False
        Console.WriteLine(tardis1 != tardis2);  // True
        Console.WriteLine(tardis1 > tardis2);   // False
        Console.WriteLine(tardis1 < tardis2);   // True

        Console.ReadLine();
    }
}
}
