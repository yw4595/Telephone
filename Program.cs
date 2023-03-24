using System;

namespace Telephone

{
    class Program
    {
        static void Main(string[] args)
        { }
    interface IPhoneInterface
        {
            void Answer();
            void MakeCall();
            void HangUp();
        }

        class Phone : IPhoneInterface
        {
            private string phoneNumber;
            public string PhoneNumber
            {
                get { return phoneNumber; }
                set { phoneNumber = value; }
            }

            public string Address { get; set; }

            public void Answer()
            {
                Console.WriteLine("Hello World!");
            }

            public void MakeCall()
            {
                Console.WriteLine("Dialing...");
            }

            public void HangUp()
            {
                Console.WriteLine("Hanging up...");
            }

            public void Connect()
            {
                Console.WriteLine("Connecting...");
            }

            public void Disconnect()
            {
                Console.WriteLine("Disconnecting...");
            }

            public override string ToString()
            {
                return $"{GetType().Name}({PhoneNumber})";
            }
        }

        class RotaryPhone : Phone
        {
            public new void Connect()
            {
                Console.WriteLine("Rotary phone connecting...");
            }

            public new void Disconnect()
            {
                Console.WriteLine("Rotary phone disconnecting...");
            }
        }


        class Tardis : Phone
        {
            private bool sonicScrewdriver;
            private byte whichDrWho;
            private string femaleSideKick;

            public double ExteriorSurfaceArea { get; set; }
            public double InteriorVolume { get; set; }

            public byte WhichDrWho
            {
                get { return whichDrWho; }
                set { whichDrWho = value; }
            }

            public string FemaleSideKick
            {
                get { return femaleSideKick; }
                set { femaleSideKick = value; }
            }

            public void TimeTravel()
            {
                Console.WriteLine("Time traveling...");
            }

            public override string ToString()
            {
                return $"{GetType().Name}(Dr. Who: {WhichDrWho})";
            }

            public static bool operator ==(Tardis t1, Tardis t2)
            {
                if (t1 is null)
                {
                    return t2 is null;
                }

                if (t2 is null)
                {
                    return false;
                }

                if (t1.WhichDrWho == 10 && t2.WhichDrWho != 10)
                {
                    return true;
                }

                if (t1.WhichDrWho != 10 && t2.WhichDrWho == 10)
                {
                    return false;
                }

                return t1.WhichDrWho == t2.WhichDrWho;
            }

            public static bool operator !=(Tardis t1, Tardis t2)
            {
                return !(t1 == t2);
            }

            public static bool operator <(Tardis t1, Tardis t2)
            {
                if (t1 == null)
                {
                    return t2 != null;
                }

                if (t2 == null)
                {
                    return false;
                }

                if (t1.WhichDrWho == 10 && t2.WhichDrWho != 10)
                {
                    return false;
                }

                if (t1.WhichDrWho != 10 && t2.WhichDrWho == 10)
                {
                    return true;
                }

                return t1.WhichDrWho < t2.WhichDrWho;
            }

            public static bool operator >(Tardis t1, Tardis t2)
            {
                if (t1 == null)
                {
                    return false;
                }

                if (t2 == null)
                {
                    return true;
                }

                if (t1.WhichDrWho == 10 && t2.WhichDrWho != 10)
                {
                    return true;
                }

                if (t1.WhichDrWho != 10 && t2.WhichDrWho == 10)
                {
                    return false;
                }

                return t1.WhichDrWho > t2.WhichDrWho;
            }
        }

    }
}
