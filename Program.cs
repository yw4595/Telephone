using System;

namespace Telephone
{
    // Author: Yanzhi Wang
    // Purpose: Define classes and interfaces for telephone objects

    // Define the main class for the program
    class Program
    {
        // Define the entry point for the program
        static void Main(string[] args)
        {
            // The Main method is currently empty and does not perform any actions
        }

        // Define an interface for a phone object
        interface IPhoneInterface
        {
            // Define methods that must be implemented by any class that implements this interface
            void Answer();      // Answers the phone
            void MakeCall();    // Dials a phone number
            void HangUp();      // Ends a phone call
        }

        // Define a base class for phone objects that implements the IPhoneInterface
        class Phone : IPhoneInterface
        {
            // Define a private field for the phone number of the phone object
            private string phoneNumber;

            // Define a public property for the phone number of the phone object
            public string PhoneNumber
            {
                get { return phoneNumber; }
                set { phoneNumber = value; }
            }

            // Define a public property for the address of the phone object
            public string Address { get; set; }

            // Implement the Answer method of the IPhoneInterface
            public void Answer()
            {
                Console.WriteLine("Hello World!");
            }

            // Implement the MakeCall method of the IPhoneInterface
            public void MakeCall()
            {
                Console.WriteLine("Dialing...");
            }

            // Implement the HangUp method of the IPhoneInterface
            public void HangUp()
            {
                Console.WriteLine("Hanging up...");
            }

            // Define a new method for connecting the phone object
            public void Connect()
            {
                Console.WriteLine("Connecting...");
            }

            // Define a new method for disconnecting the phone object
            public void Disconnect()
            {
                Console.WriteLine("Disconnecting...");
            }

            // Override the ToString method to return a string representation of the phone object
            public override string ToString()
            {
                return $"{GetType().Name}({PhoneNumber})";
            }
        }

        // Define a class for rotary phone objects that inherits from the Phone class
        class RotaryPhone : Phone
        {
            // Override the Connect method of the Phone class
            public new void Connect()
            {
                Console.WriteLine("Rotary phone connecting...");
            }

            // Override the Disconnect method of the Phone class
            public new void Disconnect()
            {
                Console.WriteLine("Rotary phone disconnecting...");
            }
        }

        // Define a class for TARDIS phone objects that inherits from the Phone class
        // Class for TARDIS phone objects that inherits from the Phone class
        class Tardis : Phone
        {
            // Whether or not the TARDIS phone object has a sonic screwdriver
            private bool sonicScrewdriver;
            // The version of Dr. Who associated with the TARDIS phone object
            private byte whichDrWho;
            // The female sidekick associated with the TARDIS phone object
            private string femaleSideKick;

            // The exterior surface area of the TARDIS phone object
            public double ExteriorSurfaceArea { get; set; }
            // The interior volume of the TARDIS phone object
            public double InteriorVolume { get; set; }

            // Gets or sets the version of Dr. Who associated with the TARDIS phone object
            public byte WhichDrWho
            {
                get { return whichDrWho; }
                set { whichDrWho = value; }
            }

            // Gets or sets the female sidekick associated with the TARDIS phone object
            public string FemaleSideKick
            {
                get { return femaleSideKick; }
                set { femaleSideKick = value; }
            }

            // Causes the TARDIS phone object to travel through time
            public void TimeTravel()
            {
                Console.WriteLine("Time traveling...");
            }

            // Returns a string representation of the TARDIS phone object
            public override string ToString()
            {
                return $"{GetType().Name}(Dr. Who: {WhichDrWho})";
            }

            // Checks if two TARDIS phone objects are equal
            public static bool operator ==(Tardis a, Tardis b)
            {
                if (a.whichDrWho == b.whichDrWho)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            // Checks if two TARDIS phone objects are not equal
            public static bool operator !=(Tardis a, Tardis b)
            {
                if (a.whichDrWho != b.whichDrWho)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            // Determines if a TARDIS phone object is equal to another object
            public override bool Equals(object obj)
            {
                if (obj is Tardis)
                {
                    Tardis otherTardis = (Tardis)obj;
                    return this == otherTardis;
                }
                else
                {
                    return false;
                }
            }

            // Returns a hash code for the TARDIS phone object
            public override int GetHashCode()
            {
                return (int)whichDrWho;
            }
        }
    }
}
