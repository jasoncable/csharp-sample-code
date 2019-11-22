using System;
using System.ComponentModel;

namespace Jaxosoft.CSharp.SampleCode.Enums
{
    // values based on order of admission to the United States
    // https://en.wikipedia.org/wiki/List_of_U.S._states_by_date_of_admission_to_the_Union
    // Washington, D.C is not a state, but worthy of inclusion and was given an arbitrart number.
    public enum State
    {
        [Description("Alabama")]
        AL = 22,

        [Description("Alaska")]
        AK = 49,

        [Description("Arkansas")]
        AR = 25,

        [Description("Arizona")]
        AZ = 48,

        [Description("California")]
        CA = 31,

        [Description("Colorado")]
        CO = 38,

        [Description("Connecticut")]
        CT = 5,

        [Description("District of Columbia")]
        DC = 100,

        [Description("Delaware")]
        DE = 1,

        [Description("Florida")]
        FL = 27,

        [Description("Georgia")]
        GA = 4,

        [Description("Hawaii")]
        HI = 50,

        [Description("Iowa")]
        IA = 29,

        [Description("Idaho")]
        ID = 43,

        [Description("Illinois")]
        IL = 21,

        [Description("Indiana")]
        IN = 19,

        [Description("Kansas")]
        KS = 34,

        [Description("Kentucky")]
        KY = 15,

        [Description("Louisiana")]
        LA = 18,

        [Description("Massachusetts")]
        MA = 6,

        [Description("Maryland")]
        MD = 7,

        [Description("Maine")]
        ME = 23,

        [Description("Michigan")]
        MI = 26,

        [Description("Minnesota")]
        MN = 32,

        [Description("Missouri")]
        MO = 24,

        [Description("Mississippi")]
        MS = 20,

        [Description("Montana")]
        MT = 41,

        [Description("North Carolina")]
        NC = 12,

        [Description("North Dakota")]
        ND = 39,

        [Description("Nebraska")]
        NE = 37,

        [Description("New Hampshire")]
        NH = 9,

        [Description("New Jersey")]
        NJ = 3,

        [Description("New Mexico")]
        NM = 47,

        [Description("Nevada")]
        NV = 36,

        [Description("New York")]
        NY = 11,

        [Description("Oklahoma")]
        OK = 46,

        [Description("Ohio")]
        OH = 17,

        [Description("Oregon")]
        OR = 33,

        [Description("Pennsylvania")]
        PA = 2,

        [Description("Rhode Island")]
        RI = 13,

        [Description("South Carolina")]
        SC = 8,

        [Description("South Dakota")]
        SD = 40,

        [Description("Tennessee")]
        TN = 16,

        [Description("Texas")]
        TX = 28,

        [Description("Utah")]
        UT = 45,

        [Description("Virginia")]
        VA = 10,

        [Description("Vermont")]
        VT = 14,

        [Description("Washington")]
        WA = 42,

        [Description("Wisconsin")]
        WI = 30,

        [Description("West Virginia")]
        WV = 35,

        [Description("Wyoming")]
        WY = 44

    }
}
